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
    public partial class expenses : Form
    {
        public expenses()
        {
            InitializeComponent();
        }
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


        static String sql = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Alfath_plastic.accdb; jet OLEDB:Database Password=''; Persist Security Info=True;";
        OleDbConnection con = new OleDbConnection(sql);

        public DataTable load()
        {

            con.Open();
            String query = "SELECT ID , Expense_Name , Expense_Value , Expense_Date FROM Expenses";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            LoadTheme();


            dataGridView1_add_Expenses.DataSource = load();
            dataGridView1_add_Expenses.BorderStyle = BorderStyle.None;
            dataGridView1_add_Expenses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_Expenses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_Expenses.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_Expenses.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_Expenses.BackgroundColor = Color.White;
            dataGridView1_add_Expenses.EnableHeadersVisualStyles = false;
            dataGridView1_add_Expenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_Expenses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_Expenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_Expenses.Columns[0].HeaderText = "ID";
            dataGridView1_add_Expenses.Columns[1].HeaderText = "بيان المصروف";
            dataGridView1_add_Expenses.Columns[2].HeaderText = "القيمة";
            dataGridView1_add_Expenses.Columns[3].HeaderText = "تاريخ الصرف";
            
            
        }

        private void Add_save_Expenses_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Expenses(Expense_Name , Expense_Value , Expense_Date) VALUES (@Expense_Name , @Expense_Value , @Expense_Date)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Expense_Name", Expense_Name.Text);
                cmd.Parameters.AddWithValue("@Expense_Value", Expense_Value.Text);
                cmd.Parameters.AddWithValue("@Expense_Date", Expense_Date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Expenses.DataSource = load();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void DataGridView1_add_Expenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_Expenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_Expenses.CurrentRow.Selected = true;
                    Expense_Name.Text = dataGridView1_add_Expenses.Rows[e.RowIndex].Cells["Expense_Name"].FormattedValue.ToString();
                    Expense_Value.Text = dataGridView1_add_Expenses.Rows[e.RowIndex].Cells["Expense_Value"].FormattedValue.ToString();
                    Expense_Date.Text = dataGridView1_add_Expenses.Rows[e.RowIndex].Cells["Expense_Date"].FormattedValue.ToString();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_save_Expenses_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Expenses SET Expense_Name=@Expense_Name , Expense_Value=@Expense_Value , Expense_Date=@Expense_Date WHERE ID=" + dataGridView1_add_Expenses.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Expense_Name", Expense_Name.Text);
                cmd.Parameters.AddWithValue("@Expense_Value", Expense_Value.Text);
                cmd.Parameters.AddWithValue("@Expense_Date", Expense_Date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Expenses.DataSource = load();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Delete_save_Expenses_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Expenses WHERE ID=" + dataGridView1_add_Expenses.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Expenses.DataSource = load();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Btn_search_Expenses_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Expense_Name , Expense_Value , Expense_Date FROM Expenses WHERE Expense_Name LIKE '%" + search_Expenses.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_Expenses.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "مصروفات";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            Margins margins = new Margins(0, 0, 0, 0);
            printer.printDocument.DefaultPageSettings.Margins = margins;
            this.dataGridView1_add_Expenses.Columns["ID"].Visible = false;
            printer.PrintPreviewNoDisplay(dataGridView1_add_Expenses);
            this.dataGridView1_add_Expenses.Columns["ID"].Visible = true;
        }

        private void Search_from_to_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Expense_Name , Expense_Value , Expense_Date FROM Expenses WHERE Expense_Date Between #" + from.Text + "# And #" + to.Text + "#";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_Expenses.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Cal_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT Sum(Expenses.Expense_Value) FROM Expenses WHERE Expense_Date Between #" + from.Text + "# And #" + to.Text + "#";
                OleDbCommand cmd1 = new OleDbCommand(query, con);
                OleDbDataReader r1 = cmd1.ExecuteReader();
                r1.Read();
                cal_label.Text = r1[0].ToString();
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

        }
    }
}
