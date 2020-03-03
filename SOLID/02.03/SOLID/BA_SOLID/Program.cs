using BA_SOLID.DIP.Validate.Abstract;
using BA_SOLID.DIP.Validate.Concrete;
using BA_SOLID.LSP.Bad;
using BA_SOLID.LSP.Validate;
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

            #region OCP
            //GoodCoffee kahve1 = new Americano();
            //GoodCoffee kahve2 = new Latte();
            //GoodCoffee kahve3 = new Mocha();

            //decimal price = 0;
            //price=kahve1.GetTotalPrice(2);
            //Console.WriteLine(price.ToString());
            //Console.ReadLine(); 
            #endregion

            //LSP=> Liskov's Substution Principle

            //Bir sınıftan türetilen sınıflar, base sınıfın yerine de kullanabilmelidir.


            #region LSP BAD
            //BadRectangle rectangle = new BadRectangle();
            //rectangle.Width = 2;
            //rectangle.Height = 3;

            //if (BadAreaCalculator.CalculateArea(rectangle) != 6)
            //{
            //    Console.WriteLine("Dörtgen alan hesaplamasında hatalı işlem");
            //}

            //BadSquare square = new BadSquare();
            //square.Height = 3;

            //if (BadAreaCalculator.CalculateArea(square) != 9)
            //{
            //    Console.WriteLine("Kare hesaplamasında hatalı işlem");
            //} 
            #endregion

            //Rectangle rectangle = new Rectangle();
            //rectangle.Width = 2;
            //rectangle.Height = 3;

            //if (rectangle.RectangleArea() != 6)
            //{

            //}

            //DIP=> Dependency Inversion Principle
            //Üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.


            Fish barbun = new Fish();
            barbun.GetCookingInstructions();

            Fish tuna = new Fish();
            tuna.GetCookingInstructions();

            Poultry poultry = new Poultry();
            poultry.GetCookingInstructions();

            List<IProduct> products = new List<IProduct>();
            products.Add(barbun);
            products.Add(tuna);
            products.Add(poultry);

            Restaurant restaurant = new Restaurant(products);
            restaurant.GenerateInstructions();
        }
    }
}
