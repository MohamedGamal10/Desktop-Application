using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DGVPrinterHelper;
using System.Drawing.Printing;

namespace Elfath_Plastic.Forms
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }
        static String sql = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Alfath_plastic.accdb; jet OLEDB:Database Password=''; Persist Security Info=True;";
        OleDbConnection con = new OleDbConnection(sql);

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

        }

        private void Cal_Click(object sender, EventArgs e)
        {

        }

        private void Search_from_to_Click(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {

        }

        private void Btn_search_Expenses_Click(object sender, EventArgs e)
        {

        }

        private void Update_save_Expenses_Click(object sender, EventArgs e)
        {

        }

        private void Delete_save_Expenses_Click(object sender, EventArgs e)
        {

        }

        private void Add_save_Expenses_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string exp = "";
            string rev = "";
            
            try
            {
                con.Open();
                String query = "SELECT Sum(Expenses.Expense_Value) FROM Expenses WHERE Expense_Date Between #" + from.Text + "# And #" + to.Text + "#";
                OleDbCommand cmd1 = new OleDbCommand(query, con);
                OleDbDataReader r1 = cmd1.ExecuteReader();
                r1.Read();
                
                exp = r1[0].ToString();
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            try
            {
                con.Open();
                String query = "SELECT Sum(Revenues.Revenues_Value) FROM Revenues WHERE Revenues_Date Between #" + from.Text + "# And #" + to.Text + "#";
                OleDbCommand cmd1 = new OleDbCommand(query, con);
                OleDbDataReader r1 = cmd1.ExecuteReader();
                r1.Read();
    
                rev = r1[0].ToString();
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            
            dataGridView1_report.Rows[0].Cells[0].Value = "مجموع الايراد";
            dataGridView1_report.Rows[0].Cells[1].Value = rev;
            dataGridView1_report.Rows[1].Cells[0].Value = "مجموع المصروفات";
            dataGridView1_report.Rows[1].Cells[1].Value = exp;
            dataGridView1_report.Rows[2].Cells[0].Value = "صافي الربح";
            dataGridView1_report.Rows[2].Cells[1].Value = Convert.ToString(float.Parse(rev) - float.Parse(exp));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void reports_Load(object sender, EventArgs e)
        {
            dataGridView1_report.BorderStyle = BorderStyle.None;
            dataGridView1_report.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_report.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_report.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_report.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_report.BackgroundColor = Color.White;
            dataGridView1_report.EnableHeadersVisualStyles = false;
            dataGridView1_report.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_report.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_report.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_report.Columns.Add("", "");
            dataGridView1_report.Columns.Add("", "");
            dataGridView1_report.Rows.Add("", "");
            dataGridView1_report.Rows.Add("", "");
            dataGridView1_report.Rows.Add("", "");
            dataGridView1_report.Columns[0].HeaderText = "البيان";
            dataGridView1_report.Columns[1].HeaderText = "القيمة";
        }

        private void print_Click_1(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "صافي الربح ";
            printer.SubTitle = "الفترة من " + from.Text + " الي " + to.Text;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            Margins margins = new Margins(0, 0, 0, 0);
            printer.printDocument.DefaultPageSettings.Margins = margins;
            printer.PrintPreviewNoDisplay(dataGridView1_report);
        }
    }
}
