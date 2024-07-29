using Entity_FrameWorkk;
using Entity_FrameWorkk.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWorkk.DAO
{
    internal class EmployeeProvider
    {
        private static EmployeeProvider instance;

        public static EmployeeProvider Instance
        {
            get { if (instance == null) instance = new EmployeeProvider(); return instance; }
            private set { instance = value; }
        }

        private EmployeeProvider() { }
        public List<Employee> GetListEmployee()
        {
            return DataProvider.Ins.DB.Employees.ToList();
        }
        public bool DeleteEmploy(int id)
        {
            try
            {
                DataProvider.Ins.DB.Employees.Remove(DataProvider.Ins.DB.Employees.Where(e => e.idEmployee == id).First());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddEmploy(string name, string birth)
        {
            int result = DataProvider.Ins.DB.USP_ThemNhanVien1(name, Convert.ToDateTime(birth));
            DataProvider.Ins.DB.SaveChanges();
            return result > 0;
        }
        public bool ActiveEmployee(int id)
        {
            int result = DataProvider.Ins.DB.USP_EmployeeWorking(id);
            return result > 0;
        }
        public List<View_EmployeeActiv> ShowActiveEmployee()
        {
            return DataProvider.Ins.DB.View_EmployeeActiv.ToList();
        }
        public bool EndShift(string time)
        {
            int result = DataProvider.Ins.DB.USP_CaculateWorkingTime(Convert.ToDouble(time));
            return result > 0;
        }
        public bool Salary(int id)
        {
            int result = DataProvider.Ins.DB.USP_ThanhToanLuong(id);
            return result > 0;
        }
    }
}
