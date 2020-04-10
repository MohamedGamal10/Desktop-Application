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
    public partial class products_store : Form
    {
        public products_store()
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
            String query = "SELECT ID , Product_Name , Quantity , Last_Check_Date FROM Products_Store";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void Products_store_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1_add_products_store.DataSource = load();
            dataGridView1_add_products_store.BorderStyle = BorderStyle.None;
            dataGridView1_add_products_store.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_products_store.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_products_store.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_products_store.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_products_store.BackgroundColor = Color.White;
            dataGridView1_add_products_store.EnableHeadersVisualStyles = false;
            dataGridView1_add_products_store.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_products_store.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_products_store.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_products_store.Columns[0].HeaderText = "ID";
            dataGridView1_add_products_store.Columns[1].HeaderText = "اسم المنتج";
            dataGridView1_add_products_store.Columns[2].HeaderText = "الكمية";
            dataGridView1_add_products_store.Columns[3].HeaderText = "تاريخ اخر تحديث";


        }

        private void Add_save_products_store_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Products_Store(Product_Name , Quantity , Last_Check_Date) VALUES (@Product_Name , @Quantity , @Last_Check_Date)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Product_Name", Product_Name.Text);
                cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                cmd.Parameters.AddWithValue("@Last_Check_Date", Last_Check_Date.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_products_store.DataSource = load();
               
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

        private void DataGridView1_add_products_store_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_products_store.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_products_store.CurrentRow.Selected = true;
                    Product_Name.Text = dataGridView1_add_products_store.Rows[e.RowIndex].Cells["Product_Name"].FormattedValue.ToString();
                    Quantity.Text = dataGridView1_add_products_store.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                    Last_Check_Date.Text = dataGridView1_add_products_store.Rows[e.RowIndex].Cells["Last_Check_Date"].FormattedValue.ToString();
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_save_products_store_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Products_Store SET Product_Name=@Product_Name , Quantity=@Quantity , Last_Check_Date=@Last_Check_Date WHERE ID=" + dataGridView1_add_products_store.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Product_Name", Product_Name.Text);
                cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                cmd.Parameters.AddWithValue("@Last_Check_Date", Last_Check_Date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_products_store.DataSource = load();
                

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

        private void Delete_save_products_store_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Products_Store WHERE ID=" + dataGridView1_add_products_store.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_products_store.DataSource = load();
                

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

        private void Btn_search_products_store_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Product_Name , Quantity , Last_Check_Date FROM Products_Store WHERE Product_Name LIKE '%" + search_products_store.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_products_store.DataSource = dt;
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
