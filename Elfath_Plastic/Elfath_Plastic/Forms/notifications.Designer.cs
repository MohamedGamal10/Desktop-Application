namespace Elfath_Plastic.Forms
{
    partial class notifications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Notice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Notice_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.Notice_End_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_search_Notice = new System.Windows.Forms.Button();
            this.search_Notice = new System.Windows.Forms.TextBox();
            this.dataGridView1_add_Notice = new System.Windows.Forms.DataGridView();
            this.update_save_Notice = new System.Windows.Forms.Button();
            this.delete_save_Notice = new System.Windows.Forms.Button();
            this.add_save_clients_Notice = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_Notice)).BeginInit();
            this.SuspendLayout();
            // 
            // Notice
            // 
            this.Notice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Notice.Location = new System.Drawing.Point(1456, 21);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(306, 36);
            this.Notice.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1778, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "اليوم الاخير للتنبية";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1784, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "اليوم الاول للتنبية";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1853, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "التنبية";
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
            this.tabControl1.Size = new System.Drawing.Size(1924, 699);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_search_Notice);
            this.tabPage1.Controls.Add(this.search_Notice);
            this.tabPage1.Controls.Add(this.dataGridView1_add_Notice);
            this.tabPage1.Controls.Add(this.update_save_Notice);
            this.tabPage1.Controls.Add(this.delete_save_Notice);
            this.tabPage1.Controls.Add(this.add_save_clients_Notice);
            this.tabPage1.Controls.Add(this.Notice_End_Date);
            this.tabPage1.Controls.Add(this.Notice_Start_Date);
            this.tabPage1.Controls.Add(this.Notice);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1916, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة وتعديل";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Notice_Start_Date
            // 
            this.Notice_Start_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Notice_Start_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Notice_Start_Date.Location = new System.Drawing.Point(1456, 83);
            this.Notice_Start_Date.Name = "Notice_Start_Date";
            this.Notice_Start_Date.Size = new System.Drawing.Size(306, 36);
            this.Notice_Start_Date.TabIndex = 16;
            // 
            // Notice_End_Date
            // 
            this.Notice_End_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Notice_End_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Notice_End_Date.Location = new System.Drawing.Point(1456, 147);
            this.Notice_End_Date.Name = "Notice_End_Date";
            this.Notice_End_Date.Size = new System.Drawing.Size(306, 36);
            this.Notice_End_Date.TabIndex = 17;
            // 
            // btn_search_Notice
            // 
            this.btn_search_Notice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_Notice.Location = new System.Drawing.Point(1497, 580);
            this.btn_search_Notice.Name = "btn_search_Notice";
            this.btn_search_Notice.Size = new System.Drawing.Size(103, 40);
            this.btn_search_Notice.TabIndex = 57;
            this.btn_search_Notice.Text = "بحث";
            this.btn_search_Notice.UseVisualStyleBackColor = true;
            this.btn_search_Notice.Click += new System.EventHandler(this.Btn_search_Notice_Click);
            // 
            // search_Notice
            // 
            this.search_Notice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_Notice.Location = new System.Drawing.Point(1626, 580);
            this.search_Notice.Name = "search_Notice";
            this.search_Notice.Size = new System.Drawing.Size(268, 36);
            this.search_Notice.TabIndex = 56;
            // 
            // dataGridView1_add_Notice
            // 
            this.dataGridView1_add_Notice.AllowUserToAddRows = false;
            this.dataGridView1_add_Notice.AllowUserToDeleteRows = false;
            this.dataGridView1_add_Notice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_add_Notice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1_add_Notice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_add_Notice.Location = new System.Drawing.Point(332, 220);
            this.dataGridView1_add_Notice.Name = "dataGridView1_add_Notice";
            this.dataGridView1_add_Notice.ReadOnly = true;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridView1_add_Notice.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1_add_Notice.RowTemplate.Height = 25;
            this.dataGridView1_add_Notice.Size = new System.Drawing.Size(1562, 354);
            this.dataGridView1_add_Notice.TabIndex = 55;
            this.dataGridView1_add_Notice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_add_Notice_CellContentClick);
            // 
            // update_save_Notice
            // 
            this.update_save_Notice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_save_Notice.Location = new System.Drawing.Point(1279, 580);
            this.update_save_Notice.Name = "update_save_Notice";
            this.update_save_Notice.Size = new System.Drawing.Size(103, 40);
            this.update_save_Notice.TabIndex = 54;
            this.update_save_Notice.Text = "تعديل";
            this.update_save_Notice.UseVisualStyleBackColor = true;
            this.update_save_Notice.Click += new System.EventHandler(this.Update_save_Notice_Click);
            // 
            // delete_save_Notice
            // 
            this.delete_save_Notice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_save_Notice.Location = new System.Drawing.Point(1388, 580);
            this.delete_save_Notice.Name = "delete_save_Notice";
            this.delete_save_Notice.Size = new System.Drawing.Size(103, 40);
            this.delete_save_Notice.TabIndex = 53;
            this.delete_save_Notice.Text = "حذف";
            this.delete_save_Notice.UseVisualStyleBackColor = true;
            this.delete_save_Notice.Click += new System.EventHandler(this.Delete_save_Notice_Click);
            // 
            // add_save_clients_Notice
            // 
            this.add_save_clients_Notice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_save_clients_Notice.Location = new System.Drawing.Point(1170, 580);
            this.add_save_clients_Notice.Name = "add_save_clients_Notice";
            this.add_save_clients_Notice.Size = new System.Drawing.Size(103, 40);
            this.add_save_clients_Notice.TabIndex = 52;
            this.add_save_clients_Notice.Text = "اضافة";
            this.add_save_clients_Notice.UseVisualStyleBackColor = true;
            this.add_save_clients_Notice.Click += new System.EventHandler(this.Add_save_clients_Notice_Click);
            // 
            // notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 699);
            this.Controls.Add(this.tabControl1);
            this.Name = "notifications";
            this.Text = "التنبيهات";
            this.Load += new System.EventHandler(this.Notifications_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_Notice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Notice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker Notice_End_Date;
        private System.Windows.Forms.DateTimePicker Notice_Start_Date;
        private System.Windows.Forms.Button btn_search_Notice;
        private System.Windows.Forms.TextBox search_Notice;
        private System.Windows.Forms.DataGridView dataGridView1_add_Notice;
        private System.Windows.Forms.Button update_save_Notice;
        private System.Windows.Forms.Button delete_save_Notice;
        private System.Windows.Forms.Button add_save_clients_Notice;
    }
}