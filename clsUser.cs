using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace BanckSystemDesktop
{
    internal class clsUser: clsPerson
    {

        //private
        static string path = Global.GetDataFilePath("Users.txt");
        static string pathloginregister = Global.GetDataFilePath("LoginRegister.txt");
        internal enum enMode { EmptyMode,UpdateMode,AddNewMode}

        enMode _Mode;
        public string UserName { get; set; }
        public string Password {  get; set; }
        public int Permissions {  get; set; }

        bool _MarkedForDelete = false;
        public static int UserCount = _LoadUsersDataFromFile().Count - 1;
        static clsUser _ConvertLineToUserObject(string line,string seprator="#//#")
        {
            string[] aUsersData = line.Split(new string[] {seprator},StringSplitOptions.None);
            return new clsUser(enMode.UpdateMode, aUsersData[0], aUsersData[1], aUsersData[2], aUsersData[3]
                , aUsersData[4], clsUtil.Decrypt(aUsersData[5]), Convert.ToInt32(aUsersData[6]));
        }

        static string _ConvertUserObjectToLine(clsUser User,string separator = "#//#")
        {
            string sUserLine = "";
            sUserLine += User.FirstName + separator;
            sUserLine+=User.LastName+ separator;
            sUserLine += User.Email + separator;
            sUserLine += User.Phone + separator;
            sUserLine += User.UserName + separator;
            sUserLine += clsUtil.Encrypt(User.Password) + separator;
            sUserLine += User.Permissions.ToString();

            return sUserLine;
        }

        static List<clsUser> _LoadUsersDataFromFile()
        {
            List<clsUser> lUsers=new List<clsUser>();
            if(File.Exists(path))
            {
                using(StreamReader MyFile=new StreamReader(path))
                {
                    string Line;
                    while ((Line = MyFile.ReadLine()) != null)
                    {
                        lUsers.Add(_ConvertLineToUserObject(Line));
                    }
                }
            }

            return lUsers;
        } 

        static void _SaveUsersDataToFile(List<clsUser> lUsers)
        {
        
            using (StreamWriter MyFile = new StreamWriter(path))
            {
                foreach(clsUser user in lUsers)
                {
                    if (user.MarkedForDeleted() == false)
                    {
                        MyFile.WriteLine(_ConvertUserObjectToLine(user));
                    }
                }
            }

        }

        void _Update()
        {
            List<clsUser> lUsers = _LoadUsersDataFromFile();
            for (int i = 0; i < lUsers.Count; i++)
            {
                if (lUsers[i].UserName==UserName)
                {
                    lUsers[i] = this;
                    break;
                }
            }
            _SaveUsersDataToFile(lUsers);
        }

        void _AddDataLineToFile(string sDataLine)
        {
            using(StreamWriter MyFile=new StreamWriter(path, true))
            {
                MyFile.WriteLine(sDataLine);
            }
        }

        void _AddNew()
        {
            _AddDataLineToFile(_ConvertUserObjectToLine(this));
        }

        static clsUser _GetEmptyUserObject()
        {
            return new clsUser(enMode.EmptyMode, "", "", "", "", "", "", 0);
        }

        string _PrepareLoginrecord(string Seperator = "#//#")
        {
            return clsDate.GetSystemdateTimeString() + Seperator +
                UserName + Seperator + clsUtil.Encrypt(Password) + Seperator +
                Permissions.ToString();
        }

        static stLoginRegisterRecord _ConvertLineToLoginRgisterRecord(string Line, string Seperator="#//#")
        {
            stLoginRegisterRecord loginRegisterRecord = new stLoginRegisterRecord();
            string[] sLoginRegisterRecord = Line.Split(new string[] { Seperator }, StringSplitOptions.None);
            loginRegisterRecord.SystemDateTime = sLoginRegisterRecord[0];
            loginRegisterRecord.UserName = sLoginRegisterRecord[1];
            loginRegisterRecord.Password = clsUtil.Decrypt(sLoginRegisterRecord[2]);
            loginRegisterRecord.Permission = Convert.ToInt32(sLoginRegisterRecord[3]);
            
            return loginRegisterRecord;
        }

        //public

        public enum enPermissions :int
        {
            pAll=-1,pListClient=1, pAddClient=2,
            pDeleteClient=4,pUpdateClient=8,
            pFindClient=16, pTransaction=32, pManageUser=64, pLoginRegister=128, pCurrencyExchange=256,
        }
        public struct stLoginRegisterRecord
        {

           public  string SystemDateTime;
            public string UserName;
            public string Password;
            public int Permission;

        };
        internal clsUser(enMode mode, string firstname, string lastname, string email, string phone, string username, string password, int permissions)
            : base(firstname, lastname, email, phone)
        {
            _Mode = mode;
            UserName = username;
            Password = password;
            Permissions = permissions;
        }
        public bool MarkedForDeleted()
        {
            return _MarkedForDelete;
        }
        public bool IsEmpty()
        {
            return _Mode == enMode.EmptyMode;
        }
        public static clsUser Find(string UserName)
        {
            List<clsUser> lUsers = _LoadUsersDataFromFile();
            foreach (clsUser user in lUsers)
            {
                if(user.UserName == UserName)
                {
                    return user;
                }
            }

            return _GetEmptyUserObject();
        }
        public static clsUser Find(string UserName,string Password)
        {
            List<clsUser> lUsers = _LoadUsersDataFromFile();
            foreach (clsUser user in lUsers)
            {
                if (user.UserName==UserName&&user.Password==Password)
                {
                    return user;
                }
            }
            return _GetEmptyUserObject();
        }
        public enum enSaveResults { svFaildEmptyObject=0, svSucceeded=1, svFailedUserExists=2}
        public enSaveResults Save()
        {
            switch (_Mode)
            {
                case enMode.EmptyMode:
                    return enSaveResults.svFaildEmptyObject;

                case enMode.UpdateMode:
                    _Update();
                    return enSaveResults.svSucceeded;

                case enMode.AddNewMode:
                    if(IsUserExist(UserName))
                    {
                        return enSaveResults.svFailedUserExists;
                    }
                    _AddNew();
                    _Mode=enMode.UpdateMode;
                    return enSaveResults.svSucceeded;
                default:
                    return enSaveResults.svFaildEmptyObject;
            }
        }
        public static bool IsUserExist(string UaserName)
        {
            clsUser User=Find(UaserName);
            return (!User.IsEmpty());
        }
        public bool Delete()
        {
            List<clsUser> lUsers= _LoadUsersDataFromFile();
            for (int i = 0; i < lUsers.Count; i++)
            {
                if (lUsers[i].UserName == UserName)
                {
                    lUsers[i]._MarkedForDelete = true;
                    break;
                }
            }
            _SaveUsersDataToFile(lUsers);
            this._Mode=enMode.EmptyMode;
            return true;
        }
        public static clsUser GetAddNewUserObject(string UserName)
        {
            return new clsUser(enMode.AddNewMode, "", "", "", "", UserName, "", 0);
        }
        public static List<clsUser> GetUserList()
        {
            return _LoadUsersDataFromFile();
        }
        public bool CheckIsHasAccessPermission(enPermissions Permission)
        {
            if(this.Permissions==(int)enPermissions.pAll)
            {
                return true;
            }
            return (((int)this.Permissions & (int)Permission) == (int)Permission);
        }
        public void RegisterLogin()
        {
            string sDataLine = _PrepareLoginrecord();
            using (StreamWriter MyFile = new StreamWriter(pathloginregister, true))
            {
                MyFile.WriteLine(sDataLine);
            }
        }
        public static List<stLoginRegisterRecord> GetLoginRegisterList()
        {
            List<stLoginRegisterRecord> lLoginRegisterRecords = new List<stLoginRegisterRecord>();
            if (File.Exists("LoginRegister.txt"))
            {
                using (StreamReader MyFile = new StreamReader(pathloginregister))
                {
                    string Line;
                    while ((Line = MyFile.ReadLine()) != null)
                    {
                        lLoginRegisterRecords.Add(_ConvertLineToLoginRgisterRecord(Line));
                    }
                }
            }
            return lLoginRegisterRecords;
        }
        
    }
}
