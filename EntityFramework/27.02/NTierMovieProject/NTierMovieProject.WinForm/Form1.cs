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
        BaseRepository<Movie> movies = new BaseRepository<Movie>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = movies.SelectAll();
        }
    }
}
