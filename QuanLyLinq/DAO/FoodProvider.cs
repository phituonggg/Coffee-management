using QuanLyLinq;
using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DAO
{
    public class FoodProvider
    {


        private static FoodProvider instance;

        public static FoodProvider Instance
        {
            get { if (instance == null) instance = new FoodProvider(); return instance; }
            private set { instance = value; }
        }

        public FoodProvider() { }
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
        public List<FoodData> GetFoods(int id)
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                List<FoodData> foodDatas = new List<FoodData>();
                var foodlist = (from Food in ql.Foods
                            where Food.idCategory == id
                            select Food);
                DataTable dataTable = LINQResultToDataTable(foodlist);
                //DataTable data = DataProvider.Instance.ExecuteQuery("SELECT *FROM Food where idCategory= " + id);
                foreach (DataRow row in dataTable.Rows)
                {
                    FoodData foodData = new FoodData(row);
                    foodDatas.Add(foodData);
                }
                return foodDatas;
            }
        }
        public List<FoodData> GetListFoods()
        {
            List<FoodData> listfood = new List<FoodData>();
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                var foodlist = (from Food in ql.Foods
                                select Food);
                DataTable data = LINQResultToDataTable(foodlist);

                //DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, name , idCategory , price FROM Food " );
                foreach (DataRow row in data.Rows)
                {
                    FoodData foodData = new FoodData(row);
                    listfood.Add(foodData);
                }
                return listfood;
            }
        }
        public bool InsertFood(string name,int id,float price)
        {
            //string query = string.Format("INSERT dbo.Food(name,idCategory,price) Values (N'{0}',{1},{2})",name,id,price);
            //int result=DataProvider.Instance.ExecuteNonQuery(query);
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                Food food = new Food();
                food.name = name;
                food.idCategory = id;
                food.price = price;
                ql.Foods.InsertOnSubmit(food);
                ql.SubmitChanges();
            }
            return true;
        }
        public bool UpdateFood(string name, int idCate, float price,int id)
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext()) {
                Food update = ql.Foods.Where(p=> p.id.Equals(id)).SingleOrDefault();
                update.name = name;
                update.idCategory=idCate;
                update.price = price;
                ql.SubmitChanges();
                //string query = string.Format("Update dbo.Food set name = '{0}' , idCategory={1} , price={2} where id={3}", name, idCate, price,id);
                //int result = DataProvider.Instance.ExecuteNonQuery(query);
            }
            return true;
        }
        public bool DeleteFood(int id)
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                Food delete = ql.Foods.Where((p) => p.id.Equals( id)).SingleOrDefault();
                ql.Foods.DeleteOnSubmit(delete);
                ql.SubmitChanges();

                //BillInfoProvider.Instance.DeleteBillInfro(id);
                //int result = DataProvider.Instance.ExecuteNonQuery(string.Format("Delete dbo.Food where id={0}", id));
            }
            return true;
        }

    }
}
