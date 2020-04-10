namespace Elfath_Plastic.Forms
{
    partial class products_store
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Product_Name = new System.Windows.Forms.TextBox();
            this.btn_search_products_store = new System.Windows.Forms.Button();
            this.search_products_store = new System.Windows.Forms.TextBox();
            this.dataGridView1_add_products_store = new System.Windows.Forms.DataGridView();
            this.update_save_products_store = new System.Windows.Forms.Button();
            this.delete_save_products_store = new System.Windows.Forms.Button();
            this.add_save_products_store = new System.Windows.Forms.Button();
            this.Last_Check_Date = new System.Windows.Forms.DateTimePicker();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_products_store)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Product_Name);
            this.tabPage1.Controls.Add(this.btn_search_products_store);
            this.tabPage1.Controls.Add(this.search_products_store);
            this.tabPage1.Controls.Add(this.dataGridView1_add_products_store);
            this.tabPage1.Controls.Add(this.update_save_products_store);
            this.tabPage1.Controls.Add(this.delete_save_products_store);
            this.tabPage1.Controls.Add(this.add_save_products_store);
            this.tabPage1.Controls.Add(this.Last_Check_Date);
            this.tabPage1.Controls.Add(this.Quantity);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1916, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة وتعديل";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Product_Name
            // 
            this.Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Product_Name.Location = new System.Drawing.Point(1456, 21);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(306, 36);
            this.Product_Name.TabIndex = 59;
            // 
            // btn_search_products_store
            // 
            this.btn_search_products_store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_products_store.Location = new System.Drawing.Point(1496, 572);
            this.btn_search_products_store.Name = "btn_search_products_store";
            this.btn_search_products_store.Size = new System.Drawing.Size(103, 40);
            this.btn_search_products_store.TabIndex = 57;
            this.btn_search_products_store.Text = "بحث";
            this.btn_search_products_store.UseVisualStyleBackColor = true;
            this.btn_search_products_store.Click += new System.EventHandler(this.Btn_search_products_store_Click);
            // 
            // search_products_store
            // 
            this.search_products_store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_products_store.Location = new System.Drawing.Point(1625, 572);
            this.search_products_store.Name = "search_products_store";
            this.search_products_store.Size = new System.Drawing.Size(268, 36);
            this.search_products_store.TabIndex = 56;
            // 
            // dataGridView1_add_products_store
            // 
            this.dataGridView1_add_products_store.AllowUserToAddRows = false;
            this.dataGridView1_add_products_store.AllowUserToDeleteRows = false;
            this.dataGridView1_add_products_store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_add_products_store.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1_add_products_store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_add_products_store.Location = new System.Drawing.Point(394, 212);
            this.dataGridView1_add_products_store.Name = "dataGridView1_add_products_store";
            this.dataGridView1_add_products_store.ReadOnly = true;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridView1_add_products_store.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1_add_products_store.RowTemplate.Height = 25;
            this.dataGridView1_add_products_store.Size = new System.Drawing.Size(1499, 354);
            this.dataGridView1_add_products_store.TabIndex = 55;
            this.dataGridView1_add_products_store.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_add_products_store_CellContentClick);
            // 
            // update_save_products_store
            // 
            this.update_save_products_store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_save_products_store.Location = new System.Drawing.Point(1278, 572);
            this.update_save_products_store.Name = "update_save_products_store";
            this.update_save_products_store.Size = new System.Drawing.Size(103, 40);
            this.update_save_products_store.TabIndex = 54;
            this.update_save_products_store.Text = "تعديل";
            this.update_save_products_store.UseVisualStyleBackColor = true;
            this.update_save_products_store.Click += new System.EventHandler(this.Update_save_products_store_Click);
            // 
            // delete_save_products_store
            // 
            this.delete_save_products_store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_save_products_store.Location = new System.Drawing.Point(1387, 572);
            this.delete_save_products_store.Name = "delete_save_products_store";
            this.delete_save_products_store.Size = new System.Drawing.Size(103, 40);
            this.delete_save_products_store.TabIndex = 53;
            this.delete_save_products_store.Text = "حذف";
            this.delete_save_products_store.UseVisualStyleBackColor = true;
            this.delete_save_products_store.Click += new System.EventHandler(this.Delete_save_products_store_Click);
            // 
            // add_save_products_store
            // 
            this.add_save_products_store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_save_products_store.Location = new System.Drawing.Point(1169, 572);
            this.add_save_products_store.Name = "add_save_products_store";
            this.add_save_products_store.Size = new System.Drawing.Size(103, 40);
            this.add_save_products_store.TabIndex = 52;
            this.add_save_products_store.Text = "اضافة";
            this.add_save_products_store.UseVisualStyleBackColor = true;
            this.add_save_products_store.Click += new System.EventHandler(this.Add_save_products_store_Click);
            // 
            // Last_Check_Date
            // 
            this.Last_Check_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Last_Check_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Last_Check_Date.Location = new System.Drawing.Point(1456, 139);
            this.Last_Check_Date.Name = "Last_Check_Date";
            this.Last_Check_Date.Size = new System.Drawing.Size(306, 36);
            this.Last_Check_Date.TabIndex = 16;
            // 
            // Quantity
            // 
            this.Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantity.Location = new System.Drawing.Point(1456, 78);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(306, 36);
            this.Quantity.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1781, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "تاريخ اخر تحديث";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1853, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "الكمية";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1826, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المنتج";
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
            this.tabControl1.TabIndex = 2;
            // 
            // products_store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 699);
            this.Controls.Add(this.tabControl1);
            this.Name = "products_store";
            this.Text = "مخزن المنتجات";
            this.Load += new System.EventHandler(this.Products_store_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_products_store)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DateTimePicker Last_Check_Date;
        private System.Windows.Forms.Button btn_search_products_store;
        private System.Windows.Forms.TextBox search_products_store;
        private System.Windows.Forms.DataGridView dataGridView1_add_products_store;
        private System.Windows.Forms.Button update_save_products_store;
        private System.Windows.Forms.Button delete_save_products_store;
        private System.Windows.Forms.Button add_save_products_store;
        private System.Windows.Forms.TextBox Product_Name;
    }
}