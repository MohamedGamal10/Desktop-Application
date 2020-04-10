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
    public partial class reports : Form
    {
        public reports()
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
            String query = "SELECT Sales.Client_Name, Sum(Sales.Credit_Balance) AS SumOfCredit_Balance, Sum(Sales.Debit_Balance) AS SumOfDebit_Balance, Sum([Debit_Balance]-[Credit_Balance]) AS Expr1 FROM Sales GROUP BY Sales.Client_Name";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable load1()
        {

            con.Open();
            String query = "SELECT Purchase.Supplier_Name, Sum(Purchase.Credit_Balance) AS SumOfCredit_Balance, Sum(Purchase.Debit_Balance) AS SumOfDebit_Balance, Sum([Debit_Balance]-[Credit_Balance]) AS Expr1 FROM Purchase GROUP BY Purchase.Supplier_Name";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            LoadTheme();
            sales.DataSource = load();
            sales.BorderStyle = BorderStyle.None;
            sales.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            sales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            sales.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            sales.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            sales.BackgroundColor = Color.White;
            sales.EnableHeadersVisualStyles = false;
            sales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            sales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            sales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            sales.Columns[0].HeaderText = "اسم العميل";
            sales.Columns[1].HeaderText = "رصيد مدين (علي العميل)";
            sales.Columns[2].HeaderText = "رصيد دائن (علي المصنع)";
            sales.Columns[3].HeaderText = "حركة البيع للمصنع";

            LoadTheme();
            dataGridView1_Purchase.DataSource = load1();
            dataGridView1_Purchase.BorderStyle = BorderStyle.None;
            dataGridView1_Purchase.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_Purchase.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_Purchase.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_Purchase.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_Purchase.BackgroundColor = Color.White;
            dataGridView1_Purchase.EnableHeadersVisualStyles = false;
            dataGridView1_Purchase.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_Purchase.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_Purchase.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_Purchase.Columns[0].HeaderText = "اسم التاجر";
            dataGridView1_Purchase.Columns[1].HeaderText = "رصيد مدين (علي المصنع)";
            dataGridView1_Purchase.Columns[2].HeaderText = "رصيد دائن (للمصنع)";
            dataGridView1_Purchase.Columns[3].HeaderText = "حركة الشراء للمصنع";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT Sales.Client_Name, Sum(Sales.Credit_Balance) AS SumOfCredit_Balance, Sum(Sales.Debit_Balance) AS SumOfDebit_Balance, Sum([Debit_Balance]-[Credit_Balance]) AS Expr1 FROM Sales GROUP BY Sales.Client_Name HAVING(((Sales.Client_Name) LIKE '%" + txt_search.Text + "%'))";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                sales.DataSource = dt;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT Purchase.Supplier_Name, Sum(Purchase.Credit_Balance) AS SumOfCredit_Balance, Sum(Purchase.Debit_Balance) AS SumOfDebit_Balance, Sum([Debit_Balance]-[Credit_Balance]) AS Expr1 FROM Purchase GROUP BY Purchase.Supplier_Name HAVING(((Purchase.Supplier_Name) LIKE '%" + textBox1.Text + "%'))";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_Purchase.DataSource = dt;
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
