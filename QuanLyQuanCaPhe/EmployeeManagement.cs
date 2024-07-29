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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCaPhe
{
    public partial class EmployeeManagement : Form
    {
        BindingSource sourceEmploy = new BindingSource();
        public EmployeeManagement()
        {
            InitializeComponent();
            loaddata();
        }
        void loaddata()
        {
            dgvEmployee.DataSource = sourceEmploy;
            LoadListEmployee();
            AddEmploy();
            LoadEmploystatus(cbStatusEmployye);
        }
        void LoadListEmployee()
        {
            sourceEmploy.DataSource = EmployeeProvider.Instance.GetListEmployee();

        }
        void AddEmploy()
        {
            txtIdEmployee.DataBindings.Add(new Binding("Text", dgvEmployee.DataSource, "Id"));//tu textbox thay doi gia tri text bang voi gia tri Name cua Datasource
            textNameEmployee.DataBindings.Add(new Binding("Text", dgvEmployee.DataSource, "Name"));
            dtEmployee.DataBindings.Add(new Binding("Text", dgvEmployee.DataSource, "Birth"));
            lbHour.DataBindings.Add(new Binding("Text", dgvEmployee.DataSource, "WorkingHour"));
            
        }
        void LoadEmploystatus(System.Windows.Forms.ComboBox categoryComboBox)
        {
            List<EmployeeData> employDatas = EmployeeProvider.Instance.GetListEmployee();
            categoryComboBox.DataSource = employDatas;
            categoryComboBox.DisplayMember = "status";
        }

        private void btnDeleteEmploy_Click(object sender, EventArgs e)
        {
            try
            {
                string r = txtIdEmployee.Text;
                if (EmployeeProvider.Instance.DeleteEmploy(r))
                {
                    MessageBox.Show("Delete Employee successfully!");
                    LoadListEmployee();
                }
                else
                {
                    MessageBox.Show("Delete Employee unsuccessfully!");
                }
            }
            catch
            {
                MessageBox.Show("Employye does not have Permission");
            }
        }

        private void btnAddEmploy_Click(object sender, EventArgs e)
        {
            AddEmployee f = new AddEmployee();
            f.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadListEmployee();
        }

        private void btnPaySalary_Click(object sender, EventArgs e)
        {
            string id=txtIdEmployee.Text;
            string name = textNameEmployee.Text;
            double salary= Convert.ToDouble(lbHour.Text)*23000;
            try
            {
                if (MessageBox.Show(string.Format("Do you want to pay salary for {0} ?\n His/her Salary : {1} ", name, salary), "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (EmployeeProvider.Instance.Salary(id))
                    {
                        MessageBox.Show("Payment Finished!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Employee does not have Permission!");
            }
            
               

        }
    }
}
