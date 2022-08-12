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
    public partial class RequestData : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-STARBP4;Initial Catalog=Registration;Integrated Security=True");
        static SqlCommand cmd;
        public RequestData()
        {
            InitializeComponent();
        }

        void GridView()
        {
            con.Open();
            string query = "select * from requestform";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);



            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 70;
            dataGridView1.ColumnHeadersHeight = 50;

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            DataGridViewImageColumn dgv1 = new DataGridViewImageColumn();
            //dgv1 = (DataGridViewImageColumn)dataGridView1.Columns[4];
            dgv1.ImageLayout = DataGridViewImageCellLayout.Stretch;


            con.Close();
        }

        private void RequestData_Load(object sender, EventArgs e)
        {
            GridView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UploadMovies Up = new UploadMovies();
            Up.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM requestform WHERE MovieName=@MovieName";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.Add("@MovieName", SqlDbType.VarChar);
            cmd.Parameters["@MovieName"].Value = textBox1.Text;

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Request Deleted!");
            GridView();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
