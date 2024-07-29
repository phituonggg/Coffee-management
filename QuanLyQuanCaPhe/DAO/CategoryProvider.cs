using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DAO
{
    public class CategoryProvider
    {
        private static CategoryProvider instance;

        public static CategoryProvider Instance
        {
            get { if (instance == null) instance = new CategoryProvider(); return instance; }
            private set { instance = value; }
        }

        public CategoryProvider() { }

        public List<CategoryData> GetCategories()
        {
            List<CategoryData> categoryDatas = new List<CategoryData>();
            string query="SELECT * FROM FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                CategoryData category=new CategoryData(row);
                categoryDatas.Add(category);
            }
            return categoryDatas;
        }
        public List<CategoryData> GetCategoriebyId(int id) {

            List<CategoryData> categoryDatas = new List<CategoryData>();
            string query = "SELECT name FROM FoodCategory where id= "+id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                CategoryData category = new CategoryData(row);
                categoryDatas.Add(category);
            }
            return categoryDatas;
        }
    }
    
}
