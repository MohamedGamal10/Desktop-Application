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
    public partial class employees : Form
    {
        public employees()
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
            String query = "SELECT ID , Job_Name, Employee_Name , Hiring_Date , Resignation_Date , Birthday , National_Number , Phone_Number , Mobile_Number , Address , Salary , Insurances_Date , Insurances_Employee_Participating , Insurances_Company_Participating , Status FROM Employees";
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
            String query = "SELECT * FROM Emp_sal";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridView1_add_employees.DataSource = load();
            dataGridView1_add_employees.BorderStyle = BorderStyle.None;
            dataGridView1_add_employees.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1_add_employees.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1_add_employees.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1_add_employees.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1_add_employees.BackgroundColor = Color.White;
            dataGridView1_add_employees.EnableHeadersVisualStyles = false;
            dataGridView1_add_employees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1_add_employees.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1_add_employees.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1_add_employees.Columns[0].HeaderText = "ID";
            dataGridView1_add_employees.Columns[1].HeaderText = "اسم الوظيفة";
            dataGridView1_add_employees.Columns[2].HeaderText = "اسم الموظف";
            dataGridView1_add_employees.Columns[3].HeaderText = "تاريخ التعيين";
            dataGridView1_add_employees.Columns[4].HeaderText = "تاريخ الاستقالة";
            dataGridView1_add_employees.Columns[5].HeaderText = "تاريخ الميلاد";
            dataGridView1_add_employees.Columns[6].HeaderText = "الرقم القومي";
            dataGridView1_add_employees.Columns[7].HeaderText = "الهاتف";
            dataGridView1_add_employees.Columns[8].HeaderText = "رقم الموبيل";
            dataGridView1_add_employees.Columns[9].HeaderText = "العنوان";
            dataGridView1_add_employees.Columns[10].HeaderText = "المرتب";
            dataGridView1_add_employees.Columns[11].HeaderText = "تاريخ التامين";
            dataGridView1_add_employees.Columns[12].HeaderText = "حصة الموظف من التامينات";
            dataGridView1_add_employees.Columns[13].HeaderText = "حصة الشركة من التامينات";
            dataGridView1_add_employees.Columns[14].HeaderText = "الموقف من العمل";

            salary_prepare.DataSource = load1();
            salary_prepare.BorderStyle = BorderStyle.None;
            salary_prepare.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            salary_prepare.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            salary_prepare.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            salary_prepare.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            salary_prepare.BackgroundColor = Color.White;
            salary_prepare.EnableHeadersVisualStyles = false;
            salary_prepare.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            salary_prepare.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            salary_prepare.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            salary_prepare.Columns[0].HeaderText = "اسم الموظف";
            salary_prepare.Columns[1].HeaderText = "المرتب";
            salary_prepare.Columns[2].HeaderText = "حصة الموظف من التامينات";
            salary_prepare.Columns[3].HeaderText = "مجموع الجزاءات";
            salary_prepare.Columns[4].HeaderText = "مجموع السلف";
            salary_prepare.Columns[5].HeaderText = "صافي المرتب";


            con.Open();
            string q0 = "DELETE * FROM Emp_Sal ";
            OleDbCommand cmd0 = new OleDbCommand(q0, con);
            cmd0.ExecuteNonQuery();
            con.Close();
            salary_prepare.DataSource = load1();

            try
            {
                con.Open();
                String query = "SELECT Employee_Name FROM Employees Where Status ='نشط'";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emp_name.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Add_save_employees_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO Employees(Job_Name, Employee_Name , Hiring_Date , Resignation_Date , Birthday , National_Number , Phone_Number , Mobile_Number , Address , Salary , Insurances_Date , Insurances_Employee_Participating , Insurances_Company_Participating , Status ) VALUES (@Job_Name , @Employee_Name , @Hiring_Date , @Resignation_Date , @Birthday , @National_Number , @Phone_Number , @Mobile_Number , @Address , @Salary , @Insurances_Date , @Insurances_Employee_Participating , @Insurances_Company_Participating , @Status)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Job_Name", Job_Name.Text);
                cmd.Parameters.AddWithValue("@Employee_Name", Employee_Name.Text);
                cmd.Parameters.AddWithValue("@Hiring_Date", Hiring_Date.Text);
                cmd.Parameters.AddWithValue("@Resignation_Date", Resignation_Date.Text);
                cmd.Parameters.AddWithValue("@Birthday", Birthday.Text);
                cmd.Parameters.AddWithValue("@National_Number", National_Number.Text);
                cmd.Parameters.AddWithValue("@Phone_Number", Phone_Number.Text);
                cmd.Parameters.AddWithValue("@Mobile_Number", Mobile_Number.Text);
                cmd.Parameters.AddWithValue("@Address", Address.Text);
                cmd.Parameters.AddWithValue("@Salary", Salary.Text);
                cmd.Parameters.AddWithValue("@Insurances_Date", Insurances_Date.Text);
                cmd.Parameters.AddWithValue("@Insurances_Employee_Participating", Insurances_Employee_Participating.Text);
                cmd.Parameters.AddWithValue("@Insurances_Company_Participating", Insurances_Company_Participating.Text);
                cmd.Parameters.AddWithValue("@Status", Status.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_employees.DataSource = load();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


            try
            {
                con.Open();
                String query = "SELECT Employee_Name FROM Employees Where Status ='نشط'";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                emp_name.Items.Clear();
                while (reader.Read())
                {
                    emp_name.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Update_save_employees_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Employees SET Job_Name=@Job_Name, Employee_Name=@Employee_Name , Hiring_Date=@Hiring_Date , Resignation_Date=@Resignation_Date , Birthday=@Birthday , National_Number=@National_Number , Phone_Number=@Phone_Number , Mobile_Number=@Mobile_Number , Address=@Address , Salary=@Salary , Insurances_Date=@Insurances_Date , Insurances_Employee_Participating=@Insurances_Employee_Participating , Insurances_Company_Participating=@Insurances_Company_Participating , Status=@Status WHERE ID=" + dataGridView1_add_employees.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Job_Name", Job_Name.Text);
                cmd.Parameters.AddWithValue("@Employee_Name", Employee_Name.Text);
                cmd.Parameters.AddWithValue("@Hiring_Date", Hiring_Date.Text);
                cmd.Parameters.AddWithValue("@Resignation_Date", Resignation_Date.Text);
                cmd.Parameters.AddWithValue("@Birthday", Birthday.Text);
                cmd.Parameters.AddWithValue("@National_Number", National_Number.Text);
                cmd.Parameters.AddWithValue("@Phone_Number", Phone_Number.Text);
                cmd.Parameters.AddWithValue("@Mobile_Number", Mobile_Number.Text);
                cmd.Parameters.AddWithValue("@Address", Address.Text);
                cmd.Parameters.AddWithValue("@Salary", Salary.Text);
                cmd.Parameters.AddWithValue("@Insurances_Date", Insurances_Date.Text);
                cmd.Parameters.AddWithValue("@Insurances_Employee_Participating", Insurances_Employee_Participating.Text);
                cmd.Parameters.AddWithValue("@Insurances_Company_Participating", Insurances_Company_Participating.Text);
                cmd.Parameters.AddWithValue("@Status", Status.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_employees.DataSource = load();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }



            try
            {
                con.Open();
                String query = "SELECT Employee_Name FROM Employees Where Status ='نشط'";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                emp_name.Items.Clear();
                while (reader.Read())
                {
                    emp_name.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void DataGridView1_add_employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1_add_employees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1_add_employees.CurrentRow.Selected = true;
                    Job_Name.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Job_Name"].FormattedValue.ToString();
                    Employee_Name.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Employee_Name"].FormattedValue.ToString();
                    Hiring_Date.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Hiring_Date"].FormattedValue.ToString();
                    Resignation_Date.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Resignation_Date"].FormattedValue.ToString();
                    Birthday.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Birthday"].FormattedValue.ToString();
                    Phone_Number.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Phone_Number"].FormattedValue.ToString();
                    Mobile_Number.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Mobile_Number"].FormattedValue.ToString();
                    Address.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                    Salary.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Salary"].FormattedValue.ToString();
                    Insurances_Date.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Insurances_Date"].FormattedValue.ToString();
                    Insurances_Employee_Participating.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Insurances_Employee_Participating"].FormattedValue.ToString();
                    Insurances_Company_Participating.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Insurances_Company_Participating"].FormattedValue.ToString();
                    Status.Text = dataGridView1_add_employees.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Delete_save_employees_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Employees WHERE ID=" + dataGridView1_add_employees.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1_add_employees.DataSource = load();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }



            try
            {
                con.Open();
                String query = "SELECT Employee_Name FROM Employees Where Status ='نشط'";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                emp_name.Items.Clear();
                while (reader.Read())
                {
                    emp_name.Items.Add(reader[0].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Btn_search_employees_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT ID , Job_Name, Employee_Name , Hiring_Date , Resignation_Date , Birthday , National_Number , Phone_Number , Mobile_Number , Address , Salary , Insurances_Date , Insurances_Employee_Participating , Insurances_Company_Participating , Status FROM Employees WHERE Employee_Name LIKE '%" + search_employees.Text + "%'";
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1_add_employees.DataSource = dt;
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

        private void Prepare_Click(object sender, EventArgs e)
        {
            for (int i = 0 ; i<= int.Parse(emp_name.Items.Count.ToString())-1 ; i++)
            {





                try
                {

                    con.Open();
                    String q1 = "SELECT Employee_Name , Salary , Insurances_Employee_Participating FROM Employees WHERE Employee_Name LIKE '%" + emp_name.Items[i] + "%'";
                    OleDbCommand cmd1 = new OleDbCommand(q1, con);
                    OleDbDataReader r1 = cmd1.ExecuteReader();
                    r1.Read();

                    String q2 = "INSERT INTO Emp_Sal (Emp_Name , Salary , Insurance_Employee_Participating) VALUES (@Emp_Name , @Salary , @Insurance_Employee_Participating)";
                    OleDbCommand cmd2 = new OleDbCommand(q2, con);
                    cmd2.Parameters.AddWithValue("@Emp_Name", r1[0].ToString());
                    cmd2.Parameters.AddWithValue("@Salary", int.Parse(r1[1].ToString()));
                    cmd2.Parameters.AddWithValue("@Insurance_Employee_Participating", int.Parse(r1[2].ToString()));
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    String q3 = "SELECT Sum(Installments.Advance_Payment_Value) AS SumOfAdvance_Payment_Value FROM Installments WHERE(((Installments.Advance_Payment_Date)Between #" + from.Text + "# And #" + to.Text + "#)) GROUP BY Installments.Employee_Name HAVING(((Installments.Employee_Name) LIKE '%" + emp_name.Items[i] + "%'))";
                    OleDbCommand cmd3 = new OleDbCommand(q3, con);
                    OleDbDataReader r3 = cmd3.ExecuteReader();
                    r3.Read();




                    if (r3.HasRows)
                    {
                        String q4 = "UPDATE Emp_Sal SET Sum_Ins=@Sum_Ins  WHERE Emp_Name LIKE '%" + emp_name.Items[i] + "%'";
                        OleDbCommand cmd4 = new OleDbCommand(q4, con);
                        cmd4.Parameters.AddWithValue("@Sum_Ins", int.Parse(r3[0].ToString()));
                        cmd4.ExecuteNonQuery();
                        con.Close();

                    }

                    else
                    {
                        String q4 = "UPDATE Emp_Sal SET Sum_Ins=@Sum_Ins  WHERE Emp_Name LIKE '%" + emp_name.Items[i] + "%'";
                        OleDbCommand cmd4 = new OleDbCommand(q4, con);
                        cmd4.Parameters.AddWithValue("@Sum_Ins", 0);
                        cmd4.ExecuteNonQuery();
                        con.Close();

                    }


                    con.Open();
                    String q5 = "SELECT Penalties.Employee_Name, Sum(Penalties.Penalty_Value) AS SumOfPenalty_Value FROM Penalties WHERE(((Penalties.Penalty_Date)Between #" + from.Text + "# And #" + to.Text + "#)) GROUP BY Penalties.Employee_Name HAVING(((Penalties.Employee_Name) LIKE '%" + emp_name.Items[i] + "%'))";
                    OleDbCommand cmd5 = new OleDbCommand(q5, con);
                    OleDbDataReader r5 = cmd5.ExecuteReader();
                    r5.Read();

                    if (r5.HasRows)
                    {
                        String q6 = "UPDATE Emp_Sal SET Sum_Penelty=@Sum_Penelty  WHERE Emp_Name LIKE '%" + emp_name.Items[i] + "%'";
                        OleDbCommand cmd6 = new OleDbCommand(q6, con);
                        cmd6.Parameters.AddWithValue("@Sum_Ins", int.Parse(r5[1].ToString()));
                        cmd6.ExecuteNonQuery();
                        con.Close();

                    }

                    else
                    {
                        String q6 = "UPDATE Emp_Sal SET Sum_Penelty=@Sum_Penelty  WHERE Emp_Name LIKE '%" + emp_name.Items[i] + "%'";
                        OleDbCommand cmd6 = new OleDbCommand(q6, con);
                        cmd6.Parameters.AddWithValue("@Sum_Ins", 0);
                        cmd6.ExecuteNonQuery();
                        con.Close();
                    }


                    salary_prepare.DataSource = load1();

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

        private void Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "مرتبات";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            Margins margins = new Margins(0, 0, 0, 0);
            printer.printDocument.DefaultPageSettings.Margins = margins;
            printer.PrintPreviewNoDisplay(salary_prepare);
            
        }

       

        private void Pay_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String q7 = "SELECT Sum(Net_Sal) FROM Emp_Sal";
                OleDbCommand cmd7 = new OleDbCommand(q7, con);
                OleDbDataReader r7 = cmd7.ExecuteReader();
                r7.Read();


                String q8 = "INSERT INTO Expenses(Expense_Name , Expense_Value , Expense_Date) VALUES (@Expense_Name , @Expense_Value , @Expense_Date)";
                OleDbCommand cmd8 = new OleDbCommand(q8, con);
                cmd8.Parameters.AddWithValue("@Expense_Name", "  دفع رواتب من  " + from.Text + "  الي  " + to.Text);
                cmd8.Parameters.AddWithValue("@Expense_Value", int.Parse(r7[0].ToString()));
                cmd8.Parameters.AddWithValue("@Expense_Date", DateTime.Today);
                cmd8.ExecuteNonQuery();
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

            MessageBox.Show("تم");
        }

        private void Pay_one_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                String q1 = "SELECT Employee_Name , Salary , Insurances_Employee_Participating FROM Employees WHERE Employee_Name LIKE '%" + emp_name.Text + "%'";
                OleDbCommand cmd1 = new OleDbCommand(q1, con);
                OleDbDataReader r1 = cmd1.ExecuteReader();
                r1.Read();

                String q2 = "INSERT INTO Emp_Sal (Emp_Name , Salary , Insurance_Employee_Participating) VALUES (@Emp_Name , @Salary , @Insurance_Employee_Participating)";
                OleDbCommand cmd2 = new OleDbCommand(q2, con);
                cmd2.Parameters.AddWithValue("@Emp_Name", r1[0].ToString());
                cmd2.Parameters.AddWithValue("@Salary", int.Parse(r1[1].ToString()));
                cmd2.Parameters.AddWithValue("@Insurance_Employee_Participating", int.Parse(r1[2].ToString()));
                cmd2.ExecuteNonQuery();
                con.Close();

                con.Open();
                String q3 = "SELECT Sum(Installments.Advance_Payment_Value) AS SumOfAdvance_Payment_Value FROM Installments WHERE(((Installments.Advance_Payment_Date)Between #" + from.Text + "# And #" + to.Text + "#)) GROUP BY Installments.Employee_Name HAVING(((Installments.Employee_Name) LIKE '%" + emp_name.Text + "%'))";
                OleDbCommand cmd3 = new OleDbCommand(q3, con);
                OleDbDataReader r3 = cmd3.ExecuteReader();
                r3.Read();




                if (r3.HasRows)
                {
                    String q4 = "UPDATE Emp_Sal SET Sum_Ins=@Sum_Ins  WHERE Emp_Name LIKE '%" + emp_name.Text + "%'";
                    OleDbCommand cmd4 = new OleDbCommand(q4, con);
                    cmd4.Parameters.AddWithValue("@Sum_Ins", int.Parse(r3[0].ToString()));
                    cmd4.ExecuteNonQuery();
                    con.Close();

                }

                else
                {
                    String q4 = "UPDATE Emp_Sal SET Sum_Ins=@Sum_Ins  WHERE Emp_Name LIKE '%" + emp_name.Text + "%'";
                    OleDbCommand cmd4 = new OleDbCommand(q4, con);
                    cmd4.Parameters.AddWithValue("@Sum_Ins", 0);
                    cmd4.ExecuteNonQuery();
                    con.Close();

                }


                con.Open();
                String q5 = "SELECT Penalties.Employee_Name, Sum(Penalties.Penalty_Value) AS SumOfPenalty_Value FROM Penalties WHERE(((Penalties.Penalty_Date)Between #" + from.Text + "# And #" + to.Text + "#)) GROUP BY Penalties.Employee_Name HAVING(((Penalties.Employee_Name) LIKE '%" + emp_name.Text + "%'))";
                OleDbCommand cmd5 = new OleDbCommand(q5, con);
                OleDbDataReader r5 = cmd5.ExecuteReader();
                r5.Read();

                if (r5.HasRows)
                {
                    String q6 = "UPDATE Emp_Sal SET Sum_Penelty=@Sum_Penelty  WHERE Emp_Name LIKE '%" + emp_name.Text + "%'";
                    OleDbCommand cmd6 = new OleDbCommand(q6, con);
                    cmd6.Parameters.AddWithValue("@Sum_Ins", int.Parse(r5[1].ToString()));
                    cmd6.ExecuteNonQuery();
                    con.Close();

                }

                else
                {
                    String q6 = "UPDATE Emp_Sal SET Sum_Penelty=@Sum_Penelty  WHERE Emp_Name LIKE '%" + emp_name.Text + "%'";
                    OleDbCommand cmd6 = new OleDbCommand(q6, con);
                    cmd6.Parameters.AddWithValue("@Sum_Ins", 0);
                    cmd6.ExecuteNonQuery();
                    con.Close();
                }


                salary_prepare.DataSource = load1();

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
