using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.Dtos;

namespace Business.Concrete
{
    public class AuthManager:IAuthService

    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordSalt, passworHash;
            HashingHelper.CreatePasswordHash(password, out passworHash, out passwordSalt);
            var user = new User
            {
                KullaniciAdi = userForRegisterDto.KullaniciAdi,
                Email = userForRegisterDto.Email,
                Ad = userForRegisterDto.ad,
                Soyad = userForRegisterDto.soyad,
                SifreHash = passworHash,
                SifreSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, "Kayıt Başarılı");
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByUsername(userForLoginDto.Id);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>("Kullanici Bulunamadı");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.password,userToCheck.SifreHash,userToCheck.SifreSalt))
            {
                return new ErrorDataResult<User>("Kullanıcı Adı veya Şifre Hatalı");
            }
            return new SuccessDataResult<User>("Giriş Başarılı");
        }

        public IResult UserExist(string kullaniciAdi)
        {
            if (_userService.GetByUsername(kullaniciAdi)!=null)
            {
                return new ErrorResult("Bu kullanıcı zaten Mevcut");
            }
            return new SuccessResult("");
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken,"AccessToken Üretildi");
        }
    }
}
