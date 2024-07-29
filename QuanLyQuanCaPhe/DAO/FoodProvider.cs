using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public List<FoodData> GetFoods(int id)
        {
            List<FoodData> foodDatas = new List<FoodData>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT *FROM Food where idCategory= "+id);
            foreach (DataRow row in data.Rows) {
                FoodData foodData = new FoodData(row);
                foodDatas.Add(foodData);
            }
            return foodDatas;
        }
        public List<FoodData> GetListFoods()
        {
            List<FoodData> listfood = new List<FoodData>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, name , idCategory , price FROM Food " );
            foreach (DataRow row in data.Rows)
            {
                FoodData foodData = new FoodData(row);
                listfood.Add(foodData);
            }
            return listfood;
        }
        public bool InsertFood(string name,int id,float price)
        {
            string query = string.Format("INSERT dbo.Food(name,idCategory,price) Values (N'{0}',{1},{2})",name,id,price);
            int result=DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateFood(string name, int idCate, float price,int id)
        {
            string query = string.Format("Update dbo.Food set name = '{0}' , idCategory={1} , price={2} where id={3}", name, idCate, price,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteFood(int id)
        {
            BillInfoProvider.Instance.DeleteBillInfro(id);
            int result = DataProvider.Instance.ExecuteNonQuery(string.Format("Delete dbo.Food where id={0}", id));
            return result > 0;
        }

    }
}
