using QuanLyLinq;
using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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


        public bool Login(string username, string password)
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                var tpQuery = ql.USP_GetLogin(username, password);
                DataTable result = LINQResultToDataTable(tpQuery);
                return result.Rows.Count > 0;


            }

        }
        public DataTable LINQResultToDataTable<T>(IEnumerable<T> Linqlist)
        {
            DataTable dt = new DataTable();
            PropertyInfo[] columns = null;

            if (Linqlist == null) return dt;

            foreach (T Record in Linqlist)
            {

                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                    (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
            }
        public AccountData GetAccount(string username)
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext()) {
               
                var query = (from Account in ql.Accounts
                             where Account.UserName == username
                             select Account);
                DataTable dataTable = LINQResultToDataTable(query) ;
                // DataProvider.Instance.ExecuteQuery("select * from account where Username= '" + username + "'");
                foreach (DataRow item in dataTable.Rows)
                {
                  return new AccountData(item);

                 }

                return null;
                
            }
        }
        public bool UpdateInfo(string username, string displayname, string password, string newpassword)
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                ql.UpdateAccount(username, displayname, password, newpassword);
                ql.SubmitChanges();
            }
            return true;
            //DataTable data = DataProvider.Instance.ExecuteQuery("exec UpdateAccount @username , @displayname , @password , @newPassword", new object[] { username, displayname, password, newpassword });
            //return data.Rows.Count > 0;
        }
        public bool CreateLogin(string username, string password, string type)
        {
            
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                ql.ThemDangNhap(username, password, Int32.Parse( type));
                
                ql.SubmitChanges();
            }
            return true;
        }
        public bool DeleteLogin(string username, string password, string type)
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                ql.USP_XoaDangNhap(username, password, Int32.Parse(type));
                ql.SubmitChanges();
            }
            return true;
        }
        public List<AccountData> GetListAccount()
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                List<AccountData> listaccount = new List<AccountData>();
                var query = (from Account in ql.Accounts
                            
                             select Account);
                DataTable dataTable = LINQResultToDataTable(query);
                // DataProvider.Instance.ExecuteQuery("select * from account where Username= '" + username + "'");
                foreach (DataRow item in dataTable.Rows)
                {
                    AccountData accountdata = new AccountData(item);
                    listaccount.Add(accountdata);

                }

                return listaccount;

            }
        }
        public List<AccountData> GetListAccountByType(string TYPE)
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                List<AccountData> listaccount = new List<AccountData>();
                var query = (from Account in ql.Accounts
                             where Account.Type== Int32.Parse(TYPE)
                             select Account);
                DataTable dataTable = LINQResultToDataTable(query);
                // DataProvider.Instance.ExecuteQuery("select * from account where Username= '" + username + "'");
                foreach (DataRow item in dataTable.Rows)
                {
                    AccountData accountdata = new AccountData(item);
                    listaccount.Add(accountdata);
                    

                }

                return listaccount;

            }
        }
    }
}
