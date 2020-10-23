using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Security.Jwt;
using Frontend.Models;
using Frontend.Validation;
using IdentityModel;
using IdentityServer4.Services;
using IdentityServer4.Validation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Frontend.Controllers
{
    public class LoginController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44388/api/");
        private IAuthService _authService;
        private IUserService _userService;


        public LoginController(IAuthService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;

        }




        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(LoginsModel loginsModel)
        {
            var httpclient = new HttpClient();
                using (var handler = new HttpClientHandler())
            {
                handler.ServerCertificateCustomValidationCallback = (request, cert, chain, errors) => true;
                using (var client = new HttpClient(handler))
                {
                    client.BaseAddress = baseAddress;
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type",
                        "application/x-www-form-urlencoded; charset=utf-8");

                    HttpResponseMessage Res = await client.GetAsync("auth/islogin?id=" + loginsModel.id +
                                                                    "&password=" + loginsModel.password);
                    
                    if (Res.IsSuccessStatusCode)
                    {
                        var result = _userService.GetByUsername(loginsModel.id);
                        HttpContext.Session.SetString("username", loginsModel.id); 
                        var token = _authService.CreateAccessToken(result);
                        HttpContext.Session.SetString("JWToken", token.Data.Token);
                        ViewData["username"] = loginsModel.id;



                        return RedirectToAction("GetTest", "Test");
                    }
                    else
                    {
                        ModelState.AddModelError("kullanicihata", "Kullanıcı Adı veya Şifre Yanlış");
                        return View();
                    }
                }
            }
        
        }

        [HttpPost]
        public ActionResult setUser(UserModel userModel)
        {
            HttpContext.Session.SetString("username", userModel.kullaniciAdi);
            return RedirectToAction("getTest", "Test"); ;
        }

        [HttpPost]
        public ActionResult noLogin(string url)
        {
            return Redirect(url);
        }

        [HttpGet]
        public ActionResult noLogin()
        {
            return View();
        }



    }
}
