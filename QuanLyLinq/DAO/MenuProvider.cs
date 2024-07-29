using QuanLyLinq;
using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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
        public List<MenuData> GetMenus(int id)
        {

            List<MenuData>  menuDatas = new List<MenuData>();
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                
                var datalist = ql.USP_GetMenu(id);
                DataTable data=LINQResultToDataTable(datalist);
                foreach (DataRow item in data.Rows)
                {
                   MenuData menu = new MenuData(item);
                    menuDatas.Add(menu);
                }
                return menuDatas;
            }
        }
    }
}
