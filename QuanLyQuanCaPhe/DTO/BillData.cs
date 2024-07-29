using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DTO
{
    public class BillData
    {
        public BillData(int id, DateTime? dateCheckIn, DateTime? dateCheckOut,int idTable, int status, int discount=0)
        {
            this.ID = id;
            this.DataCheckIn = dateCheckIn;
            this.DataCheckOut = dateCheckOut;
            this.IdTable = idTable;
            this.Status = status;
            this.Discount = discount;
        }
        public BillData(DataRow row) {
            this.ID = (int)row["id"];
            this.DataCheckIn = (DateTime?)row["dateCheckIn"] ;
            var Tempt = row["dateCheckOut"];
            if( Tempt.ToString() != "")
            {
                this.DataCheckOut = (DateTime?)Tempt;
            }
            this.IdTable = (int)row["idTable"];
            this.Status = (int)row["status"];

            this.Discount = (int)row["Discount"];
        }
        private DateTime? dateCheckIn;
        public DateTime? DataCheckIn
        { get { return dateCheckIn; } set { dateCheckIn = value; } }



        private DateTime? dateCheckOut;
        public DateTime? DataCheckOut
        { get { return dateCheckOut; } set { dateCheckOut = value; } }

        private int iD;
        public int ID { get { return iD; } set { iD = value; } }
        private int idTable;

        private int status;
        public int Status { get { return status; } set { status = value; } }

        public int IdTable { get => idTable; set => idTable = value; }
        public int Discount { get => discount; set => discount = value; }

        private int discount;
    }
}
