using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog0190.Models.Sinifler
{
    public class Foto
    {
        [Key]
        public int FotoId { get; set; }
        public string FotoUrl { get; set; }
    }
}