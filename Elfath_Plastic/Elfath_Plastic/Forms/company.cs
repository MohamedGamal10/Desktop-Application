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
    public partial class company : Form
    {
        public company()
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
            String query = "SELECT ID , Company_Name , Email , Address , Phone_Number , Mobile_Number1 , Mobile_Number2 , Website , Facebook_Account , Youtube_Account , LinkedIn_Account , Country , State , Postal_Code , Bank_Account_Number , Fax , Tax_number , Start_Financial_Year , End_Financial_Year FROM Company";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        /*public DataTable load2()
        {

            con.Open();
            String query = "SELECT Company_Name , Total_Credit_Balance , Total_Debit_Balance  FROM Company";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }*/

        public void Insert()
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Company(Company_Name , Email , Address , Phone_Number , Mobile_Number1 , Mobile_Number2 , Website , Facebook_Account , Youtube_Account , LinkedIn_Account , Country , State , Postal_Code , Bank_Account_Number , Fax , Tax_number , Start_Financial_Year , End_Financial_Year) VALUES (@Company_Name , @Email , @Address , @Phone_Number , @Mobile_Number1 , @Mobile_Number2, @Website , @Facebook_Account , @Youtube_Account , @LinkedIn_Account , @Country , @State , @Postal_Code , @Bank_Account_Number , @Fax , @Tax_number , @Start_Financial_Year , @End_Financial_Year)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Company_Name", Company_Name.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Address", Address.Text);
                cmd.Parameters.AddWithValue("@Phone_Number", Phone_Number.Text);
                cmd.Parameters.AddWithValue("@Mobile_Number1", Mobile_Number1.Text);
                cmd.Parameters.AddWithValue("@Mobile_Number2", Mobile_Number2.Text);
                cmd.Parameters.AddWithValue("@Website", Website.Text);
                cmd.Parameters.AddWithValue("@Facebook_Account", Facebook_Account.Text);
                cmd.Parameters.AddWithValue("@Youtube_Account", Youtube_Account.Text);
                cmd.Parameters.AddWithValue("@LinkedIn_Account", LinkedIn_Account.Text);
                cmd.Parameters.AddWithValue("@Country", Country.Text);
                cmd.Parameters.AddWithValue("@State", State.Text);
                cmd.Parameters.AddWithValue("@Postal_Code", Postal_Code.Text);
                cmd.Parameters.AddWithValue("@Bank_Account_Number", bank_num.Text);
                cmd.Parameters.AddWithValue("@Fax", Fax.Text);
                cmd.Parameters.AddWithValue("@Tax_number", Tax_number.Text);
                cmd.Parameters.AddWithValue("@Start_Financial_Year", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@End_Financial_Year", dateTimePicker2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView_add_company.DataSource = load();
                //dataGridView1_display_company.DataSource = load2();


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

        private void Company_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridView_add_company.DataSource = load();
            dataGridView_add_company.BorderStyle = BorderStyle.None;
            dataGridView_add_company.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_add_company.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_add_company.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_add_company.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_add_company.BackgroundColor = Color.White;
            dataGridView_add_company.EnableHeadersVisualStyles = false;
            dataGridView_add_company.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_add_company.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_add_company.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView_add_company.Columns[0].HeaderText = "ID";
            dataGridView_add_company.Columns[1].HeaderText = "اسم المصنع";
            dataGridView_add_company.Columns[2].HeaderText = "الاميل";
            dataGridView_add_company.Columns[3].HeaderText = "العنوان";
            dataGridView_add_company.Columns[4].HeaderText = "رقم الهاتف";
            dataGridView_add_company.Columns[5].HeaderText = "رقم الموبيل1";
            dataGridView_add_company.Columns[6].HeaderText = "رقم الموبيل2";
            dataGridView_add_company.Columns[7].HeaderText = "الموقع الالكتروني";
            dataGridView_add_company.Columns[8].HeaderText = "حساب الفيسبوك";
            dataGridView_add_company.Columns[9].HeaderText = "حساب اليوتيوب";
            dataGridView_add_company.Columns[10].HeaderText = "حساب لينكدن";
            dataGridView_add_company.Columns[11].HeaderText = "الدولة";
            dataGridView_add_company.Columns[12].HeaderText = "المحافظة";
            dataGridView_add_company.Columns[13].HeaderText = "الرقم البريدي";
            dataGridView_add_company.Columns[14].HeaderText = "رقم الحساب البنكي";
            dataGridView_add_company.Columns[15].HeaderText = "الفاكس";
            dataGridView_add_company.Columns[16].HeaderText = "الرقم الضريبي";
            dataGridView_add_company.Columns[17].HeaderText = "بداية السنة المالية";
            dataGridView_add_company.Columns[18].HeaderText = "نهاية السنة المالية";


            /*dataGridView1_display_company.DataSource = load2();
            dataGridView1_display_company.BorderStyle = BorderStyle.None;
            dataGridView1_display_company.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_display_company.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_display_company.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_display_company.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_display_company.BackgroundColor = Color.White;
            dataGridView1_display_company.EnableHeadersVisualStyles = false;
            dataGridView1_display_company.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_display_company.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_display_company.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_display_company.Columns[0].HeaderText = "اسم المصنع";
            dataGridView1_display_company.Columns[1].HeaderText = "الرصيد الدائن الكلي (له)";
            dataGridView1_display_company.Columns[2].HeaderText = "الرصيد المدين الكلي(علية)";*/



        }

        
        private void Add_company_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void DataGridView_add_company_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_add_company.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView_add_company.CurrentRow.Selected = true;
                Company_Name.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Company_Name"].FormattedValue.ToString();
                Email.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                Address.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                Phone_Number.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Phone_Number"].FormattedValue.ToString();
                Mobile_Number1.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Mobile_Number1"].FormattedValue.ToString();
                Mobile_Number2.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Mobile_Number2"].FormattedValue.ToString();
                Website.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Website"].FormattedValue.ToString();
                Facebook_Account.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Facebook_Account"].FormattedValue.ToString();
                Youtube_Account.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Youtube_Account"].FormattedValue.ToString();
                LinkedIn_Account.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["LinkedIn_Account"].FormattedValue.ToString();
                Country.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Country"].FormattedValue.ToString();
                State.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["State"].FormattedValue.ToString();
                Postal_Code.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Postal_Code"].FormattedValue.ToString();
                bank_num.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Bank_Account_Number"].FormattedValue.ToString();
                Fax.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Fax"].FormattedValue.ToString();
                Tax_number.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Tax_number"].FormattedValue.ToString();
                dateTimePicker1.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["Start_Financial_Year"].FormattedValue.ToString();
                dateTimePicker2.Text = dataGridView_add_company.Rows[e.RowIndex].Cells["End_Financial_Year"].FormattedValue.ToString();

            }
        }

        private void Update_company_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Company SET Company_Name = @Company_Name , Email=@Email , Address=@Address , Phone_Number=@Phone_Number , Mobile_Number1=@Mobile_Number1 , Mobile_Number2=@Mobile_Number2 , Website=@Website , Facebook_Account=@Facebook_Account , Youtube_Account=@Youtube_Account , LinkedIn_Account=@LinkedIn_Account , Country=@Country , State=@State , Postal_Code=@Postal_Code , Bank_Account_Number=@Bank_Account_Number , Fax=@Fax , Tax_number=@Tax_number , Start_Financial_Year=@Start_Financial_Year , End_Financial_Year=@End_Financial_Year WHERE ID=" + dataGridView_add_company.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Company_Name", Company_Name.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Address", Address.Text);
                cmd.Parameters.AddWithValue("@Phone_Number", Phone_Number.Text);
                cmd.Parameters.AddWithValue("@Mobile_Number1", Mobile_Number1.Text);
                cmd.Parameters.AddWithValue("@Mobile_Number2", Mobile_Number2.Text);
                cmd.Parameters.AddWithValue("@Website", Website.Text);
                cmd.Parameters.AddWithValue("@Facebook_Account", Facebook_Account.Text);
                cmd.Parameters.AddWithValue("@Youtube_Account", Youtube_Account.Text);
                cmd.Parameters.AddWithValue("@LinkedIn_Account", LinkedIn_Account.Text);
                cmd.Parameters.AddWithValue("@Country", Country.Text);
                cmd.Parameters.AddWithValue("@State", State.Text);
                cmd.Parameters.AddWithValue("@Postal_Code", Postal_Code.Text);
                cmd.Parameters.AddWithValue("@Bank_Account_Number", bank_num.Text);
                cmd.Parameters.AddWithValue("@Fax", Fax.Text);
                cmd.Parameters.AddWithValue("@Tax_number", Tax_number.Text);
                cmd.Parameters.AddWithValue("@Start_Financial_Year", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@End_Financial_Year", dateTimePicker2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView_add_company.DataSource = load();
                

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

