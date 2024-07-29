using Entity_FrameWorkk.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Entity_FrameWorkk.DAO
{
    public class AccountProvider
    {
        private static AccountProvider instance;

        public static AccountProvider Instance
        {
            get { if (instance == null) instance = new AccountProvider(); return instance; }
            private set { instance = value; }
        }

        private AccountProvider() { }

        public bool Login(string username, string password) {
            var result=DataProvider.Ins.DB.USP_GetLogin(username, password).ToList();
            return result.Count>0;
        }
        public USP_GetAccountByUserName_Result GetAccount(string username) {
            var data = DataProvider.Ins.DB.USP_GetAccountByUserName(username).ToList();
            foreach(var item in data)
            {
                return item;
            }
            return null;
        }
        public bool UpdateInfo(string username,string displayname ,string password,string newpassword) {
            var data = DataProvider.Ins.DB.UpdateAccount(username, displayname, password, newpassword).ToList();
            return data.Count>0;   
        }
        public bool CreateLogon(string username,string password,string type) {
            var result = DataProvider.Ins.DB.ThemDangNhap(username, password,Convert.ToInt32(type));
            return result > 0;
        }
        public List<Account> GetListAccount()
        {
            return DataProvider.Ins.DB.Accounts.ToList();
        }
        public List<FN_ListAccount_Result> GetListAccountByType(string TYPE)
        {
            return DataProvider.Ins.DB.FN_ListAccount(Convert.ToInt32(TYPE)).ToList();
        }
        public bool DeleteLogin(string username, string password,string type) { 
            var result = DataProvider.Ins.DB.USP_XoaDangNhap(username, password, Convert.ToInt32(type));
            return result > 0;
        }
}
}
