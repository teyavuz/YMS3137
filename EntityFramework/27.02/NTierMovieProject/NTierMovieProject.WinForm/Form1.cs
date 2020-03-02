using NTierMovieProject.BLL.Repository;
using NTierMovieProject.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierMovieProject.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BaseRepository<Movie> movieRepo = new BaseRepository<Movie>();
        BaseRepository<Actor> actorRepo = new BaseRepository<Actor>();
        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            //var movie = movieRepo.SelectById(2).MovieName;

            //MessageBox.Show(movie);

            foreach (Movie movie in movieRepo.SelectAll())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = movie.MovieName;
                lvi.SubItems.Add(movie.ReleaseDate.ToShortDateString());
                lvi.SubItems.Add(movie.Duration.ToString());
                lvi.SubItems.Add(movie.MovieLanguage);
                lvi.Tag = movie;
                listView1.Items.Add(lvi);
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();

        }
        Movie movie;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            movie = (Movie)listView1.SelectedItems[0].Tag;
            lblSure.Text = movie.Duration.ToString();
            lblCikisTarihi.Text = movie.ReleaseDate.ToShortDateString();
            lblDil.Text = movie.MovieLanguage;
            pictureBox1.ImageLocation = Application.StartupPath + "/Images/" + movie.MoviePosterPath;

        }
    }
}
