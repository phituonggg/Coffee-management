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

namespace QuanLyQuanCaPhe
{
    public partial class AccountlInformation : Form
    {
        private USP_GetAccountByUserName_Result loginAccount;

        public USP_GetAccountByUserName_Result LoginAccount
        {
            get { return loginAccount; }
            set
            {
                loginAccount = value;
                Account(LoginAccount);
            }
        }
        void Account(USP_GetAccountByUserName_Result loginaccount)
        {
            txtusername.Text = LoginAccount.UserName;
            txtdisplay.Text = LoginAccount.DisplayName;
        }
        public AccountlInformation(USP_GetAccountByUserName_Result loginAccount)
        {
            InitializeComponent();
            this.LoginAccount = loginAccount;
            
        }
        void UpdateAccount()
        {
            string username = txtusername.Text.ToString();
            string displayname = txtdisplay.Text.ToString();
            string password = txtPassword.Text.ToString();
            string newpassword=txtNewPassword.Text.ToString();
            string reenter = txtReenter.Text.ToString();
            if (!newpassword.Equals(reenter))
            {
                MessageBox.Show("Please reenter the new password ");
            }
            else
            {
                if(AccountProvider.Instance.UpdateInfo(username,displayname,password,newpassword))
                {
                    MessageBox.Show("Update Suceessfully");
                }
                else
                {
                    MessageBox.Show("Your old password is incorrect.Please try again!");
                }
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
