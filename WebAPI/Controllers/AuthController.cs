using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("sero")]


    public class AuthController : ControllerBase
    {
        private IAuthService _authService;
        private IUserService _userService;
        private IUserClaimService _userClaimService;
        private bool giris;
        

        public AuthController(IAuthService authService, IUserService userService,IUserClaimService userClaimService)
        {
            _authService = authService;
            _userService = userService;
            _userClaimService = userClaimService;
        }
        [HttpOptions("{login}")]
        public IActionResult PreflightRoute(int id)
        {
            return NoContent();
        }

        // OPTIONS: api/TodoItems2 
        [HttpOptions]
        public IActionResult PreflightRoute()
        {
            return NoContent();
        }




        [HttpGet("loginn")]
        [EnableCors("sero")]
        public ActionResult isLogin()
        {
            if (giris)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpPost("login")]
        [EnableCors("sero")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return Ok("Başarısız1");
            }
            else
            {
                return Ok("Giriş Başarılı");
            }

            //  var result = _authService.CreateAccessToken(userToLogin.Data);
            //  if (result.Success)
            //  {
            //      return Ok();
            //  }
            //return BadRequest("Başarısız2");
        }

        [HttpGet("islogin")]
        [EnableCors("sero")]

        public IActionResult IsLogin(string id, string password)
        {
            UserForLoginDto userForLoginDto = new UserForLoginDto();
            userForLoginDto.Id = id;
            userForLoginDto.password = password;
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest("false");
            }
            else
            {
                var result = _userService.GetByUsername(userForLoginDto.Id);
                if (result.KullaniciAdi == userForLoginDto.Id)
                {
              //      var token =  _authService.CreateAccessToken(result);
                    return Ok();
                }

                return BadRequest("Hata");
            }
        }


        [HttpPost("register")]
        [EnableCors("sero")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            if (userForRegisterDto.Email.Equals(null) || userForRegisterDto.KullaniciAdi.Equals(null) || userForRegisterDto.ad.Equals(null) || userForRegisterDto.soyad.Equals(null))
            {
                return BadRequest("Lütfen Boş Yerleri Doldurunuz");

            }

            var userExist = _authService.UserExist(userForRegisterDto.KullaniciAdi);
            if (!userExist.Success)
            {
                return BadRequest("Kullanıcı Mevcut");
            }


            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                var current = _userService.GetByUsername(userForRegisterDto.KullaniciAdi);
                UserOperationClaim userOperation = new UserOperationClaim
                {
                    UserId = current.ID,
                    OperationClaimId = 2
                };
                _userClaimService.Add(userOperation);
                return Ok("Başarıyla Üye Olundu");
            }

            return BadRequest("Sıkıntı var");
        }

        [HttpGet("getall")]
        [EnableCors("sero")]

        //   [Authorize(Roles = "Product.List")]

        public IActionResult GetList()
        {
            var result = _userService.GetUserList().Data;

            return Ok(result);
        }


        [HttpGet("getbyusername")]
        [EnableCors("sero")]
      //  [Authorize(Roles="Product.List")]
        public IActionResult GetByUsername(string username)
        {
            var result = _userService.GetByUsername(username);
            var exist = _authService.UserExist(username);
            if (exist.Success || result.KullaniciAdi == username)
            {
                    return Ok(result);
            }

            else
            {
                return BadRequest("Hata");

            }

        }
    }
}
