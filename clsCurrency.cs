using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BanckSystemDesktop
{
    internal class clsCurrency
    {
        internal enum enMode { UpdateMode = 1, EmptyMode = 0 }
        enMode _Mode;
        public string Country { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public float Rate { get; set; }
        private static string _ConvertCurrencyObjectToLine(clsCurrency Currency, string seperator = "#//#")
        {
            string sCurrencyLine = "";
            sCurrencyLine += Currency.Country + seperator;
            sCurrencyLine += Currency.CurrencyCode + seperator;
            sCurrencyLine += Currency.CurrencyName + seperator;
            sCurrencyLine += Convert.ToSingle(Currency.Rate) + seperator;

            return sCurrencyLine;
        }
        private static clsCurrency _ConvertLineToCurrencyObject(string Line, string seperator = "#//#")
        {
            string[] aCurrencyLine = Line.Split(new string[] { seperator }, StringSplitOptions.None);
            return new clsCurrency(enMode.UpdateMode, aCurrencyLine[0], aCurrencyLine[1], aCurrencyLine[2], Convert.ToSingle(aCurrencyLine[3]));
        }
        private static List<clsCurrency> _LoadCurrnciesFromFile()
        {
            List<clsCurrency> lCurrencies = new List<clsCurrency>();
            if (File.Exists("Currencies.txt"))
            {
                using (StreamReader MyFile = new StreamReader("Currencies.txt"))
                {
                    string Line;
                    while ((Line = MyFile.ReadLine()) != null)
                    {
                        lCurrencies.Add(_ConvertLineToCurrencyObject(Line));
                    }
                }
            }
            return lCurrencies;
        }
        private static clsCurrency _GetEmptyObject()
        {
            return new clsCurrency(enMode.EmptyMode, "", "", "", 0);
        }
        private static void _SaveCurrnciesToFile(List<clsCurrency> lCurrency)
        {
            using (StreamWriter MyFile = new StreamWriter("Currencies.txt"))
            {
                foreach (clsCurrency c in lCurrency)
                {
                    MyFile.WriteLine(_ConvertCurrencyObjectToLine(c));
                }
            }
        }
        private void _Update()
        {
            List<clsCurrency> lCurrencies = _LoadCurrnciesFromFile();
            for (int i = 0; i < lCurrencies.Count; i++)
            {
                if (lCurrencies[i].CurrencyCode == CurrencyCode)
                {
                    lCurrencies[i] = this;
                    break;
                }
            }
            _SaveCurrnciesToFile(lCurrencies);
        }

        public clsCurrency(enMode mode, string country, string currencyCode, string currencyName, float rate)
        {
            _Mode = mode;
            Country = country;
            CurrencyCode = currencyCode;
            CurrencyName = currencyName;
            Rate = rate;
        }

        void UpdateRate(float newrate)
        {
            Rate = newrate;
            _Update();
        }
        public bool IsEmpty()
        {
            return _Mode == enMode.EmptyMode;
        }
        public static clsCurrency FindByCode(string currencyCode)
        {
            List<clsCurrency> lCurrency = _LoadCurrnciesFromFile();
            foreach (clsCurrency c in lCurrency)
            {
                if (c.CurrencyCode == currencyCode)
                    return c;
            }
            return _GetEmptyObject();
        }
        public static clsCurrency FindByCountry(string country)
        {
            List<clsCurrency> lCurrency = _LoadCurrnciesFromFile();
            foreach (clsCurrency c in lCurrency)
            {
                if (c.Country == country)
                    return c;
            }
            return _GetEmptyObject();
        }
        public static bool IsCurrncyExist(string currencyCode)
        {
            clsCurrency Currency = FindByCode(currencyCode);
            return (!Currency.IsEmpty());
        }
        public static List<clsCurrency> GetCuurencyList()
        {
            return _LoadCurrnciesFromFile();
        }
        public float ConvertToUSD(float amountToTransfer)
        {
            return (float) amountToTransfer / Rate;
        }
        public float ConvertToOther(float amountToTransfer,clsCurrency currency2)
        {
            float CurrencyInUSD = ConvertToUSD(amountToTransfer);
            if(currency2.CurrencyCode=="USD")
            {
                return CurrencyInUSD;
            }
            return (float)(CurrencyInUSD * currency2.Rate);
        }
    }
}
