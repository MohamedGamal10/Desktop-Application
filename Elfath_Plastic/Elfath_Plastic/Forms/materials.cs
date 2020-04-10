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
    public partial class materials : Form
    {
        public materials()
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
            String query = "SELECT ID ,  Material_Name , Weight , Price , Notes FROM Materials";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        private void Materials_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridView1_add_materials.DataSource = load();
            dataGridView1_add_materials.BorderStyle = BorderStyle.None;
            dataGridView1_add_materials.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_materials.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_materials.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_materials.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_materials.BackgroundColor = Color.White;
            dataGridView1_add_materials.EnableHeadersVisualStyles = false;
            dataGridView1_add_materials.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_materials.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_materials.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_materials.Columns[0].HeaderText = "ID";
            dataGridView1_add_materials.Columns[1].HeaderText = "نوع الخامة";
            dataGridView1_add_materials.Columns[2].HeaderText = "الوزن";
            dataGridView1_add_materials.Columns[3].HeaderText = "السعر";
            dataGridView1_add_materials.Columns[4].HeaderText = "ملاحظات";
    
        }

        private void Add_save_materials_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Materials(Material_Name , Weight , Price , Notes ) VALUES (@Material_Name , @Weight , @Price , @Notes)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Material_Name", Material_Name.Text);
                cmd.Parameters.AddWithValue("@Weight", Weight.Text);
                cmd.Parameters.AddWithValue("@Price", Price.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_materials.DataSource = load();
                
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

        private void DataGridView1_add_materials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_materials.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_materials.CurrentRow.Selected = true;
                    Material_Name.Text = dataGridView1_add_materials.Rows[e.RowIndex].Cells["Material_Name"].FormattedValue.ToString();
                    Weight.Text = dataGridView1_add_materials.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
                    Price.Text = dataGridView1_add_materials.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    Notes.Text = dataGridView1_add_materials.Rows[e.RowIndex].Cells["Notes"].FormattedValue.ToString();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_save_materials_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Materials SET Material_Name=@Material_Name , Weight=@Weight , Price=@Price , Notes=@Notes WHERE ID=" + dataGridView1_add_materials.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Material_Name", Material_Name.Text);
                cmd.Parameters.AddWithValue("@Weight", Weight.Text);
                cmd.Parameters.AddWithValue("@Price", Price.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_materials.DataSource = load();
                

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

        private void Delete_save_materials_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Materials WHERE ID=" + dataGridView1_add_materials.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_materials.DataSource = load();
                

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

        private void Btn_search_materials_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Material_Name ,  Weight , Price , Notes FROM Materials WHERE Material_Name LIKE '%" + search_materials.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_materials.DataSource = dt;
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
