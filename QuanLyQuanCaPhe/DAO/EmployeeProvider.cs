using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DAO
{
    internal class EmployeeProvider
    {
        private static EmployeeProvider instance;

        public static EmployeeProvider Instance {
            get { if (instance == null) instance = new EmployeeProvider(); return instance; }
            private set { instance = value; }
        }
        private EmployeeProvider() { }
        public List<EmployeeData> GetListEmployee()
        {
            List<EmployeeData> listemployee = new List<EmployeeData>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Employee ");
            foreach (DataRow row in data.Rows)
            {
                EmployeeData employeeData = new EmployeeData(row);
                listemployee.Add(employeeData);
            }
            return listemployee;
        }
        public bool DeleteEmploy(string id)
        {
            string query = string.Format("EXEC DeleteEmploy "+id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool AddEmploy(string name,string birth)
        {
            string query = string.Format("EXEC USP_ThemNhanVien1 N'" + name +"' , '"+birth+"'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ActiveEmployee(string id) {
            string query = string.Format("EXEC  USP_EmployeeWorking " + id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable ShowActiveEmployee()
        {
            return DataProvider.Instance.ExecuteQuery("Select * from View_EmployeeActiv");
        } 
        public bool EndShift(string time)
        {
            string query = string.Format("EXEC  USP_CaculateWorkingTime " + time);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Salary(string id)
        {
            string query = string.Format("EXEC  USP_ThanhToanLuong " + id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
