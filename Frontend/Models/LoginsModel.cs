using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Frontend.Models
{
    public class LoginsModel : IdentityUser
    {
        [PersonalData]
        public string Username { get; set; }
        [PersonalData]
        public string Password { get; set; }
    }
}
