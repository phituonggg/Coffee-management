using Entity_FrameWorkk.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWorkk.DAO
{
    public class BillInfoProvider
    {
        private static BillInfoProvider instance;

        public static BillInfoProvider Instance {
            get { if (instance == null) instance = new BillInfoProvider(); return instance; }
            private set { instance = value; }
        }
        private BillInfoProvider() { }
    
        public List<BillInfo> GetBillInfoDatas(int id) {
            return DataProvider.Ins.DB.BillInfoes.Where(bi => bi.id == id).ToList();
        }
        public void InsertBillInfo(int idBill,int idFood,int count)
        {
            DataProvider.Ins.DB.USP_InsertBillInfo(idBill, idFood, count);
            DataProvider.Ins.DB.SaveChanges();
        }
        public void DeleteBillInfro(int id)
        {
            DataProvider.Ins.DB.BillInfoes.Remove(DataProvider.Ins.DB.BillInfoes.Where(bi => bi.id == id).First());
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
