using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserManager:IUserService

    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)

        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByUsername(string kullaniciAdi)
        {
            return _userDal.Get(u => u.KullaniciAdi == kullaniciAdi);
        }

        IDataResult<User> IUserService.GetUserList()
        {
            return new SuccessDataResult<User>(_userDal.GetList().ToList());
        }

       
        public IDataResult<List<User>> GetUserList()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetList().ToList());
        }
    }
}
