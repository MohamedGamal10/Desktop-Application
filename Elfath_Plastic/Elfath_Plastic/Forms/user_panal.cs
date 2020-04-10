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
    public partial class user_panal : Form
    {
        public user_panal()
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
            String query = "SELECT ID , UserName , Password FROM User_Panal";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void User_panal_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridView1_add_panal.DataSource = load();
            dataGridView1_add_panal.BorderStyle = BorderStyle.None;
            dataGridView1_add_panal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_panal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_panal.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_panal.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_panal.BackgroundColor = Color.White;
            dataGridView1_add_panal.EnableHeadersVisualStyles = false;
            dataGridView1_add_panal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_panal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_panal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_panal.Columns[0].HeaderText = "ID";
            dataGridView1_add_panal.Columns[1].HeaderText = "اسم المستخدم";
            dataGridView1_add_panal.Columns[2].HeaderText = "باسورد";
            
        }

        private void Add_save_panal_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO User_Panal (UserName , [Password]) VALUES (@UserName , @Password)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@UserName", UserName.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_panal.DataSource = load();
                
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

        private void DataGridView1_add_panal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_panal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_panal.CurrentRow.Selected = true;
                    UserName.Text = dataGridView1_add_panal.Rows[e.RowIndex].Cells["UserName"].FormattedValue.ToString();
                    Password.Text = dataGridView1_add_panal.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();
                    
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_save_panal_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE User_Panal SET UserName=@UserName , [Password]=@Password  WHERE ID=" + dataGridView1_add_panal.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@UserName", UserName.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Text);
                
               
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_panal.DataSource = load();
                

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

        private void Delete_save_panal_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM User_Panal WHERE ID=" + dataGridView1_add_panal.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_panal.DataSource = load();
                

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

        private void Btn_search_panal_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , UserName , [Password] FROM User_Panal WHERE UserName LIKE '%" + search_panal.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_panal.DataSource = dt;
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
