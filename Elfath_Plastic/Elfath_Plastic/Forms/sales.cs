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
    public partial class sales : Form
    {
        public sales()
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
            String query = "SELECT ID , Sale_invoice_Date , Discount , Tax , Client_Name , Products_Name , Quantity , Price , Total_invoice ,  Amount_Paid , Notes , Credit_Balance , Debit_Balance FROM Sales";

            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }


        private void Sales_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1_add_sales.DataSource = load();
            dataGridView1_add_sales.BorderStyle = BorderStyle.None;
            dataGridView1_add_sales.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_sales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_sales.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_sales.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_sales.BackgroundColor = Color.White;
            dataGridView1_add_sales.EnableHeadersVisualStyles = false;
            dataGridView1_add_sales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_sales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_sales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_sales.Columns[0].HeaderText = "ID";
            dataGridView1_add_sales.Columns[1].HeaderText = "تاريخ الفاتورة";
            dataGridView1_add_sales.Columns[2].HeaderText = "الخصم";
            dataGridView1_add_sales.Columns[3].HeaderText = "الضريبة";
            dataGridView1_add_sales.Columns[4].HeaderText = "اسم العميل";
            dataGridView1_add_sales.Columns[5].HeaderText = "اسم المنتج";
            dataGridView1_add_sales.Columns[6].HeaderText = "الكمية";
            dataGridView1_add_sales.Columns[7].HeaderText = "السعر";
            dataGridView1_add_sales.Columns[8].HeaderText = "المبلغ الكلي للفاتورة";
            dataGridView1_add_sales.Columns[9].HeaderText = "المبلغ المدفوع";
            dataGridView1_add_sales.Columns[10].HeaderText = "ملاحظات";
            dataGridView1_add_sales.Columns[11].HeaderText = "رصيد مدين (عليه)";
            dataGridView1_add_sales.Columns[12].HeaderText = "رصيد دائن (له)";


            try
            {
                con.Open();
                String query = "SELECT Client_Name FROM Clients";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Client_Name.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void Add_save_sales_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Sales(Sale_invoice_Date , Discount , Tax , Client_Name , Products_Name , Quantity , Price , Amount_Paid , Notes) VALUES (@Sale_invoice_Date , @Discount , @Tax , @Client_Name , @Products_Name , @Quantity , @Price , @Amount_Paid , @Notes)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Sale_invoice_Date", Sale_invoice_Date.Text);
                cmd.Parameters.AddWithValue("@Discount", Discount.Text);
                cmd.Parameters.AddWithValue("@Tax", Tax.Text);
                cmd.Parameters.AddWithValue("@Client_Name", Client_Name.Text);
                cmd.Parameters.AddWithValue("@Products_Name", Products_Name.Text);
                cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                cmd.Parameters.AddWithValue("@Price", Price.Text);
                cmd.Parameters.AddWithValue("@Amount_Paid", Amount_Paid.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_sales.DataSource = load();
                
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
                String q8 = "INSERT INTO Revenues(Revenues_Name , Revenues_Value , Revenues_Date) VALUES (@Revenues_Name , @Revenues_Value , @Revenues_Date)";
                OleDbCommand cmd8 = new OleDbCommand(q8, con);
                cmd8.Parameters.AddWithValue("@Revenues_Name", "بيع  " + Quantity.Text + " قطعة من  " + Products_Name.Text + " الي " + Client_Name.Text);
                cmd8.Parameters.AddWithValue("@Revenues_Value", Amount_Paid.Text);
                cmd8.Parameters.AddWithValue("@Revenues_Date", Sale_invoice_Date.Text);
                cmd8.ExecuteNonQuery();
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

        private void DataGridView1_add_sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_sales.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_sales.CurrentRow.Selected = true;
                    Sale_invoice_Date.Text = dataGridView1_add_sales.Rows[e.RowIndex].Cells["Sale_invoice_Date"].FormattedValue.ToString();
                    Discount.Text = dataGridView1_add_sales.Rows[e.RowIndex].Cells["Discount"].FormattedValue.ToString();
                    Tax.Text = dataGridView1_add_sales.Rows[e.RowIndex].Cells["Tax"].FormattedValue.ToString();
                    Client_Name.Text = dataGridView1_add_sales.Rows[e.RowIndex].Cells["Client_Name"].FormattedValue.ToString();
                    Products_Name.Text = dataGridView1_add_sales.Rows[e.RowIndex].Cells["Products_Name"].FormattedValue.ToString();
                    Quantity.Text = dataGridView1_add_sales.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                    Price.Text = dataGridView1_add_sales.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    Amount_Paid.Text = dataGridView1_add_sales.Rows[e.RowIndex].Cells["Amount_Paid"].FormattedValue.ToString();
                    Notes.Text = dataGridView1_add_sales.Rows[e.RowIndex].Cells["Notes"].FormattedValue.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_save_sales_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Sales SET Sale_invoice_Date=@Sale_invoice_Date , Discount=@Discount , Tax=@Tax , Client_Name=@Client_Name , Products_Name=@Products_Name , Quantity=@Quantity , Price=@Price , Amount_Paid=@Amount_Paid , Notes=@Notes WHERE ID=" + dataGridView1_add_sales.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Sale_invoice_Date", Sale_invoice_Date.Text);
                cmd.Parameters.AddWithValue("@Discount", Discount.Text);
                cmd.Parameters.AddWithValue("@Tax", Tax.Text);
                cmd.Parameters.AddWithValue("@Client_Name", Client_Name.Text);
                cmd.Parameters.AddWithValue("@Products_Name", Products_Name.Text);
                cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                cmd.Parameters.AddWithValue("@Price", Price.Text);
                cmd.Parameters.AddWithValue("@Amount_Paid", Amount_Paid.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_sales.DataSource = load();
                

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
                string var1 = "بيع  " + Quantity.Text + " قطعة من  " + Products_Name.Text + " الي " + Client_Name.Text;
                con.Open();
                String q8 = "UPDATE Revenues SET Revenues_Name=@Revenues_Name , Revenues_Value=@Revenues_Value, Revenues_Date=@Revenues_Date WHERE Revenues_Name LIKE '%" + var1 + "%'";
                OleDbCommand cmd8 = new OleDbCommand(q8, con);
                cmd8.Parameters.AddWithValue("@Revenues_Name", "بيع  " + Quantity.Text + " قطعة من  " + Products_Name.Text + " الي " + Client_Name.Text);
                cmd8.Parameters.AddWithValue("@Revenues_Value", Amount_Paid.Text);
                cmd8.Parameters.AddWithValue("@Revenues_Date", Sale_invoice_Date.Text);
                cmd8.ExecuteNonQuery();
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

        private void Delete_save_sales_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM sales WHERE ID=" + dataGridView1_add_sales.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_sales.DataSource = load();
                

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
                string var1 = "بيع  " + Quantity.Text + " قطعة من  " + Products_Name.Text + " الي " + Client_Name.Text;
                con.Open();
                string query = "DELETE FROM Revenues WHERE Revenues_Name LIKE '%" + var1 + "%'";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_sales.DataSource = load();


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

        private void Btn_search_sales_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Sale_invoice_Date , Discount , Tax , Client_Name , Products_Name , Quantity , Price , Total_invoice ,  Amount_Paid , Notes , Credit_Balance , Debit_Balance FROM sales WHERE Client_Name LIKE '%" + search_sales.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_sales.DataSource = dt;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double val1 = Convert.ToDouble(Quantity.Text);
                double val2 = Convert.ToDouble(Price.Text);
                double val3 = Convert.ToDouble(Discount.Text);
                double val4 = Convert.ToDouble(Tax.Text);
                double val5 = ((val1 * val2)+val4) - val3;
                Total_invoice.Text = Convert.ToString(val5);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_from_to_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Sale_invoice_Date , Discount , Tax , Client_Name , Products_Name , Quantity , Price , Total_invoice ,  Amount_Paid , Notes , Credit_Balance , Debit_Balance FROM sales WHERE Sale_invoice_Date Between #" + from.Text + "# And #" + to.Text + "#";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_sales.DataSource = dt;
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
            printer.Title = "بيع";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            Margins margins = new Margins(0, 0, 0, 0);
            printer.printDocument.DefaultPageSettings.Margins = margins;
            this.dataGridView1_add_sales.Columns["ID"].Visible = false;
            this.dataGridView1_add_sales.Columns["Debit_Balance"].Visible = false;
            this.dataGridView1_add_sales.Columns["Credit_Balance"].Visible = false;
            this.dataGridView1_add_sales.Columns["Notes"].Visible = false;
            printer.PrintPreviewNoDisplay(dataGridView1_add_sales);
            this.dataGridView1_add_sales.Columns["ID"].Visible = true;
            this.dataGridView1_add_sales.Columns["Debit_Balance"].Visible = true;
            this.dataGridView1_add_sales.Columns["Credit_Balance"].Visible = true;
            this.dataGridView1_add_sales.Columns["Notes"].Visible = true;

        }
    }
}
