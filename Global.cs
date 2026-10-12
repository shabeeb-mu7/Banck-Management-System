using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckSystemDesktop
{

    internal static class Global
    {
        public static clsUser CurrentUser = clsUser.Find("", "");

        public static string GetDataFilePath(string FileName)
        {
            return Path.GetFullPath(
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\Data",
                    FileName
                )
            );
        }
    }
}
