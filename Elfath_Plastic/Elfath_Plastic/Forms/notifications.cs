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
    public partial class notifications : Form
    {
        public notifications()
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
            String query = "SELECT ID , Notice , Notice_Start_Date , Notice_End_Date FROM Notice";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1_add_Notice.DataSource = load();
            dataGridView1_add_Notice.BorderStyle = BorderStyle.None;
            dataGridView1_add_Notice.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_Notice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_Notice.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_Notice.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_Notice.BackgroundColor = Color.White;
            dataGridView1_add_Notice.EnableHeadersVisualStyles = false;
            dataGridView1_add_Notice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_Notice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_Notice.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_Notice.Columns[0].HeaderText = "ID";
            dataGridView1_add_Notice.Columns[1].HeaderText = "التنبية";
            dataGridView1_add_Notice.Columns[2].HeaderText = "اليوم الاول للتنبية";
            dataGridView1_add_Notice.Columns[3].HeaderText = "اليوم الاخير للتنبية";
            
        }

        private void Add_save_clients_Notice_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Notice(Notice , Notice_Start_Date , Notice_End_Date) VALUES (@Notice , @Notice_Start_Date , @Notice_End_Date)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Notice", Notice.Text);
                cmd.Parameters.AddWithValue("@Notice_Start_Date", Notice_Start_Date.Text);
                cmd.Parameters.AddWithValue("@Notice_End_Date", Notice_End_Date.Text);
               
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Notice.DataSource = load();
                
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

        private void DataGridView1_add_Notice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_Notice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_Notice.CurrentRow.Selected = true;
                    Notice.Text = dataGridView1_add_Notice.Rows[e.RowIndex].Cells["Notice"].FormattedValue.ToString();
                    Notice_Start_Date.Text = dataGridView1_add_Notice.Rows[e.RowIndex].Cells["Notice_Start_Date"].FormattedValue.ToString();
                    Notice_End_Date.Text = dataGridView1_add_Notice.Rows[e.RowIndex].Cells["Notice_End_Date"].FormattedValue.ToString();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_save_Notice_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Notice SET Notice=@Notice , Notice_Start_Date=@Notice_Start_Date , Notice_End_Date=@Notice_End_Date WHERE ID=" + dataGridView1_add_Notice.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Notice", Notice.Text);
                cmd.Parameters.AddWithValue("@Notice_Start_Date", Notice_Start_Date.Text);
                cmd.Parameters.AddWithValue("@Notice_End_Date", Notice_End_Date.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Notice.DataSource = load();
                

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

        private void Delete_save_Notice_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Notice WHERE ID=" + dataGridView1_add_Notice.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Notice.DataSource = load();
                

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

        private void Btn_search_Notice_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Notice , Notice_Start_Date , Notice_End_Date FROM Notice WHERE Notice LIKE '%" + search_Notice.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_Notice.DataSource = dt;
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
