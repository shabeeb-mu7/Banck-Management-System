using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBanckDeskTop2;

namespace BanckSystemDesktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        short FaildLoginCount = 0;
        bool LoginFaild = false;
        void _Resettxtboxes()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
        void _ResetLoginScreen()
        {
            LoginFaild = false;
            FaildLoginCount = 0;
            lbWrongInput.Text = "";
            lbFaildLoginCount.Text = "";
            _Resettxtboxes();
        }
        void _ShowMainForm()
        {
            this.Hide();
            _ResetLoginScreen();
            using (Form Form1 = new frmMain())
            {
                Form1.ShowDialog();
            }
            this.Show();
            txtUserName.Focus();
        }
        void _ShowBlockMessage()
        {
            panel1.Enabled = false;
            MessageBox.Show("you were bloked press Exit To leav", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnExit.Focus();
        }
        bool _CountLoginFailedToBlock()
        {
            if (LoginFaild)
            {
                FaildLoginCount++;
                lbWrongInput.Text = "Invalid UserName or Password!";
                lbFaildLoginCount.Text = "You have " + (3 - FaildLoginCount) + " Trails";
                _Resettxtboxes();
                txtUserName.Focus();
                if (FaildLoginCount == 3)
                {
                    _ShowBlockMessage();
                }
                return true;
            }
            return false;
        }
        void _Login()
        {
            Global.CurrentUser = clsUser.Find(txtUserName.Text, txtPassword.Text);
            LoginFaild = Global.CurrentUser.IsEmpty();
            if (!_CountLoginFailedToBlock())
            {
                Global.CurrentUser.RegisterLogin();
                _ShowMainForm();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _Login();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
