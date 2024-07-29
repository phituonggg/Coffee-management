using System;

namespace QuanLyQuanCaPhe
{
    partial class TableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.txttotalPrice = new System.Windows.Forms.TextBox();
            this.Thanhtoanbtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.Themmonbtn = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.nmFood = new System.Windows.Forms.NumericUpDown();
            this.flTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLoginUser = new System.Windows.Forms.Label();
            this.ptLoginUser = new System.Windows.Forms.PictureBox();
            this.lbHour = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFood)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLoginUser)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.accountInformationToolStripMenuItem,
            this.managerToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(935, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // accountInformationToolStripMenuItem
            // 
            this.accountInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInformationToolStripMenuItem,
            this.addAccountToolStripMenuItem});
            this.accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            this.accountInformationToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.accountInformationToolStripMenuItem.Text = "Account Information";
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.personalInformationToolStripMenuItem.Text = "Personal Information";
            this.personalInformationToolStripMenuItem.Click += new System.EventHandler(this.personalInformationToolStripMenuItem_Click);
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addAccountToolStripMenuItem.Text = "Add Account";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeManagementToolStripMenuItem,
            this.activeEmployeeToolStripMenuItem});
            this.managerToolStripMenuItem.Enabled = false;
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.managerToolStripMenuItem.Text = "Manager";
            // 
            // employeeManagementToolStripMenuItem
            // 
            this.employeeManagementToolStripMenuItem.Name = "employeeManagementToolStripMenuItem";
            this.employeeManagementToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.employeeManagementToolStripMenuItem.Text = "Employee Management";
            this.employeeManagementToolStripMenuItem.Click += new System.EventHandler(this.employeeManagementToolStripMenuItem_Click);
            // 
            // activeEmployeeToolStripMenuItem
            // 
            this.activeEmployeeToolStripMenuItem.Name = "activeEmployeeToolStripMenuItem";
            this.activeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.activeEmployeeToolStripMenuItem.Text = "Active Employee";
            this.activeEmployeeToolStripMenuItem.Click += new System.EventHandler(this.activeEmployeeToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewBill);
            this.panel2.Location = new System.Drawing.Point(510, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 258);
            this.panel2.TabIndex = 3;
            // 
            // listViewBill
            // 
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBill.GridLines = true;
            this.listViewBill.HideSelection = false;
            this.listViewBill.Location = new System.Drawing.Point(0, 0);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(322, 255);
            this.listViewBill.TabIndex = 5;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Food";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 43;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Price";
            this.columnHeader4.Width = 75;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.txttotalPrice);
            this.panel3.Controls.Add(this.Thanhtoanbtn);
            this.panel3.Location = new System.Drawing.Point(510, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 58);
            this.panel3.TabIndex = 4;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(3, 32);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(92, 20);
            this.nmDiscount.TabIndex = 5;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(3, 3);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(92, 23);
            this.btnDiscount.TabIndex = 4;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // txttotalPrice
            // 
            this.txttotalPrice.ForeColor = System.Drawing.Color.Red;
            this.txttotalPrice.Location = new System.Drawing.Point(109, 18);
            this.txttotalPrice.Margin = new System.Windows.Forms.Padding(1);
            this.txttotalPrice.Name = "txttotalPrice";
            this.txttotalPrice.ReadOnly = true;
            this.txttotalPrice.Size = new System.Drawing.Size(95, 20);
            this.txttotalPrice.TabIndex = 3;
            this.txttotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Thanhtoanbtn
            // 
            this.Thanhtoanbtn.Location = new System.Drawing.Point(208, 0);
            this.Thanhtoanbtn.Name = "Thanhtoanbtn";
            this.Thanhtoanbtn.Size = new System.Drawing.Size(75, 55);
            this.Thanhtoanbtn.TabIndex = 0;
            this.Thanhtoanbtn.Text = "Pay";
            this.Thanhtoanbtn.UseVisualStyleBackColor = true;
            this.Thanhtoanbtn.Click += new System.EventHandler(this.Thanhtoanbtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbCategory);
            this.flowLayoutPanel1.Controls.Add(this.Themmonbtn);
            this.flowLayoutPanel1.Controls.Add(this.cbFood);
            this.flowLayoutPanel1.Controls.Add(this.nmFood);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(507, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 91);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbCategory
            // 
            this.cbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // Themmonbtn
            // 
            this.Themmonbtn.Location = new System.Drawing.Point(130, 3);
            this.Themmonbtn.Name = "Themmonbtn";
            this.Themmonbtn.Size = new System.Drawing.Size(75, 33);
            this.Themmonbtn.TabIndex = 2;
            this.Themmonbtn.Text = "Add Food";
            this.Themmonbtn.UseVisualStyleBackColor = true;
            this.Themmonbtn.Click += new System.EventHandler(this.Themmonbtn_Click);
            // 
            // cbFood
            // 
            this.cbFood.Location = new System.Drawing.Point(3, 42);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(121, 21);
            this.cbFood.TabIndex = 3;
            // 
            // nmFood
            // 
            this.nmFood.Location = new System.Drawing.Point(130, 42);
            this.nmFood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFood.Name = "nmFood";
            this.nmFood.Size = new System.Drawing.Size(76, 20);
            this.nmFood.TabIndex = 3;
            // 
            // flTable
            // 
            this.flTable.Location = new System.Drawing.Point(24, 30);
            this.flTable.Name = "flTable";
            this.flTable.Size = new System.Drawing.Size(466, 408);
            this.flTable.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLoginUser);
            this.panel1.Controls.Add(this.ptLoginUser);
            this.panel1.Location = new System.Drawing.Point(735, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 91);
            this.panel1.TabIndex = 4;
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.AutoSize = true;
            this.txtLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUser.Location = new System.Drawing.Point(45, 65);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(52, 18);
            this.txtLoginUser.TabIndex = 1;
            this.txtLoginUser.Text = "label1";
            this.txtLoginUser.Click += new System.EventHandler(this.txtLoginUser_Click);
            // 
            // ptLoginUser
            // 
            this.ptLoginUser.Image = global::QuanLyQuanCaPhe.Properties.Resources.admin;
            this.ptLoginUser.Location = new System.Drawing.Point(15, 0);
            this.ptLoginUser.Name = "ptLoginUser";
            this.ptLoginUser.Size = new System.Drawing.Size(100, 62);
            this.ptLoginUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptLoginUser.TabIndex = 0;
            this.ptLoginUser.TabStop = false;
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.Location = new System.Drawing.Point(659, 5);
            this.lbHour.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(79, 20);
            this.lbHour.TabIndex = 5;
            this.lbHour.Text = "00:00:00";
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 506);
            this.Controls.Add(this.lbHour);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flTable);
            this.Name = "TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableManager";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLoginUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountInformationToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button Themmonbtn;
        private System.Windows.Forms.Button Thanhtoanbtn;
        private System.Windows.Forms.NumericUpDown nmFood;
        private System.Windows.Forms.FlowLayoutPanel flTable;
        private System.Windows.Forms.ToolStripMenuItem personalInformationToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txttotalPrice;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptLoginUser;
        private System.Windows.Forms.Label txtLoginUser;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeEmployeeToolStripMenuItem;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
    }
}