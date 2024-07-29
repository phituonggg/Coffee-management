
using Entity_FrameWorkk.DAO;
using Entity_FrameWorkk.Entity;
using QuanLyQuanCaPhe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_FrameWorkk
{
    public partial class TableManager : Form
    {



        private USP_GetAccountByUserName_Result loginAccount;

        public USP_GetAccountByUserName_Result LoginAccount
        {
            get { return loginAccount; }
            set
            {
                loginAccount = value;
                Account(LoginAccount.Type);
            }
        }
        public TableManager(USP_GetAccountByUserName_Result loginaccount)
        {

            InitializeComponent();
            this.LoginAccount = loginaccount;
            LoadDataTable();
            LoadCatory();

        }
        #region Method
        void Account(int type)
        {
            try
            {

                if (type == 0)
                {
                    adminToolStripMenuItem.Enabled = true;

                    txtLoginUser.Text = "Admin";
                }
                else
                {
                    adminToolStripMenuItem.Enabled = false;

                    txtLoginUser.Text = "Staff";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
        void LoadCatory()
        {
            try
            {

                List<FoodCategory> categoryDatas = CategoryProvider.Instance.GetCategories();
                cbCategory.DataSource = categoryDatas;
                cbCategory.DisplayMember = "Name";
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
        void LoadFoodByCatory(int id)
        {
            try
            {

                List<Food> foodDatas = FoodProvider.Instance.GetFoods(id);
                cbFood.DataSource = foodDatas;
                cbFood.DisplayMember = "Name";
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
        void LoadDataTable()
        {
            try
            {

                flTable.Controls.Clear();
                List<USP_GetTableList_Result> tableList = TableProvider.Instance.LoadTableList();
                foreach (var item in tableList)
                {
                    Button btn = new Button() { Width = TableProvider.TableWidth, Height = TableProvider.TableHeight };
                    btn.Text = item.name + Environment.NewLine + item.status;
                    btn.Click += btn_Click;
                    btn.Tag = item;

                    switch (item.status)
                    {
                        case "Free":
                            btn.BackColor = Color.Yellow;
                            break;
                        default: btn.BackColor = Color.Red; break;
                    }
                    flTable.Controls.Add(btn);
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        void Show_Bill(int id)
        {
            try
            {

                listViewBill.Items.Clear();

                var listBill = MenuProvider.Instance.GetMenus(id);
                double? totalPrice = 0;
                foreach (var item in listBill)
                {
                    ListViewItem lvItem = new ListViewItem(item.namefood.ToString());
                    lvItem.SubItems.Add(item.countt.ToString());
                    lvItem.SubItems.Add(item.price.ToString());
                    lvItem.SubItems.Add(item.totalPricee.ToString());
                    listViewBill.Items.Add(lvItem);
                    totalPrice += item.totalPricee;
                }
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                txttotalPrice.Text = totalPrice?.ToString("C", cul);//doi text sang dang tien te viet nam
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {

                int tableID = ((sender as Button).Tag as TableFood).id;
                listViewBill.Tag = (sender as Button).Tag;
                Show_Bill(tableID);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void Themmonbtn_Click(object sender, EventArgs e)
        {
            try
            {

                TableFood table = listViewBill.Tag as TableFood;
                int idBill = BillProvider.Instance.GetUncheckBillById(table.id);
                int IdFood = (cbFood.SelectedItem as Food).id;
                int count = (int)nmFood.Value;
                if (idBill == -1)
                {
                    BillProvider.Instance.InsertBill(table.id);
                    BillInfoProvider.Instance.InsertBillInfo(BillProvider.Instance.GetMaxIdBill(), IdFood, count);

                }
                else
                {
                    BillInfoProvider.Instance.InsertBillInfo(idBill, IdFood, count);
                }
                Show_Bill(table.id);
                LoadDataTable();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountlInformation f = new AccountlInformation(LoginAccount);
            f.ShowDialog();

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.ShowDialog();

        }


        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null)
            {
                return;
            }
            FoodCategory selectedid = comboBox.SelectedItem as FoodCategory;
            id = selectedid.id;
            LoadFoodByCatory(id);
        }
        private void Thanhtoanbtn_Click(object sender, EventArgs e)
        {
            try
            {

                TableFood table = listViewBill.Tag as TableFood;
                int idBill = BillProvider.Instance.GetUncheckBillById(table.id);
                int discount = (int)nmDiscount.Value;
                double totalPrice = Convert.ToDouble(txttotalPrice.Text.Split(',')[0]);
                double finalPrice = totalPrice - (totalPrice / 100) * discount;
                if (idBill != -1)
                {
                    if (MessageBox.Show(string.Format("Do you want to pay {0} ?\n Price to pay: {1} ", table.name, finalPrice), "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillProvider.Instance.ChecKOut(idBill, discount, (float)finalPrice);
                        Show_Bill(table.id);
                        LoadDataTable();
                    }


                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }


        #endregion

        private void txtLoginUser_Click(object sender, EventArgs e)
        {

        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddingnewAccount f = new AddingnewAccount();
            f.ShowDialog();
        }
    }
}
