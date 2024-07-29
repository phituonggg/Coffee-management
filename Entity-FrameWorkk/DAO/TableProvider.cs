using Entity_FrameWorkk.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWorkk.DAO
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
        public List<USP_GetTableList_Result> LoadTableList()
        {
            return DataProvider.Ins.DB.USP_GetTableList().ToList();
        }
        public bool TableStatus()
        {
            var result = DataProvider.Ins.DB.TableFoods.Where(tf => tf.status == "In Using").ToList();
            return result.Count > 0;
        }
        public List<TableFood> GetListTable()
        {
            return DataProvider.Ins.DB.TableFoods.ToList();
        }
        public bool InsertTable()
        {
            int result = DataProvider.Ins.DB.AddTable();
            return result > 0;
        }
        public bool DeleteTable() {
            int result = DataProvider.Ins.DB.DeleteTable();
            return result > 0;
        }

    }
}
