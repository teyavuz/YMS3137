using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_CodeFirst.ORM.Context;

namespace WFA_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Code First
             
            Veritabanını kod yazarak oluşturmak istediğimizde kullanacağımız yaklaşımdır. Bu yaklaşımda classları ve propertyleri geliştirici oluşturur. Kullanmak içn hazır bir veritabanına ihtiyacımız bulunmamaktadır. Bu yaklaşımda tüm classlar el ile kodlarla yazılmaktadır. CodeFirst yaklaşımı diğer yaklaşımlara göre en avantajlı olanıdır. 
            
            
            Product
            Category
             */

            txtSifre.PasswordChar = '*';
        }
        ProjectContext db = new ProjectContext();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            //Any() metodu içerisine tanımlamış olduğumuz koşul sonucunda bize bool bir tip döndürür. Bu sayede buradan dönen şartı karar yapısı içerisinde kullanarak kullanıcı adı ve şifrenin doğru girilmesi durumunda (geriye true dönmesi durumunda) gerçekleşecek olan işlemi tanımlayabilmekteyiz.
            if (db.Users.Any(x => x.UserName == kullaniciAdi && x.Password == sifre))
            {
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else
            {
                lblError.Text = "Bilgiler yanlış";
                lblError.ForeColor = Color.Red;
            }
        }
    }
}
