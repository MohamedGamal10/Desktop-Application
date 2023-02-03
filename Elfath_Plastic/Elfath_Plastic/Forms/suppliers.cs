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
    public partial class suppliers : Form
    {
        public suppliers()
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
            String query = "SELECT ID ,  Supplier_Name , Mobile_Number , Address , Bank_Account_Number FROM Suppliers";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

       

        public void Insert()
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Suppliers (Supplier_Name , Mobile_Number , Address , Bank_Account_Number) VALUES (@Supplier_Name , @Mobile_Number , @Address , @Bank_Account_Number)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Supplier_Name", Supplier_Name.Text);
                cmd.Parameters.AddWithValue("@Mobile_Number", Mobile_Number.Text);
                cmd.Parameters.AddWithValue("@Address", Address.Text);
                cmd.Parameters.AddWithValue("@Bank_Account_Number", num_bank.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_suppliers.DataSource = load();
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

        private void Suppliers_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1_add_suppliers.DataSource = load();
            dataGridView1_add_suppliers.BorderStyle = BorderStyle.None;
            dataGridView1_add_suppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_suppliers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_suppliers.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_suppliers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_suppliers.BackgroundColor = Color.White;
            dataGridView1_add_suppliers.EnableHeadersVisualStyles = false;
            dataGridView1_add_suppliers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_suppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_suppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_suppliers.Columns[0].HeaderText = "ID";
            dataGridView1_add_suppliers.Columns[1].HeaderText = "اسم التاجر";
            dataGridView1_add_suppliers.Columns[2].HeaderText = "رقم الموبيل";
            dataGridView1_add_suppliers.Columns[3].HeaderText = "العنوان";
            dataGridView1_add_suppliers.Columns[4].HeaderText = "رقم الحساب البنكي";



            dataGridView1_display_suppliers.BorderStyle = BorderStyle.None;
            dataGridView1_display_suppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_display_suppliers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_display_suppliers.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_display_suppliers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_display_suppliers.BackgroundColor = Color.White;
            dataGridView1_display_suppliers.EnableHeadersVisualStyles = false;
            dataGridView1_display_suppliers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_display_suppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_display_suppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            dataGridView1_display_suppliers.Columns.Add("", "");
            dataGridView1_display_suppliers.Columns.Add("", "");
            dataGridView1_display_suppliers.Columns.Add("", "");
            dataGridView1_display_suppliers.Columns.Add("", "");
            dataGridView1_display_suppliers.Columns.Add("", "");
            dataGridView1_display_suppliers.Rows.Add("", "");
            dataGridView1_display_suppliers.Columns[0].HeaderText = "اسم المورد";
            dataGridView1_display_suppliers.Columns[2].HeaderText = "رصيد مدين (علي المورد)";
            dataGridView1_display_suppliers.Columns[1].HeaderText = "رصيد دائن (علي المصنع)";
            dataGridView1_display_suppliers.Columns[3].HeaderText = "الاقساط";
            dataGridView1_display_suppliers.Columns[4].HeaderText = "مجموع حساب المصنع";

            try
            {
                con.Open();
                String query = "SELECT Supplier_Name FROM Suppliers";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2_Supplier.Items.Add(reader[0].ToString());

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_save_clients_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void DataGridView1_add_suppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_suppliers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_suppliers.CurrentRow.Selected = true;
                    Supplier_Name.Text = dataGridView1_add_suppliers.Rows[e.RowIndex].Cells["Supplier_Name"].FormattedValue.ToString();
                    Mobile_Number.Text = dataGridView1_add_suppliers.Rows[e.RowIndex].Cells["Mobile_Number"].FormattedValue.ToString();
                    Address.Text = dataGridView1_add_suppliers.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                    num_bank.Text = dataGridView1_add_suppliers.Rows[e.RowIndex].Cells["Bank_Account_Number"].FormattedValue.ToString();
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_save_clients_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Suppliers SET Supplier_Name=@Supplier_Name , Mobile_Number=@Mobile_Number , Address=@Address , Bank_Account_Number=@Bank_Account_Number WHERE ID=" + dataGridView1_add_suppliers.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Supplier_Name", Supplier_Name.Text);
                cmd.Parameters.AddWithValue("@Mobile_Number", Mobile_Number.Text);
                cmd.Parameters.AddWithValue("@Address", Address.Text);
                cmd.Parameters.AddWithValue("@Bank_Account_Number", num_bank.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_suppliers.DataSource = load();
                

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

        private void Delete_save_clients_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Suppliers WHERE ID=" + dataGridView1_add_suppliers.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_suppliers.DataSource = load();

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

        private void Btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID ,  Supplier_Name , Mobile_Number , Address , Bank_Account_Number FROM Suppliers WHERE Supplier_Name LIKE '%" + search_suppliers.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_suppliers.DataSource = dt;
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

        private void Search_btn_display_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT Purchase.Supplier_Name, Sum(Purchase.Credit_Balance) AS SumOfCredit_Balance, Sum(Purchase.Debit_Balance) AS SumOfDebit_Balance, Sum([Debit_Balance]-[Credit_Balance]) AS Expr1 FROM Purchase GROUP BY Purchase.Supplier_Name HAVING(((Purchase.Supplier_Name) LIKE '%" + search_display_suppliers.Text + "%'))";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_display_suppliers.DataSource = dt;
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

        private void print_suppliers_status_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "كشف حساب التجار";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            Margins margins = new Margins(0, 0, 0, 0);
            printer.printDocument.DefaultPageSettings.Margins = margins;
            printer.PrintPreviewNoDisplay(dataGridView1_display_suppliers);
        }

        private void Search_Status_ٍSupplier_Click(object sender, EventArgs e)
        {
            float on_supplier_float = 0, on_factory_float = 0, inst_float = 0;
            try
            {
                con.Open();
                String query = "SELECT Sum(Purchase.Credit_Balance) AS SumOfCredit_Balance FROM Purchase WHERE (((Purchase.Supplier_Name)=" + "'" + comboBox2_Supplier.Text + "'" + "))";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (reader[0].ToString() == "")
                    {
                        on_supplier_float = 0;
                    }
                    else
                    {
                        on_supplier_float = float.Parse(reader[0].ToString());
                    }


                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                con.Open();
                String query = "SELECT Sum(Purchase.Debit_Balance) AS Debit_Balance FROM Purchase WHERE (((Purchase.Supplier_Name)=" + "'" + comboBox2_Supplier.Text + "'" + "))";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (reader[0].ToString() == "")
                    {
                        on_factory_float = 0;
                    }
                    else
                    {
                        on_factory_float = float.Parse(reader[0].ToString());
                    }

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                con.Open();
                String query = "SELECT Sum(Factory_installment.installment_value) AS SumOfinstallment_value FROM Factory_installment WHERE (((Factory_installment.Supplier_Name)=" + "'" + comboBox2_Supplier.Text + "'" + "))";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                    {
                        inst_float = 0;
                    }
                    else
                    {
                        inst_float = float.Parse(reader[0].ToString());
                    }


                    float diff = ((on_factory_float + inst_float) - on_supplier_float);
                    dataGridView1_display_suppliers.Rows[0].Cells[0].Value = comboBox2_Supplier.Text;
                    dataGridView1_display_suppliers.Rows[0].Cells[1].Value = on_supplier_float.ToString();
                    dataGridView1_display_suppliers.Rows[0].Cells[2].Value = on_factory_float.ToString();
                    dataGridView1_display_suppliers.Rows[0].Cells[3].Value = inst_float.ToString();
                    dataGridView1_display_suppliers.Rows[0].Cells[4].Value = diff.ToString();



                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
