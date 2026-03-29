using QLBV.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLBV
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {   
            string username = txbUsername.Text;
            string password = txbPassWord.Text;
            if (Login(txbUsername.Text, txbPassWord.Text))
            {
                MessageBox.Show("Đăng nhập thành công!");
                fAdmin f = new fAdmin();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin.");
            }
        }

        bool Login(string userName, string passWord)
        {
            
            return AccountDAO.Instance.Login(userName, passWord); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            } 
                
        }
    }
}
