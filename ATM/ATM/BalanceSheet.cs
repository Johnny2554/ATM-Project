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
    public partial class BalanceSheet : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-POCPU7TM\SQLEXPRESS;Initial Catalog=ATMAccount;Integrated Security=True");
        public BalanceSheet()
        {
            InitializeComponent();
        }
        

        private void BalanceSheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTMAccountDataSet.AccountHolder' table. You can move, or remove it, as needed.
            this.accountHolderTableAdapter.Fill(this.aTMAccountDataSet.AccountHolder);
            // TODO: This line of code loads data into the 'aTMAccountDataSet.atrmlogin' table. You can move, or remove it, as needed.
            this.atrmloginTableAdapter.Fill(this.aTMAccountDataSet.atrmlogin);
            // TODO: This line of code loads data into the 'aTMAccountDataSet.atrmlogin' table. You can move, or remove it, as needed.
            //this.atrmloginTableAdapter.Fill(this.aTMAccountDataSet.atrmlogin);
            // TODO: This line of code loads data into the 'aTMAccountDataSet.AccountHolder' table. You can move, or remove it, as needed.
            //this.accountHolderTableAdapter.Fill(this.aTMAccountDataSet.AccountHolder);
            con.Open();
            string query = "select * from atrmlogin";
            var cmd = new SqlCommand(query, con);



            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
           
            dataGridView1.DataSource = dt;
            
            string quary = "select * from AccountHolder";
            



            SqlDataAdapter dd = new SqlDataAdapter();
            DataTable ds = new DataTable();
          
            dataGridView2.DataSource = ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu mu = new Menu();
            mu.Show();
            this.Hide();
        }
    }
}
