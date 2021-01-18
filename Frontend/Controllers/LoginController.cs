using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
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
using IdentityServer4.Extensions;
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
        private KankammisinContext _context;

        public LoginController(IAuthService authService, IUserService userService,KankammisinContext context)
        {
            _authService = authService;
            _userService = userService;
            _context = context;

        }




        public IActionResult Index()
        {
            var intentUrl = HttpContext.Session.GetString("intentUrl");
            if (!intentUrl.IsNullOrEmpty())
            {
                ModelState.AddModelError("noLogin", "Devam Etmek İçin Giriş Yapmanız Gerekmektedir");
            }
            var currentUsername = HttpContext.Session.GetString("username");

            if (!currentUsername.IsNullOrEmpty())
            {
                return RedirectToAction("GetTest", "Test");
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(LoginsModel loginsModel)
        {
            var cozen = HttpContext.Session.GetString("uuid");
            if (loginsModel.password.IsNullOrEmpty() || loginsModel.id.IsNullOrEmpty())
            {
                ModelState.AddModelError("kullanicihata", "Lütfen Boş Bırakmayınız");
                return View();
            }


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

                        var intentUrl = HttpContext.Session.GetString("intentUrl");
                        HttpContext.Session.Remove("intentUrl");
                        if (!intentUrl.IsNullOrEmpty())
                        {
                            Redirect(intentUrl);
                        }
                        if (!cozen.IsNullOrEmpty())
                        {
                            var c = _context.Istatistik.Where(a => a.cozen == loginsModel.id).Where(c => c.testAdi == HttpContext.Session.GetString("testadi")).FirstOrDefault();
                            HttpContext.Session.Remove("testadi");

                            if (c!=null)
                            {
                                string hata1 = "Bu Testi Daha Önce Çözmüşsünüz.";
                                return RedirectToAction("Error","Error", new { hata = hata1 });
                            }
                            _context.CozulenTest.Where(c => c.cozen == cozen).FirstOrDefault().cozen = loginsModel.id;
                            _context.Istatistik.Where(c => c.cozen == cozen).FirstOrDefault().cozen = loginsModel.id;
                            _context.SaveChanges();
                            HttpContext.Session.Remove("uuid");

                        }

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
