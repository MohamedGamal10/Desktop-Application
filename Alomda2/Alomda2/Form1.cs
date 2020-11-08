using Alomda2.Properties;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alomda2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        static String sql = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb; jet OLEDB:Database Password=''; Persist Security Info=True;";
        OleDbConnection con = new OleDbConnection(sql);
        public DataTable load_enter()
        {

            con.Open();
            String query = "SELECT Enter.ID, Enter.Seller_Name, Enter.Type_Of_Potatos, Enter.Weight, Enter.Number_of_Bags, Enter.Car_Number, Enter.Warehouse_Number, Enter.Date_of_Enter, Enter.Notes FROM Enter;";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable load_exit()
        {

            con.Open();
            String query = "SELECT Exit.ID, Exit.Seller_Name, Exit.Type_Of_Potatos, Exit.Weight, Exit.Price, Exit.Total, Exit.Number_of_Bags, Exit.Warehouse_Number, Exit.Client_Name, Exit.Date_Exit, Exit.Notes FROM Exit";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            da1.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable load_seller_name()
        {

            con.Open();
            String query = "SELECT Seller.ID, Seller.Seller_Name FROM Seller";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            da1.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable load_client_name()
        {

            con.Open();
            String query = "SELECT Client.ID, Client.Client_Name FROM Client";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            da1.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable load_potato()
        {

            con.Open();
            String query = "SELECT Potato.ID, Potato.Type_Of_Potatos FROM Potato";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            da1.Fill(dt);
            con.Close();
            return dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1_Enter.DataSource = load_enter();
            dataGridView1_Enter.Columns[0].HeaderText = "ID";
            dataGridView1_Enter.Columns[1].HeaderText = "اسم البائع";
            dataGridView1_Enter.Columns[2].HeaderText = "نوع البطاطس";
            dataGridView1_Enter.Columns[3].HeaderText = "الوزن";
            dataGridView1_Enter.Columns[4].HeaderText = "عدد الشكاير";
            dataGridView1_Enter.Columns[5].HeaderText = "رقم السيارة";
            dataGridView1_Enter.Columns[6].HeaderText = "رقم االعنبر";
            dataGridView1_Enter.Columns[7].HeaderText = "التاريخ";
            dataGridView1_Enter.Columns[8].HeaderText = "ملاحظات";

            for (int i = 0; i <= 8; i++)
            {
                DataGridViewColumn column = dataGridView1_Enter.Columns[i];
                column.Width = 168;
            }

            dataGridView1_Exit.DataSource = load_exit();

            dataGridView1_Exit.Columns[0].HeaderText = "ID";
            dataGridView1_Exit.Columns[1].HeaderText = "اسم البائع";
            dataGridView1_Exit.Columns[2].HeaderText = "نوع البطاطس";
            dataGridView1_Exit.Columns[3].HeaderText = "الوزن";
            dataGridView1_Exit.Columns[4].HeaderText = "السعر";
            dataGridView1_Exit.Columns[5].HeaderText = "الاجمالي";
            dataGridView1_Exit.Columns[6].HeaderText = "عدد الشكاير";
            dataGridView1_Exit.Columns[7].HeaderText = "رقم االعنبر";
            dataGridView1_Exit.Columns[8].HeaderText = "اسم المشتري";
            dataGridView1_Exit.Columns[9].HeaderText = "التاريخ";
            dataGridView1_Exit.Columns[10].HeaderText = "ملاحظات";

            for (int i = 0; i <= 8; i++)
            {
                DataGridViewColumn column = dataGridView1_Exit.Columns[i];
                column.Width = 150;


            }

            dataGridView1_seller_table.DataSource = load_seller_name();

            dataGridView1_seller_table.Columns[0].HeaderText = "ID";
            dataGridView1_seller_table.Columns[1].HeaderText = "اسم البائع";

            dataGridView2_client_table.DataSource = load_client_name();

            dataGridView2_client_table.Columns[0].HeaderText = "ID";
            dataGridView2_client_table.Columns[1].HeaderText = "اسم المشتري";

            dataGridView1_potato.DataSource = load_potato();

            dataGridView1_potato.Columns[0].HeaderText = "ID";
            dataGridView1_potato.Columns[1].HeaderText = "نوع البطاطس";

            ///////////////////////////////////////////////
            try
            {
                con.Open();
                String query = "SELECT Seller_Name FROM Seller";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    seller_name.Items.Add(reader[0].ToString());
                    Seller_name_exit.Items.Add(reader[0].ToString());
                    seller_name_report.Items.Add(reader[0].ToString());
                    comboBox1_seller_Report.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ////////////////////////////////////////////////////
            try
            {
                con.Open();
                String query = "SELECT Client_Name FROM Client";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    client_name_exit.Items.Add(reader[0].ToString());
                    client_name_report.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ////////////////////////////////////////////////////////
            try
            {
                con.Open();
                String query = "SELECT Type_Of_Potatos FROM Potato";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    potatos_type.Items.Add(reader[0].ToString());
                    potatos_type_exit.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void add_enter_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Enter(Seller_Name , Type_Of_Potatos , Weight, Number_of_Bags, Car_Number, Warehouse_Number, Date_of_Enter, Notes) VALUES (@Seller_Name , @Type_Of_Potatos , @Weight, @Number_of_Bags, @Car_Number, @Warehouse_Number, @Date_of_Enter, @Notes)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Seller_Name", seller_name.Text);
                cmd.Parameters.AddWithValue("@Type_Of_Potatos", potatos_type.Text);
                cmd.Parameters.AddWithValue("@Weight", Weight.Text);
                cmd.Parameters.AddWithValue("@Number_of_Bags", Number_of_Bags.Text);
                cmd.Parameters.AddWithValue("@Car_Number", Car_Number.Text);
                cmd.Parameters.AddWithValue("@Warehouse_Number", Warehouse_Number.Text);
                cmd.Parameters.AddWithValue("@Date_of_Enter", Date_of_Enter.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_Enter.DataSource = load_enter();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            ///////////////////////////////////////////////////////////////////////////////
            
        }

        private void update_enter_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Enter SET Seller_Name = @Seller_Name , Type_Of_Potatos=@Type_Of_Potatos , Weight=@Weight , Number_of_Bags=@Number_of_Bags , Car_Number=@Car_Number , Warehouse_Number=@Warehouse_Number , Date_of_Enter=@Date_of_Enter , Notes=@Notes WHERE ID=" + dataGridView1_Enter.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Seller_Name", seller_name.Text);
                cmd.Parameters.AddWithValue("@Type_Of_Potatos", potatos_type.Text);
                cmd.Parameters.AddWithValue("@Weight", Weight.Text);
                cmd.Parameters.AddWithValue("@Number_of_Bags", Number_of_Bags.Text);
                cmd.Parameters.AddWithValue("@Car_Number", Car_Number.Text);
                cmd.Parameters.AddWithValue("@Warehouse_Number", Warehouse_Number.Text);
                cmd.Parameters.AddWithValue("@Date_of_Enter", Date_of_Enter.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_Enter.DataSource = load_enter();


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

        private void dataGridView1_Enter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_Enter.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_Enter.CurrentRow.Selected = true;
                    seller_name.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Seller_Name"].FormattedValue.ToString();
                    potatos_type.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Type_Of_Potatos"].FormattedValue.ToString();
                    Weight.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
                    Number_of_Bags.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Number_of_Bags"].FormattedValue.ToString();
                    Car_Number.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Car_Number"].FormattedValue.ToString();
                    Warehouse_Number.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Warehouse_Number"].FormattedValue.ToString();
                    Date_of_Enter.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Date_of_Enter"].FormattedValue.ToString();
                    Notes.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Notes"].FormattedValue.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_enter_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Enter WHERE ID=" + dataGridView1_Enter.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_Enter.DataSource = load_enter();


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

        private void dataGridView1_Enter_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_Enter.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_Enter.CurrentRow.Selected = true;
                    seller_name.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Seller_Name"].FormattedValue.ToString();
                    potatos_type.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Type_Of_Potatos"].FormattedValue.ToString();
                    Weight.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
                    Number_of_Bags.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Number_of_Bags"].FormattedValue.ToString();
                    Car_Number.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Car_Number"].FormattedValue.ToString();
                    Warehouse_Number.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Warehouse_Number"].FormattedValue.ToString();
                    Date_of_Enter.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Date_of_Enter"].FormattedValue.ToString();
                    Notes.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Notes"].FormattedValue.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_Enter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_Enter.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_Enter.CurrentRow.Selected = true;
                    seller_name.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Seller_Name"].FormattedValue.ToString();
                    potatos_type.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Type_Of_Potatos"].FormattedValue.ToString();
                    Weight.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
                    Number_of_Bags.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Number_of_Bags"].FormattedValue.ToString();
                    Car_Number.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Car_Number"].FormattedValue.ToString();
                    Warehouse_Number.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Warehouse_Number"].FormattedValue.ToString();
                    Date_of_Enter.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Date_of_Enter"].FormattedValue.ToString();
                    Notes.Text = dataGridView1_Enter.Rows[e.RowIndex].Cells["Notes"].FormattedValue.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void add_exit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Exit(Seller_Name, Type_Of_Potatos, Weight, Price, Total, Number_of_Bags, Warehouse_Number, Client_Name, Date_Exit, Notes) VALUES (@Seller_Name, @Type_Of_Potatos, @Weight, @Price, @Total, @Number_of_Bags, @Warehouse_Number, @Client_Name, @Date_Exit, @Notes)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Seller_Name", Seller_name_exit.Text);
                cmd.Parameters.AddWithValue("@Type_Of_Potatos", potatos_type_exit.Text);
                cmd.Parameters.AddWithValue("@Weight", Wight_exit.Text);
                cmd.Parameters.AddWithValue("@Price", price_exit.Text);
                cmd.Parameters.AddWithValue("@Total", total_exit.Text);
                cmd.Parameters.AddWithValue("@Number_of_Bags", number_of_bage_exit.Text);
                cmd.Parameters.AddWithValue("@Warehouse_Number", Warehouse_number_exit.Text);
                cmd.Parameters.AddWithValue("@Client_Name", client_name_exit.Text);
                cmd.Parameters.AddWithValue("@Date_Exit", date_exit.Text);
                cmd.Parameters.AddWithValue("@Notes", notes_Exit.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_Exit.DataSource = load_exit();

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Weight = int.Parse(Wight_exit.Text);
                int price = int.Parse(price_exit.Text);
                int total = Weight * price;
                total_exit.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_Exit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_Exit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_Exit.CurrentRow.Selected = true;
                    Seller_name_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Seller_Name"].FormattedValue.ToString();
                    potatos_type_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Type_Of_Potatos"].FormattedValue.ToString();
                    Wight_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
                    price_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    total_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Total"].FormattedValue.ToString();
                    number_of_bage_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Number_of_Bags"].FormattedValue.ToString();
                    Warehouse_number_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Warehouse_Number"].FormattedValue.ToString();
                    client_name_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Client_Name"].FormattedValue.ToString();
                    date_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Date_Exit"].FormattedValue.ToString();
                    notes_Exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Notes"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Exit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_Exit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_Exit.CurrentRow.Selected = true;
                    Seller_name_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Seller_Name"].FormattedValue.ToString();
                    potatos_type_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Type_Of_Potatos"].FormattedValue.ToString();
                    Wight_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
                    price_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    total_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Total"].FormattedValue.ToString();
                    number_of_bage_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Number_of_Bags"].FormattedValue.ToString();
                    Warehouse_number_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Warehouse_Number"].FormattedValue.ToString();
                    client_name_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Client_Name"].FormattedValue.ToString();
                    date_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Date_Exit"].FormattedValue.ToString();
                    notes_Exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Notes"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Exit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_Exit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_Exit.CurrentRow.Selected = true;
                    Seller_name_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Seller_Name"].FormattedValue.ToString();
                    potatos_type_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Type_Of_Potatos"].FormattedValue.ToString();
                    Wight_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
                    price_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    total_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Total"].FormattedValue.ToString();
                    number_of_bage_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Number_of_Bags"].FormattedValue.ToString();
                    Warehouse_number_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Warehouse_Number"].FormattedValue.ToString();
                    client_name_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Client_Name"].FormattedValue.ToString();
                    date_exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Date_Exit"].FormattedValue.ToString();
                    notes_Exit.Text = dataGridView1_Exit.Rows[e.RowIndex].Cells["Notes"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_exit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Exit SET Seller_Name = @Seller_Name , Type_Of_Potatos=@Type_Of_Potatos , Weight=@Weight , Price=@Price , Total=@Total , Number_of_Bags=@Number_of_Bags , Warehouse_Number=@Warehouse_Number ,Client_Name=@Client_Name , Date_Exit=@Date_Exit , Notes=@Notes WHERE ID=" + dataGridView1_Exit.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Seller_Name", Seller_name_exit.Text);
                cmd.Parameters.AddWithValue("@Type_Of_Potatos", potatos_type_exit.Text);
                cmd.Parameters.AddWithValue("@Weight", Wight_exit.Text);
                cmd.Parameters.AddWithValue("@Price", price_exit.Text);
                cmd.Parameters.AddWithValue("@Total", total_exit.Text);
                cmd.Parameters.AddWithValue("@Number_of_Bags", number_of_bage_exit.Text);
                cmd.Parameters.AddWithValue("@Warehouse_Number", Warehouse_number_exit.Text);
                cmd.Parameters.AddWithValue("@Client_Name", client_name_exit.Text);
                cmd.Parameters.AddWithValue("@Date_Exit", date_exit.Text);
                cmd.Parameters.AddWithValue("@Notes", notes_Exit.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_Exit.DataSource = load_exit();


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

        private void delete_exit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Exit WHERE ID=" + dataGridView1_Exit.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_Exit.DataSource = load_exit();


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

        private void Search_enter_Click(object sender, EventArgs e)
        {

            if (checkBox1_enter.Checked)
            {

                try
                {
                    con.Open();
                    string s = "SELECT Enter.Seller_Name, Enter.Type_Of_Potatos, Enter.Weight, Enter.Number_of_Bags, Enter.Car_Number, Enter.Warehouse_Number, Enter.Date_of_Enter, Enter.Notes FROM Enter WHERE(((Enter.Seller_Name) LIKE '%" + seller_name_report.Text + "%'))";
                    OleDbCommand cmd = new OleDbCommand(s, con);
                    OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds, "Enter");
                    seller cr1 = new seller();
                    cr1.SetDataSource(ds);
                    crystalReport_Seller.ReportSource = cr1;
                    crystalReport_Seller.Refresh();
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

            else
            {

                try
                {
                    con.Open();
                    string s = "SELECT Enter.Seller_Name, Enter.Type_Of_Potatos, Enter.Weight, Enter.Number_of_Bags, Enter.Car_Number, Enter.Warehouse_Number, Enter.Date_of_Enter, Enter.Notes FROM Enter WHERE (((Enter.Seller_Name) LIKE '%" + seller_name_report.Text + "%') AND ((Enter.Date_of_Enter) Between #" + dateTimePicker_from_enter.Text + "# And #" + dateTimePicker_to_enter.Text + "#))";
                    OleDbCommand cmd = new OleDbCommand(s, con);
                    OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds, "Enter");
                    seller cr1 = new seller();
                    cr1.SetDataSource(ds);
                    crystalReport_Seller.ReportSource = cr1;
                    crystalReport_Seller.Refresh();
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

        private void Search_exit_Click(object sender, EventArgs e)
        {
            if (checkBox2_exit.Checked)
            {

                try
                {
                    con.Open();
                    string s = "SELECT Exit.Seller_Name, Exit.Type_Of_Potatos, Exit.Weight, Exit.Price, Exit.Total, Exit.Number_of_Bags, Exit.Client_Name, Exit.Date_Exit, Exit.Notes FROM Exit WHERE(((Exit.Seller_Name) LIKE '%" + client_name_report.Text + "%'))";
                    OleDbCommand cmd = new OleDbCommand(s, con);
                    OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds, "Enter");
                    client cr1 = new client();
                    cr1.SetDataSource(ds);
                    crystalReport_exit.ReportSource = cr1;
                    crystalReport_exit.Refresh();
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

            else
            {

                try
                {
                    con.Open();
                    string s = "SELECT Exit.Seller_Name, Exit.Type_Of_Potatos, Exit.Weight, Exit.Price, Exit.Total, Exit.Number_of_Bags, Exit.Client_Name, Exit.Date_Exit, Exit.Notes FROM Exit WHERE (((Exit.Seller_Name) LIKE '%" + client_name_report.Text + "%') AND ((Exit.Date_Exit) Between #" + dateTimePicker_from_exit_report.Text + "# And #" + dateTimePicker_to_exit_report.Text + "#))";
                    OleDbCommand cmd = new OleDbCommand(s, con);
                    OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds, "Exit");
                    client cr1 = new client();
                    cr1.SetDataSource(ds);
                    crystalReport_exit.ReportSource = cr1;
                    crystalReport_exit.Refresh();
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

        private void Search_Date_Click(object sender, EventArgs e)
        {
            
            if(radioButton1_Enter_Date.Checked)
            {
                if(checkBox1_Date.Checked)
                {
                    try
                    {
                        con.Open();
                        string s = "SELECT Enter.* FROM Enter";
                        OleDbCommand cmd = new OleDbCommand(s, con);
                        OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adap.Fill(ds, "Enter");
                        Enter_Date cr1 = new Enter_Date();
                        TextObject text1 = (TextObject)cr1.ReportDefinition.Sections["Section1"].ReportObjects["From"];
                        text1.Text = "كل العمليات";
                        TextObject text2 = (TextObject)cr1.ReportDefinition.Sections["Section1"].ReportObjects["To"];
                        text2.Text = "كل العمليات";
                        cr1.SetDataSource(ds);
                        crystalReportViewer1_Date.ReportSource = cr1;
                        crystalReportViewer1_Date.Refresh();
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
                else
                {
                    try
                    {
                        con.Open();
                        string s = "SELECT Enter.Seller_Name, Enter.Type_Of_Potatos, Enter.Weight, Enter.Number_of_Bags, Enter.Car_Number, Enter.Warehouse_Number, Enter.Date_of_Enter, Enter.Notes FROM Enter WHERE ((Enter.Date_of_Enter) Between #" + dateTimePicker2_From_date.Text + "# And #" + dateTimePicker1_to_Date.Text + "#)";
                        OleDbCommand cmd = new OleDbCommand(s, con);
                        OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adap.Fill(ds, "Enter");
                        Enter_Date cr1 = new Enter_Date();
                        TextObject text1 = (TextObject)cr1.ReportDefinition.Sections["Section1"].ReportObjects["From"];
                        text1.Text = dateTimePicker2_From_date.Text;
                        TextObject text2 = (TextObject)cr1.ReportDefinition.Sections["Section1"].ReportObjects["To"];
                        text2.Text = dateTimePicker1_to_Date.Text;
                        cr1.SetDataSource(ds);
                        crystalReportViewer1_Date.ReportSource = cr1;
                        crystalReportViewer1_Date.Refresh();
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
            else
            {
                if(checkBox1_Date.Checked)
                {
                    try
                    {
                        con.Open();
                        string s = "SELECT Exit.* FROM Exit";
                        OleDbCommand cmd = new OleDbCommand(s, con);
                        OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adap.Fill(ds, "Exit");
                        Exit_Date cr11 = new Exit_Date();
                        TextObject text1 = (TextObject)cr11.ReportDefinition.Sections["Section1"].ReportObjects["From"];
                        text1.Text = "كل العمليات";
                        TextObject text2 = (TextObject)cr11.ReportDefinition.Sections["Section1"].ReportObjects["To"];
                        text2.Text = "كل العمليات";
                        cr11.SetDataSource(ds);
                        crystalReportViewer1_Date.ReportSource = cr11;
                        crystalReportViewer1_Date.Refresh();
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
                else
                {
                    try
                    {
                        con.Open();
                        string s = "SELECT Exit.Seller_Name, Exit.Type_Of_Potatos, Exit.Weight, Exit.Price, Exit.Total, Exit.Number_of_Bags, Exit.Client_Name, Exit.Date_Exit, Exit.Notes FROM Exit WHERE ((Exit.Date_Exit) Between #" + dateTimePicker2_From_date.Text + "# And #" + dateTimePicker1_to_Date.Text + "#)";
                        OleDbCommand cmd = new OleDbCommand(s, con);
                        OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adap.Fill(ds, "Exit");
                        Exit_Date cr12 = new Exit_Date();
                        TextObject text1 = (TextObject)cr12.ReportDefinition.Sections["Section1"].ReportObjects["From"];
                        text1.Text = dateTimePicker2_From_date.Text;
                        TextObject text2 = (TextObject)cr12.ReportDefinition.Sections["Section1"].ReportObjects["To"];
                        text2.Text = dateTimePicker1_to_Date.Text;
                        cr12.SetDataSource(ds);
                        crystalReportViewer1_Date.ReportSource = cr12;
                        crystalReportViewer1_Date.Refresh();
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void seller_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void seller_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Seller(Seller_Name) VALUES (@Seller_Name)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Seller_Name", seller_name_add.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_seller_table.DataSource = load_seller_name();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            seller_name.Items.Clear();
            Seller_name_exit.Items.Clear();
            seller_name_report.Items.Clear();
            comboBox1_seller_Report.Items.Clear();
            try
            {
                con.Open();
                String query = "SELECT Seller_Name FROM Seller";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    seller_name.Items.Add(reader[0].ToString());
                    Seller_name_exit.Items.Add(reader[0].ToString());
                    seller_name_report.Items.Add(reader[0].ToString());
                    comboBox1_seller_Report.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_seller_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_seller_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_seller_table.CurrentRow.Selected = true;
                    seller_name_add.Text = dataGridView1_seller_table.Rows[e.RowIndex].Cells["Seller_Name"].FormattedValue.ToString();
               

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_seller_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_seller_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_seller_table.CurrentRow.Selected = true;
                    seller_name_add.Text = dataGridView1_seller_table.Rows[e.RowIndex].Cells["Seller_Name"].FormattedValue.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_seller_table_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_seller_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_seller_table.CurrentRow.Selected = true;
                    seller_name_add.Text = dataGridView1_seller_table.Rows[e.RowIndex].Cells["Seller_Name"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void seller_update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Seller SET Seller_Name = @Seller_Name  WHERE ID=" + dataGridView1_seller_table.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Seller_Name", seller_name_add.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_seller_table.DataSource = load_seller_name();

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            seller_name.Items.Clear();
            Seller_name_exit.Items.Clear();
            seller_name_report.Items.Clear();
            comboBox1_seller_Report.Items.Clear();
            try
            {
                con.Open();
                String query = "SELECT Seller_Name FROM Seller";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    seller_name.Items.Add(reader[0].ToString());
                    Seller_name_exit.Items.Add(reader[0].ToString());
                    seller_name_report.Items.Add(reader[0].ToString());
                    comboBox1_seller_Report.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void seller_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Seller WHERE ID=" + dataGridView1_seller_table.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_seller_table.DataSource = load_seller_name();

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            seller_name.Items.Clear();
            Seller_name_exit.Items.Clear();
            seller_name_report.Items.Clear();
            comboBox1_seller_Report.Items.Clear();
            try
            {
                con.Open();
                String query = "SELECT Seller_Name FROM Seller";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    seller_name.Items.Add(reader[0].ToString());
                    Seller_name_exit.Items.Add(reader[0].ToString());
                    seller_name_report.Items.Add(reader[0].ToString());
                    comboBox1_seller_Report.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void client_add_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                String query = "INSERT INTO Client(Client_Name) VALUES (@Client_Name)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Client_Name", client_name_add.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView2_client_table.DataSource = load_client_name();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            client_name_exit.Items.Clear();
            client_name_report.Items.Clear();
            try
            {
                con.Open();
                String query = "SELECT Client_Name FROM Client";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    client_name_exit.Items.Add(reader[0].ToString());
                    client_name_report.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_client_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2_client_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_seller_table.CurrentRow.Selected = true;
                    client_name_add.Text = dataGridView2_client_table.Rows[e.RowIndex].Cells["Client_Name"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_client_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2_client_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_seller_table.CurrentRow.Selected = true;
                    client_name_add.Text = dataGridView2_client_table.Rows[e.RowIndex].Cells["Client_Name"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_client_table_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2_client_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_seller_table.CurrentRow.Selected = true;
                    client_name_add.Text = dataGridView2_client_table.Rows[e.RowIndex].Cells["Client_Name"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void client_update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Client SET Client_Name = @SClient_Name  WHERE ID=" + dataGridView2_client_table.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Client_Name", client_name_add.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView2_client_table.DataSource = load_client_name();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            client_name_exit.Items.Clear();
            client_name_report.Items.Clear();
            try
            {
                con.Open();
                String query = "SELECT Client_Name FROM Client";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    client_name_exit.Items.Add(reader[0].ToString());
                    client_name_report.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void client_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Client WHERE ID=" + dataGridView2_client_table.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView2_client_table.DataSource = load_client_name();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            client_name_exit.Items.Clear();
            client_name_report.Items.Clear();
            try
            {
                con.Open();
                String query = "SELECT Client_Name FROM Client";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    client_name_exit.Items.Add(reader[0].ToString());
                    client_name_report.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Potato_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Potato(Type_Of_Potatos) VALUES (@Type_Of_Potatos)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Type_Of_Potatos", potato_type_add.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_potato.DataSource = load_potato();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            potatos_type.Items.Clear();
            potatos_type_exit.Items.Clear();
            try
            {
                con.Open();
                String query = "SELECT Type_Of_Potatos FROM Potato";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    potatos_type.Items.Add(reader[0].ToString());
                    potatos_type_exit.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_potato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_potato.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_potato.CurrentRow.Selected = true;
                    potato_type_add.Text = dataGridView1_potato.Rows[e.RowIndex].Cells["Type_Of_Potatos"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_potato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_potato.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_potato.CurrentRow.Selected = true;
                    potato_type_add.Text = dataGridView1_potato.Rows[e.RowIndex].Cells["Type_Of_Potatos"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_potato_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_potato.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_potato.CurrentRow.Selected = true;
                    potato_type_add.Text = dataGridView1_potato.Rows[e.RowIndex].Cells["Type_Of_Potatos"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void potato_update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Potato SET Type_Of_Potatos = @Type_Of_Potatos  WHERE ID=" + dataGridView1_potato.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Client_Name", potato_type_add.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_potato.DataSource = load_potato();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            potatos_type.Items.Clear();
            potatos_type_exit.Items.Clear();
            try
            {
                con.Open();
                String query = "SELECT Type_Of_Potatos FROM Potato";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    potatos_type.Items.Add(reader[0].ToString());
                    potatos_type_exit.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void potato_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Potato WHERE ID=" + dataGridView1_potato.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_potato.DataSource = load_potato();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            potatos_type.Items.Clear();
            potatos_type_exit.Items.Clear();
            try
            {
                con.Open();
                String query = "SELECT Type_Of_Potatos FROM Potato";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    potatos_type.Items.Add(reader[0].ToString());
                    potatos_type_exit.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void button2_Seller_Report_Click(object sender, EventArgs e)
        {
            
            ArrayList type_of_potato_Enter = new ArrayList();
            string Sum_Weight_Enter = "";
            string Sum_Bags_Enter = "";
            string Sum_Weight_Exit = "";
            string Sum_Bags_Exit = "";
            int Remain_Weight = 0;
            int Remain_Bags = 0;
            ///////////////////////
            try
            {

                con.Open();
                String query1 = "DELETE * FROM Total_Seller;";
                OleDbCommand cmd1 = new OleDbCommand(query1, con);
                cmd1.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }
            /////////////////////////
            try
            {
                
                con.Open();
                String query1 = "SELECT DISTINCT Enter.Type_Of_Potatos FROM Enter WHERE(((Enter.Seller_Name) = '"+comboBox1_seller_Report.Text+"'));";
                OleDbCommand cmd1 = new OleDbCommand(query1, con);
                OleDbDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    type_of_potato_Enter.Add(reader1.GetValue(0).ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }
            //////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < type_of_potato_Enter.Count; i++) 
            {
                //MessageBox.Show(type_of_potato_Enter[i].ToString());
                ///////////////////
                try
                {

                    con.Open();
                    String query2 = "SELECT Sum(Enter.Weight) AS SumOfWeight, Sum(Enter.Number_of_Bags) AS SumOfNumber_of_Bags FROM Enter WHERE(((Enter.Seller_Name) = '" + comboBox1_seller_Report.Text + "')) GROUP BY Enter.Type_Of_Potatos HAVING(((Enter.Type_Of_Potatos)= '" + type_of_potato_Enter[i].ToString() + "'));";
                    OleDbCommand cmd2 = new OleDbCommand(query2, con);
                    OleDbDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        if (reader2.HasRows)
                        {
                            Sum_Weight_Enter = reader2[0].ToString();
                            Sum_Bags_Enter = reader2[1].ToString();
                        }
                        else
                        {
                            Sum_Weight_Enter = "0";
                            Sum_Bags_Enter = "0";
                        }
                        
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                ///////////////////
                try
                {

                    con.Open();
                    String query3 = "SELECT Sum(Exit.Weight) AS SumOfWeight, Sum(Exit.Number_of_Bags) AS SumOfNumber_of_Bags FROM Exit WHERE (((Exit.Seller_Name)='" + comboBox1_seller_Report.Text + "')) GROUP BY Exit.Type_Of_Potatos HAVING (((Exit.Type_Of_Potatos)='" + type_of_potato_Enter[i].ToString() + "'));";
                    OleDbCommand cmd3 = new OleDbCommand(query3, con);
                    OleDbDataReader reader3 = cmd3.ExecuteReader();
                    while (reader3.Read())
                    {
                        if (reader3.HasRows)
                        {
                            Sum_Weight_Exit = reader3[0].ToString();
                            Sum_Bags_Exit = reader3[1].ToString();
                        }
                        else
                        {
                            Sum_Weight_Exit = "0";
                            Sum_Bags_Exit = "0";
                        }
                        
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                /////////////////
                if(Sum_Weight_Enter == "" & Sum_Bags_Enter=="")
                {
                    Sum_Weight_Enter = "0";
                    Sum_Bags_Enter = "0";
                }
                if (Sum_Weight_Exit == "" & Sum_Bags_Exit == "")
                {
                    Sum_Weight_Exit = "0";
                    Sum_Bags_Exit = "0";
                }
                Remain_Weight = int.Parse(Sum_Weight_Enter) - int.Parse(Sum_Weight_Exit);
                Remain_Bags = int.Parse(Sum_Bags_Enter) - int.Parse(Sum_Bags_Exit);
                /////////////////
                try
                {
                    con.Open();
                    String query = "INSERT INTO Total_Seller(Seller_Name,Potato_Type,Remain_Weight,Remain_Bags) VALUES (@Seller_Name,@Potato_Type,@Remain_Weight,@Remain_Bags)";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@Seller_Name", comboBox1_seller_Report.Text);
                    cmd.Parameters.AddWithValue("@Potato_Type", type_of_potato_Enter[i].ToString());
                    cmd.Parameters.AddWithValue("@Remain_Weight", Remain_Weight);
                    cmd.Parameters.AddWithValue("@Remain_Bags", Remain_Bags);
                    cmd.ExecuteNonQuery();
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

            try
            {
                con.Open();
                string s = "SELECT Total_Seller.* FROM Total_Seller ";
                OleDbCommand cmd = new OleDbCommand(s, con);
                OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds, "Total_Seller");
                CrystalReport_total_seller cr1 = new CrystalReport_total_seller();
                cr1.SetDataSource(ds);
                crystalReportViewer1_Seller_Report_Remain.ReportSource = cr1;
                crystalReportViewer1_Seller_Report_Remain.Refresh();
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

        private void Warehouse_btn_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                String query1 = "DELETE * FROM Enter_Warehouse;";
                OleDbCommand cmd1 = new OleDbCommand(query1, con);
                String query2 = "DELETE * FROM Exit_Warehouse;";
                OleDbCommand cmd2 = new OleDbCommand(query2, con);
                String query3 = "DELETE * FROM Total_Warehouse;";
                OleDbCommand cmd3 = new OleDbCommand(query3, con);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }
            ////////////////////////////////////////////////////////////////////////
            try
            {
                con.Open();
                String query = "INSERT INTO Enter_Warehouse ( Seller_Name_Enter, Potatos_Type_Enter, Warehouse_Enter, Number_of_bages_Enter, Weight_Enter ) SELECT Enter.Seller_Name, Enter.Type_Of_Potatos,Enter.Warehouse_Number, Enter.Number_of_Bags, Enter.Weight FROM Enter WHERE (((Enter.Warehouse_Number)="+Warehouse_total.Text+ "));";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
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
                String query = "INSERT INTO Exit_Warehouse ( Seller_Name_Exit, Potatos_Type_Exit, Warehouse_Exit, Number_of_bages_Exit, Weight_Exit ) SELECT Exit.Seller_Name, Exit.Type_Of_Potatos,Exit.Warehouse_Number, Exit.Number_of_Bags, Exit.Weight FROM Exit WHERE (((Exit.Warehouse_Number)=" + Warehouse_total.Text + "));";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
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
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            ArrayList Enter_Warehouse_Seller_Name_Enter = new ArrayList();
            ArrayList Enter_Warehouse_Potatos_Type_Enter = new ArrayList();
            ArrayList Exit_Warehouse_Seller_Name_Exit = new ArrayList();
            ArrayList Exit_Warehouse_Potatos_Type_Exit = new ArrayList();
            try
            {

                con.Open();
                String query1 = "SELECT DISTINCT Enter_Warehouse.Seller_Name_Enter FROM Enter_Warehouse;";
                OleDbCommand cmd1 = new OleDbCommand(query1, con);
                OleDbDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    Enter_Warehouse_Seller_Name_Enter.Add(reader1.GetValue(0).ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }
            try
            {

                con.Open();
                String query1 = "SELECT DISTINCT Enter_Warehouse.Potatos_Type_Enter FROM Enter_Warehouse;";
                OleDbCommand cmd1 = new OleDbCommand(query1, con);
                OleDbDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    Enter_Warehouse_Potatos_Type_Enter.Add(reader1.GetValue(0).ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }
            try
            {

                con.Open();
                String query1 = "SELECT DISTINCT Exit_Warehouse.Seller_Name_Exit FROM Exit_Warehouse;";
                OleDbCommand cmd1 = new OleDbCommand(query1, con);
                OleDbDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    Exit_Warehouse_Seller_Name_Exit.Add(reader1.GetValue(0).ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }
            try
            {

                con.Open();
                String query1 = "SELECT DISTINCT Exit_Warehouse.Potatos_Type_Exit FROM Exit_Warehouse;";
                OleDbCommand cmd1 = new OleDbCommand(query1, con);
                OleDbDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    Exit_Warehouse_Potatos_Type_Exit.Add(reader1.GetValue(0).ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////
            
            string Sum_Number_of_bages_Enter_Warehouse = "";
            string Sum_Weight_Enter_Warehouse = "";
            string Sum_Number_of_bages_Exit_Warehouse = "";
            string Sum_Weight_Exit_Warehouse = "";
            int Remain_Weight = 0;
            int Remain_Bags = 0;
            string Sum_Weight_Enter = "";
            string Sum_Number_of_bages = "";
            for (int i=0; i< Enter_Warehouse_Seller_Name_Enter.Count; i++)
            {
                for (int j = 0; j < Enter_Warehouse_Potatos_Type_Enter.Count; j++)
                {
                    if(Exit_Warehouse_Seller_Name_Exit.Contains(Enter_Warehouse_Seller_Name_Enter[i].ToString())& Exit_Warehouse_Potatos_Type_Exit.Contains(Enter_Warehouse_Potatos_Type_Enter[j].ToString()))
                        {
                            //MessageBox.Show(Enter_Warehouse_Seller_Name_Enter[i].ToString()+"/"+ Enter_Warehouse_Potatos_Type_Enter[j].ToString()+"/ok");
                            try
                            {

                                con.Open();
                                String query1 = "SELECT Sum(Enter_Warehouse.Weight_Enter) AS SumOfWeight, Sum(Enter_Warehouse.Number_of_bages_Enter) AS SumOfNumber_of_Bags FROM Enter_Warehouse WHERE(((Enter_Warehouse.Seller_Name_Enter) = '" + Enter_Warehouse_Seller_Name_Enter[i].ToString() + "')) GROUP BY Enter_Warehouse.Potatos_Type_Enter HAVING(((Enter_Warehouse.Potatos_Type_Enter)= '" + Enter_Warehouse_Potatos_Type_Enter[j].ToString() + "'));";
                                OleDbCommand cmd1 = new OleDbCommand(query1, con);
                                OleDbDataReader reader1 = cmd1.ExecuteReader();
                                while (reader1.Read())
                                {
                                    if (reader1.HasRows)
                                    {
                                        Sum_Weight_Enter_Warehouse = reader1[0].ToString();
                                        Sum_Number_of_bages_Enter_Warehouse = reader1[1].ToString();
                                    }
                                    else
                                    {
                                    Sum_Weight_Enter_Warehouse = "0";
                                    Sum_Number_of_bages_Enter_Warehouse = "0";
                                    }

                                }
                                con.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                con.Close();
                            }
                        finally
                        {
                            con.Close();
                        }
                        try
                        {

                            con.Open();
                            String query1 = "SELECT Sum(Exit_Warehouse.Weight_Exit) AS SumOfWeight, Sum(Exit_Warehouse.Number_of_bages_Exit) AS SumOfNumber_of_Bags FROM Exit_Warehouse WHERE(((Exit_Warehouse.Seller_Name_Exit) = '" + Enter_Warehouse_Seller_Name_Enter[i].ToString() + "')) GROUP BY Exit_Warehouse.Potatos_Type_Exit HAVING(((Exit_Warehouse.Potatos_Type_Exit)= '" + Enter_Warehouse_Potatos_Type_Enter[j].ToString() + "'));";
                            OleDbCommand cmd1 = new OleDbCommand(query1, con);
                            OleDbDataReader reader1 = cmd1.ExecuteReader();
                            while (reader1.Read())
                            {
                                if (reader1.HasRows)
                                {
                                    Sum_Weight_Exit_Warehouse = reader1[0].ToString();
                                    Sum_Number_of_bages_Exit_Warehouse = reader1[1].ToString();
                                    
                                }
                                else
                                {
                                    Sum_Number_of_bages_Exit_Warehouse = "0";
                                    Sum_Weight_Exit_Warehouse = "0";
                                }

                            }
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                        finally
                        {
                            con.Close();
                        }

                        if (Sum_Weight_Enter_Warehouse == "" & Sum_Number_of_bages_Enter_Warehouse == "")
                        {
                            Sum_Weight_Enter_Warehouse = "0";
                            Sum_Number_of_bages_Enter_Warehouse = "0";
                        }
                        if (Sum_Weight_Exit_Warehouse == "" & Sum_Number_of_bages_Exit_Warehouse == "")
                        {
                            Sum_Weight_Exit_Warehouse = "0";
                            Sum_Number_of_bages_Exit_Warehouse = "0";
                        }
                        Remain_Weight = int.Parse(Sum_Weight_Enter_Warehouse) - int.Parse(Sum_Weight_Exit_Warehouse);
                        Remain_Bags = int.Parse(Sum_Number_of_bages_Enter_Warehouse) - int.Parse(Sum_Number_of_bages_Exit_Warehouse);
                        /////////////////
                        try
                        {
                            con.Open();
                            String query = "INSERT INTO Total_Warehouse (Seller_Name_Total,Potatos_Type_Total,Warehouse,Number_of_bages_total,Weight_Total) VALUES (@Seller_Name_Total,@Potatos_Type_Total,@Warehouse,@Number_of_bages_total,@Weight_Total)";
                            OleDbCommand cmd = new OleDbCommand(query, con);
                            cmd.Parameters.AddWithValue("@Seller_Name_Total", Enter_Warehouse_Seller_Name_Enter[i].ToString());
                            cmd.Parameters.AddWithValue("@Potatos_Type_Total", Enter_Warehouse_Potatos_Type_Enter[j].ToString());
                            cmd.Parameters.AddWithValue("@Warehouse", Warehouse_total.Text);
                            cmd.Parameters.AddWithValue("@Number_of_bages_total", Remain_Bags);
                            cmd.Parameters.AddWithValue("@Weight_Total", Remain_Weight);
                            cmd.ExecuteNonQuery();
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
                    else
                        {
                        //MessageBox.Show(Enter_Warehouse_Seller_Name_Enter[i].ToString() + "/" + Enter_Warehouse_Potatos_Type_Enter[j].ToString() + "/not");
                        try
                        {

                            con.Open();
                            String query1 = "SELECT Sum(Enter_Warehouse.Weight_Enter) AS SumOfWeight, Sum(Enter_Warehouse.Number_of_bages_Enter) AS SumOfNumber_of_Bags FROM Enter_Warehouse WHERE(((Enter_Warehouse.Seller_Name_Enter) = '" + Enter_Warehouse_Seller_Name_Enter[i].ToString() + "')) GROUP BY Enter_Warehouse.Potatos_Type_Enter HAVING(((Enter_Warehouse.Potatos_Type_Enter)= '" + Enter_Warehouse_Potatos_Type_Enter[j].ToString() + "'));";
                            OleDbCommand cmd1 = new OleDbCommand(query1, con);
                            OleDbDataReader reader1 = cmd1.ExecuteReader();
                            while (reader1.Read())
                            {
                                Sum_Weight_Enter = reader1[0].ToString();
                                Sum_Number_of_bages = reader1[1].ToString();

                            }
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                        finally
                        {
                            con.Close();
                        }
                        try
                        {
                            con.Open();
                            String query = "INSERT INTO Total_Warehouse (Seller_Name_Total,Potatos_Type_Total,Warehouse,Number_of_bages_total,Weight_Total) VALUES (@Seller_Name_Total,@Potatos_Type_Total,@Warehouse,@Number_of_bages_total,@Weight_Total)";
                            OleDbCommand cmd = new OleDbCommand(query, con);
                            cmd.Parameters.AddWithValue("@Seller_Name_Total", Enter_Warehouse_Seller_Name_Enter[i].ToString());
                            cmd.Parameters.AddWithValue("@Potatos_Type_Total", Enter_Warehouse_Potatos_Type_Enter[j].ToString());
                            cmd.Parameters.AddWithValue("@Warehouse", Warehouse_total.Text);
                            cmd.Parameters.AddWithValue("@Number_of_bages_total", Sum_Number_of_bages);
                            cmd.Parameters.AddWithValue("@Weight_Total", Sum_Weight_Enter);
                            cmd.ExecuteNonQuery();
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
            try
            {

                con.Open();
                String query1 = "DELETE Total_Warehouse.Seller_Name_Total, Total_Warehouse.Potatos_Type_Total, Total_Warehouse.Warehouse, Total_Warehouse.Number_of_bages_total, Total_Warehouse.Weight_Total FROM Total_Warehouse WHERE (((Total_Warehouse.Number_of_bages_total)='') AND ((Total_Warehouse.Weight_Total)=''));";
                OleDbCommand cmd1 = new OleDbCommand(query1, con);
                cmd1.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }

            try
            {
                con.Open();
                string s = "SELECT Total_Warehouse.* FROM Total_Warehouse ";
                OleDbCommand cmd = new OleDbCommand(s, con);
                OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds, "Total_Warehouse");
                Warehouse cr1 = new Warehouse();
                cr1.SetDataSource(ds);
                crystalReportViewer1_Warehouse.ReportSource = cr1;
                crystalReportViewer1_Warehouse.Refresh();
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
