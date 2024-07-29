using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DTO
{
    public class EmployeeData
    {
        public EmployeeData(int id,string name,DateTime? birth,float workingHour,string status) {
            this.Id = id;
            this.Name = name;
            this.Birth = birth;
            this.WorkingHour = workingHour;
            this.Status = status;
        }
        public EmployeeData(DataRow row)
        {
            this.Id = (int)row["idEmployee"];
            this.Name = (string)row["nameEmpployee"].ToString();
            var Tempt = row["birthEmployye"];
            if (Tempt.ToString() != "")
            {
                this.Birth = (DateTime?)Tempt;
            }
            
            this.WorkingHour = (float)Convert.ToDouble(row["workingEmployye"].ToString());
            this.Status = (string)row["statusEmployye"].ToString();
        }
        private int id;
        private string name;
        private DateTime? birth ;
        private float workingHour;
        private string status;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        
        public float WorkingHour { get => workingHour; set => workingHour = value; }
        public string Status { get => status; set => status = value; }
        public DateTime? Birth { get => birth; set => birth = value; }
    }
}
