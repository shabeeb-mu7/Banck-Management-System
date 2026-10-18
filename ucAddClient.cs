using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanckSystemDesktop;
using Guna.UI2.WinForms;

namespace SystemBanckDeskTop2
{
    public partial class ucAddClient : UserControl
    {
        // 1. Constructor
        public ucAddClient()
        {
            InitializeComponent();
            gtxtAccountNumber.Focus();

        }

        // 2. Event
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ucAddClient_Load(object sender, EventArgs e)
        {

        }
        private void gtxtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!_IsValidateAccountNumberText(gtxtAccountNumber))
            {
                e.Cancel=false;
                gtxtAccountNumber.Focus();
                return;
            }
            errorProvider1.SetError(gtxtAccountNumber, "");
            if (!_IsAccountNumberAvailable(gtxtAccountNumber.Text))
            {
                e.Cancel=false;
                gtxtAccountNumber.Text=string.Empty;
                gtxtAccountNumber.Focus();
                return;
            }
        }
        private void gbtnSearch_Click(object sender, EventArgs e)
        {
            _AddNewClient();
        }
        private void gbtnNames_Validating(object sender, CancelEventArgs e)
        {
            if (!_IsValidateName((Guna2TextBox)sender))
            {

                ((Guna2TextBox)sender).Focus();
                return;
            }
            errorProvider1.SetError((Guna2TextBox)sender, "");
        }
        private void gtxtPhone_Validating(object sender, CancelEventArgs e)
        {
            if(!_IsValidatePhone(gtxtPhone))
            {
                gtxtPhone.Focus();
                return;
            }
            errorProvider1.SetError(gtxtPhone, "");
        }
        private void gtxtPinCode_Validating(object sender, CancelEventArgs e)
        {
            if(!_IsValidatePinCode(gtxtPinCode))
            {
              gtxtPinCode.Focus();return;
            }
            errorProvider1.SetError(gtxtPinCode, "");
        }
        private void gtxtAccountBalance_Validating(object sender, CancelEventArgs e)
        {
            if (!_IsValidateBalance(gtxtAccountBalance))
            {
                gtxtAccountBalance.Focus(); return;
            }
            errorProvider1.SetError(gtxtAccountBalance, "");
        }
        private void gtxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(!_IsValdateEmail(gtxtEmail))
            {
                gtxtEmail.Focus(); 
                return;
            }
            errorProvider1.SetError(gtxtEmail, "");
        }


       
        // 4. Error handling
        private void _SetError(Guna2TextBox sender,string errorMessage)
        {
            errorProvider1.SetError(sender, errorMessage);
            sender.Focus();
        }

        // 5.Text boxes Validation methods
        private bool _IsValidateAccountNumberText(Guna2TextBox textBox)
        {
            string txtAccountNumberCurrentText = textBox.Text;
            if (clsValidate.IsTextEmpty(txtAccountNumberCurrentText))
            {
                _SetError(textBox, "Acc.Number is required.");
                return false;
            }

            if (!clsValidate.IsTextContainsLetterAndDigit(txtAccountNumberCurrentText))
            {
                _SetError(textBox, "Acc.Number must contain number and igit");
                return false;
            }
               
            if (clsValidate.IsTextContainsSpecialOrSpaceCharacter(txtAccountNumberCurrentText))
            {
                _SetError(textBox, "Special character or Space are not allowed.");
                return false ;
            }
            return true;
        }
        private bool _IsAccountNumberAvailable(string accountNumber)
        {
            if (clsBanckClient.IsClientExist(accountNumber))
            {
                MessageBox.Show("Used Acc.Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool _IsValidateName(Guna2TextBox textBox)
        {
            string text = textBox.Text;
            if (clsValidate.IsTextEmpty(text))
            {
                _SetError(textBox, "Feild Is required.");
                return false;
            }
            if (clsValidate.IsTextContainsDigit(text))
            {
                _SetError(textBox, "number Is not allowed.");
                return false;
            }


            if (clsValidate.IsTextContainsSpecialCharacter(text))
            {
                _SetError(textBox, "special character Is not allowed.");
                return false;
            }
            return true;
        }
        private bool _IsValidatePhone(Guna2TextBox textBox)
        {
            string phone=textBox.Text;
            if (clsValidate.IsTextEmpty(phone))
            {
                _SetError(textBox, "Phone is required.");
                return false;
            }
            if (phone.Length != 9)
            {
                _SetError(textBox, "Phone must contain of 9 digit.");
                return false;
            }
            if (!(phone.StartsWith("77") || phone.StartsWith("78") || phone.StartsWith("71") || phone.StartsWith("73")))
            {
                _SetError(textBox, "Number must start with \"77\" or \"78\" or \"71\" or \"73\".");
                return false;
            }
            if (clsValidate.IsTextContainsLetter(phone))
            {
                _SetError(textBox, "Letter is not allowed.");
                return false;
            }
            
            if (clsValidate.IsTextContainsSpecialOrSpaceCharacter(phone))
            {
                _SetError(textBox, "Special character or Space is not allowed.");
                return false;
            }
            
            
            return true ;
        }
        private bool _IsValidatePinCode(Guna2TextBox textBox)
        {
            string pinCode=textBox.Text;
            if(clsValidate.IsTextEmpty(pinCode))
            {
                _SetError(textBox, "Pine Code is required.");
                return false;
            }
            if (pinCode.Length != 4)
            {
                _SetError(textBox, "PinCode must be 4 digit.");
                return false;
            }
            if (clsValidate.IsTextContainsLetter(pinCode))
            {
                _SetError(textBox, "Letter is not allowed.");
                return false;
            }
            
            if (clsValidate.IsTextContainsSpecialOrSpaceCharacter(pinCode))
            {
                _SetError(textBox, "Special character or Space is not allowed.");
                return false;
            }
            return true;
        }
        private bool _IsValdateEmail(Guna2TextBox textBox)
        {
            string valdateEmail=textBox.Text;
            if(clsValidate.IsTextEmpty(valdateEmail))
            {
                _SetError(textBox, "Email is requred.");
                return false;
            }
            if (!valdateEmail.Contains('@'))
            {
                _SetError(textBox, "Email must contain @.");
                return false;
            }
            return true;
        }
        private bool _IsValidateBalance(Guna2TextBox textBox)
        {
            string balance=textBox.Text;
            if(clsValidate.IsTextEmpty(balance))
            {
                _SetError(textBox, "Balance Is required.");
                return false;
            }
            if(!float.TryParse(balance,out float value))
            {
                _SetError(textBox, "Balance must be number.");
                return false;
            }
            return true;
        }


        // 6. Reading input
        private bool _IsAllClientInfoRead(clsBanckClient newClient)
        {
            
            if(!_IsValidateName(gtxtFirstName))
            {
                gtxtFirstName.Focus();
                return false;
            }
            newClient.FirstName = gtxtFirstName.Text.Trim();
            if (!_IsValidateName(gtxtLastName))
            {
                gtxtLastName.Focus();
                return false;
            }
            newClient.LastName = gtxtLastName.Text.Trim();
            if (!_IsValidatePhone(gtxtPhone))
            {
                gtxtPhone.Focus();
                return false;
            }
            newClient.Phone = gtxtPhone.Text.Trim();
            if (!_IsValdateEmail(gtxtEmail))
            {
                gtxtEmail.Focus();
                return false;
            }
            newClient.Email = gtxtEmail.Text.Trim();
            if (!_IsValidatePinCode(gtxtPinCode))
            {
                gtxtPinCode.Focus();
                return false;
            }
            newClient.PinCode = gtxtPinCode.Text.Trim();
            if (!_IsValidateBalance(gtxtAccountBalance))
            {
                gtxtAccountBalance.Focus();
                return false;
            }
            newClient.AccountBalance =Convert.ToSingle( gtxtAccountBalance.Text);
            return true;
        }
        private bool _ReadgtxtValue(Guna2TextBox guna2TextBox,ref string textvalue)
        {
            
            if (_IsValidateAccountNumberText(guna2TextBox))
            {
                textvalue = guna2TextBox.Text.Trim();
                return true;
            }
            return false;
        }

        // 7. Client operations

        private void _AddNewClient()
        {
            string AccountNumber = "";
            if(!_ReadgtxtValue(gtxtAccountNumber,ref AccountNumber))
            {
                gtxtAccountNumber.Focus();
                return;
            }
            if(!_IsAccountNumberAvailable(AccountNumber))
            {
                gtxtAccountNumber.Focus();
                return;
            }
            gtxtAccountNumber.Enabled = false;
            gtxtAccountNumber.FillColor = Color.Red;
            gtxtFirstName.Focus();
            clsBanckClient NewClient = clsBanckClient.GetAddNewClientObject(AccountNumber);
            if(!_IsAllClientInfoRead(NewClient))
            {
                return;
            }
            clsBanckClient.enSaveResult enSaveResult = NewClient.Save();
            switch(enSaveResult)
            {
                case clsBanckClient.enSaveResult.svSucceeded:
                    {
                        MessageBox.Show("Client Saved", "Succeess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case clsBanckClient.enSaveResult.svFaildEmptyObject:
                    {
                        MessageBox.Show("Save Faild", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case clsBanckClient.enSaveResult.svFailedUserExists:
                    {
                        MessageBox.Show("Save Faild User exist", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
            

        }

        
    }
}
