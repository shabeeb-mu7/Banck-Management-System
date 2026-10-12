using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace BanckSystemDesktop
{
    internal class clsBanckClient:clsPerson
    {
        //private

        internal enum enMode { UpdateMode=0, AddNewMode,EmptyMode}

        enMode _Mode;
        public string AccountNumber {  get; set; }
        public string PinCode {  get; set; }
        public float AccountBalance {  get; set; }
        bool _MarkedForDelete = false;

        static clsBanckClient _ConvertLineToBanckClientObject(string Line,string seperator="#//#")
        {
            string[] aBanckClientData = Line.Split(new string[] { seperator }, StringSplitOptions.None);
            return new clsBanckClient(enMode.UpdateMode, aBanckClientData[0], aBanckClientData[1],
                aBanckClientData[2], aBanckClientData[3], aBanckClientData[4], aBanckClientData[5],Convert.ToSingle(aBanckClientData[6]));
        }
        static string _ConvertBanckClientObjectToLine(clsBanckClient BanckClient,string seperator="#//#")
        {
            string sBanckClientLine = "";
            sBanckClientLine += BanckClient.FirstName + seperator;
            sBanckClientLine += BanckClient.LastName + seperator;
            sBanckClientLine += BanckClient.Email + seperator;
            sBanckClientLine += BanckClient.Phone + seperator;
            sBanckClientLine += BanckClient.AccountNumber + seperator;
            sBanckClientLine += BanckClient.PinCode + seperator;
            sBanckClientLine += BanckClient.AccountBalance.ToString();
            return sBanckClientLine;
        }
        static List<clsBanckClient> _LoadBanckClientDataFromFile()
        {
            List<clsBanckClient> lClients= new List<clsBanckClient>();
            if (File.Exists("Clients.txt"))
            {
                using(StreamReader MyFile=new StreamReader("Clients.txt"))
                {
                    string Line;
                    while ((Line = MyFile.ReadLine()) != null)
                    {
                        lClients.Add(_ConvertLineToBanckClientObject(Line));
                    }
                }
            }
            return lClients;
        }
        static void _SaveClienstDataToFile(List<clsBanckClient> lClients)
        {
            using(StreamWriter MyFile=new StreamWriter("Clients.txt"))
            {
                foreach(clsBanckClient Client in lClients)
                {
                    if (Client.MarkedForDelete() == false)
                    {
                        MyFile.WriteLine(_ConvertBanckClientObjectToLine(Client));
                    }
                }
            }
        }
        static clsBanckClient _GetEmptyBanckClientObject()
        {
            return new clsBanckClient(enMode.EmptyMode, "", "", "", "", "", "", 0);
        }
        void _Update()
        {
            List<clsBanckClient> lClients = _LoadBanckClientDataFromFile();
            for (int i = 0; i < lClients.Count; i++)
            {
                if (lClients[i].AccountNumber==AccountNumber)
                {
                    lClients[i] = this;
                    break;
                }
            }
            _SaveClienstDataToFile(lClients);
        }
        void _AddDataLineToFile(string Line)
        {
            using(StreamWriter MyFile=new StreamWriter(Line, true))
            {
                MyFile.WriteLine(Line);
            }
        }
        void _AddNew()
        {
            _AddDataLineToFile(_ConvertBanckClientObjectToLine(this));
        }
        string _PrepareTransferLogRecord(float AmountTransfer,clsBanckClient DestenationClient, string seperator="#//#")
        {
            string sTransferLogRecordLine = "";
            sTransferLogRecordLine += clsDate.GetSystemdateTimeString() + seperator;
            sTransferLogRecordLine += AccountNumber + seperator;
            sTransferLogRecordLine += DestenationClient.AccountNumber + seperator;
            sTransferLogRecordLine += AmountTransfer.ToString() + seperator;
            sTransferLogRecordLine += AccountBalance.ToString() + seperator;
            sTransferLogRecordLine += DestenationClient.AccountBalance.ToString() + seperator;
            sTransferLogRecordLine += Global.CurrentUser.UserName;

            return sTransferLogRecordLine;
        }
        void _RegisterTransferLog(float AmountTransfer,clsBanckClient DestenationClient)
        {
            string RegisterLine=_PrepareTransferLogRecord(AmountTransfer,DestenationClient);
            using(StreamWriter MyFile= new StreamWriter("TransferLog.txt", true))
            {
                MyFile.WriteLine(RegisterLine);
            }
        }
        static stTransferOperationsLogs _ConvertLineToTransferLogObject(string Line,string seperator="#//#")
        {
            string[] aTransferLogLine = Line.Split(new string[] { seperator }, StringSplitOptions.None);
            stTransferOperationsLogs TransferLog= new stTransferOperationsLogs();
            TransferLog.SystemDateTime = aTransferLogLine[0];
            TransferLog.SourceClient_AcountNumber=aTransferLogLine[1];
            TransferLog.DestinationsClient_AcountNumber = aTransferLogLine[2];
            TransferLog.TheAmountTransferd=Convert.ToSingle(aTransferLogLine[3]);
            TransferLog.SourceClientAmount=Convert.ToSingle(aTransferLogLine[4]);
            TransferLog.DestinationsClientAmount = Convert.ToSingle(aTransferLogLine[5]);
            TransferLog.UserName=aTransferLogLine[6];

            return TransferLog;
        }

        //public

        public clsBanckClient(enMode mode,string firstname,string lastname,string email, string phone,string accountnumber
            ,string pincode,float accountbalance):base(firstname, lastname, phone, email)
        {
            AccountNumber= accountnumber;
            PinCode= pincode;
            AccountBalance = accountbalance;
        }
        public struct stTransferOperationsLogs
        {
            public string SystemDateTime;
            public string SourceClient_AcountNumber;
            public string DestinationsClient_AcountNumber;
            public float TheAmountTransferd;
            public float SourceClientAmount;
            public float DestinationsClientAmount;
            public string UserName;
        };
        public bool MarkedForDelete()
        {
            return _MarkedForDelete;
        }
        public bool IsEmpty()
        {
            return _Mode == enMode.EmptyMode;
        }
        public static clsBanckClient Find(string AccountNumber)
        {
            List<clsBanckClient> lClients = _LoadBanckClientDataFromFile();
            foreach(clsBanckClient client in lClients)
            {
                if(client.AccountNumber == AccountNumber)
                {
                    return client;
                }
            }
            return _GetEmptyBanckClientObject();
        }
        public static clsBanckClient Find(string AccountNumber,string PinCode)
        {
            List<clsBanckClient>lClients = _LoadBanckClientDataFromFile();
            foreach(clsBanckClient client in lClients)
            {
                if(client.AccountNumber==AccountNumber&&client.PinCode==PinCode)
                {
                    return client;
                }
            }
            return _GetEmptyBanckClientObject();
        }
        public static bool IsClientExist(string AccountNumber)
        {
            clsBanckClient Client=Find(AccountNumber);
            return (!Client.IsEmpty());
        }
        public enum enSaveResult { svFaildEmptyObject = 0, svSucceeded = 1, svFailedUserExists = 2 }
        public enSaveResult Save()
        {
            switch (_Mode)
            {
                case enMode.EmptyMode:
                    return enSaveResult.svFaildEmptyObject;
                case enMode.UpdateMode:
                    _Update();
                    return enSaveResult.svSucceeded;
                    case enMode.AddNewMode:
                    if(IsClientExist(AccountNumber))
                    {
                        return enSaveResult.svFailedUserExists;
                    }
                    _AddNew();
                    _Mode=enMode.UpdateMode;
                    return enSaveResult.svSucceeded;
                default:
                    return enSaveResult.svFaildEmptyObject;
                    

            }
        }
        public bool Delete()
        {
            List<clsBanckClient> lClients = _LoadBanckClientDataFromFile();
            for(int i=0;i<lClients.Count;i++)
            {
                if (lClients[i].AccountNumber== AccountNumber)
                {
                    lClients[i]._MarkedForDelete = true;
                    break;
                }
            }
            _SaveClienstDataToFile(lClients);
            _Mode = enMode.EmptyMode;
            return true;
        }
        public static List<clsBanckClient> GetBanckClientsList()
        {
            return _LoadBanckClientDataFromFile();
        }
        public static clsBanckClient GetAddNewClientObject()
        {
            return new clsBanckClient(enMode.AddNewMode, "", "", "", "", "", "", 0);
        }
        public static float GetTotalBalnces()
        {
            List<clsBanckClient> lClients= _LoadBanckClientDataFromFile();
            float total = 0;
            foreach(clsBanckClient client in lClients)
            {
                total += client.AccountBalance;
            }
            return total;
        }
        public void Deposit(float amount)
        {
            AccountBalance += amount;
            Save();
        }
        public bool WithDraw(float amount)
        {
            if(AccountBalance<amount)
            {
                return false;
            }
            AccountBalance-=amount;
            Save();
            return true;
        }
        public bool Transfer(float amount ,ref clsBanckClient DestenationClient)
        {
            if(this.WithDraw(amount))
            {
                DestenationClient.Deposit(amount);
                _RegisterTransferLog(amount, DestenationClient);
                return true;
            }
            return false;
        }
        public static List<stTransferOperationsLogs> GetTransferOperationsLogsList()
        {
            List<stTransferOperationsLogs>lstTransferOperationsLogs= new List<stTransferOperationsLogs>();
            if (File.Exists("TransferLog.txt"))
            {
                using(StreamReader MyFile=new StreamReader("TransferLog.txt"))
                {
                    string Line;
                    while ((Line = MyFile.ReadLine()) != null)
                    {
                        lstTransferOperationsLogs.Add(_ConvertLineToTransferLogObject(Line));
                    }
                    
                }
            }
            return lstTransferOperationsLogs;
        }
    }
}
