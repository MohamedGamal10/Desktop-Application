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
    public partial class Installments : Form
    {
        public Installments()
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
            String query = "SELECT ID , Employee_Name , Advance_Payment_Value , Advance_Payment_Date FROM Installments";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void Installments_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridView1_add_Installments.DataSource = load();
            dataGridView1_add_Installments.BorderStyle = BorderStyle.None;
            dataGridView1_add_Installments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_Installments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_Installments.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_Installments.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_Installments.BackgroundColor = Color.White;
            dataGridView1_add_Installments.EnableHeadersVisualStyles = false;
            dataGridView1_add_Installments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_Installments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_Installments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_Installments.Columns[0].HeaderText = "ID";
            dataGridView1_add_Installments.Columns[1].HeaderText = "اسم الموظف";
            dataGridView1_add_Installments.Columns[2].HeaderText = "قيمة السلفة";
            dataGridView1_add_Installments.Columns[3].HeaderText = "تاريخ السلفة";
            


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

        private void Add_save_Installments_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Installments(Employee_Name , Advance_Payment_Value , Advance_Payment_Date ) VALUES (@Employee_Name , @Advance_Payment_Value , @Advance_Payment_Date)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Employee_Name", Employee_Name.Text);
                cmd.Parameters.AddWithValue("@Advance_Payment_Value", Advance_Payment_Value.Text);
                cmd.Parameters.AddWithValue("@Advance_Payment_Date", Advance_Payment_Date.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Installments.DataSource = load();
                
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

        private void DataGridView1_add_Installments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_Installments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_Installments.CurrentRow.Selected = true;
                    Employee_Name.Text = dataGridView1_add_Installments.Rows[e.RowIndex].Cells["Employee_Name"].FormattedValue.ToString();
                    Advance_Payment_Value.Text = dataGridView1_add_Installments.Rows[e.RowIndex].Cells["Advance_Payment_Value"].FormattedValue.ToString();
                    Advance_Payment_Date.Text = dataGridView1_add_Installments.Rows[e.RowIndex].Cells["Advance_Payment_Date"].FormattedValue.ToString();
                    
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_save_Installments_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Installments SET Employee_Name=@Employee_Name , Advance_Payment_Value=@Advance_Payment_Value , Advance_Payment_Date=@Advance_Payment_Date  WHERE ID=" + dataGridView1_add_Installments.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Employee_Name", Employee_Name.Text);
                cmd.Parameters.AddWithValue("@Advance_Payment_Value", Advance_Payment_Value.Text);
                cmd.Parameters.AddWithValue("@Advance_Payment_Date", Advance_Payment_Date.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Installments.DataSource = load();
                

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

        private void Delete_save_Installments_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Installments WHERE ID=" + dataGridView1_add_Installments.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Installments.DataSource = load();
                

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

        private void Btn_search_Installments_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Employee_Name , Advance_Payment_Value , Advance_Payment_Date FROM Installments WHERE Employee_Name LIKE '%" + search_Installments.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_Installments.DataSource = dt;
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
