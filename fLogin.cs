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
                fAdmin f = new fAdmin();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Login failed. Please double-check your information.");
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
            if(MessageBox.Show("Do you want to exit the program??", "Notification", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            } 
                
        }
    }
}
