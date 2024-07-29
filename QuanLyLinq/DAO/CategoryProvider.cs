using QuanLyLinq;
using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Reflection;
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
        public List<CategoryData> GetCategories()
        {
            List<CategoryData> categoryDatas = new List<CategoryData>();
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext()) {

                var catelist = (from FoodCategory in ql.FoodCategories
                                select FoodCategory);
                DataTable dataTable = LINQResultToDataTable(catelist);



            
            //string query="SELECT * FROM FoodCategory";
            //DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in dataTable.Rows)
                {
                    CategoryData category = new CategoryData(row);
                    categoryDatas.Add(category);
                }
                return categoryDatas;
            }
        }
        public List<CategoryData> GetCategoriebyId(int id) {

            List<CategoryData> categoryDatas = new List<CategoryData>();
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                var catelist = (from Food in ql.Foods
                                where Food.id == id
                                select Food.name);
                DataTable dataTable = LINQResultToDataTable(catelist);

                //string query = "SELECT name FROM FoodCategory where id= "+id;
                //DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in dataTable.Rows)
                {
                    CategoryData category = new CategoryData(row);
                   categoryDatas.Add(category);
                }
                return categoryDatas;
            }
        }
    }
    
}
