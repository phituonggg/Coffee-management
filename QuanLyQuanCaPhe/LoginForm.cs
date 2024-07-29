﻿using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
           
                
                string username = txtusername.Text;
                string password = txtpassword.Text;
                if(DataProvider.Instance.TestCon(username, password))
                {
                    if (Login(username, password))
                    {
                        AccountData loginaccount = AccountProvider.Instance.GetAccount(username);
                        TableManager f = new TableManager(loginaccount);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                        txtpassword.Clear();
                    }
                }
            else
            {
                MessageBox.Show("Cannot connect to DB");
            }
                
            
            

        }
        bool Login(string username,string password)
        {

            return AccountProvider.Instance.Login(username,password);
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
             
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do you want to exit ?", "Warning", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
