using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Diagnostics;
namespace SystemBanckDeskTop2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            this.KeyPreview = true;
            ppBnckIcon.Image = Image.FromFile(@"C:\Users\STCH\Downloads\convenience.png");
            gbtnClients.Image = Image.FromFile(@"C:\Users\STCH\Downloads\audience.png");
            gbtnTransaction.Image = Image.FromFile(@"C:\Users\STCH\Downloads\money-transfer.png");
            gbtnUser.Image = Image.FromFile(@"D:\user (1).png");
            gbtnReorts.Image = Image.FromFile(@"D:\report.png");
            gbtnLogOut.Image = Image.FromFile(@"D:\logout.png");
        }
        private Guna2Button _SelectedButton = null;

        //panel content operation
        public void ShowpanelContentControls(UserControl userControl)
        {

            panelcontent.SuspendLayout();
            try
            {
                foreach(Control control in panelcontent.Controls)
                {
                    control.Dispose();
                }
                panelcontent.Controls.Clear();

                userControl.Dock = DockStyle.Fill;
                panelcontent.Controls.Add(userControl);
                userControl.Focus();
            }
            finally
            {
                panelcontent.ResumeLayout(true);
            }
        }
        private void btnclickchangebanelcontent(object sender, UserControl userControl)
        {

            SelectedButton(((Guna2Button)sender));
            ShowpanelContentControls(userControl);
        }


        //Helper function for SideBar buttons
        private void change_gbtnbackcolormouseEnter(object sender, EventArgs e)
        {
            if (((Guna2Button)sender) == _SelectedButton)
            {
                return;
            }
            ((Guna2Button)sender).BorderRadius = 5;
            ((Guna2Button)sender).FillColor = Color.FromArgb(147, 197, 253);
        }
        private void change_gbtnbackcolormouseLeave(object sender, EventArgs e)
        {
            if(((Guna2Button)sender)==_SelectedButton)
            {                
                return;
            }
            ((Guna2Button)sender).BorderRadius = 0;
            ((Guna2Button)sender).FillColor = Color.Transparent;
        }
        private void SelectedButton(Guna2Button guna2Button)
        {
            if (_SelectedButton != null)
            {
                if (_SelectedButton == guna2Button)
                    return;
                _SelectedButton.FillColor = Color.Transparent;
                _SelectedButton.BorderThickness = 0;
                _SelectedButton.ForeColor = Color.FromArgb(23, 37, 84);
                _SelectedButton.BackColor = Color.Transparent;


            }
            _SelectedButton = guna2Button;
            _SelectedButton.FillColor = Color.FromArgb(37, 99, 235);
            _SelectedButton.BackColor = Color.White;
            _SelectedButton.ForeColor = Color.White;
            _SelectedButton.BorderThickness = 1;
        }

        //Declare uc Variable

        ucHome home = null;
        ucClients ucClients = null;
        ucTransaction ucTransaction = null;
        ucUsers ucUsers = null;
        ucReports ucReports = null;


        //Event
        private void frmMain_Load(object sender, EventArgs e)
        {
        }
        private void gbtnHome_Click(object sender, EventArgs e)
        {
            //if (home == null)
                home = new ucHome();
            btnclickchangebanelcontent(sender, home);

        }
        private void gbtnClients_Click(object sender, EventArgs e)
        {
            
                ucClients = new ucClients();
            btnclickchangebanelcontent(sender, ucClients);
        }
        private void gbtnTransaction_Click(object sender, EventArgs e)
        {
            //if(ucTransaction==null)
                ucTransaction = new ucTransaction();

            btnclickchangebanelcontent(sender, ucTransaction);
        }
        private void gbtnUser_Click(object sender, EventArgs e)
        {
           // if(ucUsers==null)
                ucUsers = new ucUsers();
            btnclickchangebanelcontent(sender , ucUsers);
        }
        private void gbtnReorts_Click(object sender, EventArgs e)
        {
           // if(ucReports==null)
                ucReports = new ucReports();
            btnclickchangebanelcontent(sender,ucReports);
        }
        private void gbtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
