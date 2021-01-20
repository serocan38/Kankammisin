using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class UserdbModel
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
        public byte[] SifreSalt { get; set; }
        public byte[] SifreHash { get; set; }
    }
}
