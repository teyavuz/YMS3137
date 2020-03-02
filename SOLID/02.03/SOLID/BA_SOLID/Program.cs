using BA_SOLID.OCP.Validate.Abstract;
using BA_SOLID.OCP.Validate.Concrete;
using BA_SOLID.SRP.BAD;
using BA_SOLID.SRP.Model;
using BA_SOLID.SRP.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID Prensipleri=> Solid, beş önemli OOP prensiplerinin kısaltılmışıdır.

            //SRP=> Single Responsibility Principle
            /*
             Bir class sadece bir işi yapıyor olmalı.
             */

            #region Bad SRP
            //Employee employee = new Employee();
            //employee.ID = 1;
            //employee.FirstName = "Fatih";
            //employee.LastName = "Günalp";
            //employee.HireDate = new DateTime(2020, 03, 02);

            //BadEmployeeProcessor badEmployee = new BadEmployeeProcessor();
            //badEmployee.InsertEmployee(employee);
            //Console.Read(); 
            #endregion

            #region Validate SRP
            //GoodEmployeeProcessor good = new GoodEmployeeProcessor();
            //Employee employee = new Employee();
            //employee.ID = 1;
            //employee.FirstName = "Fatih";
            //employee.LastName = "Günalp";
            //employee.HireDate = new DateTime(2020, 03, 02);

            //Console.WriteLine(good.InsertEmployee(employee) ? "Başarılı" : "Hata!");
            //Console.Read(); 
            #endregion

            GoodCoffee kahve1 = new Americano();
            GoodCoffee kahve2 = new Latte();
            GoodCoffee kahve3 = new Mocha();

            decimal price = 0;
            price=kahve1.GetTotalPrice(2);
            Console.WriteLine(price.ToString());
            Console.ReadLine();

        }
    }
}
