using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckSystemDesktop
{
    internal class clsDate
    {
        static  DateTime now = DateTime.Now;
        public static string GetSystemdateTimeString()
        {
            return now.ToString("d/M/yyyy - HH:mm:ss");
        }
        public static string Date()
        {
            return now.ToString("dd/MM/yyyy");
        }
        public static string Time()
        {
            return DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
