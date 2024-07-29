using Entity_FrameWorkk.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWorkk.DAO
{
    public class MenuProvider
    {
        private static MenuProvider instance;

        public static MenuProvider Instance {
            get { if (instance == null) instance = new MenuProvider(); return instance; }
            private set { instance = value; }
        }

        private MenuProvider() { }
        public List<FN_GetMenu_Result> GetMenus(int id)
        {

            return DataProvider.Ins.DB.FN_GetMenu(id).ToList();
        }
    }
}
