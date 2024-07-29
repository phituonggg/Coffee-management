using QuanLyLinq;
using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DAO
{
    public class TableProvider
    {
        private static TableProvider instance;
        public static TableProvider Instance
        {
            get { if (instance == null) instance = new TableProvider(); return instance; }
            private set { instance = value; }
        }
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        private TableProvider() { }
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
        public List<TableData> LoadTableList()
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                List<TableData> tableDatas = new List<TableData>();
                var tablelist = ql.USP_GetTableList();
                DataTable dataTable = LINQResultToDataTable(tablelist);
                //DataTable dataTable =( DataTable)ql.USP_GetTableList();
                foreach (DataRow item in dataTable.Rows)
                {
                    TableData table = new TableData(item);

                    tableDatas.Add(table);

                }
                return tableDatas;
            }
        }
        public bool TableStatus()
        {
            
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext()) {
                var result = from TableFood in ql.TableFoods 
                             where TableFood.status =="'In Using'"
                             select TableFood;
                //SELECT * from dbo.TaleFood where status = 'In Using';
                if (result != null)
                {
                    return false;
                }
                return true;
            }
        }
        public List<TableData> GetListTable()
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                List<TableData> listTable = new List<TableData>();
                var tableList= (from TableFood in ql.TableFoods
                                 select TableFood);
                DataTable data = LINQResultToDataTable(tableList);
                //                 select TableFood;
                //    //"SELECT * from TableFood ");
                foreach (DataRow row in data.Rows)
                {
                  TableData tableData = new TableData(row);
                    listTable.Add(tableData);
                }
                return listTable;
            }
        }
        public bool InsertTable()
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                //string query = string.Format("EXEC AddTable ");
                var tableadd = ql.AddTable();
                
                return true;
            }
        }
        public bool DeleteTable() {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext()) {
                // string query = string.Format("EXEC DeleteTable ");
                var result = ql.DeleteTable();
                return true;
            }
        }
    }
}
