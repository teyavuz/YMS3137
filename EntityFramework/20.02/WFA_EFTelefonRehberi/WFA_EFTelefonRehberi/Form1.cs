using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EFTelefonRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TelefonDefteriDBEntities db = new TelefonDefteriDBEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            KisiListesi();


        }

        private void KisiListesi()
        {
            listView1.Items.Clear();
            foreach (var person in db.Persons)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = person.FirstName;
                lvi.SubItems.Add(person.LastName);
                lvi.SubItems.Add(person.PhoneNumber);
                listView1.Items.Add(lvi);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person();
                person.FirstName = txtAd.Text;
                person.LastName = txtSoyad.Text;
                person.PhoneNumber = txtTelefonNo.Text;

                db.Persons.Add(person);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show(string.Format("{0} eklendi", person.FirstName));
                }
                else
                {
                    MessageBox.Show("Bir sorun oluştu");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Sorun oluştu.");
            }

            KisiListesi();
        }
    }
}
