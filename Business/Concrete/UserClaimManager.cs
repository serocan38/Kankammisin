using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserClaimManager:IUserClaimService
    {
         IUserClaimDal _userClaimDal;

        public UserClaimManager(IUserClaimDal userClaimDal)
        {
            _userClaimDal = userClaimDal;
        }


        public IResult Add(UserOperationClaim userOperationClaim)
        {
            _userClaimDal.Add(userOperationClaim);
            return new SuccessResult("Ekleme Başarılı ");
        }
    }
}
