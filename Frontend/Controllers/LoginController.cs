using System;
using System.Linq;
using System.Threading.Tasks;
using Frontend.eskiapi;
using Frontend.Models;
using IdentityServer4.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Frontend.Controllers
{
    public class LoginController : Controller
    {
        private KankammisinContext _context;
        private JwtHelper _jwtHelper;
        private IConfiguration Configuration;
        private EfUserDal _efUser;
        public LoginController( KankammisinContext context, IConfiguration configuration)
        {
            _context = context;
            _efUser = new EfUserDal(_context);
            Configuration = configuration;
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

            var userToCheck = _context.Users.Where(u=>u.KullaniciAdi==loginsModel.id).FirstOrDefault() ;
            if (userToCheck == null)
            {
                ModelState.AddModelError("kullanicihata", "Kullanıcı Bulunamadı");
                return View();
            }
            else
            {
                if (!HashingHelper.VerifyPasswordHash(loginsModel.password, userToCheck.SifreHash,
                    userToCheck.SifreSalt))
                {
                    ModelState.AddModelError("kullanicihata", "sifre yanlış");
                    return View();
                }
                else
                {
                    var result = _context.Users.Where(u => u.KullaniciAdi == loginsModel.id).FirstOrDefault();
                    HttpContext.Session.SetString("username", loginsModel.id);
                    var claims = _efUser.GetClaims(result);
                    _jwtHelper = new JwtHelper(Configuration);
                    var token = _jwtHelper.CreateToken(result,claims);
                    HttpContext.Session.SetString("JWToken", token.Token);
                    var intentUrl = HttpContext.Session.GetString("intentUrl");
                    HttpContext.Session.Remove("intentUrl");
                    if (!intentUrl.IsNullOrEmpty())
                    {
                        Redirect(intentUrl);
                    }

                    if (!cozen.IsNullOrEmpty())
                    {
                        var c = _context.Istatistik.Where(a => a.cozen == loginsModel.id)
                            .Where(c => c.testAdi == HttpContext.Session.GetString("testadi")).FirstOrDefault();
                        HttpContext.Session.Remove("testadi");

                        if (c != null)
                        {
                            string hata1 = "Bu Testi Daha Önce Çözmüşsünüz.";
                            return RedirectToAction("Error", "Error", new {hata = hata1});
                        }

                        _context.CozulenTest.Where(c => c.cozen == cozen).FirstOrDefault().cozen = loginsModel.id;
                        _context.Istatistik.Where(c => c.cozen == cozen).FirstOrDefault().cozen = loginsModel.id;
                        _context.SaveChanges();
                        HttpContext.Session.Remove("uuid");

                    }

                    return RedirectToAction("GetTest", "Test");
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
