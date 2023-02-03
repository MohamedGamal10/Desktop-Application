namespace Elfath_Plastic.Forms
{
    partial class Revenues
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
            this.print = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cal_label = new System.Windows.Forms.Label();
            this.cal = new System.Windows.Forms.Button();
            this.search_from_to = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Revenues_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_search_Revenues = new System.Windows.Forms.Button();
            this.search_Revenues = new System.Windows.Forms.TextBox();
            this.dataGridView1_add_Revenues = new System.Windows.Forms.DataGridView();
            this.update_save_Revenues = new System.Windows.Forms.Button();
            this.delete_save_Revenues = new System.Windows.Forms.Button();
            this.add_save_Revenues = new System.Windows.Forms.Button();
            this.Revenues_Value = new System.Windows.Forms.TextBox();
            this.Revenues_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_Revenues)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1921, 899);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.print);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cal_label);
            this.tabPage1.Controls.Add(this.cal);
            this.tabPage1.Controls.Add(this.search_from_to);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.to);
            this.tabPage1.Controls.Add(this.from);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Revenues_Date);
            this.tabPage1.Controls.Add(this.btn_search_Revenues);
            this.tabPage1.Controls.Add(this.search_Revenues);
            this.tabPage1.Controls.Add(this.dataGridView1_add_Revenues);
            this.tabPage1.Controls.Add(this.update_save_Revenues);
            this.tabPage1.Controls.Add(this.delete_save_Revenues);
            this.tabPage1.Controls.Add(this.add_save_Revenues);
            this.tabPage1.Controls.Add(this.Revenues_Value);
            this.tabPage1.Controls.Add(this.Revenues_Name);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1913, 857);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة وتعديل";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // print
            // 
            this.print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print.Location = new System.Drawing.Point(1060, 642);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(103, 40);
            this.print.TabIndex = 77;
            this.print.Text = "طباعة";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.Print_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(905, 783);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 29);
            this.label6.TabIndex = 76;
            this.label6.Text = "جنية";
            // 
            // cal_label
            // 
            this.cal_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cal_label.AutoSize = true;
            this.cal_label.Location = new System.Drawing.Point(996, 783);
            this.cal_label.Name = "cal_label";
            this.cal_label.Size = new System.Drawing.Size(21, 29);
            this.cal_label.TabIndex = 75;
            this.cal_label.Text = "-";
            // 
            // cal
            // 
            this.cal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cal.Location = new System.Drawing.Point(1110, 777);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(103, 40);
            this.cal.TabIndex = 74;
            this.cal.Text = "تجميع";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.Cal_Click);
            // 
            // search_from_to
            // 
            this.search_from_to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_from_to.Location = new System.Drawing.Point(1219, 776);
            this.search_from_to.Name = "search_from_to";
            this.search_from_to.Size = new System.Drawing.Size(103, 40);
            this.search_from_to.TabIndex = 73;
            this.search_from_to.Text = "بحث";
            this.search_from_to.UseVisualStyleBackColor = true;
            this.search_from_to.Click += new System.EventHandler(this.Search_from_to_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1549, 776);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 29);
            this.label15.TabIndex = 72;
            this.label15.Text = "الي";
            // 
            // to
            // 
            this.to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to.Location = new System.Drawing.Point(1328, 776);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(200, 36);
            this.to.TabIndex = 71;
            // 
            // from
            // 
            this.from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from.Location = new System.Drawing.Point(1628, 776);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(200, 36);
            this.from.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1834, 776);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 29);
            this.label11.TabIndex = 69;
            this.label11.Text = "من";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1792, 642);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "بيان الايراد";
            // 
            // Revenues_Date
            // 
            this.Revenues_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Revenues_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Revenues_Date.Location = new System.Drawing.Point(1427, 143);
            this.Revenues_Date.Name = "Revenues_Date";
            this.Revenues_Date.Size = new System.Drawing.Size(306, 36);
            this.Revenues_Date.TabIndex = 52;
            // 
            // btn_search_Revenues
            // 
            this.btn_search_Revenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_Revenues.Location = new System.Drawing.Point(1325, 642);
            this.btn_search_Revenues.Name = "btn_search_Revenues";
            this.btn_search_Revenues.Size = new System.Drawing.Size(103, 40);
            this.btn_search_Revenues.TabIndex = 51;
            this.btn_search_Revenues.Text = "بحث";
            this.btn_search_Revenues.UseVisualStyleBackColor = true;
            this.btn_search_Revenues.Click += new System.EventHandler(this.Btn_search_Revenues_Click);
            // 
            // search_Revenues
            // 
            this.search_Revenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_Revenues.Location = new System.Drawing.Point(1482, 642);
            this.search_Revenues.Name = "search_Revenues";
            this.search_Revenues.Size = new System.Drawing.Size(268, 36);
            this.search_Revenues.TabIndex = 50;
            // 
            // dataGridView1_add_Revenues
            // 
            this.dataGridView1_add_Revenues.AllowUserToAddRows = false;
            this.dataGridView1_add_Revenues.AllowUserToDeleteRows = false;
            this.dataGridView1_add_Revenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1_add_Revenues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_add_Revenues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1_add_Revenues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_add_Revenues.Location = new System.Drawing.Point(933, 238);
            this.dataGridView1_add_Revenues.Name = "dataGridView1_add_Revenues";
            this.dataGridView1_add_Revenues.ReadOnly = true;
            this.dataGridView1_add_Revenues.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1_add_Revenues.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridView1_add_Revenues.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1_add_Revenues.RowTemplate.Height = 25;
            this.dataGridView1_add_Revenues.Size = new System.Drawing.Size(932, 354);
            this.dataGridView1_add_Revenues.TabIndex = 49;
            this.dataGridView1_add_Revenues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_add_Revenues_CellContentClick);
            // 
            // update_save_Revenues
            // 
            this.update_save_Revenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_save_Revenues.Location = new System.Drawing.Point(1060, 688);
            this.update_save_Revenues.Name = "update_save_Revenues";
            this.update_save_Revenues.Size = new System.Drawing.Size(103, 40);
            this.update_save_Revenues.TabIndex = 47;
            this.update_save_Revenues.Text = "تعديل";
            this.update_save_Revenues.UseVisualStyleBackColor = true;
            this.update_save_Revenues.Click += new System.EventHandler(this.Update_save_Revenues_Click);
            // 
            // delete_save_Revenues
            // 
            this.delete_save_Revenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_save_Revenues.Location = new System.Drawing.Point(933, 642);
            this.delete_save_Revenues.Name = "delete_save_Revenues";
            this.delete_save_Revenues.Size = new System.Drawing.Size(103, 40);
            this.delete_save_Revenues.TabIndex = 46;
            this.delete_save_Revenues.Text = "حذف";
            this.delete_save_Revenues.UseVisualStyleBackColor = true;
            this.delete_save_Revenues.Click += new System.EventHandler(this.Delete_save_Revenues_Click);
            // 
            // add_save_Revenues
            // 
            this.add_save_Revenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_save_Revenues.Location = new System.Drawing.Point(933, 688);
            this.add_save_Revenues.Name = "add_save_Revenues";
            this.add_save_Revenues.Size = new System.Drawing.Size(103, 40);
            this.add_save_Revenues.TabIndex = 41;
            this.add_save_Revenues.Text = "اضافة";
            this.add_save_Revenues.UseVisualStyleBackColor = true;
            this.add_save_Revenues.Click += new System.EventHandler(this.Add_save_Revenues_Click);
            // 
            // Revenues_Value
            // 
            this.Revenues_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Revenues_Value.Location = new System.Drawing.Point(1427, 83);
            this.Revenues_Value.Name = "Revenues_Value";
            this.Revenues_Value.Size = new System.Drawing.Size(306, 36);
            this.Revenues_Value.TabIndex = 14;
            // 
            // Revenues_Name
            // 
            this.Revenues_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Revenues_Name.Location = new System.Drawing.Point(1427, 21);
            this.Revenues_Name.Name = "Revenues_Name";
            this.Revenues_Name.Size = new System.Drawing.Size(306, 36);
            this.Revenues_Name.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1783, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "تاريخ الايراد";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1792, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "قيمة الايراد";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1792, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "بيان الايراد";
            // 
            // Revenues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1921, 899);
            this.Controls.Add(this.tabControl1);
            this.Name = "Revenues";
            this.Text = "الايرادات";
            this.Load += new System.EventHandler(this.Revenues_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_Revenues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_search_Revenues;
        private System.Windows.Forms.TextBox search_Revenues;
        private System.Windows.Forms.DataGridView dataGridView1_add_Revenues;
        private System.Windows.Forms.Button update_save_Revenues;
        private System.Windows.Forms.Button delete_save_Revenues;
        private System.Windows.Forms.Button add_save_Revenues;
        private System.Windows.Forms.TextBox Revenues_Value;
        private System.Windows.Forms.TextBox Revenues_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Revenues_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cal_label;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Button search_from_to;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button print;
    }
}