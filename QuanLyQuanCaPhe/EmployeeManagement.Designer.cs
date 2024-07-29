namespace QuanLyQuanCaPhe
{
    partial class EmployeeManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStatusEmployye = new System.Windows.Forms.ComboBox();
            this.lbHour = new System.Windows.Forms.Label();
            this.dtEmployee = new System.Windows.Forms.DateTimePicker();
            this.textNameEmployee = new System.Windows.Forms.TextBox();
            this.txtIdEmployee = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnAddEmploy = new System.Windows.Forms.Button();
            this.btnDeleteEmploy = new System.Windows.Forms.Button();
            this.btnPaySalary = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(247, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE MANAGEMENT LIST";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStatusEmployye);
            this.groupBox1.Controls.Add(this.lbHour);
            this.groupBox1.Controls.Add(this.dtEmployee);
            this.groupBox1.Controls.Add(this.textNameEmployee);
            this.groupBox1.Controls.Add(this.txtIdEmployee);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(42, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(785, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // cbStatusEmployye
            // 
            this.cbStatusEmployye.FormattingEnabled = true;
            this.cbStatusEmployye.Location = new System.Drawing.Point(535, 103);
            this.cbStatusEmployye.Margin = new System.Windows.Forms.Padding(1);
            this.cbStatusEmployye.Name = "cbStatusEmployye";
            this.cbStatusEmployye.Size = new System.Drawing.Size(89, 21);
            this.cbStatusEmployye.TabIndex = 9;
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Location = new System.Drawing.Point(533, 65);
            this.lbHour.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(35, 13);
            this.lbHour.TabIndex = 8;
            this.lbHour.Text = "label8";
            // 
            // dtEmployee
            // 
            this.dtEmployee.Location = new System.Drawing.Point(110, 103);
            this.dtEmployee.Margin = new System.Windows.Forms.Padding(1);
            this.dtEmployee.Name = "dtEmployee";
            this.dtEmployee.Size = new System.Drawing.Size(120, 20);
            this.dtEmployee.TabIndex = 7;
            // 
            // textNameEmployee
            // 
            this.textNameEmployee.Location = new System.Drawing.Point(110, 65);
            this.textNameEmployee.Margin = new System.Windows.Forms.Padding(1);
            this.textNameEmployee.Name = "textNameEmployee";
            this.textNameEmployee.Size = new System.Drawing.Size(120, 20);
            this.textNameEmployee.TabIndex = 6;
            // 
            // txtIdEmployee
            // 
            this.txtIdEmployee.AutoSize = true;
            this.txtIdEmployee.Location = new System.Drawing.Point(108, 28);
            this.txtIdEmployee.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtIdEmployee.Name = "txtIdEmployee";
            this.txtIdEmployee.Size = new System.Drawing.Size(35, 13);
            this.txtIdEmployee.TabIndex = 5;
            this.txtIdEmployee.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Working Time : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date Of Birth :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name : ";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(30, 28);
            this.ID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEmployee);
            this.groupBox2.Location = new System.Drawing.Point(42, 273);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(785, 173);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General Information";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 16);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(1);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 102;
            this.dgvEmployee.RowTemplate.Height = 40;
            this.dgvEmployee.Size = new System.Drawing.Size(760, 146);
            this.dgvEmployee.TabIndex = 0;
            // 
            // btnAddEmploy
            // 
            this.btnAddEmploy.Location = new System.Drawing.Point(429, 235);
            this.btnAddEmploy.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddEmploy.Name = "btnAddEmploy";
            this.btnAddEmploy.Size = new System.Drawing.Size(86, 29);
            this.btnAddEmploy.TabIndex = 10;
            this.btnAddEmploy.Text = "Add Employee";
            this.btnAddEmploy.UseVisualStyleBackColor = true;
            this.btnAddEmploy.Click += new System.EventHandler(this.btnAddEmploy_Click);
            // 
            // btnDeleteEmploy
            // 
            this.btnDeleteEmploy.Location = new System.Drawing.Point(540, 235);
            this.btnDeleteEmploy.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeleteEmploy.Name = "btnDeleteEmploy";
            this.btnDeleteEmploy.Size = new System.Drawing.Size(104, 29);
            this.btnDeleteEmploy.TabIndex = 11;
            this.btnDeleteEmploy.Text = "Delete Employee";
            this.btnDeleteEmploy.UseVisualStyleBackColor = true;
            this.btnDeleteEmploy.Click += new System.EventHandler(this.btnDeleteEmploy_Click);
            // 
            // btnPaySalary
            // 
            this.btnPaySalary.Location = new System.Drawing.Point(739, 235);
            this.btnPaySalary.Margin = new System.Windows.Forms.Padding(1);
            this.btnPaySalary.Name = "btnPaySalary";
            this.btnPaySalary.Size = new System.Drawing.Size(88, 29);
            this.btnPaySalary.TabIndex = 12;
            this.btnPaySalary.Text = "Pay Salary";
            this.btnPaySalary.UseVisualStyleBackColor = true;
            this.btnPaySalary.Click += new System.EventHandler(this.btnPaySalary_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(664, 235);
            this.btnReset.Margin = new System.Windows.Forms.Padding(1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 29);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 502);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPaySalary);
            this.Controls.Add(this.btnDeleteEmploy);
            this.Controls.Add(this.btnAddEmploy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "EmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtIdEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox cbStatusEmployye;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.DateTimePicker dtEmployee;
        private System.Windows.Forms.TextBox textNameEmployee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnAddEmploy;
        private System.Windows.Forms.Button btnDeleteEmploy;
        private System.Windows.Forms.Button btnPaySalary;
        private System.Windows.Forms.Button btnReset;
    }
}