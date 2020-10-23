using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Dtos;

namespace Business.Abstract
{
   public class ClaimAdd
   {
       private KankammisinContext context;
       private IUserService _userService;
        public ClaimAdd(KankammisinContext _context,IUserService userService)
        {
            context = _context;
            _userService = userService;
        }

        public void ClaimAdds(UserForRegisterDto userForRegisterDto)
        {
            var k = _userService.GetByUsername(userForRegisterDto.KullaniciAdi);
            UserOperationClaim userOperationClaim = new UserOperationClaim
            {
                UserId = k.ID,
                OperationClaimId = 1
            };
            context.UserOperationClaims.Add(userOperationClaim);
            context.SaveChanges();
        }
   }
}
