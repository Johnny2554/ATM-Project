using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    
    public partial class Form1 : Form
    {
     SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-POCPU7TM\SQLEXPRESS;Initial Catalog=ATMAccount;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string query = "Select * from atrmlogin where Account_No = @AcccountNo And Userpass = @Password"; 
                var cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AccountNo", acctext.Text);
                cmd.Parameters.AddWithValue("@Password", passtext.Text);

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count ==1)
                {
                    Menu mu = new Menu();
                    mu.Show();
                    this.Hide();
                    MessageBox.Show("Success in logging in", "YAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                 MessageBox.Show("Your Account no/Password supplied is incorrect", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acctext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
