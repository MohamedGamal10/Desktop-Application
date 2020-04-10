namespace Elfath_Plastic.Forms
{
    partial class user_panal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_search_panal = new System.Windows.Forms.Button();
            this.search_panal = new System.Windows.Forms.TextBox();
            this.dataGridView1_add_panal = new System.Windows.Forms.DataGridView();
            this.update_save_panal = new System.Windows.Forms.Button();
            this.delete_save_panal = new System.Windows.Forms.Button();
            this.add_save_panal = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_panal)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.Location = new System.Drawing.Point(1310, 89);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(306, 36);
            this.Password.TabIndex = 15;
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.Location = new System.Drawing.Point(1310, 25);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(306, 36);
            this.UserName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1685, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "كلمة السر";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1665, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المستخدم";
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
            this.tabControl1.Size = new System.Drawing.Size(1778, 760);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_search_panal);
            this.tabPage1.Controls.Add(this.search_panal);
            this.tabPage1.Controls.Add(this.dataGridView1_add_panal);
            this.tabPage1.Controls.Add(this.update_save_panal);
            this.tabPage1.Controls.Add(this.delete_save_panal);
            this.tabPage1.Controls.Add(this.add_save_panal);
            this.tabPage1.Controls.Add(this.Password);
            this.tabPage1.Controls.Add(this.UserName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1770, 718);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة وتعديل";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_search_panal
            // 
            this.btn_search_panal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_panal.Location = new System.Drawing.Point(1351, 579);
            this.btn_search_panal.Name = "btn_search_panal";
            this.btn_search_panal.Size = new System.Drawing.Size(103, 40);
            this.btn_search_panal.TabIndex = 57;
            this.btn_search_panal.Text = "بحث";
            this.btn_search_panal.UseVisualStyleBackColor = true;
            this.btn_search_panal.Click += new System.EventHandler(this.Btn_search_panal_Click);
            // 
            // search_panal
            // 
            this.search_panal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_panal.Location = new System.Drawing.Point(1480, 579);
            this.search_panal.Name = "search_panal";
            this.search_panal.Size = new System.Drawing.Size(268, 36);
            this.search_panal.TabIndex = 56;
            // 
            // dataGridView1_add_panal
            // 
            this.dataGridView1_add_panal.AllowUserToAddRows = false;
            this.dataGridView1_add_panal.AllowUserToDeleteRows = false;
            this.dataGridView1_add_panal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_add_panal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1_add_panal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_add_panal.Location = new System.Drawing.Point(299, 219);
            this.dataGridView1_add_panal.Name = "dataGridView1_add_panal";
            this.dataGridView1_add_panal.ReadOnly = true;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridView1_add_panal.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1_add_panal.RowTemplate.Height = 25;
            this.dataGridView1_add_panal.Size = new System.Drawing.Size(1449, 354);
            this.dataGridView1_add_panal.TabIndex = 55;
            this.dataGridView1_add_panal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_add_panal_CellContentClick);
            // 
            // update_save_panal
            // 
            this.update_save_panal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_save_panal.Location = new System.Drawing.Point(1133, 579);
            this.update_save_panal.Name = "update_save_panal";
            this.update_save_panal.Size = new System.Drawing.Size(103, 40);
            this.update_save_panal.TabIndex = 54;
            this.update_save_panal.Text = "تعديل";
            this.update_save_panal.UseVisualStyleBackColor = true;
            this.update_save_panal.Click += new System.EventHandler(this.Update_save_panal_Click);
            // 
            // delete_save_panal
            // 
            this.delete_save_panal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_save_panal.Location = new System.Drawing.Point(1242, 579);
            this.delete_save_panal.Name = "delete_save_panal";
            this.delete_save_panal.Size = new System.Drawing.Size(103, 40);
            this.delete_save_panal.TabIndex = 53;
            this.delete_save_panal.Text = "حذف";
            this.delete_save_panal.UseVisualStyleBackColor = true;
            this.delete_save_panal.Click += new System.EventHandler(this.Delete_save_panal_Click);
            // 
            // add_save_panal
            // 
            this.add_save_panal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_save_panal.Location = new System.Drawing.Point(1024, 579);
            this.add_save_panal.Name = "add_save_panal";
            this.add_save_panal.Size = new System.Drawing.Size(103, 40);
            this.add_save_panal.TabIndex = 52;
            this.add_save_panal.Text = "اضافة";
            this.add_save_panal.UseVisualStyleBackColor = true;
            this.add_save_panal.Click += new System.EventHandler(this.Add_save_panal_Click);
            // 
            // user_panal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 760);
            this.Controls.Add(this.tabControl1);
            this.Name = "user_panal";
            this.Text = "لوحة المستخدمين";
            this.Load += new System.EventHandler(this.User_panal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_panal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_search_panal;
        private System.Windows.Forms.TextBox search_panal;
        private System.Windows.Forms.DataGridView dataGridView1_add_panal;
        private System.Windows.Forms.Button update_save_panal;
        private System.Windows.Forms.Button delete_save_panal;
        private System.Windows.Forms.Button add_save_panal;
    }
}