using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
  public  class UserForRegisterDto
    {
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
    }
}
