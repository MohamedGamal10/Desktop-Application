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
        public DataTable loadconsume()
        {

            con.Open();
            String query = "SELECT Client_Name, Products_Name, Quantity, Total_invoice, Amount_Paid FROM Sales where Client_Name = ''";

            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable loadinstallments()
        {

            con.Open();
            String query = "SELECT ID, Client_Name , installment_Name , installment_value , Date_installment FROM Clients_installment";

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

            consume_dataGridView1.DataSource = loadconsume();
            consume_dataGridView1.BorderStyle = BorderStyle.None;
            consume_dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            consume_dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            consume_dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            consume_dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            consume_dataGridView1.BackgroundColor = Color.White;
            consume_dataGridView1.EnableHeadersVisualStyles = false;
            consume_dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            consume_dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            consume_dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            consume_dataGridView1.Columns[0].HeaderText = "اسم العميل";
            consume_dataGridView1.Columns[1].HeaderText = "اسم المنتج";
            consume_dataGridView1.Columns[2].HeaderText = "الكمية";
            consume_dataGridView1.Columns[3].HeaderText = "مجموع الفواتير";
            consume_dataGridView1.Columns[4].HeaderText = "مجموع المدفوعات";

            dataGridView1_Clients_installment.DataSource = loadinstallments();
            dataGridView1_Clients_installment.BorderStyle = BorderStyle.None;
            dataGridView1_Clients_installment.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_Clients_installment.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_Clients_installment.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_Clients_installment.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_Clients_installment.BackgroundColor = Color.White;
            dataGridView1_Clients_installment.EnableHeadersVisualStyles = false;
            dataGridView1_Clients_installment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_Clients_installment.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_Clients_installment.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_Clients_installment.Columns[0].HeaderText = "ID";
            dataGridView1_Clients_installment.Columns[1].HeaderText = "اسم العميل";
            dataGridView1_Clients_installment.Columns[2].HeaderText = "اسم القسط";
            dataGridView1_Clients_installment.Columns[3].HeaderText = "قيمة القسط";
            dataGridView1_Clients_installment.Columns[4].HeaderText = "تاريخ القسط";
            


            try
            {
                con.Open();
                String query = "SELECT Client_Name FROM Clients";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Client_Name.Items.Add(reader[0].ToString());
                    consume_client.Items.Add(reader[0].ToString());
                    comboBox1_Client_Name.Items.Add(reader[0].ToString());
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
                if (search_sales.Text=="") 
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
                else
                {
                    con.Open();
                    String query = "SELECT ID , Sale_invoice_Date , Discount , Tax , Client_Name , Products_Name , Quantity , Price , Total_invoice ,  Amount_Paid , Notes , Credit_Balance , Debit_Balance FROM sales WHERE Client_Name LIKE '%" + search_sales.Text + "%' and Sale_invoice_Date Between #" + from.Text + "# And #" + to.Text + "#";
                    DataTable dt = new DataTable();
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    dataGridView1_add_sales.DataSource = dt;

                }
                
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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (consume_product.Text=="") 
                {
                    con.Open();
                    String query = "SELECT Sales.Client_Name, Sales.Products_Name, Sum(Sales.Quantity) AS Quantity, Sum(Sales.Total_invoice) AS Total_invoices, Sum(Sales.Amount_Paid) AS Amount_Paid FROM Sales WHERE (((Sales.Client_Name)="  +"'"+consume_client.Text + "'" + ") AND ((Sales.Sale_invoice_Date) Between #" + consume_from.Text + "# And #" + consume_to.Text + "#)) GROUP BY Sales.Client_Name, Sales.Products_Name;";
                    DataTable dt = new DataTable();
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    consume_dataGridView1.DataSource = dt;
                    consume_dataGridView1.Columns[3].HeaderText = "مجموع الفواتير";

                }
                else
                {
                    con.Open();
                    String query = "SELECT Sales.Client_Name, Sales.Products_Name, Sum(Sales.Quantity) AS Quantity, Sum(Sales.Total_invoice) AS Total_invoices, Sum(Sales.Amount_Paid) AS Amount_Paid FROM Sales WHERE (((Sales.Client_Name)=" + "'" + consume_client.Text +"'"+ ") AND ((Sales.Products_Name)="  +"'" + consume_product.Text  +"'" + ") AND ((Sales.Sale_invoice_Date) Between #" + consume_from.Text + "# And #" + consume_to.Text + "#)) GROUP BY Sales.Client_Name, Sales.Products_Name;";
                    
                    DataTable dt = new DataTable();
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    consume_dataGridView1.DataSource = dt;
                    consume_dataGridView1.Columns[3].HeaderText = "مجموع الفواتير";

                }        

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

        private void consume_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "فاتورة استهلاك العميل : " + consume_client.Text;
            printer.SubTitle = "الفترة من " + consume_from.Text + " الي " + consume_to.Text;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            Margins margins = new Margins(0, 0, 0, 0);
            printer.printDocument.DefaultPageSettings.Margins = margins;
            printer.PrintPreviewNoDisplay(consume_dataGridView1);

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void update_Clients_installment_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Clients_installment SET Client_Name=@Client_Name , installment_Name=@installment_Name , installment_value=@installment_value , Date_installment=@Date_installment WHERE ID=" + dataGridView1_Clients_installment.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Client_Name", comboBox1_Client_Name.Text);
                cmd.Parameters.AddWithValue("@installment_Name", installment_Name.Text);
                cmd.Parameters.AddWithValue("@installment_value", installment_value.Text);
                cmd.Parameters.AddWithValue("@Date_installment", Date_installment.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_Clients_installment.DataSource = loadinstallments();


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
                string var1 = "   دفع قسط من العميل  " + comboBox1_Client_Name.Text + " عن    " + installment_Name.Text;
                con.Open();
                String q8 = "UPDATE Revenues SET Revenues_Name=@Revenues_Name , Revenues_Value=@Revenues_Value, Revenues_Date=@Revenues_Date WHERE Revenues_Name LIKE '%" + var1 + "%'";
                OleDbCommand cmd8 = new OleDbCommand(q8, con);
                cmd8.Parameters.AddWithValue("@Revenues_Name", "   دفع قسط من العميل  " + comboBox1_Client_Name.Text + " عن    " + installment_Name.Text);
                cmd8.Parameters.AddWithValue("@Revenues_Value", installment_value.Text);
                cmd8.Parameters.AddWithValue("@Revenues_Date", Date_installment.Text);
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

        private void add_Clients_installment_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Clients_installment(Client_Name , installment_Name , installment_value , Date_installment) VALUES (@Client_Name , @installment_Name , @installment_value , @Date_installment)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Client_Name", comboBox1_Client_Name.Text);
                cmd.Parameters.AddWithValue("@installment_Name", installment_Name.Text);
                cmd.Parameters.AddWithValue("@installment_value", installment_value.Text);
                cmd.Parameters.AddWithValue("@Date_installment", Date_installment.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_Clients_installment.DataSource = loadinstallments();

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
               cmd8.Parameters.AddWithValue("@Revenues_Name","   دفع قسط من العميل  " + comboBox1_Client_Name.Text  +" عن    "+installment_Name.Text );
                cmd8.Parameters.AddWithValue("@Revenues_Value", installment_value.Text);
                cmd8.Parameters.AddWithValue("@Revenues_Date", Date_installment.Text);
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

        private void dataGridView1_Clients_installment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_Clients_installment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_Clients_installment.CurrentRow.Selected = true;
                    Date_installment.Text = dataGridView1_Clients_installment.Rows[e.RowIndex].Cells["Date_installment"].FormattedValue.ToString();
                    comboBox1_Client_Name.Text = dataGridView1_Clients_installment.Rows[e.RowIndex].Cells["Client_Name"].FormattedValue.ToString();
                    installment_Name.Text = dataGridView1_Clients_installment.Rows[e.RowIndex].Cells["installment_Name"].FormattedValue.ToString();
                    installment_value.Text = dataGridView1_Clients_installment.Rows[e.RowIndex].Cells["installment_value"].FormattedValue.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Clients_installment_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Clients_installment WHERE ID=" + dataGridView1_Clients_installment.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_Clients_installment.DataSource = loadinstallments();


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
                string var1 = "   دفع قسط من العميل  " + comboBox1_Client_Name.Text + " عن    " + installment_Name.Text;
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

        private void print_Clients_installment_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "اقساط العملاء ";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            Margins margins = new Margins(0, 0, 0, 0);
            printer.printDocument.DefaultPageSettings.Margins = margins;
            printer.PrintPreviewNoDisplay(dataGridView1_Clients_installment);
        }

        private void button3_Click(object sender, EventArgs e)
        {
      
            try
            {
                con.Open();
                String query = "SELECT ID, Client_Name , installment_Name , installment_value , Date_installment FROM Clients_installment WHERE Client_Name LIKE '%" + client_inst_search.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_Clients_installment.DataSource = dt;
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
