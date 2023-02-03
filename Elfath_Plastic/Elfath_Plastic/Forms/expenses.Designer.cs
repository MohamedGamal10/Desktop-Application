namespace Elfath_Plastic.Forms
{
    partial class expenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Expense_Value = new System.Windows.Forms.TextBox();
            this.Expense_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cal_label = new System.Windows.Forms.Label();
            this.cal = new System.Windows.Forms.Button();
            this.search_from_to = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.Expense_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_search_Expenses = new System.Windows.Forms.Button();
            this.search_Expenses = new System.Windows.Forms.TextBox();
            this.dataGridView1_add_Expenses = new System.Windows.Forms.DataGridView();
            this.update_save_Expenses = new System.Windows.Forms.Button();
            this.delete_save_Expenses = new System.Windows.Forms.Button();
            this.add_save_Expenses = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_Expenses)).BeginInit();
            this.SuspendLayout();
            // 
            // Expense_Value
            // 
            this.Expense_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Expense_Value.Location = new System.Drawing.Point(1439, 83);
            this.Expense_Value.Name = "Expense_Value";
            this.Expense_Value.Size = new System.Drawing.Size(306, 36);
            this.Expense_Value.TabIndex = 14;
            // 
            // Expense_Name
            // 
            this.Expense_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Expense_Name.Location = new System.Drawing.Point(1439, 21);
            this.Expense_Name.Name = "Expense_Name";
            this.Expense_Name.Size = new System.Drawing.Size(306, 36);
            this.Expense_Name.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1781, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ الصرف";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1835, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "القيمة";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1780, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "بيان المصروف";
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
            this.tabControl1.Size = new System.Drawing.Size(1924, 986);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cal_label);
            this.tabPage1.Controls.Add(this.cal);
            this.tabPage1.Controls.Add(this.search_from_to);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.to);
            this.tabPage1.Controls.Add(this.from);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.print);
            this.tabPage1.Controls.Add(this.Expense_Date);
            this.tabPage1.Controls.Add(this.btn_search_Expenses);
            this.tabPage1.Controls.Add(this.search_Expenses);
            this.tabPage1.Controls.Add(this.dataGridView1_add_Expenses);
            this.tabPage1.Controls.Add(this.update_save_Expenses);
            this.tabPage1.Controls.Add(this.delete_save_Expenses);
            this.tabPage1.Controls.Add(this.add_save_Expenses);
            this.tabPage1.Controls.Add(this.Expense_Value);
            this.tabPage1.Controls.Add(this.Expense_Name);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1916, 944);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة وتعديل";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(919, 748);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 29);
            this.label6.TabIndex = 68;
            this.label6.Text = "جنية";
            // 
            // cal_label
            // 
            this.cal_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cal_label.AutoSize = true;
            this.cal_label.Location = new System.Drawing.Point(974, 748);
            this.cal_label.Name = "cal_label";
            this.cal_label.Size = new System.Drawing.Size(21, 29);
            this.cal_label.TabIndex = 67;
            this.cal_label.Text = "-";
            // 
            // cal
            // 
            this.cal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cal.Location = new System.Drawing.Point(1112, 742);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(103, 40);
            this.cal.TabIndex = 66;
            this.cal.Text = "تجميع";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.Cal_Click);
            // 
            // search_from_to
            // 
            this.search_from_to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_from_to.Location = new System.Drawing.Point(1221, 742);
            this.search_from_to.Name = "search_from_to";
            this.search_from_to.Size = new System.Drawing.Size(103, 40);
            this.search_from_to.TabIndex = 65;
            this.search_from_to.Text = "بحث";
            this.search_from_to.UseVisualStyleBackColor = true;
            this.search_from_to.Click += new System.EventHandler(this.Search_from_to_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1769, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 64;
            this.label4.Text = "بيان المصروف";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1551, 741);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 29);
            this.label15.TabIndex = 63;
            this.label15.Text = "الي";
            // 
            // to
            // 
            this.to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to.Location = new System.Drawing.Point(1330, 741);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(200, 36);
            this.to.TabIndex = 62;
            // 
            // from
            // 
            this.from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from.Location = new System.Drawing.Point(1630, 741);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(200, 36);
            this.from.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1836, 741);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 29);
            this.label11.TabIndex = 60;
            this.label11.Text = "من";
            // 
            // print
            // 
            this.print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print.Location = new System.Drawing.Point(1016, 600);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(103, 40);
            this.print.TabIndex = 59;
            this.print.Text = "طباعة";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Expense_Date
            // 
            this.Expense_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Expense_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Expense_Date.Location = new System.Drawing.Point(1439, 147);
            this.Expense_Date.Name = "Expense_Date";
            this.Expense_Date.Size = new System.Drawing.Size(306, 36);
            this.Expense_Date.TabIndex = 58;
            // 
            // btn_search_Expenses
            // 
            this.btn_search_Expenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_Expenses.Location = new System.Drawing.Point(1366, 604);
            this.btn_search_Expenses.Name = "btn_search_Expenses";
            this.btn_search_Expenses.Size = new System.Drawing.Size(103, 40);
            this.btn_search_Expenses.TabIndex = 57;
            this.btn_search_Expenses.Text = "بحث";
            this.btn_search_Expenses.UseVisualStyleBackColor = true;
            this.btn_search_Expenses.Click += new System.EventHandler(this.Btn_search_Expenses_Click);
            // 
            // search_Expenses
            // 
            this.search_Expenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_Expenses.Location = new System.Drawing.Point(1495, 604);
            this.search_Expenses.Name = "search_Expenses";
            this.search_Expenses.Size = new System.Drawing.Size(268, 36);
            this.search_Expenses.TabIndex = 56;
            // 
            // dataGridView1_add_Expenses
            // 
            this.dataGridView1_add_Expenses.AllowUserToAddRows = false;
            this.dataGridView1_add_Expenses.AllowUserToDeleteRows = false;
            this.dataGridView1_add_Expenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1_add_Expenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_add_Expenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1_add_Expenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_add_Expenses.Location = new System.Drawing.Point(907, 205);
            this.dataGridView1_add_Expenses.Name = "dataGridView1_add_Expenses";
            this.dataGridView1_add_Expenses.ReadOnly = true;
            this.dataGridView1_add_Expenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1_add_Expenses.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridView1_add_Expenses.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1_add_Expenses.RowTemplate.Height = 25;
            this.dataGridView1_add_Expenses.Size = new System.Drawing.Size(971, 354);
            this.dataGridView1_add_Expenses.TabIndex = 55;
            this.dataGridView1_add_Expenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_add_Expenses_CellContentClick);
            // 
            // update_save_Expenses
            // 
            this.update_save_Expenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_save_Expenses.Location = new System.Drawing.Point(1016, 646);
            this.update_save_Expenses.Name = "update_save_Expenses";
            this.update_save_Expenses.Size = new System.Drawing.Size(103, 40);
            this.update_save_Expenses.TabIndex = 54;
            this.update_save_Expenses.Text = "تعديل";
            this.update_save_Expenses.UseVisualStyleBackColor = true;
            this.update_save_Expenses.Click += new System.EventHandler(this.Update_save_Expenses_Click);
            // 
            // delete_save_Expenses
            // 
            this.delete_save_Expenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_save_Expenses.Location = new System.Drawing.Point(907, 600);
            this.delete_save_Expenses.Name = "delete_save_Expenses";
            this.delete_save_Expenses.Size = new System.Drawing.Size(103, 40);
            this.delete_save_Expenses.TabIndex = 53;
            this.delete_save_Expenses.Text = "حذف";
            this.delete_save_Expenses.UseVisualStyleBackColor = true;
            this.delete_save_Expenses.Click += new System.EventHandler(this.Delete_save_Expenses_Click);
            // 
            // add_save_Expenses
            // 
            this.add_save_Expenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_save_Expenses.Location = new System.Drawing.Point(907, 646);
            this.add_save_Expenses.Name = "add_save_Expenses";
            this.add_save_Expenses.Size = new System.Drawing.Size(103, 40);
            this.add_save_Expenses.TabIndex = 52;
            this.add_save_Expenses.Text = "اضافة";
            this.add_save_Expenses.UseVisualStyleBackColor = true;
            this.add_save_Expenses.Click += new System.EventHandler(this.Add_save_Expenses_Click);
            // 
            // expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 986);
            this.Controls.Add(this.tabControl1);
            this.Name = "expenses";
            this.Text = "مصروفات متنوعة";
            this.Load += new System.EventHandler(this.Expenses_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_Expenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Expense_Value;
        private System.Windows.Forms.TextBox Expense_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_search_Expenses;
        private System.Windows.Forms.TextBox search_Expenses;
        private System.Windows.Forms.DataGridView dataGridView1_add_Expenses;
        private System.Windows.Forms.Button update_save_Expenses;
        private System.Windows.Forms.Button delete_save_Expenses;
        private System.Windows.Forms.Button add_save_Expenses;
        private System.Windows.Forms.DateTimePicker Expense_Date;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button search_from_to;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cal_label;
        private System.Windows.Forms.Button cal;
    }
}