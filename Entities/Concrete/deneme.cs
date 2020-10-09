using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class deneme
    {
        public string listele()
        {
            User user = new User();
            return user.Ad;
        }
    }
}
