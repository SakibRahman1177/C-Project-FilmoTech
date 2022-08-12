using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary
{
    public partial class UploadMovies : Form
    {
        public UploadMovies()
        {
            InitializeComponent();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieManager M = new MovieManager();
            M.Show();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Uploads_Enter(object sender, EventArgs e)
        {
            Uploads.BackColor = Color.Black;
        }

        private void Uploads_Leave(object sender, EventArgs e)
        {
            Uploads.BackColor = Color.DarkSlateGray;
        }

        private void Movies_Enter(object sender, EventArgs e)
        {
            Movies.BackColor = Color.Black;
        }

        private void Movies_Leave(object sender, EventArgs e)
        {
            Movies.BackColor = Color.DarkSlateGray;
        }
    }
}
