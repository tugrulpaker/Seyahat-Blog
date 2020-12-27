using System;
using System.ComponentModel.DataAnnotations;

namespace adamgibi2.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
