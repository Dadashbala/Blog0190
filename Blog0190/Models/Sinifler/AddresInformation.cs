using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog0190.Models.Sinifler
{
    public class AddresInformation
    {
        [Key]
        public int ID { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
    }
}