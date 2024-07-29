using QuanLyQuanCaPhe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCaPhe
{
    public partial class AddingnewAccount : Form
    {
        public AddingnewAccount()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            LoadListAccount();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccountProvider.Instance.CreateLogon(txtUserName.Text, txtPassword.Text, cbType.SelectedItem.ToString()))
                {
                    MessageBox.Show("Create new Account unsuccessfully");

                }


                else
                {
                    MessageBox.Show("Create new Account successfully");
                }
                LoadData();
            }
            catch
            {
                MessageBox.Show("Employye does not have Permission");
            }
        }
        void LoadListAccount()
        {
            dgvAccount.DataSource=AccountProvider.Instance.GetListAccount();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string type = this.cbTypeFind.GetItemText(this.cbTypeFind.SelectedItem);
                dgvAccount.DataSource = AccountProvider.Instance.GetListAccountByType(type);
            }
            catch
            {
                MessageBox.Show("Employye does not have Permission");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                int r = dgvAccount.CurrentCell.RowIndex;
                string username = dgvAccount.Rows[r].Cells[0].Value.ToString();
                string password = dgvAccount.Rows[r].Cells[2].Value.ToString();
                string type = dgvAccount.Rows[r].Cells[3].Value.ToString();
                if (AccountProvider.Instance.DeleteLogin(username, password, type))
                {
                    MessageBox.Show("Delete Account successfully");

                }
                LoadListAccount();
            }
            catch
            {
                MessageBox.Show("Employye does not have Permission");
            }
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
