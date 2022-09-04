using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog0190.Models.Sinifler
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string TextName { get; set; }
        public string Text { get; set; }
        public string BigFoto { get; set; }
        public string FotoOne { get; set; }
        public string FotoTwo { get; set; }
        public string CV { get; set; }
        public string QrCode { get; set; }
        public string Location { get; set; }
    }
}