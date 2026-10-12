using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemBanckDeskTop2
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
            ppUserP.Image = Image.FromFile(@"D:\user.png");
            gppCalender.Image = Image.FromFile(@"D:\calendar.png");
            ppTotalTransaction.Image = Image.FromFile(@"D:\transaction-history.png");
            ppTotalClients.Image = Image.FromFile(@"C:\Users\STCH\Downloads\audience.png");
            ppTotalBalances.Image = Image.FromFile(@"C:\Users\STCH\Downloads\money (1).png");
            ppTotalDeposits.Image = Image.FromFile(@"C:\Users\STCH\Downloads\money (2).png");
            ppWithdarwCard.Image = Image.FromFile(@"C:\Users\STCH\Downloads\withdraw.png");
            ppTotalTransfers.Image = Image.FromFile(@"C:\Users\STCH\Downloads\transference.png");
            ppTotalUsres.Image = Image.FromFile(@"C:\Users\STCH\Downloads\employee.png");
            gbtnRecentActivity.Image = Image.FromFile(@"C:\Users\STCH\Downloads\recently.png");
            gbtnCurrencyExchange.Image = Image.FromFile(@"C:\Users\STCH\Downloads\currency.png");
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelcontentcards_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gpnlMangeClients_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbtransactioncount_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ppTotalClients_Click(object sender, EventArgs e)
        {

        }
    }
}
