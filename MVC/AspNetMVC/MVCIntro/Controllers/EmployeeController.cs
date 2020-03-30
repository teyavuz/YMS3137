using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
    //Controller oluşturulurken Controller soneki ile beraber oluşturulmak zorundadır!!!
    public class EmployeeController : Controller
    {

        //Model
        /*
         Proje içerisinde kullanılacak olan classları barındıran klasördür. 
             */

            //View
            /*
             Controller içerisinde oluşturulan actionREsult metotları için geriye dönüş tipi olan Viewleri barındırır.
             */
       
        //Controller içerisinde bulunan ActionResult tipi geriye bir action döndürür. Bu actionlar bir view olabildiği gibi bir yönlendirme veya bir string ifade dahi olabilir. o yüzden oluşturulan her bir controller içerisinde kullanıcıya sunulacak olan sayfaları ActionResult tipinde metotlar sayesinde tanımlamalıyız.

            //Aşağıda tanımlanan her iki metot (ActionResult) bize Employee isimli controllerla beraber iki adet sayfa olduğunu temsil eder.

            //Sayfalara ulaşabilmek için URL tarafında  http://localhost/{portnumber}/controllerName/ActionName formatı ile ulaşabiliriz.

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddEmployee()
        {
            return View();
        }


       
    }
}

//Controller/View
//Employee/Index
//Employee/AddEmployee
//Employee/UpdateEmployee


//Product/Index
//Product/Add
