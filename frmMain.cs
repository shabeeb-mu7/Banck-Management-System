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

namespace SystemBanckDeskTop2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            ppBnckIcon.Image = Image.FromFile(@"C:\Users\STCH\Downloads\convenience.png");
            gbtnClients.Image = Image.FromFile(@"C:\Users\STCH\Downloads\audience.png");
            gbtnTransaction.Image = Image.FromFile(@"C:\Users\STCH\Downloads\money-transfer.png");
            gbtnUser.Image = Image.FromFile(@"D:\user (1).png");
            gbtnReorts.Image = Image.FromFile(@"D:\report.png");
            gbtnLogOut.Image = Image.FromFile(@"D:\logout.png");
        }
        private Guna2Button _SelectedButton = null;
        private void SelectedButton(Guna2Button guna2Button)
        {
            if(_SelectedButton != null)
            {
                if (_SelectedButton == guna2Button)
                    return;
                _SelectedButton.FillColor = Color.Transparent;
                _SelectedButton.BorderThickness = 0;
                
            }
            _SelectedButton=guna2Button;
            _SelectedButton.FillColor = Color.FromArgb(37, 99, 235);
            _SelectedButton.BorderThickness = 1;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void ShowpanelContentControls(UserControl userControl)
        {
            panelcontent.Controls.Clear();
            userControl.Dock=DockStyle.Fill;
            panelcontent.Controls.Add(userControl);
        }
        private void change_gbtnbackcolormouseEnter(object sender, EventArgs e)
        {
            if (((Guna2Button)sender) == _SelectedButton)
            {
               
                return;
            }
            guna2Elipseforgbtns.TargetControl = ((Guna2Button)sender);
            ((Guna2Button)sender).FillColor = Color.FromArgb(147, 197, 253);
        }
        private void change_gbtnbackcolormouseLeave(object sender, EventArgs e)
        {
            if(((Guna2Button)sender)==_SelectedButton)
            {                
                return;
            }
            guna2Elipseforgbtns.TargetControl = null;
            ((Guna2Button)sender).FillColor = Color.Transparent;
        }
        ucHome home = new ucHome();
        private void gbtnHome_Click(object sender, EventArgs e)
        {
            SelectedButton(((Guna2Button)sender));
            ShowpanelContentControls(home);
        }
        ucClients ucClients = new ucClients();
        private void gbtnClients_Click(object sender, EventArgs e)
        {
            SelectedButton((Guna2Button)sender);
            ShowpanelContentControls(ucClients);
        }
    }
}
