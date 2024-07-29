using QuanLyLinq;

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
            this.tpAdmin = new System.Windows.Forms.TabControl();
            this.tpThucAn = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbFoodCate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WatchFoodbtn = new System.Windows.Forms.Button();
            this.EditFoodbtn = new System.Windows.Forms.Button();
            this.AddFoodbtn = new System.Windows.Forms.Button();
            this.RemoveFoodbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.tpIncome = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ThongKeviewbtn = new System.Windows.Forms.Button();
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnTableWatch = new System.Windows.Forms.Button();
            this.btnTableEdit = new System.Windows.Forms.Button();
            this.btnTableAdd = new System.Windows.Forms.Button();
            this.btnTableRemove = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.cbTableStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txtTableid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnShowIncome = new System.Windows.Forms.Button();
            this.dateTimeIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimeOut = new System.Windows.Forms.DateTimePicker();
            this.quanLyQuanCafe1DataSet = new QuanLyLinq.QuanLyQuanCafe1DataSet();
            this.GetListByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetListByDateTableAdapter = new QuanLyLinq.QuanLyQuanCafe1DataSetTableAdapters.GetListByDateTableAdapter();
            this.tpAdmin.SuspendLayout();
            this.tpThucAn.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.tpIncome.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.tpTable.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel18.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetListByDateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tpAdmin
            // 
            this.tpAdmin.Controls.Add(this.tpThucAn);
            this.tpAdmin.Controls.Add(this.tpIncome);
            this.tpAdmin.Controls.Add(this.tpTable);
            this.tpAdmin.Controls.Add(this.tabPage1);
            this.tpAdmin.Location = new System.Drawing.Point(12, 12);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.SelectedIndex = 0;
            this.tpAdmin.Size = new System.Drawing.Size(749, 416);
            this.tpAdmin.TabIndex = 0;
            // 
            // tpThucAn
            // 
            this.tpThucAn.Controls.Add(this.panel6);
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
            // panel6
            // 
            this.panel6.Controls.Add(this.btnFind);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Location = new System.Drawing.Point(426, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(294, 58);
            this.panel6.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(215, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(73, 34);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 2;
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
            // panel10
            // 
            this.panel10.Controls.Add(this.nmFoodPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(3, 192);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(288, 58);
            this.panel10.TabIndex = 4;
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
            // panel9
            // 
            this.panel9.Controls.Add(this.cbFoodCate);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(3, 128);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(288, 58);
            this.panel9.TabIndex = 3;
            // 
            // cbFoodCate
            // 
            this.cbFoodCate.FormattingEnabled = true;
            this.cbFoodCate.Location = new System.Drawing.Point(141, 16);
            this.cbFoodCate.Name = "cbFoodCate";
            this.cbFoodCate.Size = new System.Drawing.Size(144, 21);
            this.cbFoodCate.TabIndex = 2;
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
            // panel8
            // 
            this.panel8.Controls.Add(this.txtFoodName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 67);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(288, 58);
            this.panel8.TabIndex = 2;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(141, 22);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(144, 20);
            this.txtFoodName.TabIndex = 1;
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
            // panel7
            // 
            this.panel7.Controls.Add(this.txtid);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(288, 58);
            this.panel7.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(141, 22);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(144, 20);
            this.txtid.TabIndex = 1;
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
            // tpIncome
            // 
            this.tpIncome.Controls.Add(this.panel2);
            this.tpIncome.Controls.Add(this.panel1);
            this.tpIncome.Location = new System.Drawing.Point(4, 22);
            this.tpIncome.Name = "tpIncome";
            this.tpIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tpIncome.Size = new System.Drawing.Size(741, 390);
            this.tpIncome.TabIndex = 2;
            this.tpIncome.Text = "Income";
            this.tpIncome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ThongKeviewbtn);
            this.panel2.Controls.Add(this.dtOut);
            this.panel2.Controls.Add(this.dtIn);
            this.panel2.Location = new System.Drawing.Point(6, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 26);
            this.panel2.TabIndex = 1;
            // 
            // ThongKeviewbtn
            // 
            this.ThongKeviewbtn.Location = new System.Drawing.Point(296, 3);
            this.ThongKeviewbtn.Name = "ThongKeviewbtn";
            this.ThongKeviewbtn.Size = new System.Drawing.Size(75, 23);
            this.ThongKeviewbtn.TabIndex = 3;
            this.ThongKeviewbtn.Text = "Static";
            this.ThongKeviewbtn.UseVisualStyleBackColor = true;
            this.ThongKeviewbtn.Click += new System.EventHandler(this.ThongKeviewbtn_Click);
            // 
            // dtOut
            // 
            this.dtOut.Location = new System.Drawing.Point(523, 3);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(200, 20);
            this.dtOut.TabIndex = 2;
            // 
            // dtIn
            // 
            this.dtIn.Location = new System.Drawing.Point(3, 3);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(200, 20);
            this.dtIn.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvThongKe);
            this.panel1.Location = new System.Drawing.Point(3, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 319);
            this.panel1.TabIndex = 0;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(3, 3);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 102;
            this.dgvThongKe.Size = new System.Drawing.Size(726, 316);
            this.dgvThongKe.TabIndex = 0;
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
            // panel12
            // 
            this.panel12.Controls.Add(this.btnTableWatch);
            this.panel12.Controls.Add(this.btnTableEdit);
            this.panel12.Controls.Add(this.btnTableAdd);
            this.panel12.Controls.Add(this.btnTableRemove);
            this.panel12.Location = new System.Drawing.Point(13, 6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(398, 58);
            this.panel12.TabIndex = 7;
            // 
            // btnTableWatch
            // 
            this.btnTableWatch.Location = new System.Drawing.Point(304, 12);
            this.btnTableWatch.Name = "btnTableWatch";
            this.btnTableWatch.Size = new System.Drawing.Size(73, 34);
            this.btnTableWatch.TabIndex = 6;
            this.btnTableWatch.Text = "Watch";
            this.btnTableWatch.UseVisualStyleBackColor = true;
            this.btnTableWatch.Click += new System.EventHandler(this.btnTableWatch_Click);
            // 
            // btnTableEdit
            // 
            this.btnTableEdit.Location = new System.Drawing.Point(209, 12);
            this.btnTableEdit.Name = "btnTableEdit";
            this.btnTableEdit.Size = new System.Drawing.Size(73, 34);
            this.btnTableEdit.TabIndex = 5;
            this.btnTableEdit.Text = "Edit";
            this.btnTableEdit.UseVisualStyleBackColor = true;
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
            // panel19
            // 
            this.panel19.Controls.Add(this.cbTableStatus);
            this.panel19.Controls.Add(this.label9);
            this.panel19.Location = new System.Drawing.Point(3, 128);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(288, 58);
            this.panel19.TabIndex = 3;
            // 
            // cbTableStatus
            // 
            this.cbTableStatus.FormattingEnabled = true;
            this.cbTableStatus.Location = new System.Drawing.Point(171, 16);
            this.cbTableStatus.Name = "cbTableStatus";
            this.cbTableStatus.Size = new System.Drawing.Size(114, 21);
            this.cbTableStatus.TabIndex = 1;
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
            // panel15
            // 
            this.panel15.Controls.Add(this.txtTableName);
            this.panel15.Controls.Add(this.label5);
            this.panel15.Location = new System.Drawing.Point(3, 67);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(288, 58);
            this.panel15.TabIndex = 2;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(171, 22);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(114, 20);
            this.txtTableName.TabIndex = 1;
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
            // panel18
            // 
            this.panel18.Controls.Add(this.txtTableid);
            this.panel18.Controls.Add(this.label6);
            this.panel18.Location = new System.Drawing.Point(3, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(288, 58);
            this.panel18.TabIndex = 1;
            // 
            // txtTableid
            // 
            this.txtTableid.Location = new System.Drawing.Point(171, 22);
            this.txtTableid.Name = "txtTableid";
            this.txtTableid.ReadOnly = true;
            this.txtTableid.Size = new System.Drawing.Size(114, 20);
            this.txtTableid.TabIndex = 1;
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimeOut);
            this.tabPage1.Controls.Add(this.dateTimeIn);
            this.tabPage1.Controls.Add(this.btnShowIncome);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 390);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Income List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetListByDateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyLinq.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(709, 310);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnShowIncome
            // 
            this.btnShowIncome.Location = new System.Drawing.Point(333, 19);
            this.btnShowIncome.Name = "btnShowIncome";
            this.btnShowIncome.Size = new System.Drawing.Size(75, 23);
            this.btnShowIncome.TabIndex = 1;
            this.btnShowIncome.Text = "Show Income";
            this.btnShowIncome.UseVisualStyleBackColor = true;
            this.btnShowIncome.Click += new System.EventHandler(this.btnShowIncome_Click);
            // 
            // dateTimeIn
            // 
            this.dateTimeIn.Location = new System.Drawing.Point(26, 19);
            this.dateTimeIn.Name = "dateTimeIn";
            this.dateTimeIn.Size = new System.Drawing.Size(200, 20);
            this.dateTimeIn.TabIndex = 2;
            // 
            // dateTimeOut
            // 
            this.dateTimeOut.Location = new System.Drawing.Point(535, 22);
            this.dateTimeOut.Name = "dateTimeOut";
            this.dateTimeOut.Size = new System.Drawing.Size(200, 20);
            this.dateTimeOut.TabIndex = 3;
            // 
            // quanLyQuanCafe1DataSet1
            // 
            this.quanLyQuanCafe1DataSet.DataSetName = "QuanLyQuanCafe1DataSet";
            this.quanLyQuanCafe1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyQuanCafe1DataSet1BindingSource
            // 
            this.GetListByDateBindingSource.DataMember = "GetListByDate";
            this.GetListByDateBindingSource.DataSource = this.quanLyQuanCafe1DataSet;
            // 
            this.GetListByDateTableAdapter.ClearBeforeFill = true;
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 544);
            this.Controls.Add(this.tpAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tpAdmin.ResumeLayout(false);
            this.tpThucAn.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.tpIncome.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.tpTable.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetListByDateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpAdmin;
        private System.Windows.Forms.TabPage tpThucAn;
        private System.Windows.Forms.TabPage tpIncome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AddFoodbtn;
        private System.Windows.Forms.Button RemoveFoodbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button ThongKeviewbtn;
        private System.Windows.Forms.DateTimePicker dtOut;
        private System.Windows.Forms.DateTimePicker dtIn;
        private System.Windows.Forms.Button WatchFoodbtn;
        private System.Windows.Forms.Button EditFoodbtn;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnTableWatch;
        private System.Windows.Forms.Button btnTableEdit;
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
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetListByDateBindingSource;
        private QuanLyLinq.QuanLyQuanCafe1DataSetTableAdapters.GetListByDateTableAdapter GetListByDateTableAdapter;
        private QuanLyLinq.QuanLyQuanCafe1DataSet quanLyQuanCafe1DataSet;
        private System.Windows.Forms.DateTimePicker dateTimeOut;
        private System.Windows.Forms.DateTimePicker dateTimeIn;
        private System.Windows.Forms.Button btnShowIncome;
        
        
    }
}