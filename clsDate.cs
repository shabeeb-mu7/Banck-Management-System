using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckSystemDesktop
{
    internal class clsDate
    {
        public static string GetSystemdateTimeString()
        {
            DateTime now = DateTime.Now;
            return now.ToString("d/M/yyyy - HH:mm:ss");
        }
    }
}
