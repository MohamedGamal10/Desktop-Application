namespace Elfath_Plastic.Forms
{
    partial class Installments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Employee_Name = new System.Windows.Forms.ComboBox();
            this.btn_search_Installments = new System.Windows.Forms.Button();
            this.search_Installments = new System.Windows.Forms.TextBox();
            this.dataGridView1_add_Installments = new System.Windows.Forms.DataGridView();
            this.update_save_Installments = new System.Windows.Forms.Button();
            this.delete_save_Installments = new System.Windows.Forms.Button();
            this.add_save_Installments = new System.Windows.Forms.Button();
            this.Advance_Payment_Date = new System.Windows.Forms.DateTimePicker();
            this.Advance_Payment_Value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_Installments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1924, 756);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Employee_Name);
            this.tabPage1.Controls.Add(this.btn_search_Installments);
            this.tabPage1.Controls.Add(this.search_Installments);
            this.tabPage1.Controls.Add(this.dataGridView1_add_Installments);
            this.tabPage1.Controls.Add(this.update_save_Installments);
            this.tabPage1.Controls.Add(this.delete_save_Installments);
            this.tabPage1.Controls.Add(this.add_save_Installments);
            this.tabPage1.Controls.Add(this.Advance_Payment_Date);
            this.tabPage1.Controls.Add(this.Advance_Payment_Value);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1916, 714);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة وتعديل";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Employee_Name
            // 
            this.Employee_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Employee_Name.FormattingEnabled = true;
            this.Employee_Name.Location = new System.Drawing.Point(1456, 21);
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.Size = new System.Drawing.Size(306, 37);
            this.Employee_Name.TabIndex = 58;
            // 
            // btn_search_Installments
            // 
            this.btn_search_Installments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_Installments.Location = new System.Drawing.Point(1497, 651);
            this.btn_search_Installments.Name = "btn_search_Installments";
            this.btn_search_Installments.Size = new System.Drawing.Size(103, 40);
            this.btn_search_Installments.TabIndex = 57;
            this.btn_search_Installments.Text = "بحث";
            this.btn_search_Installments.UseVisualStyleBackColor = true;
            this.btn_search_Installments.Click += new System.EventHandler(this.Btn_search_Installments_Click);
            // 
            // search_Installments
            // 
            this.search_Installments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_Installments.Location = new System.Drawing.Point(1626, 651);
            this.search_Installments.Name = "search_Installments";
            this.search_Installments.Size = new System.Drawing.Size(268, 36);
            this.search_Installments.TabIndex = 56;
            // 
            // dataGridView1_add_Installments
            // 
            this.dataGridView1_add_Installments.AllowUserToAddRows = false;
            this.dataGridView1_add_Installments.AllowUserToDeleteRows = false;
            this.dataGridView1_add_Installments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_add_Installments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1_add_Installments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_add_Installments.Location = new System.Drawing.Point(394, 291);
            this.dataGridView1_add_Installments.Name = "dataGridView1_add_Installments";
            this.dataGridView1_add_Installments.ReadOnly = true;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridView1_add_Installments.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1_add_Installments.RowTemplate.Height = 25;
            this.dataGridView1_add_Installments.Size = new System.Drawing.Size(1500, 354);
            this.dataGridView1_add_Installments.TabIndex = 55;
            this.dataGridView1_add_Installments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_add_Installments_CellContentClick);
            // 
            // update_save_Installments
            // 
            this.update_save_Installments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_save_Installments.Location = new System.Drawing.Point(1279, 651);
            this.update_save_Installments.Name = "update_save_Installments";
            this.update_save_Installments.Size = new System.Drawing.Size(103, 40);
            this.update_save_Installments.TabIndex = 54;
            this.update_save_Installments.Text = "تعديل";
            this.update_save_Installments.UseVisualStyleBackColor = true;
            this.update_save_Installments.Click += new System.EventHandler(this.Update_save_Installments_Click);
            // 
            // delete_save_Installments
            // 
            this.delete_save_Installments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_save_Installments.Location = new System.Drawing.Point(1388, 651);
            this.delete_save_Installments.Name = "delete_save_Installments";
            this.delete_save_Installments.Size = new System.Drawing.Size(103, 40);
            this.delete_save_Installments.TabIndex = 53;
            this.delete_save_Installments.Text = "حذف";
            this.delete_save_Installments.UseVisualStyleBackColor = true;
            this.delete_save_Installments.Click += new System.EventHandler(this.Delete_save_Installments_Click);
            // 
            // add_save_Installments
            // 
            this.add_save_Installments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_save_Installments.Location = new System.Drawing.Point(1170, 651);
            this.add_save_Installments.Name = "add_save_Installments";
            this.add_save_Installments.Size = new System.Drawing.Size(103, 40);
            this.add_save_Installments.TabIndex = 52;
            this.add_save_Installments.Text = "اضافة";
            this.add_save_Installments.UseVisualStyleBackColor = true;
            this.add_save_Installments.Click += new System.EventHandler(this.Add_save_Installments_Click);
            // 
            // Advance_Payment_Date
            // 
            this.Advance_Payment_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Advance_Payment_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Advance_Payment_Date.Location = new System.Drawing.Point(1456, 135);
            this.Advance_Payment_Date.Name = "Advance_Payment_Date";
            this.Advance_Payment_Date.Size = new System.Drawing.Size(306, 36);
            this.Advance_Payment_Date.TabIndex = 18;
            // 
            // Advance_Payment_Value
            // 
            this.Advance_Payment_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Advance_Payment_Value.Location = new System.Drawing.Point(1456, 83);
            this.Advance_Payment_Value.Name = "Advance_Payment_Value";
            this.Advance_Payment_Value.Size = new System.Drawing.Size(306, 36);
            this.Advance_Payment_Value.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1816, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ السلفة";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1825, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "قيمة السلفة";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1814, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الموظف";
            // 
            // Installments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 756);
            this.Controls.Add(this.tabControl1);
            this.Name = "Installments";
            this.Text = "سلف";
            this.Load += new System.EventHandler(this.Installments_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_Installments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Advance_Payment_Value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Advance_Payment_Date;
        private System.Windows.Forms.Button btn_search_Installments;
        private System.Windows.Forms.TextBox search_Installments;
        private System.Windows.Forms.DataGridView dataGridView1_add_Installments;
        private System.Windows.Forms.Button update_save_Installments;
        private System.Windows.Forms.Button delete_save_Installments;
        private System.Windows.Forms.Button add_save_Installments;
        private System.Windows.Forms.ComboBox Employee_Name;
    }
}