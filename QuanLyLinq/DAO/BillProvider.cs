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
    public class BillProvider
    {
        private static BillProvider instance;

        public static BillProvider Instance {
            get { if (instance == null) instance = new BillProvider(); return instance; }
            private set { instance = value; }
        }
        private BillProvider() { }
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
        public int GetUncheckBillById(int id) {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext()) {
                var data = ql.USP_GetUnCheckTable(id);
                DataTable dataTable=LINQResultToDataTable(data);
                //DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill Where idTable = " + id + "AND status =0");
                if (dataTable.Rows.Count > 0)
                {
                    BillData billData = new BillData(dataTable.Rows[0]);
                    return billData.ID;//co du lieu
                }
                return -1;//khong co du lieu
            }
        }
        public void InsertBill(int id)
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                ql.USP_InsertBill(id);
                ql.SubmitChanges();

            }
            //DataProvider.Instance.ExecuteNonQuery("exec  USP_InsertBill @idTable", new object[] { id });
        }    
        public int GetMaxIdBill()
        {

            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                try
                {

                    return (int)ql.Bills.Max(p => p.id);
                    //return (int)DataProvider.Instance.ExucuteScalar("SELECT MAX (id) FROM dbo.Bill");
                }
                catch
                {
                    return 1;
                }
            }
            
        }
        public DataTable GetListBill(DateTime checkin,DateTime checkout)
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                return LINQResultToDataTable( ql.GetListByDate(checkin, checkout)); 
                //DataProvider.Instance.ExecuteQuery("exec GetListByDate @datein , @dateout", new object[] { checkin, checkout });
            }
        }
        public void ChecKOut(int id,int discount,float totalPrice)
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                Bill update = ql.Bills.Where(p => p.id.Equals(id)).SingleOrDefault();
                update.totalPrice = totalPrice;
                update.Discount = discount;
                update.DateCheckOut = DateTime.Now;
                update.status = 1;
                ql.SubmitChanges();

            }
                //string query = "UPDATE dbo.Bill set DateCheckOut=GETDATE() , status =1 , discount=" +discount+ " , totalPrice = "+totalPrice+" where id="+id;
                // DataProvider.Instance.ExecuteNonQuery(query);

            }
    }
}
