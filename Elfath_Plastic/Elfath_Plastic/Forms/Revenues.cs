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
using DGVPrinterHelper;
using System.Drawing.Printing;

namespace Elfath_Plastic.Forms
{
    public partial class Revenues : Form
    {
        public Revenues()
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
            String query = "SELECT ID , Revenues_Name , Revenues_Value , Revenues_Date FROM Revenues";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void Revenues_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridView1_add_Revenues.DataSource = load();
            dataGridView1_add_Revenues.BorderStyle = BorderStyle.None;
            dataGridView1_add_Revenues.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_Revenues.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_Revenues.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_Revenues.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_Revenues.BackgroundColor = Color.White;
            dataGridView1_add_Revenues.EnableHeadersVisualStyles = false;
            dataGridView1_add_Revenues.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_Revenues.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_Revenues.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_Revenues.Columns[0].HeaderText = "ID";
            dataGridView1_add_Revenues.Columns[1].HeaderText = "بيان الايراد";
            dataGridView1_add_Revenues.Columns[2].HeaderText = "قيمة الايراد";
            dataGridView1_add_Revenues.Columns[3].HeaderText = "تاريخ الايراد";
        }

        private void Add_save_Revenues_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Revenues(Revenues_Name , Revenues_Value , Revenues_Date) VALUES (@Revenues_Name , @Revenues_Value , @Revenues_Date)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Revenues_Name", Revenues_Name.Text);
                cmd.Parameters.AddWithValue("@Revenues_Value", Revenues_Value.Text);
                cmd.Parameters.AddWithValue("@Revenues_Date", Revenues_Date.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Revenues.DataSource = load();
                
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

        private void Update_save_Revenues_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Revenues SET Revenues_Name=@Revenues_Name , Revenues_Value=@Revenues_Value , Revenues_Date=@Revenues_Date WHERE ID=" + dataGridView1_add_Revenues.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Revenues_Name", Revenues_Name.Text);
                cmd.Parameters.AddWithValue("@Revenues_Value", Revenues_Value.Text);
                cmd.Parameters.AddWithValue("@Revenues_Date", Revenues_Date.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Revenues.DataSource = load();
                

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

        private void DataGridView1_add_Revenues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_Revenues.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_Revenues.CurrentRow.Selected = true;
                    Revenues_Name.Text = dataGridView1_add_Revenues.Rows[e.RowIndex].Cells["Revenues_Name"].FormattedValue.ToString();
                    Revenues_Value.Text = dataGridView1_add_Revenues.Rows[e.RowIndex].Cells["Revenues_Value"].FormattedValue.ToString();
                    Revenues_Date.Text = dataGridView1_add_Revenues.Rows[e.RowIndex].Cells["Revenues_Date"].FormattedValue.ToString();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_save_Revenues_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Revenues WHERE ID=" + dataGridView1_add_Revenues.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_Revenues.DataSource = load();
                

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

        private void Btn_search_Revenues_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Revenues_Name , Revenues_Value , Revenues_Date FROM Revenues WHERE Revenues_Name LIKE '%" + search_Revenues.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_Revenues.DataSource = dt;
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
            printer.Title = "ايرادات";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            Margins margins = new Margins(0, 0, 0, 0);
            printer.printDocument.DefaultPageSettings.Margins = margins;
            this.dataGridView1_add_Revenues.Columns["ID"].Visible = false;
            printer.PrintPreviewNoDisplay(dataGridView1_add_Revenues);
            this.dataGridView1_add_Revenues.Columns["ID"].Visible = true;
        }

        private void Search_from_to_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Revenues_Name , Revenues_Value , Revenues_Date FROM Revenues WHERE Revenues_Date Between #" + from.Text + "# And #" + to.Text + "#";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_Revenues.DataSource = dt;
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

        private void Cal_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT Sum(Revenues.Revenues_Value) FROM Revenues WHERE Revenues_Date Between #" + from.Text + "# And #" + to.Text + "#";
                OleDbCommand cmd1 = new OleDbCommand(query, con);
                OleDbDataReader r1 = cmd1.ExecuteReader();
                r1.Read();
                cal_label.Text = r1[0].ToString();
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
