using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCaPhe.DAO
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
            string query = " exec USP_GetLogin  @UserName , @Password";
            DataTable result=DataProvider.Instance.ExecuteQuery(query,new object[] {username,password});
            return result.Rows.Count>0;
        }
        public AccountData GetAccount(string username) {
            DataTable data=DataProvider.Instance.ExecuteQuery("exec USP_GetAccountByUserName  " + username);
            foreach(DataRow item in data.Rows)
            {
                return new AccountData(item);
            }
            return null;
        }
        public bool UpdateInfo(string username,string displayname ,string password,string newpassword) {
            DataTable data=DataProvider.Instance.ExecuteQuery("exec UpdateAccount @username , @displayname , @password , @newPassword", new object[]{username,displayname,password,newpassword });
            return data.Rows.Count>0;   
        }
        public bool CreateLogon(string username,string password,string type) {
            string query = " exec ThemDangNhap  @UserName , @Password , @Type";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password,type });
            return result.Rows.Count > 0;
        }
        public List<AccountData> GetListAccount()
        {
            List<AccountData> listaccount = new List<AccountData>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select* from ListAccount ");
            foreach (DataRow row in data.Rows)
            {
                AccountData accountdata = new AccountData(row);
                listaccount.Add(accountdata);
            }
            return listaccount;
        }
        public List<AccountData> GetListAccountByType(string TYPE)
        {
            List<AccountData> listaccount = new List<AccountData>();
            string query = string.Format("select * from FN_ListAccount ({0})", TYPE);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AccountData accountdata = new AccountData(row);
                listaccount.Add(accountdata);
            }
            return listaccount;
        }
        public bool DeleteLogin(string username, string password,string type) { 
            string query = " exec USP_XoaDangNhap  @UserName , @Password , @Type";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password, type });
            return result.Rows.Count > 0;
        }
}
}
