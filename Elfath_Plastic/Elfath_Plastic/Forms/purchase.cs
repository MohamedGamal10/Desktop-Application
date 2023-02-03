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
    public partial class purchase : Form
    {
        public purchase()
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
            String query = "SELECT ID ,  Purchase_Invoice_Date , Supplier_Name , Discount , Material_Name , Weight , Price , Total_invoice , Amount_Paid , Notes  , Credit_Balance , Debit_Balance FROM Purchase";
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
            String query = "SELECT ID, Supplier_Name , installment_Name , installment_value , Date_installment FROM Factory_installment";

            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridView1_add_purchase.DataSource = load();
            dataGridView1_add_purchase.BorderStyle = BorderStyle.None;
            dataGridView1_add_purchase.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_purchase.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_purchase.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_purchase.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_purchase.BackgroundColor = Color.White;
            dataGridView1_add_purchase.EnableHeadersVisualStyles = false;
            dataGridView1_add_purchase.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_purchase.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_purchase.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_purchase.Columns[0].HeaderText = "ID";
            dataGridView1_add_purchase.Columns[1].HeaderText = "تاريخ الفاتورة";
            dataGridView1_add_purchase.Columns[2].HeaderText = "اسم التاجر";
            dataGridView1_add_purchase.Columns[3].HeaderText = "الخصم";
            dataGridView1_add_purchase.Columns[4].HeaderText = "نوع الخامة";
            dataGridView1_add_purchase.Columns[5].HeaderText = "الوزن";
            dataGridView1_add_purchase.Columns[6].HeaderText = "السعر";
            dataGridView1_add_purchase.Columns[7].HeaderText = "المبلغ الكلي للفاتورة";
            dataGridView1_add_purchase.Columns[8].HeaderText = "المبلغ المدفوع";
            dataGridView1_add_purchase.Columns[9].HeaderText = "الملاحظات";
            dataGridView1_add_purchase.Columns[10].HeaderText = "رصيد دائن (له)";
            dataGridView1_add_purchase.Columns[11].HeaderText = "رصيد مدين (عليه)";

            dataGridView1_Factory_installment.DataSource = loadinstallments();
            dataGridView1_Factory_installment.BorderStyle = BorderStyle.None;
            dataGridView1_Factory_installment.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_Factory_installment.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_Factory_installment.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_Factory_installment.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_Factory_installment.BackgroundColor = Color.White;
            dataGridView1_Factory_installment.EnableHeadersVisualStyles = false;
            dataGridView1_Factory_installment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_Factory_installment.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_Factory_installment.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_Factory_installment.Columns[0].HeaderText = "ID";
            dataGridView1_Factory_installment.Columns[1].HeaderText = "اسم المورد";
            dataGridView1_Factory_installment.Columns[2].HeaderText = "اسم القسط";
            dataGridView1_Factory_installment.Columns[3].HeaderText = "قيمة القسط";
            dataGridView1_Factory_installment.Columns[4].HeaderText = "تاريخ القسط";

            try
            {
                con.Open();
                String query = "SELECT Supplier_Name FROM Suppliers";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Supplier_Name.Items.Add(reader[0].ToString());
                    comboBox1_Supplier_Name.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            


        }

        private void Add_save_purchase_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Purchase(Purchase_Invoice_Date , Supplier_Name , Discount , Material_Name , Weight , Price , Amount_Paid , Notes) VALUES (@Purchase_Invoice_Date , @Supplier_Name , @Discount , @Material_Name , @Weight , @Price , @Amount_Paid , @Notes)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Purchase_Invoice_Date", Purchase_Invoice_Date.Text);
                cmd.Parameters.AddWithValue("@Supplier_Name", Supplier_Name.Text);
                cmd.Parameters.AddWithValue("@Discount", Discount.Text);
                cmd.Parameters.AddWithValue("@Material_Name", Material_Name.Text);
                cmd.Parameters.AddWithValue("@Weight", Weight.Text);
                cmd.Parameters.AddWithValue("@Price", Price.Text);
                cmd.Parameters.AddWithValue("@Amount_Paid", Amount_Paid.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);
               
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_purchase.DataSource = load();
                
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
                String q8 = "INSERT INTO Expenses(Expense_Name , Expense_Value , Expense_Date) VALUES (@Expense_Name , @Expense_Value , @Expense_Date)";
                OleDbCommand cmd8 = new OleDbCommand(q8, con);
                cmd8.Parameters.AddWithValue("@Expense_Name", "شراء  "+ Weight.Text +" طن "+ Material_Name.Text +" من " + Supplier_Name.Text );
                cmd8.Parameters.AddWithValue("@Expense_Value", Amount_Paid.Text);
                cmd8.Parameters.AddWithValue("@Expense_Date", Purchase_Invoice_Date.Text);
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

        private void DataGridView1_add_purchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_purchase.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_purchase.CurrentRow.Selected = true;
                    Purchase_Invoice_Date.Text = dataGridView1_add_purchase.Rows[e.RowIndex].Cells["Purchase_Invoice_Date"].FormattedValue.ToString();
                    Supplier_Name.Text = dataGridView1_add_purchase.Rows[e.RowIndex].Cells["Supplier_Name"].FormattedValue.ToString();
                    Discount.Text = dataGridView1_add_purchase.Rows[e.RowIndex].Cells["Discount"].FormattedValue.ToString();
                    Material_Name.Text = dataGridView1_add_purchase.Rows[e.RowIndex].Cells["Material_Name"].FormattedValue.ToString();
                    Weight.Text = dataGridView1_add_purchase.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
                    Price.Text = dataGridView1_add_purchase.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    Amount_Paid.Text = dataGridView1_add_purchase.Rows[e.RowIndex].Cells["Amount_Paid"].FormattedValue.ToString();
                    Notes.Text = dataGridView1_add_purchase.Rows[e.RowIndex].Cells["Notes"].FormattedValue.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Update_save_purchase_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Purchase SET Purchase_Invoice_Date=@Purchase_Invoice_Date , Supplier_Name=@Supplier_Name , Discount=@Discount , Material_Name=@Material_Name , Weight=@Weight  , Price=@Price , Amount_Paid=@Amount_Paid , Notes=@Notes WHERE ID=" + dataGridView1_add_purchase.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Purchase_Invoice_Date", Purchase_Invoice_Date.Text);
                cmd.Parameters.AddWithValue("@Supplier_Name", Supplier_Name.Text);
                cmd.Parameters.AddWithValue("@Discount", Discount.Text);
                cmd.Parameters.AddWithValue("@Material_Name", Material_Name.Text);
                cmd.Parameters.AddWithValue("@Weight", Weight.Text);
                cmd.Parameters.AddWithValue("@Price", Price.Text);
                cmd.Parameters.AddWithValue("@Amount_Paid", Amount_Paid.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_purchase.DataSource = load();
                

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
                string var1 = "شراء  " + Weight.Text + " طن " + Material_Name.Text + " من " + Supplier_Name.Text; 
                con.Open();
                String q8 = "UPDATE Expenses SET Expense_Name=@Expense_Name , Expense_Value=@Expense_Value, Expense_Date=@Expense_Date WHERE Expense_Name LIKE '%" + var1 + "%'";
                OleDbCommand cmd8 = new OleDbCommand(q8, con);
                cmd8.Parameters.AddWithValue("@Expense_Name", "شراء  " + Weight.Text + " طن " + Material_Name.Text + " من " + Supplier_Name.Text);
                cmd8.Parameters.AddWithValue("@Expense_Value", Amount_Paid.Text);
                cmd8.Parameters.AddWithValue("@Expense_Date", Purchase_Invoice_Date.Text);
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

        private void Delete_save_purchase_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Purchase WHERE ID=" + dataGridView1_add_purchase.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_purchase.DataSource = load();
                

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
                string var1 = "شراء  " + Weight.Text + " طن " + Material_Name.Text + " من " + Supplier_Name.Text;
                con.Open();
                String q8 = "DELETE FROM  Expenses WHERE Expense_Name LIKE '%" + var1 + "%'";
                OleDbCommand cmd8 = new OleDbCommand(q8, con);
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

        private void Btn_search_purchase_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID ,  Purchase_Invoice_Date , Supplier_Name , Discount , Material_Name , Weight , Price , Total_invoice , Amount_Paid , Notes , Credit_Balance , Debit_Balance FROM Purchase WHERE Supplier_Name LIKE '%" + search_purchase.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_purchase.DataSource = dt;
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
                double val1 = Convert.ToDouble(Weight.Text);
                double val2 = Convert.ToDouble(Price.Text);
                double val3 = Convert.ToDouble(Discount.Text);
                double val4 = (val1 * val2)-val3;
                Total_invoice.Text = Convert.ToString(val4);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_from_to_Click(object sender, EventArgs e)
        {
            try
            {
                if (search_purchase.Text=="")
                {
                    con.Open();
                    String query = "SELECT ID ,  Purchase_Invoice_Date , Supplier_Name , Discount , Material_Name , Weight , Price , Total_invoice , Amount_Paid , Notes , Credit_Balance , Debit_Balance FROM Purchase WHERE Purchase_Invoice_Date Between #" + from.Text + "# And #" + to.Text + "#";
                    DataTable dt = new DataTable();
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    dataGridView1_add_purchase.DataSource = dt;

                }
                else
                {
                    con.Open();
                    String query = "SELECT ID ,  Purchase_Invoice_Date , Supplier_Name , Discount , Material_Name , Weight , Price , Total_invoice , Amount_Paid , Notes , Credit_Balance , Debit_Balance FROM Purchase WHERE Supplier_Name LIKE '%" + search_purchase.Text + "%' and Purchase_Invoice_Date Between #" + from.Text + "# And #" + to.Text + "#";
                    DataTable dt = new DataTable();
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    dataGridView1_add_purchase.DataSource = dt;

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
            printer.Title = "شراء";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            Margins margins = new Margins(0, 0, 0, 0);
            printer.printDocument.DefaultPageSettings.Margins = margins;
            this.dataGridView1_add_purchase.Columns["ID"].Visible = false;
            this.dataGridView1_add_purchase.Columns["Debit_Balance"].Visible = false;
            this.dataGridView1_add_purchase.Columns["Credit_Balance"].Visible = false;
            this.dataGridView1_add_purchase.Columns["Notes"].Visible = false;
            printer.PrintPreviewNoDisplay(dataGridView1_add_purchase);
            this.dataGridView1_add_purchase.Columns["ID"].Visible = true;
            this.dataGridView1_add_purchase.Columns["Debit_Balance"].Visible = true;
            this.dataGridView1_add_purchase.Columns["Credit_Balance"].Visible = true;
            this.dataGridView1_add_purchase.Columns["Notes"].Visible = true;







        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void to_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void from_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Material_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Supplier_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Purchase_Invoice_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void search_purchase_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Total_invoice_Click(object sender, EventArgs e)
        {

        }

        private void Notes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Amount_Paid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Factory_installment_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Factory_installment(Supplier_Name , installment_Name , installment_value , Date_installment) VALUES (@Supplier_Name , @installment_Name , @installment_value , @Date_installment)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Supplier_Name", comboBox1_Supplier_Name.Text);
                cmd.Parameters.AddWithValue("@installment_Name", installment_Name.Text);
                cmd.Parameters.AddWithValue("@installment_value", installment_value.Text);
                cmd.Parameters.AddWithValue("@Date_installment", Date_installment.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_Factory_installment.DataSource = loadinstallments();

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
                String q8 = "INSERT INTO Expenses(Expense_Name , Expense_Value , Expense_Date) VALUES (@Expense_Name , @Expense_Value , @Expense_Date)";
                OleDbCommand cmd8 = new OleDbCommand(q8, con);
                cmd8.Parameters.AddWithValue("@Expense_Name", "   دفع قسط الي المورد  " + comboBox1_Supplier_Name.Text + " عن    " + installment_Name.Text);
                cmd8.Parameters.AddWithValue("@Expense_Value", installment_value.Text);
                cmd8.Parameters.AddWithValue("@Expense_Date", Date_installment.Text);
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

        private void Factory_inst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_Factory_installment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_Factory_installment.CurrentRow.Selected = true;
                    Date_installment.Text = dataGridView1_Factory_installment.Rows[e.RowIndex].Cells["Date_installment"].FormattedValue.ToString();
                    comboBox1_Supplier_Name.Text = dataGridView1_Factory_installment.Rows[e.RowIndex].Cells["Supplier_Name"].FormattedValue.ToString();
                    installment_Name.Text = dataGridView1_Factory_installment.Rows[e.RowIndex].Cells["installment_Name"].FormattedValue.ToString();
                    installment_value.Text = dataGridView1_Factory_installment.Rows[e.RowIndex].Cells["installment_value"].FormattedValue.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Factory_installment_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Factory_installment SET Supplier_Name=@Supplier_Name , installment_Name=@installment_Name , installment_value=@installment_value , Date_installment=@Date_installment WHERE ID=" + dataGridView1_Factory_installment.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Client_Name", comboBox1_Supplier_Name.Text);
                cmd.Parameters.AddWithValue("@installment_Name", installment_Name.Text);
                cmd.Parameters.AddWithValue("@installment_value", installment_value.Text);
                cmd.Parameters.AddWithValue("@Date_installment", Date_installment.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_Factory_installment.DataSource = loadinstallments();


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
                string var1 = "   دفع قسط الي المورد  " + comboBox1_Supplier_Name.Text + " عن    " + installment_Name.Text;
                con.Open();
                String q8 = "UPDATE Expenses SET Expense_Name=@Expense_Name , Expense_Value=@Expense_Value, Expense_Date=@Expense_Date WHERE Expense_Name LIKE '%" + var1 + "%'";
                OleDbCommand cmd8 = new OleDbCommand(q8, con);
                cmd8.Parameters.AddWithValue("@Revenues_Name", "   دفع قسط الي المورد  " + comboBox1_Supplier_Name.Text + " عن    " + installment_Name.Text);
                cmd8.Parameters.AddWithValue("@Expense_Value", installment_value.Text);
                cmd8.Parameters.AddWithValue("@Expense_Date", Date_installment.Text);
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

        private void delete_Factory_installment_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Factory_installment WHERE ID=" + dataGridView1_Factory_installment.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_Factory_installment.DataSource = loadinstallments();


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
                string var1 = "   دفع قسط الي المورد  " + comboBox1_Supplier_Name.Text + " عن    " + installment_Name.Text;
                con.Open();
                string query = "DELETE FROM Expenses WHERE Expense_Name LIKE '%" + var1 + "%'";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_purchase.DataSource = load();


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

        private void print_Factory_installment_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "اقساط الموردين ";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            Margins margins = new Margins(0, 0, 0, 0);
            printer.printDocument.DefaultPageSettings.Margins = margins;
            printer.PrintPreviewNoDisplay(dataGridView1_Factory_installment);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID, Supplier_Name , installment_Name , installment_value , Date_installment FROM Factory_installment WHERE Supplier_Name LIKE '%" + Factory_inst_search.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_Factory_installment.DataSource = dt;
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

