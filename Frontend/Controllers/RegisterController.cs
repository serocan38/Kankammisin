using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Frontend.eskiapi;
using Microsoft.AspNetCore.Mvc;
using Frontend.Models;
using Frontend.Validation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Frontend.Controllers
{
    public class RegisterController : Controller
    {
        private readonly KankammisinContext _context;

        private JwtHelper _jwtHelper;
        private IConfiguration Configuration;
        private EfUserDal _efUser;
        public RegisterController(KankammisinContext context,IConfiguration configuration)
        {
            _context = context;
            _efUser = new EfUserDal(_context);
            Configuration = configuration;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AnonymusRegister()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AnonymusRegister(UserForRegisterDto userForRegisterDto)
        {
            var cozen = HttpContext.Session.GetString("uuid");

            if (userForRegisterDto.Email == null || userForRegisterDto.KullaniciAdi==null || userForRegisterDto.ad == null || userForRegisterDto.soyad== null)
            {
                ModelState.AddModelError("kullanicihata", "Lütfen Heryeri Doldurunuz");
                return RedirectToAction("Index", "Register");
            }

            var hasKullaniciAdi = _context.Users.Where(u => u.KullaniciAdi == userForRegisterDto.KullaniciAdi);
            if (hasKullaniciAdi.Count() != 0)
            {
                ModelState.AddModelError("kullanicihata", "Kullanıcı Adı Bulunmaktadır");
                return RedirectToAction("Index","Register");
            }
            byte[] passwordSalt, passworHash;
            HashingHelper.CreatePasswordHash(userForRegisterDto.password, out passworHash, out passwordSalt);
            var user = new UserdbModel
            {
                KullaniciAdi = userForRegisterDto.KullaniciAdi,
                Email = userForRegisterDto.Email,
                Ad = userForRegisterDto.ad,
                Soyad = userForRegisterDto.soyad,
                SifreHash = passworHash,
                SifreSalt = passwordSalt,
                Status = true
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            var current = _context.Users.Where(u => u.KullaniciAdi == userForRegisterDto.KullaniciAdi).FirstOrDefault();

                UserOperationClaim userOperation = new UserOperationClaim
                {
                    UserId = current.ID,
                    OperationClaimId = 2
                };
                _context.UserOperationClaims.Add(userOperation);
                _context.SaveChanges();
                        var result = _context.Users.Where(u => u.KullaniciAdi == user.KullaniciAdi) as UserdbModel;
            HttpContext.Session.SetString("username", user.KullaniciAdi);
            _jwtHelper = new JwtHelper(Configuration);
            var claims = _efUser.GetClaims(user);
            var token = _jwtHelper.CreateToken(user,claims);
            HttpContext.Session.SetString("JWToken", token.Token);

            _context.CozulenTest.Where(c => c.cozen == cozen).FirstOrDefault().cozen = user.KullaniciAdi;
            _context.Istatistik.Where(c => c.cozen == cozen).FirstOrDefault().cozen = user.KullaniciAdi;
            _context.SaveChanges();
            HttpContext.Session.Remove("uuid");

            return RedirectToAction("GetTest", "Test");
        }
        public IActionResult Aregister()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Aregister(UserForRegisterDto userForRegisterDto)
        {
            var cozen = HttpContext.Session.GetString("uuid");

            if (userForRegisterDto.Email == null || userForRegisterDto.KullaniciAdi == null || userForRegisterDto.ad == null || userForRegisterDto.soyad == null)
            {
                ModelState.AddModelError("kullanicihata", "Lütfen Heryeri Doldurunuz");
                return RedirectToAction("Index", "Register");
            }

            var hasKullaniciAdi = _context.Users.Where(u => u.KullaniciAdi == userForRegisterDto.KullaniciAdi);
            if (hasKullaniciAdi.Count() != 0)
            {
                ModelState.AddModelError("kullanicihata", "Kullanıcı Adı Bulunmaktadır");
                return RedirectToAction("Index", "Register");
            }
            byte[] passwordSalt, passworHash;
            HashingHelper.CreatePasswordHash(userForRegisterDto.password, out passworHash, out passwordSalt);
            var user = new UserdbModel
            {
                KullaniciAdi = userForRegisterDto.KullaniciAdi,
                Email = userForRegisterDto.Email,
                Ad = userForRegisterDto.ad,
                Soyad = userForRegisterDto.soyad,
                SifreHash = passworHash,
                SifreSalt = passwordSalt,
                Status = true
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            var current = _context.Users.Where(u => u.KullaniciAdi == userForRegisterDto.KullaniciAdi).FirstOrDefault();

            UserOperationClaim userOperation = new UserOperationClaim
            {
                UserId = current.ID,
                OperationClaimId = 2
            };
            _context.UserOperationClaims.Add(userOperation);
            _context.SaveChanges();
            var result = _context.Users.Where(u => u.KullaniciAdi == user.KullaniciAdi).FirstOrDefault();
            HttpContext.Session.SetString("username", user.KullaniciAdi);
            _jwtHelper = new JwtHelper(Configuration);
            var claims = _efUser.GetClaims(user);
            var token = _jwtHelper.CreateToken(user, claims);
            HttpContext.Session.SetString("JWToken", token.Token);

            return RedirectToAction("GetTest", "Test");
        }

    }
}
