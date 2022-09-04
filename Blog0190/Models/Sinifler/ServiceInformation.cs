using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog0190.Models.Sinifler
{
    public class ServiceInformation
    {
        [Key]
        public int ServicesID { get; set; }
        public string ServicesName { get; set; }
        public string ServicesText { get; set; }
        public string ServiceIcon { get; set; }
    }
}