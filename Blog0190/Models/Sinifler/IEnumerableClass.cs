using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog0190.Models.Sinifler
{
    public class IEnumerableClass
    {
        public IEnumerable<AddresInformation> AddresDeyer { get; set; }
        public IEnumerable<Contact> ContactDeyer { get; set; }
        public IEnumerable<About> AboutDeyer { get; set; }
    }
}