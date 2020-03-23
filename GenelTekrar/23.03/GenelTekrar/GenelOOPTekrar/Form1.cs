using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenelOOPTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Bilgisayar bilgisayar = new Bilgisayar();
           string bilgisayarKdvOrani= bilgisayar.KDVHesapla();
            MessageBox.Show(bilgisayarKdvOrani);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Unitsinstock = Convert.ToInt16(txtStock.Text);
        }

    }
}
