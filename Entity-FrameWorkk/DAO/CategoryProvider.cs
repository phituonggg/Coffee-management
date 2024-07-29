using Entity_FrameWorkk.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWorkk.DAO
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

        public List<FoodCategory> GetCategories()
        {
            return DataProvider.Ins.DB.FoodCategories.ToList();
        }
        public List<FoodCategory> GetCategoriebyId(int id) {

            return DataProvider.Ins.DB.FoodCategories.Where(fc => fc.id == id).ToList();
        }
    }
    
}
