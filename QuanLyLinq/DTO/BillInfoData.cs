using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DTO
{
    public class BillInfoData
    {

        public BillInfoData(int id,int idBill, int idFood, int count) {
            this.ID = id;
            this.BillId = idBill;
            this.FoodId = idFood;
            this.Count = count;
        
        }
        public BillInfoData(DataRow row) {//lay du lieu theo ten cot
            this.ID = (int)row["id"];
            this.BillId = (int)row["idBill"];
            this.FoodId = (int)row["idFood"];
            this.Count = (int)row["count"];
        }

       

        private int iD;
        public int ID { get { return iD; } set { iD = value; } }



        private int billId;
        public int BillId { get { return billId; } set { billId = value; } }



        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private int foodId;
        public int FoodId { get { return foodId; } set { foodId = value; } }
    }

       
}
