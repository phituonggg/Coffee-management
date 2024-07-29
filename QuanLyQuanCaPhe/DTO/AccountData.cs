using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DTO
{
    public class AccountData
    {

        public AccountData(string username,string displayname,string password,int type)
        {
            this.Username = username;
            this.Displayname = displayname;
            this.Password = password;   
            this.Type = type;
        }
        public AccountData(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.Displayname = row["Displayname"].ToString();
            this.Password = row["Password"].ToString();
            this.Type = (int)row["Type"];
        }
        private int type;
        private string password;
        private string displayname;
        private string username;

        public string Username { get => username; set => username = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
    }
}
