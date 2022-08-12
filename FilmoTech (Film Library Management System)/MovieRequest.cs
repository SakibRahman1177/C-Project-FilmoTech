using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary
{
    public partial class MovieRequest : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-STARBP4;Initial Catalog=Registration;Integrated Security=True");
        static SqlCommand cmd;
        public MovieRequest()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberDashboard M = new MemberDashboard();
            M.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account A = new Account();
            A.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Downloads D = new Downloads();
            D.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUS AU = new AboutUS();
            AU.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!authentication())
            {
                MessageBox.Show("Field can not be Empty!");
                return;
            }
            con.Open();
            string query = "INSERT INTO requestform VALUES(@mname,@ryear,@dname)";
            cmd = new SqlCommand(query, con);

            //adding values

            cmd.Parameters.Add("@mname", SqlDbType.VarChar);
            cmd.Parameters["@mname"].Value = textBox1.Text;

            cmd.Parameters.Add("@ryear", SqlDbType.VarChar);
            cmd.Parameters["@ryear"].Value = textBox2.Text;

            cmd.Parameters.Add("@dname", SqlDbType.VarChar);
            cmd.Parameters["@dname"].Value = textBox3.Text;

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Sent Request!");
            //GridView();
        }

        bool authentication()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox2.Text) ||
               string.IsNullOrWhiteSpace(textBox3.Text))
                return false;
            else return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }

}

