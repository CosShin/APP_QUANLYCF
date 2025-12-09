using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to to exit program "," NOTICE ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;            
            }
        }

        private void BTDangNhap_Click(object sender, EventArgs e)
        {
            String UserName = TBUserName.Text;
            String PassWord = TBPassWord.Text;
            
            if (Login(UserName, PassWord))
            {
                Account loginaccount = AccountDAO.Instance.GetAccountBytheName(UserName);
                FTableManager f = new FTableManager(loginaccount);
                
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else {
                MessageBox.Show("sai ten Tai khoan Hoac Mat Khau");
            
                
            }
        }

        bool Login(String UerName, String PassWord) {
            return AccountDAO.Instance.Login(UerName, PassWord);
        }

    }
}
