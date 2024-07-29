
using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.DTO;
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

namespace QuanLyQuanCaPhe
{
    public partial class TableManager : Form
    {



        private AccountData loginAccount;

        public AccountData LoginAccount
        {
            get { return loginAccount; }
            set
            {
                loginAccount = value;
                Account(LoginAccount.Type);
            }
        }
        public TableManager(AccountData loginaccount)
        {

            InitializeComponent();
            this.LoginAccount = loginaccount;
            LoadDataTable();
            LoadCatory();
            
        }
        #region Method
        void Account(int type)
        {
            if (type == 0)
            {
                adminToolStripMenuItem.Enabled = true;
                
                txtLoginUser.Text = "Admin";
            }
            else
            {
                adminToolStripMenuItem.Enabled=false;
                
                txtLoginUser.Text = "Staff";
            }

        }
        void LoadCatory()
        {
            List<CategoryData> categoryDatas = CategoryProvider.Instance.GetCategories();
            cbCategory.DataSource = categoryDatas;
            cbCategory.DisplayMember = "Name";

        }
        void LoadFoodByCatory(int id)
        {
            List<FoodData> foodDatas = FoodProvider.Instance.GetFoods(id);
            cbFood.DataSource = foodDatas;
            cbFood.DisplayMember = "Name";

        }
        void LoadDataTable()
        {
            flTable.Controls.Clear();
            List<TableData> tableList = TableProvider.Instance.LoadTableList();
            foreach (TableData item in tableList)
            {
                Button btn = new Button() { Width = TableProvider.TableWidth, Height = TableProvider.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status  ;
                btn.Click += btn_Click;
                btn.Tag = item;
                
                switch (item.Status)
                {
                    case "Free":
                        btn.BackColor = Color.Yellow;
                        break;
                    default: btn.BackColor = Color.Red; break;
                }
                flTable.Controls.Add(btn);
            }
            
        }
        void Show_Bill(int id)
        {
            listViewBill.Items.Clear();
          
            List<MenuData> listBill=MenuProvider.Instance.GetMenus(id);
            float totalPrice = 0;
            foreach(MenuData item in listBill)
            {
                ListViewItem lvItem=new ListViewItem(item.FoodName.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.TotalPrice.ToString());
                listViewBill.Items.Add(lvItem);
                totalPrice += item.TotalPrice;
            }
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            txttotalPrice.Text = totalPrice.ToString("C",cul);//doi text sang dang tien te viet nam
            
        }

        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            
            int tableID = ((sender as Button).Tag as TableData).ID;
            listViewBill.Tag = (sender as Button).Tag;
            Show_Bill(tableID);
        }
        private void Themmonbtn_Click(object sender, EventArgs e)
        {
            TableData table=listViewBill.Tag as TableData;
            int idBill = BillProvider.Instance.GetUncheckBillById(table.ID);
            int IdFood = (cbFood.SelectedItem as FoodData).Id;
            int count = (int)nmFood.Value;
            if(idBill == -1)
            {
                BillProvider.Instance.InsertBill(table.ID);
                BillInfoProvider.Instance.InsertBillInfo(BillProvider.Instance.GetMaxIdBill(), IdFood, count);

            }
            else
            {
                BillInfoProvider.Instance.InsertBillInfo(idBill, IdFood, count);
            }
            Show_Bill(table.ID);
            LoadDataTable();

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
            CategoryData selectedid = comboBox.SelectedItem as CategoryData;
            id = selectedid.Id;
            LoadFoodByCatory(id);
        }
        private void Thanhtoanbtn_Click(object sender, EventArgs e)
        {
            TableData table = listViewBill.Tag as TableData;
            int idBill = BillProvider.Instance.GetUncheckBillById(table.ID);
            int discount = (int)nmDiscount.Value;
            double totalPrice=Convert.ToDouble(txttotalPrice.Text.Split(',')[0]);
            double finalPrice = totalPrice - (totalPrice / 100)*discount;
            if (idBill != -1)
            {
                if(MessageBox.Show(string.Format("Do you want to pay {0} ?\n Price to pay: {1} ",table.Name,finalPrice), "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillProvider.Instance.ChecKOut(idBill,discount,(float)finalPrice);
                    Show_Bill(table.ID);
                    LoadDataTable();
                }
               

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
