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
    public partial class fACount : Form
    {
        private Account loginaccount;

        public Account Loginaccount
        {
            get { return loginaccount; }
            set { loginaccount = value; changAccount(loginaccount); }
        }
        public fACount(Account acc)
        {
            InitializeComponent();
            this.Loginaccount = acc;
        }

        void changAccount(Account acc) 
        {
            txbName.Text = loginaccount.Name;
            TxBdisplayName.Text = loginaccount.Displayname;



        }

        private void BTexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void UpdateAccount()
        {
            string displayName = TxBdisplayName.Text;
            string password = txbPassword.Text;
            string newPass = txbnewPassword.Text;
            string reenterPass = txbcomfimpassword.Text;
            string userName = txbName.Text;

            if (newPass.Equals(reenterPass))
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newPass))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu khớp với mật khẩu mới!");
            }
        }

        private void BTUpDate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        
    }
}
