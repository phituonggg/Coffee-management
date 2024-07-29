namespace QuanLyQuanCaPhe
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GetListByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanCafe1DataSet = new QuanLyQuanCaPhe.QuanLyQuanCafe1DataSet();
            this.GetListByDateTableAdapter = new QuanLyQuanCaPhe.QuanLyQuanCafe1DataSetTableAdapters.GetListByDateTableAdapter();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnShowIncome = new System.Windows.Forms.Button();
            this.dateTimeIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimeOut = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTableid = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTableStatus = new System.Windows.Forms.ComboBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnTableRemove = new System.Windows.Forms.Button();
            this.btnTableAdd = new System.Windows.Forms.Button();
            this.btnTableWatch = new System.Windows.Forms.Button();
            this.tpThucAn = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RemoveFoodbtn = new System.Windows.Forms.Button();
            this.AddFoodbtn = new System.Windows.Forms.Button();
            this.EditFoodbtn = new System.Windows.Forms.Button();
            this.WatchFoodbtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFoodCate = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.tpAdmin = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.GetListByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe1DataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panel12.SuspendLayout();
            this.tpThucAn.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.tpAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetListByDateBindingSource
            // 
            this.GetListByDateBindingSource.DataMember = "GetListByDate";
            this.GetListByDateBindingSource.DataSource = this.quanLyQuanCafe1DataSet;
            // 
            // quanLyQuanCafe1DataSet
            // 
            this.quanLyQuanCafe1DataSet.DataSetName = "QuanLyQuanCafe1DataSet";
            this.quanLyQuanCafe1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GetListByDateTableAdapter
            // 
            this.GetListByDateTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.dateTimeOut);
            this.tabPage1.Controls.Add(this.dateTimeIn);
            this.tabPage1.Controls.Add(this.btnShowIncome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 390);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Income List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnShowIncome
            // 
            this.btnShowIncome.Location = new System.Drawing.Point(306, 6);
            this.btnShowIncome.Name = "btnShowIncome";
            this.btnShowIncome.Size = new System.Drawing.Size(121, 23);
            this.btnShowIncome.TabIndex = 1;
            this.btnShowIncome.Text = "Show Income";
            this.btnShowIncome.UseVisualStyleBackColor = true;
            this.btnShowIncome.Click += new System.EventHandler(this.btnShowIncome_Click);
            // 
            // dateTimeIn
            // 
            this.dateTimeIn.Location = new System.Drawing.Point(28, 9);
            this.dateTimeIn.Name = "dateTimeIn";
            this.dateTimeIn.Size = new System.Drawing.Size(200, 20);
            this.dateTimeIn.TabIndex = 2;
            // 
            // dateTimeOut
            // 
            this.dateTimeOut.Location = new System.Drawing.Point(511, 9);
            this.dateTimeOut.Name = "dateTimeOut";
            this.dateTimeOut.Size = new System.Drawing.Size(200, 20);
            this.dateTimeOut.TabIndex = 3;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetListByDateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCaPhe.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(28, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(667, 285);
            this.reportViewer1.TabIndex = 4;
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel12);
            this.tpTable.Controls.Add(this.dgvTable);
            this.tpTable.Controls.Add(this.panel14);
            this.tpTable.Location = new System.Drawing.Point(4, 22);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(741, 390);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Table";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel19);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.panel18);
            this.panel14.Location = new System.Drawing.Point(433, 70);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(294, 314);
            this.panel14.TabIndex = 8;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.txtTableid);
            this.panel18.Controls.Add(this.label6);
            this.panel18.Location = new System.Drawing.Point(3, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(288, 58);
            this.panel18.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID :";
            // 
            // txtTableid
            // 
            this.txtTableid.Location = new System.Drawing.Point(171, 22);
            this.txtTableid.Name = "txtTableid";
            this.txtTableid.ReadOnly = true;
            this.txtTableid.Size = new System.Drawing.Size(114, 20);
            this.txtTableid.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtTableName);
            this.panel15.Controls.Add(this.label5);
            this.panel15.Location = new System.Drawing.Point(3, 67);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(288, 58);
            this.panel15.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Table Number:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(171, 22);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(114, 20);
            this.txtTableName.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.cbTableStatus);
            this.panel19.Controls.Add(this.label9);
            this.panel19.Location = new System.Drawing.Point(3, 128);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(288, 58);
            this.panel19.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "State :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTableStatus
            // 
            this.cbTableStatus.FormattingEnabled = true;
            this.cbTableStatus.Location = new System.Drawing.Point(171, 16);
            this.cbTableStatus.Name = "cbTableStatus";
            this.cbTableStatus.Size = new System.Drawing.Size(114, 21);
            this.cbTableStatus.TabIndex = 1;
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(13, 74);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 102;
            this.dgvTable.Size = new System.Drawing.Size(392, 308);
            this.dgvTable.TabIndex = 6;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnTableWatch);
            this.panel12.Controls.Add(this.btnTableAdd);
            this.panel12.Controls.Add(this.btnTableRemove);
            this.panel12.Location = new System.Drawing.Point(13, 6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(398, 58);
            this.panel12.TabIndex = 7;
            // 
            // btnTableRemove
            // 
            this.btnTableRemove.Location = new System.Drawing.Point(110, 12);
            this.btnTableRemove.Name = "btnTableRemove";
            this.btnTableRemove.Size = new System.Drawing.Size(73, 34);
            this.btnTableRemove.TabIndex = 4;
            this.btnTableRemove.Text = "Remove";
            this.btnTableRemove.UseVisualStyleBackColor = true;
            this.btnTableRemove.Click += new System.EventHandler(this.btnTableRemove_Click);
            // 
            // btnTableAdd
            // 
            this.btnTableAdd.Location = new System.Drawing.Point(3, 12);
            this.btnTableAdd.Name = "btnTableAdd";
            this.btnTableAdd.Size = new System.Drawing.Size(86, 34);
            this.btnTableAdd.TabIndex = 3;
            this.btnTableAdd.Text = "Add";
            this.btnTableAdd.UseVisualStyleBackColor = true;
            this.btnTableAdd.Click += new System.EventHandler(this.btnTableAdd_Click);
            // 
            // btnTableWatch
            // 
            this.btnTableWatch.Location = new System.Drawing.Point(216, 12);
            this.btnTableWatch.Name = "btnTableWatch";
            this.btnTableWatch.Size = new System.Drawing.Size(73, 34);
            this.btnTableWatch.TabIndex = 6;
            this.btnTableWatch.Text = "Watch";
            this.btnTableWatch.UseVisualStyleBackColor = true;
            this.btnTableWatch.Click += new System.EventHandler(this.btnTableWatch_Click);
            // 
            // tpThucAn
            // 
            this.tpThucAn.Controls.Add(this.panel5);
            this.tpThucAn.Controls.Add(this.panel4);
            this.tpThucAn.Controls.Add(this.panel3);
            this.tpThucAn.Location = new System.Drawing.Point(4, 22);
            this.tpThucAn.Name = "tpThucAn";
            this.tpThucAn.Padding = new System.Windows.Forms.Padding(3);
            this.tpThucAn.Size = new System.Drawing.Size(741, 390);
            this.tpThucAn.TabIndex = 1;
            this.tpThucAn.Text = "Food";
            this.tpThucAn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvFood);
            this.panel3.Location = new System.Drawing.Point(6, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(398, 314);
            this.panel3.TabIndex = 0;
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(3, 3);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 102;
            this.dgvFood.Size = new System.Drawing.Size(392, 308);
            this.dgvFood.TabIndex = 0;
            this.dgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.WatchFoodbtn);
            this.panel4.Controls.Add(this.EditFoodbtn);
            this.panel4.Controls.Add(this.AddFoodbtn);
            this.panel4.Controls.Add(this.RemoveFoodbtn);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 58);
            this.panel4.TabIndex = 1;
            // 
            // RemoveFoodbtn
            // 
            this.RemoveFoodbtn.Location = new System.Drawing.Point(110, 12);
            this.RemoveFoodbtn.Name = "RemoveFoodbtn";
            this.RemoveFoodbtn.Size = new System.Drawing.Size(73, 34);
            this.RemoveFoodbtn.TabIndex = 4;
            this.RemoveFoodbtn.Text = "Remove";
            this.RemoveFoodbtn.UseVisualStyleBackColor = true;
            this.RemoveFoodbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddFoodbtn
            // 
            this.AddFoodbtn.Location = new System.Drawing.Point(3, 12);
            this.AddFoodbtn.Name = "AddFoodbtn";
            this.AddFoodbtn.Size = new System.Drawing.Size(86, 34);
            this.AddFoodbtn.TabIndex = 3;
            this.AddFoodbtn.Text = "Add";
            this.AddFoodbtn.UseVisualStyleBackColor = true;
            this.AddFoodbtn.Click += new System.EventHandler(this.AddFoodbtn_Click);
            // 
            // EditFoodbtn
            // 
            this.EditFoodbtn.Location = new System.Drawing.Point(209, 12);
            this.EditFoodbtn.Name = "EditFoodbtn";
            this.EditFoodbtn.Size = new System.Drawing.Size(73, 34);
            this.EditFoodbtn.TabIndex = 5;
            this.EditFoodbtn.Text = "Edit";
            this.EditFoodbtn.UseVisualStyleBackColor = true;
            this.EditFoodbtn.Click += new System.EventHandler(this.EditFoodbtn_Click);
            // 
            // WatchFoodbtn
            // 
            this.WatchFoodbtn.Location = new System.Drawing.Point(304, 12);
            this.WatchFoodbtn.Name = "WatchFoodbtn";
            this.WatchFoodbtn.Size = new System.Drawing.Size(73, 34);
            this.WatchFoodbtn.TabIndex = 6;
            this.WatchFoodbtn.Text = "Watch";
            this.WatchFoodbtn.UseVisualStyleBackColor = true;
            this.WatchFoodbtn.Click += new System.EventHandler(this.WatchFoodbtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(426, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 314);
            this.panel5.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtid);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(288, 58);
            this.panel7.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(141, 22);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(144, 20);
            this.txtid.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtFoodName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 67);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(288, 58);
            this.panel8.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Food Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(141, 22);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(144, 20);
            this.txtFoodName.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbFoodCate);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(3, 128);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(288, 58);
            this.panel9.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Mục:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbFoodCate
            // 
            this.cbFoodCate.FormattingEnabled = true;
            this.cbFoodCate.Location = new System.Drawing.Point(141, 16);
            this.cbFoodCate.Name = "cbFoodCate";
            this.cbFoodCate.Size = new System.Drawing.Size(144, 21);
            this.cbFoodCate.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmFoodPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(3, 192);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(288, 58);
            this.panel10.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gía:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(141, 22);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(134, 20);
            this.nmFoodPrice.TabIndex = 1;
            // 
            // tpAdmin
            // 
            this.tpAdmin.Controls.Add(this.tpThucAn);
            this.tpAdmin.Controls.Add(this.tpTable);
            this.tpAdmin.Controls.Add(this.tabPage1);
            this.tpAdmin.Location = new System.Drawing.Point(12, 12);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.SelectedIndex = 0;
            this.tpAdmin.Size = new System.Drawing.Size(749, 416);
            this.tpAdmin.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 544);
            this.Controls.Add(this.tpAdmin);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetListByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe1DataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tpTable.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panel12.ResumeLayout(false);
            this.tpThucAn.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.tpAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource GetListByDateBindingSource;
        private QuanLyQuanCafe1DataSetTableAdapters.GetListByDateTableAdapter GetListByDateTableAdapter;
        private QuanLyQuanCafe1DataSet quanLyQuanCafe1DataSet;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimeOut;
        private System.Windows.Forms.DateTimePicker dateTimeIn;
        private System.Windows.Forms.Button btnShowIncome;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnTableWatch;
        private System.Windows.Forms.Button btnTableAdd;
        private System.Windows.Forms.Button btnTableRemove;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.ComboBox cbTableStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txtTableid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tpThucAn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbFoodCate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button WatchFoodbtn;
        private System.Windows.Forms.Button EditFoodbtn;
        private System.Windows.Forms.Button AddFoodbtn;
        private System.Windows.Forms.Button RemoveFoodbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.TabControl tpAdmin;
    }
}