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

namespace Elfath_Plastic.Forms
{
    public partial class products : Form
    {
        public products()
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
            String query = "SELECT ID , Product_Name , Unit , Price , Notes FROM Products";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        private void Products_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1_add_products.DataSource = load();
            dataGridView1_add_products.BorderStyle = BorderStyle.None;
            dataGridView1_add_products.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_products.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_products.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_products.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_products.BackgroundColor = Color.White;
            dataGridView1_add_products.EnableHeadersVisualStyles = false;
            dataGridView1_add_products.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_products.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_products.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_products.Columns[0].HeaderText = "ID";
            dataGridView1_add_products.Columns[1].HeaderText = "اسم المنتج";
            dataGridView1_add_products.Columns[2].HeaderText = "الوحدة";
            dataGridView1_add_products.Columns[3].HeaderText = "سعر البيع";
            dataGridView1_add_products.Columns[4].HeaderText = "ملاحظات";

        }

        private void Add_save_products_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Products(Product_Name , Unit , Price , Notes ) VALUES (@Product_Name , @Unit , @Price , @Notes)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Product_Name", Product_Name.Text);
                cmd.Parameters.AddWithValue("@Unit", Unit.Text);
                cmd.Parameters.AddWithValue("@Price", Price.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_products.DataSource = load();
                
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

        private void DataGridView1_add_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_products.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_products.CurrentRow.Selected = true;
                    Product_Name.Text = dataGridView1_add_products.Rows[e.RowIndex].Cells["Product_Name"].FormattedValue.ToString();
                    Unit.Text = dataGridView1_add_products.Rows[e.RowIndex].Cells["Unit"].FormattedValue.ToString();
                    Price.Text = dataGridView1_add_products.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    Notes.Text = dataGridView1_add_products.Rows[e.RowIndex].Cells["Notes"].FormattedValue.ToString();
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_save_products_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Products SET Product_Name=@Product_Name , Unit=@Unit , Price=@Price , Notes=@Notes WHERE ID=" + dataGridView1_add_products.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Product_Name", Product_Name.Text);
                cmd.Parameters.AddWithValue("@Unit", Unit.Text);
                cmd.Parameters.AddWithValue("@Price", Price.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_products.DataSource = load();
                

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

        private void Delete_save_products_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Products WHERE ID=" + dataGridView1_add_products.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_products.DataSource = load();
                

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

        private void Btn_search_products_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Product_Name , Unit , Price , Notes FROM Products WHERE Product_Name LIKE '%" + search_products.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_products.DataSource = dt;
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
