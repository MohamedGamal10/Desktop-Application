namespace Elfath_Plastic.Forms
{
    partial class reports
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.print = new System.Windows.Forms.Button();
            this.dataGridView1_report = new System.Windows.Forms.DataGridView();
            this.calculate = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_report)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1338, 780);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.print);
            this.tabPage1.Controls.Add(this.dataGridView1_report);
            this.tabPage1.Controls.Add(this.calculate);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.to);
            this.tabPage1.Controls.Add(this.from);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1330, 738);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "صافي الربح";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // print
            // 
            this.print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print.Location = new System.Drawing.Point(518, 29);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(103, 40);
            this.print.TabIndex = 83;
            this.print.Text = "طباعة";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click_1);
            // 
            // dataGridView1_report
            // 
            this.dataGridView1_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_report.Location = new System.Drawing.Point(518, 110);
            this.dataGridView1_report.Name = "dataGridView1_report";
            this.dataGridView1_report.RowHeadersWidth = 51;
            this.dataGridView1_report.RowTemplate.Height = 24;
            this.dataGridView1_report.Size = new System.Drawing.Size(771, 309);
            this.dataGridView1_report.TabIndex = 82;
            // 
            // calculate
            // 
            this.calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calculate.Location = new System.Drawing.Point(627, 29);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(103, 40);
            this.calculate.TabIndex = 71;
            this.calculate.Text = "حساب";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(981, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 29);
            this.label15.TabIndex = 70;
            this.label15.Text = "الي";
            // 
            // to
            // 
            this.to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to.Location = new System.Drawing.Point(760, 28);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(200, 36);
            this.to.TabIndex = 69;
            // 
            // from
            // 
            this.from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from.Location = new System.Drawing.Point(1026, 28);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(200, 36);
            this.from.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1246, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 29);
            this.label11.TabIndex = 67;
            this.label11.Text = "من";
            // 
            // reports
            // 
            this.ClientSize = new System.Drawing.Size(1338, 780);
            this.Controls.Add(this.tabControl1);
            this.Name = "reports";
            this.Load += new System.EventHandler(this.reports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_report)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1_report;
        private System.Windows.Forms.Button print;
    }
}