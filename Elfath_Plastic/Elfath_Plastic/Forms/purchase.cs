﻿using System;
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

            try
            {
                con.Open();
                String query = "SELECT Supplier_Name FROM Suppliers";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Supplier_Name.Items.Add(reader[0].ToString());
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
                Int32 val1 = Convert.ToInt32(Weight.Text);
                Int32 val2 = Convert.ToInt32(Price.Text);
                Int32 val3 = Convert.ToInt32(Discount.Text);
                Int32 val4 = (val1 * val2)-val3;
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
                con.Open();
                String query = "SELECT ID ,  Purchase_Invoice_Date , Supplier_Name , Discount , Material_Name , Weight , Price , Total_invoice , Amount_Paid , Notes , Credit_Balance , Debit_Balance FROM Purchase WHERE Purchase_Invoice_Date Between #" + from.Text + "# And #"+to.Text+"#";
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

        
    }
}

