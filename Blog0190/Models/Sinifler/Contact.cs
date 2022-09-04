using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog0190.Models.Sinifler
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public long Tel { get; set; }
        public string Message { get; set; }
        
    }
}