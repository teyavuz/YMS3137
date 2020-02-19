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

namespace WFA_EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //EntityFramework=> database'in yansımasını projeye entegre eden bir farmework'dür. EF 3 yaklaşımı bulunmaktadır.
            //1- DatabaseFirst
            //2- CodeFirst
            //3- ModelFirst

            //

            //NorthwindEntities db = new NorthwindEntities();
            //dataGridView1.DataSource= db.Categories.ToList();
        }

        private void btnConnected_Click(object sender, EventArgs e)
        {
            DateTime baslangic = DateTime.Now;
            SqlDataAdapter da = new SqlDataAdapter("select orderId from orders", "server=.;database=northwind;uid=sa;pwd=123");
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstConnected.DataSource = dt;
            lstConnected.DisplayMember = "orderId";
            DateTime bitis = DateTime.Now;
            TimeSpan ts = bitis - baslangic;
            lblConnected.Text = ts.Milliseconds.ToString();

        }

        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            DateTime baslangic = DateTime.Now;
            SqlConnection connection = new SqlConnection("server=.;database=northwind;uid=sa;pwd=123");
            SqlCommand command = new SqlCommand("select orderId from orders", connection);

            if (connection.State == ConnectionState.Closed) connection.Open();

            SqlDataReader dr = command.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lstDisconected.Items.Add(dr.GetInt32(0));
                }
            }
            dr.Close();
            connection.Close();
            DateTime bitis = DateTime.Now;
            TimeSpan ts = bitis - baslangic;
            lblDiconnected.Text = ts.Milliseconds.ToString();
        }

        private void btnEntityFramework_Click(object sender, EventArgs e)
        {
            DateTime baslangic = DateTime.Now;
            NorthwindEntities db = new NorthwindEntities();
            lstEf.DataSource = db.Orders.Select(x => new
            {
                x.OrderID
            }).ToList();
            DateTime bitis = DateTime.Now;
            TimeSpan ts = bitis - baslangic;
            lblEf.Text = ts.Milliseconds.ToString();
        }
    }
}
