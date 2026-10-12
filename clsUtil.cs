using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckSystemDesktop
{
    internal class clsUtil
    {
        public static string Encrypt(string input,int EncryptKey=2)
        {
            char[] chinput = input.ToCharArray();
            for (int i = 0; i < chinput.Length; i++)
            {
                chinput[i] = (char)(chinput[i] + EncryptKey);
            }
            return new string(chinput);
        }

        public static string Decrypt(string input,int DecryptKey=2)
        {
            char[] chinput = input.ToCharArray();
            for (int i = 0; i < chinput.Length; i++)
            {
                chinput[i] = (char)(chinput[i] - DecryptKey);
            }
            return new string(chinput);
        }
    }
}
