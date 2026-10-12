using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckSystemDesktop
{
    internal class clsPerson: IComunication
    {
        //private 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        


        //pblic 

        public clsPerson(string firstName,string lastName,string email,string phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;

        }


        public void SendEmail(string Title, string Body)
        {

        }

        public void SendFax(string Title, string Body)
        {

        }
        public void SendSMS(string Title, string Body)
        {

        }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
