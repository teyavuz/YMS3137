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

namespace WFA_EFIntroduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Eski Yöntem 
            /*
             Ado.Net
                    => Connected Mimari
                    => Disconnected Mimari
             */

            //Disconnected Mimari
            //Not: System.Data.SqlClient kütüphanesini eklmeyi unutmayın!!!
            #region Disconnected
            //SqlConnection connection = new SqlConnection("server=.;database=northwind;uid=sa;pwd=123");
            //SqlCommand command = new SqlCommand("select * from employees", connection);
            //if (connection.State == ConnectionState.Closed) connection.Open();
            //SqlDataReader dr = command.ExecuteReader();
            //DataTable dt = new DataTable();

            //dt.Load(dr);
            //connection.Close();

            //dataGridView1.DataSource = dt; 
            #endregion

            #region Connected
            //SqlConnection connection = new SqlConnection("server=.;database=northwind;uid=sa;pwd=123");
            //SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from employees", connection);
            //DataTable dt = new DataTable();

            //dataAdapter.Fill(dt);
            //dataGridView1.DataSource = dt; 
            #endregion

            NorthwindEntities db = new NorthwindEntities();
            dataGridView1.DataSource = db.Employees.ToList();



        }
    }
}
