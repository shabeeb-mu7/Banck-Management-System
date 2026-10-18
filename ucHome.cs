using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanckSystemDesktop;
using Guna.UI2.WinForms;

namespace SystemBanckDeskTop2
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
            //ppUserP.Image = Image.FromFile(@"D:\" + Global.CurrentUser.UserName + ".png");
            ppUserP.Image = Image.FromFile(@"C:\Users\STCH\Downloads\man.png");
            
            ppCalaender.Image = Image.FromFile(@"D:\calendar.png");
            ppTotalTransaction.Image = Image.FromFile(@"D:\transaction-history.png");
            ppTotalClients.Image = Image.FromFile(@"C:\Users\STCH\Downloads\audience.png");
            ppTotalBalances.Image = Image.FromFile(@"C:\Users\STCH\Downloads\money (1).png");
            ppTotalDeposits.Image = Image.FromFile(@"C:\Users\STCH\Downloads\money (2).png");
            ppWithdarwCard.Image = Image.FromFile(@"C:\Users\STCH\Downloads\withdraw.png");
            ppTotalTransfers.Image = Image.FromFile(@"C:\Users\STCH\Downloads\transference.png");
            ppTotalUsres.Image = Image.FromFile(@"C:\Users\STCH\Downloads\employee.png");
            gbtnRecentActivity.Image = Image.FromFile(@"C:\Users\STCH\Downloads\recently.png");
            gbtnCurrencyExchange.Image = Image.FromFile(@"C:\Users\STCH\Downloads\currency.png");
            lbTotalClients.Text=clsBanckClient.ClientCount.ToString();
            lbTotalBalances.Text=clsBanckClient.GetTotalBalnces().ToString()+ "$";
            lbTotalTransfers.Text=clsBanckClient.TransferCount.ToString();
            lbTotalUsers.Text=clsUser.UserCount.ToString();
        }
        private void chgangebanelcolormouseHover(object sender, EventArgs e)
        {
            ((Guna2Panel)sender).FillColor = Color.FromArgb(37, 99, 235);
        }
        private void chgangebanelcolormouseLeave(object sender, EventArgs e)
        {
            ((Guna2Panel)sender).FillColor = Color.White;
        }

        private void gpnlMangeClients_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbtnRecentActivity_Click(object sender, EventArgs e)
        {

        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            timerforTime.Start();
            lbUserName.Text = Global.CurrentUser.UserName;
            lbDate.Text = clsDate.Date();
            lbTime.Text = clsDate.Time();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbtnRecentActivity_Click_1(object sender, EventArgs e)
        {

        }

        private void timerforTime_Tick(object sender, EventArgs e)
        {
            lbTime.Text = clsDate.Time();
        }

        private void gbtnRecentActivity_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbtnRecentActivity_Click_3(object sender, EventArgs e)
        {

        }
    }
}
