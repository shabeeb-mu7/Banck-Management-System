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
using System.Media;
namespace SystemBanckDeskTop2
{
    public partial class ucTransaction : UserControl
    {
        public ucTransaction()
        {
            InitializeComponent();
            pnlDepositHeader.Width = 840;
            pnlTransfer.Width = 840;

            pnlTransfer.Visible = false;

            gbtnProcess.Image = Image.FromFile(@"C:\Users\STCH\Downloads\transfer.png");


            _SelectButton(gbtnDeposit);
            _ShowDepositAndWithdrawScreenHeader();
        }

        private Guna2Button _SelectedButton = null;
        private Panel _CurrentPanel = null;
        private Panel _NextPanel = null;
        //Btn selected functions
        private void _SelectButton(Guna2Button button)
        {
            if(_SelectedButton != null)
            {
                if (_SelectedButton == button)
                    return;
                _SelectedButton.FillColor = Color.FromArgb(203, 213, 225);
                _SelectedButton.ForeColor = Color.FromArgb(37, 99, 235);
            }
            _SelectedButton = button;
            _SelectedButton.FillColor = Color.FromArgb(37, 99, 235);
            _SelectedButton.ForeColor = Color.White;
        }
        private void _SelectPanelHeaderContent()
        {
            if (_SelectedButton == gbtnDeposit || _SelectedButton == gbtnWithdrawlas)
            {
                _CurrentPanel = pnlDepositHeader;
                return;
            }
            if (_SelectedButton == gbtnTransfer)
            {
                _CurrentPanel = pnlTransfer;
                return;
            }
        }
        private void _ShowTransferScreedHeader()
        {
            _ChangePanel(pnlTransfer);
        }
        private void _ShowDepositAndWithdrawScreenHeader()
        {
            _ChangePanel(pnlDepositHeader);
        }
        private void _ChangePanel(Panel panel)
        {
            if (_CurrentPanel == panel && _NextPanel == null)
                return;

            timerFadeIn.Stop();
            timerFadeOut.Stop();

            _NextPanel = panel;

            if (_CurrentPanel == null || _CurrentPanel.Width == 0)
            {
                _ShowNextPanel();
                return;
            }

            timerFadeOut.Start();
        }
        private void _ShowNextPanel()
        {
            if (_CurrentPanel != null)
                _CurrentPanel.Visible = false;

            _CurrentPanel = _NextPanel;
            _NextPanel = null;

            if (_CurrentPanel == null)
                return;

            _CurrentPanel.Width = 0;
            _CurrentPanel.Visible = true;

            timerFadeIn.Start();
        }
        //Search function
        private bool _IsAccountNumberUsed(Guna2TextBox guna2TextBox)
        {
            if(!clsValidate._IsgtxtSearchValidate(guna2TextBox))
            {
                return false;
            }
            if(!clsValidate._IsClientExist(guna2TextBox.Text))
            {
                return false;
            }
            return true;
        }
        //Reset functions
        private void _ResetDepositAndWithDrawalsFeilds()
        {
            gtxtSearch.Text= string.Empty;
            gtxtBalance.Text= string.Empty;
        }
        private void _ResetTransferFeilds()
        {
            gtxtSenderAccountNumber.Text = string.Empty;
            gtxtBalance.Text = string.Empty;
            gtxtRecipientAccountNumber.Text = string.Empty;
        }
        //Message Box
        private void _ShowProcessSucceesMessageBox()
        {
            MessageBox.Show("Process Done.","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void _ShowClientFoundNotiFy()
        {
            frmshowIconnotifycation frmshow= new frmshowIconnotifycation();
            frmshow.sTitle = "Success";
            frmshow.Description = "Client Found.";
            SystemSounds.Asterisk.Play();
            frmshow.Show();
            
        }
        //Client Operation
        private void Deposit()
        {
            if(!_IsAccountNumberUsed(gtxtSearch))
            {
                return;
            }
            if(!_IsValidateBalance(gtxtBalance))
            {
                return;
            }
            clsBanckClient client=clsBanckClient.Find(gtxtSearch.Text);
            if(_SelectedButton==gbtnDeposit)
            {
                client.Deposit(Convert.ToSingle(gtxtBalance.Text));
            }
            if(_SelectedButton==gbtnWithdrawlas)
            {
                if(!client.WithDraw(Convert.ToSingle(gtxtBalance.Text)))
                {
                    return;
                }
            }
            _ShowProcessSucceesMessageBox();
            _ResetDepositAndWithDrawalsFeilds();
        }
        //Error setter method
        private void _SetError(Guna2TextBox sender, string errorMessage)
        {
            errorProvider1.SetError(sender, errorMessage);
        }
        // Text boxes validation method
        private bool _IsValidateBalance(Guna2TextBox textBox)
        {
            string balance = textBox.Text;
            if (clsValidate.IsTextEmpty(balance))
            {
                _SetError(textBox, "Balance Is required.");
                return false;
            }
            if (!float.TryParse(balance, out float value))
            {
                _SetError(textBox, "Balance must be number.");
                return false;
            }
            if(value<=0)
            {
                _SetError(textBox, "Balance must be <Positive>.");
                return false;
            }
            return true;
        }
        //Event
        private void gtxtSearch_Enter(object sender, EventArgs e)
        {
            if (((Guna2TextBox)sender).Text == "Search by Account number...")
            {
                ((Guna2TextBox)sender).Text = string.Empty;
            }
        }
        private void gtxtSearch_Leave(object sender, EventArgs e)
        {
            if (((Guna2TextBox)sender).Text == string.Empty)
            {
                ((Guna2TextBox)sender).Text = "Search by Account number...";
            }
        }
        private void gbtnSearch_Click(object sender, EventArgs e)
        {

        }
        private void gbtnTransfer_Click(object sender, EventArgs e)
        {
            _SelectButton(gbtnTransfer);
            _ShowTransferScreedHeader();
        }
        private void gbtnDeposit_Withdraw_Click(object sender, EventArgs e)
        {
            _SelectButton((Guna2Button)sender);
            _ShowDepositAndWithdrawScreenHeader();
        }
        private void gtxtSenderAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void gtxtBalance_Validating(object sender, CancelEventArgs e)
        {
            if(!_IsValidateBalance(gtxtBalance))
            {
                return;
            }
            errorProvider1.SetError(gtxtBalance, "");
        }
        private void gbtnProcess_Click(object sender, EventArgs e)
        {
            Deposit();
        }
        private void gbtnSearch_Click_1(object sender, EventArgs e)
        {
            if (!_IsAccountNumberUsed(gtxtSearch))
            {
                gtxtSearch.Text = string.Empty;
                gtxtSearch.Focus();
                return;
            }
            _ShowClientFoundNotiFy();
        }
        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            _CurrentPanel.Width = Math.Min(_CurrentPanel.Width + 24, 840);

            if (_CurrentPanel.Width == 840)
            {
                timerFadeIn.Stop();
            }

        }
        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            _CurrentPanel.Width = Math.Max(_CurrentPanel.Width - 24, 0);

            if (_CurrentPanel.Width == 0)
            {
                timerFadeOut.Stop();
                _ShowNextPanel();
            }

        }
    }
}
