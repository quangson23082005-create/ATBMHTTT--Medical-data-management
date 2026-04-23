using QLBV.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLBV
{
    public partial class fKyThuatVien : Form
    {
        private DataTable _data;

        public fKyThuatVien()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════════════════════
        // KHOI DONG FORM
        // ════════════════════════════════════════════════════════════════════════
        private void fKyThuatVien_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            LoadDanhSachDichVu();
        }

        /// <summary>
        /// Cau hinh DataGridView: header, co dinh cot — chi goi 1 lan khi Load.
        /// Tach rieng khoi LoadData de tranh config lai moi lan refresh.
        /// </summary>
        private void ConfigureGrid()
        {
            dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDichVu.RowHeadersVisible = false;
            dgvDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // ════════════════════════════════════════════════════════════════════════
        // LOAD DATA
        // ════════════════════════════════════════════════════════════════════════
        private void LoadDanhSachDichVu()
        {
            try
            {
                _data = KyThuatVienDAO.Instance.GetDanhSachDichVu();
                dgvDichVu.DataSource = _data;

                // Khoa tat ca cot, chi de KETQUA co the sua
                foreach (DataGridViewColumn col in dgvDichVu.Columns)
                    col.ReadOnly = col.Name != "KETQUA";

                // Dat header text sau khi DataSource duoc gan
                if (dgvDichVu.Columns.Contains("MAHSBA"))  dgvDichVu.Columns["MAHSBA"].HeaderText = "Ma HSBA";
                if (dgvDichVu.Columns.Contains("LOAIDV"))  dgvDichVu.Columns["LOAIDV"].HeaderText = "Loai dich vu";
                if (dgvDichVu.Columns.Contains("NGAYDV"))  dgvDichVu.Columns["NGAYDV"].HeaderText = "Ngay thuc hien";
                if (dgvDichVu.Columns.Contains("MAKTV"))   dgvDichVu.Columns["MAKTV"].HeaderText  = "Ma KTV";
                if (dgvDichVu.Columns.Contains("KETQUA"))  dgvDichVu.Columns["KETQUA"].HeaderText = "Ket qua (co the sua)";

                lblTongSo.Text = $"Tong so dich vu: {_data.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tai du lieu: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        // XU LY SU KIEN
        // ════════════════════════════════════════════════════════════════════════
        private void btnLuuKetQua_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.CurrentRow == null) return;

            var row    = dgvDichVu.CurrentRow;
            string mahsba = row.Cells["MAHSBA"].Value?.ToString();
            string loaidv = row.Cells["LOAIDV"].Value?.ToString();
            string ngaydv = row.Cells["NGAYDV"].Value?.ToString();
            string ketqua = row.Cells["KETQUA"].Value?.ToString() ?? "";

            try
            {
                int affected = KyThuatVienDAO.Instance.CapNhatKetQua(mahsba, loaidv, ngaydv, ketqua);
                if (affected > 0)
                    MessageBox.Show("Cap nhat ket qua thanh cong!", "Thong bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Khong tim thay ban ghi de cap nhat.", "Thong bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi cap nhat: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachDichVu();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon dang xuat?", "Xac nhan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
