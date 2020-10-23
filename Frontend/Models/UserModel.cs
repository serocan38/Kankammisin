using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string kullaniciAdi { get; set; }

    }
}
