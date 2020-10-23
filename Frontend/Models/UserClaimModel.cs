using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class UserClaimModel
    {
        public UserModel userModel { get; set; }
        public string kullaniciTuru { get; set; }
        public UserClaimModel()
        {
            this.userModel = new UserModel();
            this.kullaniciTuru = new string(kullaniciTuru);
        }
    }
}
