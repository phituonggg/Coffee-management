using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public List<TableData> LoadTableList()
        {
            List<TableData> tableDatas = new List<TableData>();

            DataTable dataTable = DataProvider.Instance.ExecuteQuery("EXEC USP_GetTableList");
            foreach(DataRow item in dataTable.Rows)
            {
                TableData table=new TableData(item);
           
                tableDatas.Add(table);

            }
            return tableDatas;
        }
        public bool TableStatus()
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SELECT * from dbo.TableFood where status='In Using'");
            return result > 0;
        }
        public List<TableData> GetListTable()
        {
            List<TableData> listTable = new List<TableData>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * from TableFood ");
            foreach (DataRow row in data.Rows)
            {
                TableData tableData = new TableData(row);
                listTable.Add(tableData);
            }
            return listTable;
        }
        public bool InsertTable()
        {
            string query = string.Format("EXEC AddTable ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable() {
            string query = string.Format("EXEC DeleteTable ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
