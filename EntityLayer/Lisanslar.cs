using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityLayer
{
    public class Lisanslar : myClass
    {
        public int id { get; set; }
        public int firmaid { get; set; }
        public string firmaadi { get; set; }
        public string projekodu { get; set; }
        public string padi { get; set; }
        public string lisansanahtari { get; set; }
        public bool lisansdurumu { get; set; }
        public string adsoyad { get; set; }
        public string islemcino { get; set; }
        public DateTime lisanstarihi { get; set; }
        public string firmakodu { get; set; }
        public int pid { get; set; }
    }
}
