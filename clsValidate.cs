using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanckSystemDesktop;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace SystemBanckDeskTop2
{
    public static class clsValidate
    {
        public static bool _IsClientExist(string accountNumber)
        {
            if (!clsBanckClient.IsClientExist(accountNumber))
            {
                MessageBox.Show("worng acc.number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool _IsgtxtSearchValidate(Guna2TextBox guna2TextBox)
        {
            if (guna2TextBox.Text == "Search by Account number..." || string.IsNullOrEmpty(guna2TextBox.Text))
            {
                return false;
            }
            return true;
        }
        public static bool IsTextEmpty(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }
        public static bool IsTextContainsLetter(string text)
        {
            return text.Any(char.IsLetter);
        }
        public static bool IsTextContainsDigit(string text)
        {
            return text.Any(char.IsDigit);
        }
        public static bool IsTextContainsLetterAndDigit(string text)
        {
            return IsTextContainsLetter(text) && IsTextContainsDigit(text);
        }
        public static bool IsTextContainsSpecialOrSpaceCharacter(string text)
        {
            return (text.Any(c => !char.IsLetterOrDigit(c)));
        }
        public static bool IsTextContainsSpecialCharacter(string text)
        {
            return (text.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)));
        }
    }
}
