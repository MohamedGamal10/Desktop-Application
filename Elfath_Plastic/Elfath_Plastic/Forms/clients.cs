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
    public partial class clients : Form
    {
        public clients()
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
            String query= "SELECT ID , Client_Name , Email , Phone , Mobile , adderss , Bank_Number , Strategies , Notes FROM Clients";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

       

        public void Insert()
        {
            try { 
            con.Open();
            String query= "INSERT INTO Clients(Client_Name, Email , Phone , Mobile , adderss , Bank_Number , Strategies , Notes ) VALUES (@Client_Name, @Email , @Phone , @Mobile , @adderss , @Bank_Number, @Strategies , @Notes)";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Client_Name", Client_Name.Text);
            cmd.Parameters.AddWithValue("@Email", Email.Text);
            cmd.Parameters.AddWithValue("@Phone", Phone_Number.Text);
            cmd.Parameters.AddWithValue("@Mobile", Mobile_Number.Text);
            cmd.Parameters.AddWithValue("@adderss", Address.Text);
            cmd.Parameters.AddWithValue("@Bank_Number", num_bank.Text);
            cmd.Parameters.AddWithValue("@Strategies", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Notes", Notes.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1_add_clients.DataSource = load();
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


        private void Clients_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridView1_add_clients.DataSource = load();
            dataGridView1_add_clients.BorderStyle = BorderStyle.None;
            dataGridView1_add_clients.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_clients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_clients.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_clients.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_clients.BackgroundColor = Color.White;
            dataGridView1_add_clients.EnableHeadersVisualStyles = false;
            dataGridView1_add_clients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_clients.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_clients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_clients.Columns[0].HeaderText = "ID";
            dataGridView1_add_clients.Columns[1].HeaderText = "اسم العميل";
            dataGridView1_add_clients.Columns[2].HeaderText = "الاميل";
            dataGridView1_add_clients.Columns[3].HeaderText = "رقم الهاتف";
            dataGridView1_add_clients.Columns[4].HeaderText = "رقم الموبيل";
            dataGridView1_add_clients.Columns[5].HeaderText = "العنوان";
            dataGridView1_add_clients.Columns[6].HeaderText = "الحساب البنكي";
            dataGridView1_add_clients.Columns[7].HeaderText = "مستوي التسعير";
            dataGridView1_add_clients.Columns[8].HeaderText = "ملاحظات";


            dataGridView1_display_clients.BorderStyle = BorderStyle.None;
            dataGridView1_display_clients.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_display_clients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_display_clients.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_display_clients.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_display_clients.BackgroundColor = Color.White;
            dataGridView1_display_clients.EnableHeadersVisualStyles = false;
            dataGridView1_display_clients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_display_clients.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_display_clients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_display_clients.Columns.Add("", "");
            dataGridView1_display_clients.Columns.Add("", "");
            dataGridView1_display_clients.Columns.Add("", "");
            dataGridView1_display_clients.Columns.Add("", "");
            dataGridView1_display_clients.Columns.Add("", "");
            dataGridView1_display_clients.Rows.Add("", "");
            dataGridView1_display_clients.Columns[0].HeaderText = "اسم العميل";
            dataGridView1_display_clients.Columns[1].HeaderText = "رصيد مدين (علي العميل)";
            dataGridView1_display_clients.Columns[2].HeaderText = "رصيد دائن (علي المصنع)";
            dataGridView1_display_clients.Columns[3].HeaderText = "الاقساط";
            dataGridView1_display_clients.Columns[4].HeaderText = "مجموع حساب العميل";

            try
            {
                con.Open();
                String query = "SELECT Client_Name FROM Clients";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2_clients.Items.Add(reader[0].ToString());
                    
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

        private void DataGridView1_add_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_clients.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1_add_clients.CurrentRow.Selected = true;
                Client_Name.Text = dataGridView1_add_clients.Rows[e.RowIndex].Cells["Client_Name"].FormattedValue.ToString();
                Email.Text = dataGridView1_add_clients.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                Phone_Number.Text = dataGridView1_add_clients.Rows[e.RowIndex].Cells["Phone"].FormattedValue.ToString();
                Mobile_Number.Text = dataGridView1_add_clients.Rows[e.RowIndex].Cells["Mobile"].FormattedValue.ToString();
                Address.Text = dataGridView1_add_clients.Rows[e.RowIndex].Cells["adderss"].FormattedValue.ToString();
                num_bank.Text = dataGridView1_add_clients.Rows[e.RowIndex].Cells["Bank_Number"].FormattedValue.ToString();
                comboBox1.Text = dataGridView1_add_clients.Rows[e.RowIndex].Cells["Strategies"].FormattedValue.ToString();
                Notes.Text = dataGridView1_add_clients.Rows[e.RowIndex].Cells["Notes"].FormattedValue.ToString();

            }

            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Update_save_clients_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Clients SET Client_Name = @Client_Name , Email = @Email , Phone=@Phone , Mobile=@Mobile , adderss=@adderss , Bank_Number=@Bank_Number , Strategies=@Strategies , Notes=@Notes WHERE ID=" + dataGridView1_add_clients.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Client_Name", Client_Name.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Phone", Phone_Number.Text);
                cmd.Parameters.AddWithValue("@Mobile", Mobile_Number.Text);
                cmd.Parameters.AddWithValue("@adderss", Address.Text);
                cmd.Parameters.AddWithValue("@Bank_Number", num_bank.Text);
                cmd.Parameters.AddWithValue("@Strategies", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_clients.DataSource = load();


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
                string query = "DELETE FROM Clients WHERE ID=" + dataGridView1_add_clients.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_clients.DataSource = load();
                

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
                String query = "SELECT ID ,  Client_Name , Email , Phone , Mobile , adderss , Bank_Number , Strategies , Notes FROM Clients WHERE Client_Name LIKE '%" + search.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_clients.DataSource = dt;
            }
            catch(Exception ex)
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
                String query = "SELECT Sales.Client_Name, Sum(Sales.Credit_Balance) AS SumOfCredit_Balance, Sum(Sales.Debit_Balance) AS SumOfDebit_Balance, Sum([Debit_Balance]-[Credit_Balance]) AS Expr1 FROM Sales GROUP BY Sales.Client_Name HAVING(((Sales.Client_Name) LIKE '%" + search_display.Text + "%'))";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_display_clients.DataSource = dt;
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

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void clients_status_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "كشف حساب العملاء";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            Margins margins = new Margins(0, 0, 0, 0);
            printer.printDocument.DefaultPageSettings.Margins = margins;
            printer.PrintPreviewNoDisplay(dataGridView1_display_clients);
        }

        private void Search_Status_Clients_Click(object sender, EventArgs e)
        {
            float on_client_float = 0, on_factory_float = 0, inst_float = 0;
            try
            {
                con.Open();
                String query = "SELECT Sum(Sales.Credit_Balance) AS SumOfCredit_Balance FROM Sales WHERE (((Sales.Client_Name)="+ "'"+comboBox2_clients.Text + "'" + "))";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (reader[0].ToString() == "")
                    {
                        on_client_float = 0;
                    }
                    else
                    {
                        on_client_float = float.Parse(reader[0].ToString());
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
                String query = "SELECT Sum(Sales.Debit_Balance) AS Debit_Balance FROM Sales WHERE (((Sales.Client_Name)=" + "'" + comboBox2_clients.Text + "'" + "))";
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
                String query = "SELECT Sum(Clients_installment.installment_value) AS SumOfinstallment_value FROM Clients_installment WHERE (((Clients_installment.Client_Name)=" + "'" + comboBox2_clients.Text + "'" + "))";
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
                    
                    
                    float diff = ((on_factory_float+ inst_float)- on_client_float);
                    dataGridView1_display_clients.Rows[0].Cells[0].Value = comboBox2_clients.Text;
                    dataGridView1_display_clients.Rows[0].Cells[1].Value = on_client_float.ToString();
                    dataGridView1_display_clients.Rows[0].Cells[2].Value = on_factory_float.ToString();
                    dataGridView1_display_clients.Rows[0].Cells[3].Value = inst_float.ToString();
                    dataGridView1_display_clients.Rows[0].Cells[4].Value = diff.ToString();



                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            

        }

        private void comboBox2_clients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
