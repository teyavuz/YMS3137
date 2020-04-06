using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCFilters.Models.Entity
{
    [Table("Logs")]
    public class Log
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Log tarihi doldurulması zorunludur.")]
        public DateTime LogDate { get; set; }

        [Required(ErrorMessage = "kullanıcı adı zorunlu.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Action adı zorunlu")]
        public string ActionName { get; set; }

        [Required(ErrorMessage = "Controller adı zorunlu")]
        public string ControllerName { get; set; }

        public string Description { get; set; }

    }
}