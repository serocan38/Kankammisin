using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Dtos;
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
        private bool giris;

        public AuthController(IAuthService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;
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




        [HttpGet("login")]
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
                return BadRequest("Başarısız1");
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

        public IActionResult IsLogin(UserForLoginDto userForLoginDto)
        {
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
                    return Ok(result);
                }

                return BadRequest("Hata");
            }
        }


        [HttpPost("register")]
        [EnableCors("sero")]

        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExist = _authService.UserExist(userForRegisterDto.KullaniciAdi);
            if (!userExist.Success)
            {
                return BadRequest("Kullanıcı Mevcut");
            }

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
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

        public IActionResult GetByUsername(string username)
        {
            var result = _userService.GetByUsername(username);
            if (result.KullaniciAdi==username)
            {
                return Ok(result);
            }

            return BadRequest("Hata");
        }
    }
}
