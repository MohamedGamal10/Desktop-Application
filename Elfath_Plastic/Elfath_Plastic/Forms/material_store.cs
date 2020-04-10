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
    public partial class material_store : Form
    {
        public material_store()
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
            String query = "SELECT ID , Material_Name , Supplier_Name , Quantity , Last_Check_Date FROM Materials_Store";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void Material_store_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1_add_Materials_Store.DataSource = load();
            dataGridView1_add_Materials_Store.BorderStyle = BorderStyle.None;
            dataGridView1_add_Materials_Store.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_Materials_Store.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_Materials_Store.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_Materials_Store.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_Materials_Store.BackgroundColor = Color.White;
            dataGridView1_add_Materials_Store.EnableHeadersVisualStyles = false;
            dataGridView1_add_Materials_Store.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_Materials_Store.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_Materials_Store.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_Materials_Store.Columns[0].HeaderText = "ID";
            dataGridView1_add_Materials_Store.Columns[1].HeaderText = "نوع الخامة";
            dataGridView1_add_Materials_Store.Columns[2].HeaderText = "اسم التاجر";
            dataGridView1_add_Materials_Store.Columns[3].HeaderText = "الكمية";
            dataGridView1_add_Materials_Store.Columns[4].HeaderText = "اخر تحديث";


            

            try
            {
                con.Open();
                String query = "SELECT Supplier_Name FROM Suppliers";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
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

        private void Add_save_Materials_Store_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Materials_Store(Material_Name , Supplier_Name , Quantity , Last_Check_Date) VALUES (@Material_Name , @Supplier_Name , @Quantity , @Last_Check_Date)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Material_Name", Material_Name.Text);
                cmd.Parameters.AddWithValue("@Supplier_Name", Supplier_Name.Text);
                cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                cmd.Parameters.AddWithValue("@Last_Check_Date", Last_Check_Date.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Materials_Store.DataSource = load();
                
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

        private void DataGridView1_add_Materials_Store_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_Materials_Store.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_Materials_Store.CurrentRow.Selected = true;
                    Material_Name.Text = dataGridView1_add_Materials_Store.Rows[e.RowIndex].Cells["Material_Name"].FormattedValue.ToString();
                    Supplier_Name.Text = dataGridView1_add_Materials_Store.Rows[e.RowIndex].Cells["Supplier_Name"].FormattedValue.ToString();
                    Quantity.Text = dataGridView1_add_Materials_Store.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                    Last_Check_Date.Text = dataGridView1_add_Materials_Store.Rows[e.RowIndex].Cells["Last_Check_Date"].FormattedValue.ToString();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_save_Materials_Store_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Materials_Store SET Material_Name = @Material_Name , Supplier_Name = @Supplier_Name , Quantity=@Quantity , Last_Check_Date=@Last_Check_Date WHERE ID=" + dataGridView1_add_Materials_Store.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Material_Name", Material_Name.Text);
                cmd.Parameters.AddWithValue("@Supplier_Name", Supplier_Name.Text);
                cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                cmd.Parameters.AddWithValue("@Last_Check_Date", Last_Check_Date.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Materials_Store.DataSource = load();
                

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

        private void Delete_save_Materials_Store_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Materials_Store WHERE ID=" + dataGridView1_add_Materials_Store.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Materials_Store.DataSource = load();
                

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

        private void Btn_search_Materials_Store_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Material_Name , Supplier_Name , Quantity , Last_Check_Date FROM Materials_Store WHERE Material_Name LIKE '%" + search_Materials_Store.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_Materials_Store.DataSource = dt;
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
