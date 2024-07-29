using Entity_FrameWorkk.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWorkk.DAO
{
    public class BillProvider
    {
        private static BillProvider instance;

        public static BillProvider Instance
        {
            get { if (instance == null) instance = new BillProvider(); return instance; }
            private set { instance = value; }
        }

        private BillProvider() { }

        public int GetUncheckBillById(int id) {
            
            List<USP_GetUnCheckTable_Result> data = DataProvider.Ins.DB.USP_GetUnCheckTable(id).ToList();
            if(data.Count > 0 )
            {
                return data[0].id;//co du lieu
            }
            return -1;//khong co du lieu
        }
        public void InsertBill(int id)
        {
            DataProvider.Ins.DB.USP_InsertBill(id);
            DataProvider.Ins.DB.SaveChanges();
        }
        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Ins.DB.Bills.Max(v => v.id);
            }
            catch
            {
                return 1;
            }
            
        }
        public List<FN_GetListIncomeByDate_Result> GetListBill(DateTime checkin,DateTime checkout)
        {
            return DataProvider.Ins.DB.FN_GetListIncomeByDate(checkin, checkout).ToList();
        }
        public void ChecKOut(int id,int discount,float totalPrice)
        {
            var temp = DataProvider.Ins.DB.Bills.Where(b => b.id == id).First();
            temp.DateCheckOut = new DateTime();
            temp.status = 1;
            temp.Discount = discount;
            temp.totalPrice = totalPrice;
            DataProvider.Ins.DB.SaveChanges();

        }
    }
}
