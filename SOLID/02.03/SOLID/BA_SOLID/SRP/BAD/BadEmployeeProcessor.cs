using BA_SOLID.SRP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.SRP.BAD
{
    public class BadEmployeeProcessor
    {
        //Alttaki işlemlerre bakarsak, sınıf içerisinde çalışan ekleme kodumuzda birden fazla iş yapıldığını görebilmekteyiz. Hem ekleme, hem de log işlemöleri bir arada gitmektedir. Alttaki kod bu nedenle SRP ters düşmektedir. 

        public void InsertEmployee(Employee newEmployee)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(newEmployee.ID);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.LastName);
                sb.AppendLine();
                File.WriteAllText(@"C:\SRP\EmployeeData.txt", sb.ToString());
                sb = new StringBuilder();
                sb.Append("Kayıt Ekleme Tarihi :");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Personel Adı Soyadı: ");
                sb.Append(newEmployee.FirstName).Append(" ");
                sb.Append(newEmployee.LastName);
                File.WriteAllText(@"C:\SRP\LogEmployee.txt", sb.ToString());

                Console.WriteLine("Çalışan Başarıyla Eklendi");

            }
            catch (Exception ex)
            {
                sb = new StringBuilder();
                sb.Append("Hata Tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata Mesajı: ");
                sb.Append(ex.Message);
                File.WriteAllText(@"C:\SRP\Exception.txt", sb.ToString());

                Console.WriteLine("Hata!");
                
            }
        }
    }
}
