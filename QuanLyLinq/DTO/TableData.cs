﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DTO
{
     public class TableData
    {
        public TableData(int id,string name,string status)
        {
            this.ID= id;
            this.Name= name;
            this.Status= status;

        }
        public TableData(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = (string)row["name"].ToString();
            this.Status = (string) row["status"].ToString();
        }
       
       
       

        private int iD;
        public int ID { get { return iD; } set { iD = value; } }
        private string name;
       
        public string Name { get { return name; } set { name = value; } }
        private string status;
        public string Status { get { return status; } set { status = value; } }
        
    }
}
