using QuanLyLinq;
using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DAO
{
    public class BillInfoProvider
    {
        private static BillInfoProvider instance;

        public static BillInfoProvider Instance {
            get { if (instance == null) instance = new BillInfoProvider(); return instance; }
            private set { instance = value; }
        }
        private BillInfoProvider() { }
    
        public List<BillInfoData> GetBillInfoDatas(int id) {
            List<BillInfoData> billInfoDatas = new List<BillInfoData>();
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext()) {
                billInfoDatas = (List<BillInfoData>)(from BillInfo in ql.BillInfos
                                where BillInfo.id == id
                                select BillInfo);

            //DataTable dt = DataProvider.Instance.ExecuteQuery("Select *From dbo.BillInfo where id= " +id);
            //foreach(DataRow item in  dt.Rows)
            //{
            //    BillInfoData info = new BillInfoData(item);
            //    billInfoDatas.Add(info);


                                //}
                return billInfoDatas;
            }
        }
        public void InsertBillInfo(int idBill,int idFood,int count)
        {
            using(QuanLyQuanCaPhe1DataContext ql= new QuanLyQuanCaPhe1DataContext())
            {
               ql.USP_InsertBillInfo(idBill,idFood,count);

            }
           // DataProvider.Instance.ExecuteNonQuery("exec  USP_InsertBillInfo @idBill , @idFood , @count ", new object[] { idBill,idFood,count });
        }
        public void DeleteBillInfro(int id)
        {
            using (QuanLyQuanCaPhe1DataContext ql = new QuanLyQuanCaPhe1DataContext())
            {
                BillInfo delete = ql.BillInfos.Where(p => p.idFood.Equals(id)).SingleOrDefault();
                ql.BillInfos.DeleteOnSubmit(delete);
                ql.SubmitChanges();
            }
            //DataProvider.Instance.ExecuteQuery("Delete dbo.BillInfo where idFood= " + id);
        }
    }
}
