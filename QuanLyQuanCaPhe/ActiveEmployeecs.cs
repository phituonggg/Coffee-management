using QuanLyQuanCaPhe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class ActiveEmployeecs : Form
        
    {
        System.Timers.Timer timer;
        int hour,minute,second;
        BindingSource sourceEmployee = new BindingSource();
        public ActiveEmployeecs(int h,int m)
        {
            this.hour= h;
            this.minute = m;
            InitializeComponent();
            dgvActiveEmploy.DataSource = sourceEmployee;
            LoadListActiveEmploy();
        }
        void LoadListActiveEmploy()
        {
            sourceEmployee.DataSource = EmployeeProvider.Instance.ShowActiveEmployee();
        }
        private void btnActiv_Click(object sender, EventArgs e)
        {
           
                if (txtActiveEmployee.Text != null)
                {
                    try
                    {
                        if (EmployeeProvider.Instance.ActiveEmployee(txtActiveEmployee.Text))
                        {
                            MessageBox.Show("Active employee with " + txtActiveEmployee.Text + " successfully");
                            LoadListActiveEmploy();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Employye does not have Permission");
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter id of employee! ");
                }
            
            
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            try
            {
                string time = (string)(hour + minute / 10).ToString();
                if (EmployeeProvider.Instance.EndShift(time))
                {
                    MessageBox.Show("Shift has been end");

                    LoadListActiveEmploy();

                }
                TableManager f = new TableManager(0);
                this.Hide();
                f.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Employye does not have Permission");
            }

                
        }

        
        
    }
}
