namespace Elfath_Plastic.Forms
{
    partial class materials
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
            this.Notes = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Material_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_search_materials = new System.Windows.Forms.Button();
            this.search_materials = new System.Windows.Forms.TextBox();
            this.dataGridView1_add_materials = new System.Windows.Forms.DataGridView();
            this.update_save_materials = new System.Windows.Forms.Button();
            this.delete_save_materials = new System.Windows.Forms.Button();
            this.add_save_materials = new System.Windows.Forms.Button();
            this.Weight = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_materials)).BeginInit();
            this.SuspendLayout();
            // 
            // Notes
            // 
            this.Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Notes.Location = new System.Drawing.Point(912, 21);
            this.Notes.Multiline = true;
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(306, 101);
            this.Notes.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1269, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 24);
            this.label14.TabIndex = 42;
            this.label14.Text = "ملاحظات";
            // 
            // Price
            // 
            this.Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Price.Location = new System.Drawing.Point(1435, 136);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(306, 36);
            this.Price.TabIndex = 18;
            // 
            // Material_Name
            // 
            this.Material_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Material_Name.Location = new System.Drawing.Point(1435, 21);
            this.Material_Name.Name = "Material_Name";
            this.Material_Name.Size = new System.Drawing.Size(306, 36);
            this.Material_Name.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1835, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "السعر";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1834, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "الوزن";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1805, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع الخامة";
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
            this.tabControl1.Size = new System.Drawing.Size(1924, 991);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.btn_search_materials);
            this.tabPage1.Controls.Add(this.search_materials);
            this.tabPage1.Controls.Add(this.dataGridView1_add_materials);
            this.tabPage1.Controls.Add(this.update_save_materials);
            this.tabPage1.Controls.Add(this.delete_save_materials);
            this.tabPage1.Controls.Add(this.add_save_materials);
            this.tabPage1.Controls.Add(this.Notes);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.Price);
            this.tabPage1.Controls.Add(this.Weight);
            this.tabPage1.Controls.Add(this.Material_Name);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1916, 949);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة وتعديل";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_search_materials
            // 
            this.btn_search_materials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_materials.Location = new System.Drawing.Point(1475, 606);
            this.btn_search_materials.Name = "btn_search_materials";
            this.btn_search_materials.Size = new System.Drawing.Size(103, 40);
            this.btn_search_materials.TabIndex = 57;
            this.btn_search_materials.Text = "بحث";
            this.btn_search_materials.UseVisualStyleBackColor = true;
            this.btn_search_materials.Click += new System.EventHandler(this.Btn_search_materials_Click);
            // 
            // search_materials
            // 
            this.search_materials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_materials.Location = new System.Drawing.Point(1604, 606);
            this.search_materials.Name = "search_materials";
            this.search_materials.Size = new System.Drawing.Size(268, 36);
            this.search_materials.TabIndex = 56;
            // 
            // dataGridView1_add_materials
            // 
            this.dataGridView1_add_materials.AllowUserToAddRows = false;
            this.dataGridView1_add_materials.AllowUserToDeleteRows = false;
            this.dataGridView1_add_materials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_add_materials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1_add_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_add_materials.Location = new System.Drawing.Point(290, 246);
            this.dataGridView1_add_materials.Name = "dataGridView1_add_materials";
            this.dataGridView1_add_materials.ReadOnly = true;
            this.dataGridView1_add_materials.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1_add_materials.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridView1_add_materials.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1_add_materials.RowTemplate.Height = 25;
            this.dataGridView1_add_materials.Size = new System.Drawing.Size(1582, 354);
            this.dataGridView1_add_materials.TabIndex = 55;
            this.dataGridView1_add_materials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_add_materials_CellContentClick);
            // 
            // update_save_materials
            // 
            this.update_save_materials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_save_materials.Location = new System.Drawing.Point(1257, 606);
            this.update_save_materials.Name = "update_save_materials";
            this.update_save_materials.Size = new System.Drawing.Size(103, 40);
            this.update_save_materials.TabIndex = 54;
            this.update_save_materials.Text = "تعديل";
            this.update_save_materials.UseVisualStyleBackColor = true;
            this.update_save_materials.Click += new System.EventHandler(this.Update_save_materials_Click);
            // 
            // delete_save_materials
            // 
            this.delete_save_materials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_save_materials.Location = new System.Drawing.Point(1366, 606);
            this.delete_save_materials.Name = "delete_save_materials";
            this.delete_save_materials.Size = new System.Drawing.Size(103, 40);
            this.delete_save_materials.TabIndex = 53;
            this.delete_save_materials.Text = "حذف";
            this.delete_save_materials.UseVisualStyleBackColor = true;
            this.delete_save_materials.Click += new System.EventHandler(this.Delete_save_materials_Click);
            // 
            // add_save_materials
            // 
            this.add_save_materials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_save_materials.Location = new System.Drawing.Point(1148, 606);
            this.add_save_materials.Name = "add_save_materials";
            this.add_save_materials.Size = new System.Drawing.Size(103, 40);
            this.add_save_materials.TabIndex = 52;
            this.add_save_materials.Text = "اضافة";
            this.add_save_materials.UseVisualStyleBackColor = true;
            this.add_save_materials.Click += new System.EventHandler(this.Add_save_materials_Click);
            // 
            // Weight
            // 
            this.Weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Weight.Location = new System.Drawing.Point(1435, 86);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(306, 36);
            this.Weight.TabIndex = 17;
            // 
            // materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 991);
            this.Controls.Add(this.tabControl1);
            this.Name = "materials";
            this.Text = "الخامات";
            this.Load += new System.EventHandler(this.Materials_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_materials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Material_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_search_materials;
        private System.Windows.Forms.TextBox search_materials;
        private System.Windows.Forms.DataGridView dataGridView1_add_materials;
        private System.Windows.Forms.Button update_save_materials;
        private System.Windows.Forms.Button delete_save_materials;
        private System.Windows.Forms.Button add_save_materials;
        private System.Windows.Forms.TextBox Weight;
    }
}