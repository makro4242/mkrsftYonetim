using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityLayer
{
    public class ProjeDosyalari:myClass
    {
        public int id { get; set; }
        public string dosyaadi { get; set; }
        public int pid { get; set; }
        public string vno { get; set; }
        public bool durum { get; set; }
        public string boyut { get; set; }

    }
}
