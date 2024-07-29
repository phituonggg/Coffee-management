using Entity_FrameWorkk.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWorkk.DAO
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
        public List<Food> GetFoods(int id)
        {
            return DataProvider.Ins.DB.Foods.Where(gf => gf.idCategory == id).ToList();
        }
        public List<Food> GetListFoods()
        {
            return DataProvider.Ins.DB.Foods.ToList();
        }
        public bool InsertFood(string name, int id, float price)
        {
            try
            {
                Food food = new Food();
                food.price = price;
                food.name = name;
                food.idCategory = id;
                DataProvider.Ins.DB.Foods.Add(food);
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateFood(string name, int idCate, float price, int id)
        {
            try
            {
                var temp = DataProvider.Ins.DB.Foods.Where(f => f.id == id).First();
                temp.price = price;
                temp.idCategory = idCate;
                temp.name = name;
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteFood(int id)
        {
            try
            {

                BillInfoProvider.Instance.DeleteBillInfro(id);
                DataProvider.Ins.DB.Foods.Remove(DataProvider.Ins.DB.Foods.Where(f => f.id == id).First());
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch { return false; }
        }

    }
}
