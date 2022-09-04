using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog0190.Models.Sinifler
{
    public class LessonComment
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public long Telefon { get; set; }
        public DateTime Saat { get; set; }
        public DateTime Tarix { get; set; }
        public string Text { get; set; }
        public int LessonID { get; set; }
        public virtual LessonInformation LessonInformation { get; set; }
    }
}