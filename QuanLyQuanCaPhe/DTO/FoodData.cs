﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DTO
{
    public class FoodData
    {
        public FoodData(int id,string name,int idCategory,float price)
        {
            this.Id= id;
            this.Name= name;
            this.IdCategory= idCategory;
            this.Price= price;
        }
        public FoodData(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString() ;
            this.IdCategory = (int)row["idCategory"] ;
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        private int id;
        private string name;
        private int idCategory;
        private float price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public float Price { get => price; set => price = value; }
    }
}
