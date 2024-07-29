using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.CompilerServices;

namespace QuanLyQuanCaPhe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public string username;
        public string password;

        public string ConnectionSTR;



         //ConnectionSTR="Data Source=DESKTOP-MH4FSR8;Initial Catalog=QuanLyQuanCafe1;Integrated Security=false;User ID =staff;Password =staff " ;
        public static DataProvider Instance {
            get {if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

     

        private DataProvider() { }
        public  bool TestCon(string username, string password)
        {
             ConnectionSTR = "Data Source=LAPTOP-BEKQV95A\\MSSQLSERVER02;Initial Catalog=QuanLyQuanCafe1;Integrated Security=false;User ID =" + username + ";Password = " + password;
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionSTR))
            {
                try
                {
                    sqlConnection.Open();
                    
                    return true;
               }
               catch (SqlException)
               {
                  return false;
                }
            }
           
        }
        public DataTable ExecuteQuery(string query, object[] parameter=null)//tra ra ket qua
        {
            DataTable data = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionSTR))
            {//giai phong du lieu

                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                if(parameter != null)
                {
                    string[] listPara=query.Split(' ');
                    int i = 0;
                    foreach( string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)//tra ve so dong duoc thuc thi
        {
            int data = 0;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionSTR))
            {//giai phong du lieu

                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return data;
        }
        public object ExucuteScalar (string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionSTR))
            {//giai phong du lieu

                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                sqlConnection.Close();
            }
            return data;
        }//tra ve count *
    }
}
