﻿namespace Elfath_Plastic.Forms
{
    partial class suppliers
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
            this.num_bank = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Mobile_Number = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.search_btn_display = new System.Windows.Forms.Button();
            this.search_display_suppliers = new System.Windows.Forms.TextBox();
            this.dataGridView1_display_suppliers = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1_add_suppliers = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.search_suppliers = new System.Windows.Forms.TextBox();
            this.update_save_clients = new System.Windows.Forms.Button();
            this.delete_save_clients = new System.Windows.Forms.Button();
            this.add_save_clients = new System.Windows.Forms.Button();
            this.Supplier_Name = new System.Windows.Forms.TextBox();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_display_suppliers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // num_bank
            // 
            this.num_bank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_bank.Location = new System.Drawing.Point(909, 18);
            this.num_bank.Name = "num_bank";
            this.num_bank.Size = new System.Drawing.Size(306, 36);
            this.num_bank.TabIndex = 20;
            // 
            // Address
            // 
            this.Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Address.Location = new System.Drawing.Point(909, 88);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(306, 36);
            this.Address.TabIndex = 18;
            // 
            // Mobile_Number
            // 
            this.Mobile_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mobile_Number.Location = new System.Drawing.Point(1456, 88);
            this.Mobile_Number.Name = "Mobile_Number";
            this.Mobile_Number.Size = new System.Drawing.Size(306, 36);
            this.Mobile_Number.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1270, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "رقم الحساب البنكي";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1340, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "العنوان";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1820, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "رقم الموبيل";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1826, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المورد";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.search_btn_display);
            this.tabPage3.Controls.Add(this.search_display_suppliers);
            this.tabPage3.Controls.Add(this.dataGridView1_display_suppliers);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1916, 703);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "كشف حساب";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // search_btn_display
            // 
            this.search_btn_display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn_display.Location = new System.Drawing.Point(1511, 14);
            this.search_btn_display.Name = "search_btn_display";
            this.search_btn_display.Size = new System.Drawing.Size(103, 40);
            this.search_btn_display.TabIndex = 58;
            this.search_btn_display.Text = "بحث";
            this.search_btn_display.UseVisualStyleBackColor = true;
            this.search_btn_display.Click += new System.EventHandler(this.Search_btn_display_Click);
            // 
            // search_display_suppliers
            // 
            this.search_display_suppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_display_suppliers.Location = new System.Drawing.Point(1640, 14);
            this.search_display_suppliers.Name = "search_display_suppliers";
            this.search_display_suppliers.Size = new System.Drawing.Size(268, 36);
            this.search_display_suppliers.TabIndex = 57;
            // 
            // dataGridView1_display_suppliers
            // 
            this.dataGridView1_display_suppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1_display_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_display_suppliers.Location = new System.Drawing.Point(241, 69);
            this.dataGridView1_display_suppliers.Name = "dataGridView1_display_suppliers";
            this.dataGridView1_display_suppliers.RowTemplate.Height = 24;
            this.dataGridView1_display_suppliers.Size = new System.Drawing.Size(1667, 533);
            this.dataGridView1_display_suppliers.TabIndex = 56;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1924, 745);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1_add_suppliers);
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.search_suppliers);
            this.tabPage1.Controls.Add(this.update_save_clients);
            this.tabPage1.Controls.Add(this.delete_save_clients);
            this.tabPage1.Controls.Add(this.add_save_clients);
            this.tabPage1.Controls.Add(this.num_bank);
            this.tabPage1.Controls.Add(this.Address);
            this.tabPage1.Controls.Add(this.Mobile_Number);
            this.tabPage1.Controls.Add(this.Supplier_Name);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1916, 703);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة وتعديل";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1_add_suppliers
            // 
            this.dataGridView1_add_suppliers.AllowUserToAddRows = false;
            this.dataGridView1_add_suppliers.AllowUserToDeleteRows = false;
            this.dataGridView1_add_suppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_add_suppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1_add_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_add_suppliers.Location = new System.Drawing.Point(319, 150);
            this.dataGridView1_add_suppliers.Name = "dataGridView1_add_suppliers";
            this.dataGridView1_add_suppliers.ReadOnly = true;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridView1_add_suppliers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1_add_suppliers.RowTemplate.Height = 25;
            this.dataGridView1_add_suppliers.Size = new System.Drawing.Size(1576, 354);
            this.dataGridView1_add_suppliers.TabIndex = 57;
            this.dataGridView1_add_suppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_add_suppliers_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(1488, 539);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(103, 40);
            this.btn_search.TabIndex = 56;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // search_suppliers
            // 
            this.search_suppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_suppliers.Location = new System.Drawing.Point(1627, 539);
            this.search_suppliers.Name = "search_suppliers";
            this.search_suppliers.Size = new System.Drawing.Size(268, 36);
            this.search_suppliers.TabIndex = 55;
            // 
            // update_save_clients
            // 
            this.update_save_clients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_save_clients.Location = new System.Drawing.Point(1270, 539);
            this.update_save_clients.Name = "update_save_clients";
            this.update_save_clients.Size = new System.Drawing.Size(103, 40);
            this.update_save_clients.TabIndex = 54;
            this.update_save_clients.Text = "تعديل";
            this.update_save_clients.UseVisualStyleBackColor = true;
            this.update_save_clients.Click += new System.EventHandler(this.Update_save_clients_Click);
            // 
            // delete_save_clients
            // 
            this.delete_save_clients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_save_clients.Location = new System.Drawing.Point(1379, 539);
            this.delete_save_clients.Name = "delete_save_clients";
            this.delete_save_clients.Size = new System.Drawing.Size(103, 40);
            this.delete_save_clients.TabIndex = 53;
            this.delete_save_clients.Text = "حذف";
            this.delete_save_clients.UseVisualStyleBackColor = true;
            this.delete_save_clients.Click += new System.EventHandler(this.Delete_save_clients_Click);
            // 
            // add_save_clients
            // 
            this.add_save_clients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_save_clients.Location = new System.Drawing.Point(1161, 539);
            this.add_save_clients.Name = "add_save_clients";
            this.add_save_clients.Size = new System.Drawing.Size(103, 40);
            this.add_save_clients.TabIndex = 52;
            this.add_save_clients.Text = "اضافة";
            this.add_save_clients.UseVisualStyleBackColor = true;
            this.add_save_clients.Click += new System.EventHandler(this.Add_save_clients_Click);
            // 
            // Supplier_Name
            // 
            this.Supplier_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Supplier_Name.Location = new System.Drawing.Point(1456, 21);
            this.Supplier_Name.Name = "Supplier_Name";
            this.Supplier_Name.Size = new System.Drawing.Size(306, 36);
            this.Supplier_Name.TabIndex = 13;
            // 
            // suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 745);
            this.Controls.Add(this.tabControl1);
            this.Name = "suppliers";
            this.Text = "الموردين";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_display_suppliers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_suppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox num_bank;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Mobile_Number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Supplier_Name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox search_suppliers;
        private System.Windows.Forms.Button update_save_clients;
        private System.Windows.Forms.Button delete_save_clients;
        private System.Windows.Forms.Button add_save_clients;
        private System.Windows.Forms.DataGridView dataGridView1_add_suppliers;
        private System.Windows.Forms.Button search_btn_display;
        private System.Windows.Forms.TextBox search_display_suppliers;
        private System.Windows.Forms.DataGridView dataGridView1_display_suppliers;
    }
}