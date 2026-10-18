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
    public partial class ucDelete : UserControl
    {
        public ucDelete()
        {
            InitializeComponent();
        }

        //Hellper Function
        
        
        private bool _EncureDelete()
        {
            if(MessageBox.Show("Press Ok to confirm delete","Confirm",MessageBoxButtons.OKCancel
                ,MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2)
                ==DialogResult.OK)
            {
                return true;
            }
            return false;
        }
        private void _ShowClientCard(clsBanckClient client)
        {
            lbFirstname.Text = client.FirstName;
            lbLastName.Text = client.LastName;
            lbEmail.Text = client.Email;
            lbPhone.Text = client.Phone;
            lbPinCode.Text = client.PinCode;
            lbBalance.Text = client.AccountBalance.ToString();
        }
        private void _DischargeClientCard()
        {
            lbFirstname.Text=string.Empty;
            lbLastName.Text=string.Empty;
            lbEmail.Text=string.Empty;
            lbPhone.Text=string.Empty;
            lbPinCode.Text=string.Empty;
            lbBalance.Text=string.Empty;
        }
        private void _ShowDeleteSucceessMessage()
        {
            MessageBox.Show("Client Deleted", "Succees", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Search fuction
        private bool _GetClientSearchedFor(ref clsBanckClient client)
        {
            if (!clsValidate._IsgtxtSearchValidate(gtxtSearch))
            {
                return false;
            }
            if (!clsValidate._IsClientExist(gtxtSearch.Text))
            {
                return false;
            }

            client = clsBanckClient.Find(gtxtSearch.Text.Trim());
            return true;
        }

        //Client operation
        private void _DeleteClient()
        {
            clsBanckClient client = clsBanckClient.Find("");
            if (!_GetClientSearchedFor(ref client))
            {
                gtxtSearch.Focus();
                _DischargeClientCard();
                return;
            }
            _ShowClientCard(client);
            if (!_EncureDelete())
            {
                return;
            }
            client.Delete();
            _DischargeClientCard();
            _ShowDeleteSucceessMessage();

        }

        //Event
        private void gbtnDeleteClient_Click(object sender, EventArgs e)
        {
            _DeleteClient();
        }
        private void gbtnSearch_Click(object sender, EventArgs e)
        {
            clsBanckClient client = clsBanckClient.Find("");
            if (!_GetClientSearchedFor(ref client))
            {
                gtxtSearch.Focus();
                _DischargeClientCard();
                return;
            }
            _ShowClientCard(client);
        }
        private void gtxtSearch_Enter(object sender, EventArgs e)
        {
            if(gtxtSearch.Text== "Search by Account number...")
            {
                gtxtSearch.Text = string.Empty;
            }
        }
        private void gtxtSearch_Leave(object sender, EventArgs e)
        {
            if(gtxtSearch.Text==string.Empty)
            {
                gtxtSearch.Text = "Search by Account number...";
            }
        }
        private void gbtnCancel_Click(object sender, EventArgs e)
        {
            gtxtSearch.Text = "Search by Account number...";
            _DischargeClientCard();
        }

        private void ucDelete_Load(object sender, EventArgs e)
        {
            if (ucClients.CurrentAccountNumber != "")
            {
                gtxtSearch.Text=ucClients.CurrentAccountNumber;
                gbtnSearch.PerformClick();
            }
        }
    }
}
