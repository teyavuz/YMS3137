using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCrudDAL.Models.ViewModels
{
    public class EmployeeVM
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}