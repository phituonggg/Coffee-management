using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public int GetUncheckBillById(int id) {
            
            DataTable data= DataProvider.Instance.ExecuteQuery("exec USP_GetUnCheckTable   "+id);
            if(data.Rows.Count > 0 )
            {
                BillData billData = new BillData(data.Rows[0]);
                return billData.ID;//co du lieu
            }
            return -1;//khong co du lieu
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec  USP_InsertBill @idTable", new object[] { id });
        }
        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExucuteScalar("SELECT MAX (id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
            
        }
        public DataTable GetListBill(DateTime checkin,DateTime checkout)
        {
            return DataProvider.Instance.ExecuteQuery("select * from FN_GetListIncomeByDate ( @datein , @dateout )", new object[] { checkin, checkout });
        }
        public void ChecKOut(int id,int discount,float totalPrice)
        {
            string query = "UPDATE dbo.Bill set DateCheckOut=GETDATE() , status =1 , discount=" +discount+ " , totalPrice = "+totalPrice+" where id="+id;
            DataProvider.Instance.ExecuteNonQuery(query);

        }
    }
}
