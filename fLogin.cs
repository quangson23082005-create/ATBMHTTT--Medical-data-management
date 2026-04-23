using QLBV.DAO;
using System;
using System.Windows.Forms;

namespace QLBV
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text.Trim().ToUpper();
            string password = txbPassWord.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bước 1: Thử đăng nhập bằng tài khoản của chính user đó
            bool loginOk = AccountDAO.Instance.Login(username, password);
            if (!loginOk)
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Bước 2: Lấy vai trò để điều hướng đúng form
            // Dùng lại connection ADMIN để đọc VAITRO (vì BN/KTV không có quyền đọc DBA_USERS)
            string vaitro = AccountDAO.Instance.GetVaiTro(username);

            string userConnStr = $"User Id={username};Password={password};Data Source=localhost:1521/XEPDB1";
            DataProvider.Instance.UpdateConnectionString(userConnStr);

            this.Hide();

            switch (vaitro)
            {
                case "Kỹ thuật viên":
                    new fKyThuatVien().ShowDialog();
                    break;

                case "Bệnh nhân":
                    new fBenhNhan().ShowDialog();
                    break;

                case "Bác sĩ":
                case " Y tá":
                    new fBacSi().ShowDialog();
                    break;

                case "Điều phối viên":
                    new fDieuPhoiVien().ShowDialog();
                    break;

                default:
                    // ADMIN hoặc DBA → mở form quản trị
                    new fAdmin().ShowDialog();
                    break;
            }

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo",
                MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
