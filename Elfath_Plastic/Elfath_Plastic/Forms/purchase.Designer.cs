namespace Elfath_Plastic.Forms
{
    partial class purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.print = new System.Windows.Forms.Button();
            this.search_from_to = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Material_Name = new System.Windows.Forms.TextBox();
            this.Supplier_Name = new System.Windows.Forms.ComboBox();
            this.Purchase_Invoice_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_search_purchase = new System.Windows.Forms.Button();
            this.search_purchase = new System.Windows.Forms.TextBox();
            this.dataGridView1_add_purchase = new System.Windows.Forms.DataGridView();
            this.update_save_purchase = new System.Windows.Forms.Button();
            this.delete_save_purchase = new System.Windows.Forms.Button();
            this.add_save_purchase = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Total_invoice = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Amount_Paid = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.Discount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_purchase)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1924, 878);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.print);
            this.tabPage1.Controls.Add(this.search_from_to);
            this.tabPage1.Controls.Add(this.to);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.from);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.Price);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Material_Name);
            this.tabPage1.Controls.Add(this.Supplier_Name);
            this.tabPage1.Controls.Add(this.Purchase_Invoice_Date);
            this.tabPage1.Controls.Add(this.btn_search_purchase);
            this.tabPage1.Controls.Add(this.search_purchase);
            this.tabPage1.Controls.Add(this.dataGridView1_add_purchase);
            this.tabPage1.Controls.Add(this.update_save_purchase);
            this.tabPage1.Controls.Add(this.delete_save_purchase);
            this.tabPage1.Controls.Add(this.add_save_purchase);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Total_invoice);
            this.tabPage1.Controls.Add(this.Notes);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.Amount_Paid);
            this.tabPage1.Controls.Add(this.Weight);
            this.tabPage1.Controls.Add(this.Discount);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1916, 836);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة وتعديل";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // print
            // 
            this.print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print.Location = new System.Drawing.Point(924, 707);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(103, 40);
            this.print.TabIndex = 72;
            this.print.Text = "طباعة";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.Print_Click);
            // 
            // search_from_to
            // 
            this.search_from_to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_from_to.Location = new System.Drawing.Point(1066, 806);
            this.search_from_to.Name = "search_from_to";
            this.search_from_to.Size = new System.Drawing.Size(103, 40);
            this.search_from_to.TabIndex = 71;
            this.search_from_to.Text = "بحث";
            this.search_from_to.UseVisualStyleBackColor = true;
            this.search_from_to.Click += new System.EventHandler(this.Search_from_to_Click);
            // 
            // to
            // 
            this.to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to.Location = new System.Drawing.Point(1222, 806);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(187, 36);
            this.to.TabIndex = 70;
            this.to.ValueChanged += new System.EventHandler(this.to_ValueChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1440, 812);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 29);
            this.label13.TabIndex = 69;
            this.label13.Text = "الي";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // from
            // 
            this.from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from.Location = new System.Drawing.Point(1498, 806);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(187, 36);
            this.from.TabIndex = 68;
            this.from.ValueChanged += new System.EventHandler(this.from_ValueChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1717, 806);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 29);
            this.label10.TabIndex = 67;
            this.label10.Text = "بحث من الفترة ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1706, 713);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 66;
            this.label3.Text = "بحث باسم التاجر";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(788, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 29);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1524, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 29);
            this.label9.TabIndex = 64;
            this.label9.Text = "كيلو";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Price
            // 
            this.Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Price.Location = new System.Drawing.Point(788, 21);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(306, 36);
            this.Price.TabIndex = 63;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1222, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 24);
            this.label6.TabIndex = 62;
            this.label6.Text = "السعر";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Material_Name
            // 
            this.Material_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Material_Name.Location = new System.Drawing.Point(1417, 218);
            this.Material_Name.Name = "Material_Name";
            this.Material_Name.Size = new System.Drawing.Size(306, 36);
            this.Material_Name.TabIndex = 61;
            this.Material_Name.TextChanged += new System.EventHandler(this.Material_Name_TextChanged);
            // 
            // Supplier_Name
            // 
            this.Supplier_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Supplier_Name.FormattingEnabled = true;
            this.Supplier_Name.Location = new System.Drawing.Point(1417, 79);
            this.Supplier_Name.Name = "Supplier_Name";
            this.Supplier_Name.Size = new System.Drawing.Size(306, 37);
            this.Supplier_Name.TabIndex = 59;
            this.Supplier_Name.SelectedIndexChanged += new System.EventHandler(this.Supplier_Name_SelectedIndexChanged);
            // 
            // Purchase_Invoice_Date
            // 
            this.Purchase_Invoice_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Purchase_Invoice_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Purchase_Invoice_Date.Location = new System.Drawing.Point(1417, 21);
            this.Purchase_Invoice_Date.Name = "Purchase_Invoice_Date";
            this.Purchase_Invoice_Date.Size = new System.Drawing.Size(306, 36);
            this.Purchase_Invoice_Date.TabIndex = 58;
            this.Purchase_Invoice_Date.ValueChanged += new System.EventHandler(this.Purchase_Invoice_Date_ValueChanged);
            // 
            // btn_search_purchase
            // 
            this.btn_search_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_purchase.Location = new System.Drawing.Point(1284, 706);
            this.btn_search_purchase.Name = "btn_search_purchase";
            this.btn_search_purchase.Size = new System.Drawing.Size(103, 40);
            this.btn_search_purchase.TabIndex = 57;
            this.btn_search_purchase.Text = "بحث";
            this.btn_search_purchase.UseVisualStyleBackColor = true;
            this.btn_search_purchase.Click += new System.EventHandler(this.Btn_search_purchase_Click);
            // 
            // search_purchase
            // 
            this.search_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_purchase.Location = new System.Drawing.Point(1417, 706);
            this.search_purchase.Name = "search_purchase";
            this.search_purchase.Size = new System.Drawing.Size(268, 36);
            this.search_purchase.TabIndex = 56;
            this.search_purchase.TextChanged += new System.EventHandler(this.search_purchase_TextChanged);
            // 
            // dataGridView1_add_purchase
            // 
            this.dataGridView1_add_purchase.AllowUserToAddRows = false;
            this.dataGridView1_add_purchase.AllowUserToDeleteRows = false;
            this.dataGridView1_add_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_add_purchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1_add_purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_add_purchase.Location = new System.Drawing.Point(788, 346);
            this.dataGridView1_add_purchase.Name = "dataGridView1_add_purchase";
            this.dataGridView1_add_purchase.ReadOnly = true;
            this.dataGridView1_add_purchase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1_add_purchase.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridView1_add_purchase.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1_add_purchase.RowTemplate.Height = 25;
            this.dataGridView1_add_purchase.Size = new System.Drawing.Size(1070, 354);
            this.dataGridView1_add_purchase.TabIndex = 55;
            this.dataGridView1_add_purchase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_add_purchase_CellContentClick);
            // 
            // update_save_purchase
            // 
            this.update_save_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_save_purchase.Location = new System.Drawing.Point(924, 753);
            this.update_save_purchase.Name = "update_save_purchase";
            this.update_save_purchase.Size = new System.Drawing.Size(103, 40);
            this.update_save_purchase.TabIndex = 54;
            this.update_save_purchase.Text = "تعديل";
            this.update_save_purchase.UseVisualStyleBackColor = true;
            this.update_save_purchase.Click += new System.EventHandler(this.Update_save_purchase_Click);
            // 
            // delete_save_purchase
            // 
            this.delete_save_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_save_purchase.Location = new System.Drawing.Point(815, 706);
            this.delete_save_purchase.Name = "delete_save_purchase";
            this.delete_save_purchase.Size = new System.Drawing.Size(103, 40);
            this.delete_save_purchase.TabIndex = 53;
            this.delete_save_purchase.Text = "حذف";
            this.delete_save_purchase.UseVisualStyleBackColor = true;
            this.delete_save_purchase.Click += new System.EventHandler(this.Delete_save_purchase_Click);
            // 
            // add_save_purchase
            // 
            this.add_save_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_save_purchase.Location = new System.Drawing.Point(815, 753);
            this.add_save_purchase.Name = "add_save_purchase";
            this.add_save_purchase.Size = new System.Drawing.Size(103, 40);
            this.add_save_purchase.TabIndex = 52;
            this.add_save_purchase.Text = "اضافة";
            this.add_save_purchase.UseVisualStyleBackColor = true;
            this.add_save_purchase.Click += new System.EventHandler(this.Add_save_purchase_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(878, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "جنية";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Total_invoice
            // 
            this.Total_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Total_invoice.AutoSize = true;
            this.Total_invoice.Location = new System.Drawing.Point(965, 92);
            this.Total_invoice.Name = "Total_invoice";
            this.Total_invoice.Size = new System.Drawing.Size(21, 29);
            this.Total_invoice.TabIndex = 44;
            this.Total_invoice.Text = "-";
            this.Total_invoice.Click += new System.EventHandler(this.Total_invoice_Click);
            // 
            // Notes
            // 
            this.Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Notes.Location = new System.Drawing.Point(788, 218);
            this.Notes.Multiline = true;
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(306, 101);
            this.Notes.TabIndex = 43;
            this.Notes.TextChanged += new System.EventHandler(this.Notes_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1203, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 24);
            this.label14.TabIndex = 42;
            this.label14.Text = "ملاحظات";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Amount_Paid
            // 
            this.Amount_Paid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount_Paid.Location = new System.Drawing.Point(788, 142);
            this.Amount_Paid.Name = "Amount_Paid";
            this.Amount_Paid.Size = new System.Drawing.Size(306, 36);
            this.Amount_Paid.TabIndex = 24;
            this.Amount_Paid.TextChanged += new System.EventHandler(this.Amount_Paid_TextChanged);
            // 
            // Weight
            // 
            this.Weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Weight.Location = new System.Drawing.Point(1606, 283);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(117, 36);
            this.Weight.TabIndex = 20;
            this.Weight.TextChanged += new System.EventHandler(this.Weight_TextChanged);
            // 
            // Discount
            // 
            this.Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Discount.Location = new System.Drawing.Point(1417, 142);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(306, 36);
            this.Discount.TabIndex = 17;
            this.Discount.TextChanged += new System.EventHandler(this.Discount_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1175, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "المبلغ المدفوع";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1140, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "المبلغ الكلي للفاتورة";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1817, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "الوزن";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1788, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "نوع الخامة";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1808, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "الخصم";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1785, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم التاجر";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1767, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاريخ الفاتورة";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 878);
            this.Controls.Add(this.tabControl1);
            this.Name = "purchase";
            this.Text = "المشتريات";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_add_purchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Amount_Paid;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Total_invoice;
        private System.Windows.Forms.Button btn_search_purchase;
        private System.Windows.Forms.TextBox search_purchase;
        private System.Windows.Forms.DataGridView dataGridView1_add_purchase;
        private System.Windows.Forms.Button update_save_purchase;
        private System.Windows.Forms.Button delete_save_purchase;
        private System.Windows.Forms.Button add_save_purchase;
        private System.Windows.Forms.DateTimePicker Purchase_Invoice_Date;
        private System.Windows.Forms.ComboBox Supplier_Name;
        private System.Windows.Forms.TextBox Material_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button search_from_to;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button print;
    }
}