﻿using Entity_FrameWorkk.DAO;
using Entity_FrameWorkk.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_FrameWorkk
{
    public partial class Admin : Form
    {
        BindingSource sourceFood=new BindingSource();
        BindingSource sourceTable = new BindingSource();
        public Admin()
        {
            InitializeComponent();
            LoadData();
            
        }
        void LoadData()
        {
            dgvFood.DataSource = sourceFood;
            dgvTable.DataSource = sourceTable;
            LoadDate();
            LoadListFood();
            AddFood();
            LoadCategory(cbFoodCate);
            LoadListTable();
            AddTable();
            LoadidTable(cbTableStatus);
        }
        //Load Food List tab
        void AddFood()
        {
            txtFoodName.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Name"));//tu textbox thay doi gia tri text bang voi gia tri Name cua Datasource
            txtid.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "id"));
            nmFoodPrice.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Price"));
        }
        void LoadCategory(ComboBox categoryComboBox)
        {
            List<FoodCategory> categoryDatas = CategoryProvider.Instance.GetCategories();
            categoryComboBox.DataSource = categoryDatas;
            categoryComboBox.DisplayMember = "Name";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int idFood = Convert.ToInt32(txtid.Text);
            if (TableProvider.Instance.TableStatus())
            {
                MessageBox.Show("All table need to payed ,so you can remove Food");
            }
            else
            {
                if(FoodProvider.Instance.DeleteFood(idFood))
                {
                    MessageBox.Show("Food has been deleted");
                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Food has been deleted fail");
                }
            }
        }
        void LoadListFood()
        {
            sourceFood.DataSource=FoodProvider.Instance.GetListFoods();
            
        }
        void LoadListBill(DateTime datein,DateTime dateout)
        {
            
            dgvThongKe.DataSource= BillProvider.Instance.GetListBill(datein, dateout);
        }
        void LoadDate()
        {
            DateTime date = DateTime.Now;
            dtIn.Value = new DateTime(date.Year, date.Month, 1);
            dtOut.Value=dtIn.Value.AddMonths(1).AddDays(-1);
            dateTimeIn.Value = new DateTime(date.Year, date.Month, 1);
            dateTimeOut.Value = dtIn.Value.AddMonths(1).AddDays(-1);
        }

        //Load Table list tab

        void LoadListTable()
        {
            sourceTable.DataSource=TableProvider.Instance.GetListTable();   
        }
        void AddTable()
        {
            txtTableName.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "Name"));//tu textbox thay doi gia tri text bang voi gia tri Name cua Datasource
            txtTableid.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "id"));
            
        }
        void LoadidTable(ComboBox categoryComboBox)
        {
            List<TableFood> categoryDatas = TableProvider.Instance.GetListTable();
            categoryComboBox.DataSource = categoryDatas;
            categoryComboBox.DisplayMember = "status";
        }


        #region Method
        #endregion


        #region Events
        #endregion
        //Event Food
        private void ThongKeviewbtn_Click(object sender, EventArgs e)
        {
            LoadListBill(dtIn.Value, dtOut.Value);
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvFood.CurrentCell.RowIndex;
            int index = (int)dgvFood.Rows[r].Cells[2].Value;
           
            cbFoodCate.SelectedIndex = index-1;
            
        }

        private void WatchFoodbtn_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void AddFoodbtn_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text;
            int idCategory = cbFoodCate.SelectedItem != null ? (cbFoodCate.SelectedItem as FoodCategory).id : 1;
            float price=(float)nmFoodPrice.Value;
            if(FoodProvider.Instance.InsertFood(name, idCategory, price))
            {
                MessageBox.Show("Add Food Successfully");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Add Food Fail");
            }

            
        }

        private void EditFoodbtn_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text;
            int idCategory = (cbFoodCate.SelectedItem as FoodCategory).id;
            float price = (float)nmFoodPrice.Value;
            int id=Convert.ToInt32(txtid.Text);
            if (FoodProvider.Instance.UpdateFood(name, idCategory, price,id))
            {
                MessageBox.Show("Update Food Successfully");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Update Food fail");
            }
        }


        //Event Button
        private void btnTableWatch_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTable.CurrentCell.RowIndex;
            string index = (string)dgvTable.Rows[r].Cells[2].Value;

            cbTableStatus.SelectedItem = index;
        }

        private void btnTableAdd_Click(object sender, EventArgs e)
        {
            
            if (TableProvider.Instance.InsertTable())
            {
                MessageBox.Show("Add Table Successfully");
                LoadListTable();
            }
            else
            {
                MessageBox.Show("Add Table Fail");
            }
        }

        private void btnTableRemove_Click(object sender, EventArgs e)
        {
            if (TableProvider.Instance.TableStatus())
            {
                MessageBox.Show("All table need to payed ,so you can remove Table");
            }
            else
            {
                if (TableProvider.Instance.DeleteTable())
                {
                    MessageBox.Show("Table has been deleted");
                    LoadListTable();
                }
                else
                {
                    MessageBox.Show("Table has been deleted fail");
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //this.getListByDateTableAdapter1.Fill(this.quanLyQuanCafe1DataSet1.GetListByDate, dateTimeIn.Value, dateTimeOut.Value);
            //this.reportViewer1.RefreshReport();
        }

        private void btnShowIncome_Click(object sender, EventArgs e)
        {
            //this.getListByDateTableAdapter1.Fill(this.quanLyQuanCafe1DataSet1.GetListByDate, dateTimeIn.Value, dateTimeOut.Value);
            //this.reportViewer1.RefreshReport();
        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
