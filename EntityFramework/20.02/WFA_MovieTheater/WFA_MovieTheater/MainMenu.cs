using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MovieTheater
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public void ChildForm(Form _childForm)
        {
            

            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }

        private void allMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AllMovies());
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AddMovie());
        }
    }
}
