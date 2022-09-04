using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog0190.Models.Sinifler
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string TextName { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public ICollection<BlogComment> BlogComments { get; set; }
    }
}