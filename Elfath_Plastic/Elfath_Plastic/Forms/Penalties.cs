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
    public partial class Penalties : Form
    {
        public Penalties()
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
            String query = "SELECT ID , Employee_Name , Penalty , Penalty_Date , Penalty_Value FROM Penalties";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }


        private void Penalties_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridView1_add_Penalties.DataSource = load();
            dataGridView1_add_Penalties.BorderStyle = BorderStyle.None;
            dataGridView1_add_Penalties.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_Penalties.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_Penalties.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_Penalties.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_Penalties.BackgroundColor = Color.White;
            dataGridView1_add_Penalties.EnableHeadersVisualStyles = false;
            dataGridView1_add_Penalties.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_Penalties.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_Penalties.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_Penalties.Columns[0].HeaderText = "ID";
            dataGridView1_add_Penalties.Columns[1].HeaderText = "اسم الموظف";
            dataGridView1_add_Penalties.Columns[2].HeaderText = "الجزاء";
            dataGridView1_add_Penalties.Columns[3].HeaderText = "تاريخ الجزاء";
            dataGridView1_add_Penalties.Columns[4].HeaderText = "قيمة الجزاء";

            try
            {
                con.Open();
                String query = "SELECT Employee_Name FROM Employees";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee_Name.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Add_save_Penalties_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Penalties(Employee_Name , Penalty , Penalty_Date , Penalty_Value) VALUES (@Employee_Name , @Penalty , @Penalty_Date , @Penalty_Value)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Employee_Name", Employee_Name.Text);
                cmd.Parameters.AddWithValue("@Penalty", Penalty.Text);
                cmd.Parameters.AddWithValue("@Penalty_Date", Penalty_Date.Text);
                cmd.Parameters.AddWithValue("@Penalty_Value", Penalty_Value.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Penalties.DataSource = load();
                
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

        private void DataGridView1_add_Penalties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_Penalties.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_Penalties.CurrentRow.Selected = true;
                    Employee_Name.Text = dataGridView1_add_Penalties.Rows[e.RowIndex].Cells["Employee_Name"].FormattedValue.ToString();
                    Penalty.Text = dataGridView1_add_Penalties.Rows[e.RowIndex].Cells["Penalty"].FormattedValue.ToString();
                    Penalty_Date.Text = dataGridView1_add_Penalties.Rows[e.RowIndex].Cells["Penalty_Date"].FormattedValue.ToString();
                    Penalty_Value.Text = dataGridView1_add_Penalties.Rows[e.RowIndex].Cells["Penalty_Value"].FormattedValue.ToString();
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_save_Penalties_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Penalties SET Employee_Name=@Employee_Name , Penalty=@Penalty , Penalty_Date=@Penalty_Date , Penalty_Value=@Penalty_Value WHERE ID=" + dataGridView1_add_Penalties.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Employee_Name", Employee_Name.Text);
                cmd.Parameters.AddWithValue("@Penalty", Penalty.Text);
                cmd.Parameters.AddWithValue("@Penalty_Date", Penalty_Date.Text);
                cmd.Parameters.AddWithValue("@Penalty_Value", Penalty_Value.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Penalties.DataSource = load();
                

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

        private void Delete_save_Penalties_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Penalties WHERE ID=" + dataGridView1_add_Penalties.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Penalties.DataSource = load();
                

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

        private void Btn_search_Penalties_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Employee_Name , Penalty , Penalty_Date , Penalty_Value FROM Penalties WHERE Employee_Name LIKE '%" + search_Penalties.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_Penalties.DataSource = dt;
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
