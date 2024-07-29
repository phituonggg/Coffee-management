using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DTO
{
    public class CategoryData
    {
        public CategoryData(int id,string name)
        {
            this.Id=id;
            this.Name=name; 

        }
        public CategoryData(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name= (string)row["name"];
        }
        private int id;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        private string name;
    }
}
