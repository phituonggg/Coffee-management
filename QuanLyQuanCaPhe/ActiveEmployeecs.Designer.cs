using System;

namespace QuanLyQuanCaPhe
{
    partial class ActiveEmployeecs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShift = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvActiveEmploy = new System.Windows.Forms.DataGridView();
            this.btnActiv = new System.Windows.Forms.Button();
            this.txtActiveEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveEmploy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShift);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvActiveEmploy);
            this.panel1.Controls.Add(this.btnActiv);
            this.panel1.Controls.Add(this.txtActiveEmployee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(46, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 239);
            this.panel1.TabIndex = 0;
            // 
            // btnShift
            // 
            this.btnShift.Location = new System.Drawing.Point(517, 209);
            this.btnShift.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(90, 23);
            this.btnShift.TabIndex = 5;
            this.btnShift.Text = "End Shift";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(212, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee in work shift";
            // 
            // dgvActiveEmploy
            // 
            this.dgvActiveEmploy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveEmploy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveEmploy.Location = new System.Drawing.Point(19, 79);
            this.dgvActiveEmploy.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvActiveEmploy.Name = "dgvActiveEmploy";
            this.dgvActiveEmploy.RowHeadersWidth = 102;
            this.dgvActiveEmploy.RowTemplate.Height = 40;
            this.dgvActiveEmploy.Size = new System.Drawing.Size(588, 116);
            this.dgvActiveEmploy.TabIndex = 3;
            // 
            // btnActiv
            // 
            this.btnActiv.Location = new System.Drawing.Point(210, 44);
            this.btnActiv.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnActiv.Name = "btnActiv";
            this.btnActiv.Size = new System.Drawing.Size(82, 20);
            this.btnActiv.TabIndex = 2;
            this.btnActiv.Text = "Click to Activ";
            this.btnActiv.UseVisualStyleBackColor = true;
            this.btnActiv.Click += new System.EventHandler(this.btnActiv_Click);
            // 
            // txtActiveEmployee
            // 
            this.txtActiveEmployee.Location = new System.Drawing.Point(122, 47);
            this.txtActiveEmployee.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtActiveEmployee.Name = "txtActiveEmployee";
            this.txtActiveEmployee.Size = new System.Drawing.Size(78, 20);
            this.txtActiveEmployee.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER ID :";
            // 
            // ActiveEmployeecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 312);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "ActiveEmployeecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActiveEmployeecs";
            this.Load += new System.EventHandler(this.ActiveEmployeecs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveEmploy)).EndInit();
            this.ResumeLayout(false);

        }

        private void ActiveEmployeecs_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvActiveEmploy;
        private System.Windows.Forms.Button btnActiv;
        private System.Windows.Forms.TextBox txtActiveEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Label label2;
    }
}