using BA_SOLID.SRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.SRP.Validate
{
    class GoodEmployeeProcessor
    {
        //Logger isimli class içerisinde yapılacak olan işlemleri barındırıyor. GoodEmployeProcessor'den bir instance alındığı anda yeni bir örneği oluşturularak altta tanımladığımız IOnsertEmployee isimli metotta kullanıma sunuluyor.
        Logger logger;
        string log;
        public GoodEmployeeProcessor()
        {
            logger = new Logger();
        }

        //Altta tanımlanan InsertEmployee isimli metot sadece veri girişinden sorumlu getirildi.

        public bool InsertEmployee(Employee newEmployee)
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
                sb.Append(newEmployee.HireDate);
                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\SRP\EmployeeData.txt", log);

                return true;
            }
            catch (Exception ex)
            {

                sb = new StringBuilder();
                sb.Append("Hata Mesajı ");
                sb.AppendLine();
                sb.Append(ex.Message);
                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\SRP\Exception.txt", log);

                return false;
            }
        }

    }
}
