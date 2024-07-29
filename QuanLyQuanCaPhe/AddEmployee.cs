using QuanLyQuanCaPhe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            txtAddbirth.Init("YYYY-MM-DD");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtAddName.Text;
                string birth = txtAddbirth.Text;
                if (EmployeeProvider.Instance.AddEmploy(name, birth))
                {
                    MessageBox.Show("Add Employee successfully");

                }
                else
                {
                    MessageBox.Show("Add Employee unsuccessfully");
                }
            }
            catch(SqlException SQL)
            {
                if (SQL.Message.StartsWith("The INSERT statement conflicted with")){
                    MessageBox.Show(" Employee must equal or greather than 18 age");
                }
                else
                {
                    MessageBox.Show("You dont have Permission as Staff");
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
