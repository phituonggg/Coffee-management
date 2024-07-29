using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DAO
{
    public class MenuProvider
    {
        private static MenuProvider instance;

        public static MenuProvider Instance {
            get { if (instance == null) instance = new MenuProvider(); return instance; }
            private set { instance = value; }
        }

        private MenuProvider() { }
        public List<MenuData> GetMenus(int id)
        {

            List<MenuData>  menuDatas = new List<MenuData>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from FN_GetMenu (  "+id+" )");
            foreach (DataRow item in data.Rows) {
                MenuData menu = new MenuData(item);
                menuDatas.Add(menu);
            }
            return menuDatas;
        }
    }
}
