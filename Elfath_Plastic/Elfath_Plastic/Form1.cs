using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elfath_Plastic
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }

        static String sql = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Alfath_plastic.accdb; jet OLEDB:Database Password=''; Persist Security Info=True;";
        OleDbConnection con = new OleDbConnection(sql);

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT User_Panal.* FROM User_Panal WHERE(((User_Panal.UserName) = '"+username.Text+"') AND((User_Panal.Password) = '"+password.Text+"'))";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;

                }
                
                if (count==1)
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }

                else if(count>1)
                {
                    MessageBox.Show("برجاء ادخال اسم مستخدم او كلمة السر بشكل صحيح", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    MessageBox.Show("برجاء ادخال اسم مستخدم او كلمة السر بشكل صحيح", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
