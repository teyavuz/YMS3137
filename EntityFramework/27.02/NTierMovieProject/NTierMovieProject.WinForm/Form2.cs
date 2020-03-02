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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
        BaseRepository<Movie> movies = new BaseRepository<Movie>();

        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie()
            {
                MovieName = tbxName.Text,
                MovieLanguage = tbxLanguage.Text,
                Duration = Convert.ToInt16(nudMovieDuration.Value),
                ReleaseDate = dateTimePicker1.Value

            };
            movies.Add(movie);
            MessageBox.Show("movie added :) ");
        }
    }
}
