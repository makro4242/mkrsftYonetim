using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EntityLayer
{
    public class Musteriler : myClass
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Firma Kodu Zorunludur"), StringLength(100, ErrorMessage = "Firma Kodu Çok Uzun(Max. 100)")]
        public string firmakodu { get; set; }
        [Required(ErrorMessage = "Firma Adı Zorunludur"), StringLength(150, ErrorMessage = "Firma Adı Çok Uzun(Max. 150)")]
        public string firmaadi { get; set; }
        public string yetkili { get; set; }
        public string yetkilitel { get; set; }
        public string firmatel { get; set; }
        public string vdairesi { get; set; }
        public string vnumarasi { get; set; }
        public string adres { get; set; }
        public string mnotu { get; set; }

    }
}
