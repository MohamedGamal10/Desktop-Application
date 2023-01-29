namespace Elfath_Plastic.Forms
{
    partial class Penalties
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
            this.Penalty_Value = new System.Windows.Forms.TextBox();
            this.Penalty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Employee_Name = new System.Windows.Forms.ComboBox();
            this.Penalty_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_search_Penalties = new System.Windows.Forms.Button();
            this.search_Penalties = new System.Windows.Forms.TextBox();
            this.dataGridView1_add_Penalties = new System.Windows.Forms.DataGridView();
            this.update_save_Penalties = new System.Windows.Forms.Button();
            this.delete_save_Penalties = new System.Windows.Forms.Button();
            this.add_save_Penalties = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_Penalties)).BeginInit();
            this.SuspendLayout();
            // 
            // Penalty_Value
            // 
            this.Penalty_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Penalty_Value.Location = new System.Drawing.Point(1437, 254);
            this.Penalty_Value.Name = "Penalty_Value";
            this.Penalty_Value.Size = new System.Drawing.Size(306, 36);
            this.Penalty_Value.TabIndex = 16;
            // 
            // Penalty
            // 
            this.Penalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Penalty.Location = new System.Drawing.Point(1437, 83);
            this.Penalty.Multiline = true;
            this.Penalty.Name = "Penalty";
            this.Penalty.Size = new System.Drawing.Size(306, 70);
            this.Penalty.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1805, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "قيمة الجزاء";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1792, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ الجزاء";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1833, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "الجزاء";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1795, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الموظف";
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
            this.tabControl1.Size = new System.Drawing.Size(1924, 780);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.Employee_Name);
            this.tabPage1.Controls.Add(this.Penalty_Date);
            this.tabPage1.Controls.Add(this.btn_search_Penalties);
            this.tabPage1.Controls.Add(this.search_Penalties);
            this.tabPage1.Controls.Add(this.dataGridView1_add_Penalties);
            this.tabPage1.Controls.Add(this.update_save_Penalties);
            this.tabPage1.Controls.Add(this.delete_save_Penalties);
            this.tabPage1.Controls.Add(this.add_save_Penalties);
            this.tabPage1.Controls.Add(this.Penalty_Value);
            this.tabPage1.Controls.Add(this.Penalty);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1916, 738);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة وتعديل";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Employee_Name
            // 
            this.Employee_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Employee_Name.FormattingEnabled = true;
            this.Employee_Name.Location = new System.Drawing.Point(1437, 21);
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.Size = new System.Drawing.Size(306, 37);
            this.Employee_Name.TabIndex = 59;
            // 
            // Penalty_Date
            // 
            this.Penalty_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Penalty_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Penalty_Date.Location = new System.Drawing.Point(1437, 193);
            this.Penalty_Date.Name = "Penalty_Date";
            this.Penalty_Date.Size = new System.Drawing.Size(306, 36);
            this.Penalty_Date.TabIndex = 58;
            // 
            // btn_search_Penalties
            // 
            this.btn_search_Penalties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_Penalties.Location = new System.Drawing.Point(1482, 677);
            this.btn_search_Penalties.Name = "btn_search_Penalties";
            this.btn_search_Penalties.Size = new System.Drawing.Size(103, 40);
            this.btn_search_Penalties.TabIndex = 57;
            this.btn_search_Penalties.Text = "بحث";
            this.btn_search_Penalties.UseVisualStyleBackColor = true;
            this.btn_search_Penalties.Click += new System.EventHandler(this.Btn_search_Penalties_Click);
            // 
            // search_Penalties
            // 
            this.search_Penalties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_Penalties.Location = new System.Drawing.Point(1611, 677);
            this.search_Penalties.Name = "search_Penalties";
            this.search_Penalties.Size = new System.Drawing.Size(268, 36);
            this.search_Penalties.TabIndex = 56;
            // 
            // dataGridView1_add_Penalties
            // 
            this.dataGridView1_add_Penalties.AllowUserToAddRows = false;
            this.dataGridView1_add_Penalties.AllowUserToDeleteRows = false;
            this.dataGridView1_add_Penalties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_add_Penalties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1_add_Penalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_add_Penalties.Location = new System.Drawing.Point(291, 317);
            this.dataGridView1_add_Penalties.Name = "dataGridView1_add_Penalties";
            this.dataGridView1_add_Penalties.ReadOnly = true;
            this.dataGridView1_add_Penalties.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1_add_Penalties.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridView1_add_Penalties.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1_add_Penalties.RowTemplate.Height = 25;
            this.dataGridView1_add_Penalties.Size = new System.Drawing.Size(1588, 354);
            this.dataGridView1_add_Penalties.TabIndex = 55;
            this.dataGridView1_add_Penalties.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_add_Penalties_CellContentClick);
            // 
            // update_save_Penalties
            // 
            this.update_save_Penalties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_save_Penalties.Location = new System.Drawing.Point(1264, 677);
            this.update_save_Penalties.Name = "update_save_Penalties";
            this.update_save_Penalties.Size = new System.Drawing.Size(103, 40);
            this.update_save_Penalties.TabIndex = 54;
            this.update_save_Penalties.Text = "تعديل";
            this.update_save_Penalties.UseVisualStyleBackColor = true;
            this.update_save_Penalties.Click += new System.EventHandler(this.Update_save_Penalties_Click);
            // 
            // delete_save_Penalties
            // 
            this.delete_save_Penalties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_save_Penalties.Location = new System.Drawing.Point(1373, 677);
            this.delete_save_Penalties.Name = "delete_save_Penalties";
            this.delete_save_Penalties.Size = new System.Drawing.Size(103, 40);
            this.delete_save_Penalties.TabIndex = 53;
            this.delete_save_Penalties.Text = "حذف";
            this.delete_save_Penalties.UseVisualStyleBackColor = true;
            this.delete_save_Penalties.Click += new System.EventHandler(this.Delete_save_Penalties_Click);
            // 
            // add_save_Penalties
            // 
            this.add_save_Penalties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_save_Penalties.Location = new System.Drawing.Point(1155, 677);
            this.add_save_Penalties.Name = "add_save_Penalties";
            this.add_save_Penalties.Size = new System.Drawing.Size(103, 40);
            this.add_save_Penalties.TabIndex = 52;
            this.add_save_Penalties.Text = "اضافة";
            this.add_save_Penalties.UseVisualStyleBackColor = true;
            this.add_save_Penalties.Click += new System.EventHandler(this.Add_save_Penalties_Click);
            // 
            // Penalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 780);
            this.Controls.Add(this.tabControl1);
            this.Name = "Penalties";
            this.Text = "الجزاءات";
            this.Load += new System.EventHandler(this.Penalties_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_Penalties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Penalty_Value;
        private System.Windows.Forms.TextBox Penalty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_search_Penalties;
        private System.Windows.Forms.TextBox search_Penalties;
        private System.Windows.Forms.DataGridView dataGridView1_add_Penalties;
        private System.Windows.Forms.Button update_save_Penalties;
        private System.Windows.Forms.Button delete_save_Penalties;
        private System.Windows.Forms.Button add_save_Penalties;
        private System.Windows.Forms.DateTimePicker Penalty_Date;
        private System.Windows.Forms.ComboBox Employee_Name;
    }
}