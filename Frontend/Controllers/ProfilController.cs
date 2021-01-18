using System.Linq;
using Frontend.Models;
using IdentityServer4.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Frontend.Controllers
{
    public class ProfilController : Controller
    {
        private KankammisinContext _context;

        public ProfilController(KankammisinContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var currentUsername = HttpContext.Session.GetString("username");
            ViewData["username"] = currentUsername;
            var currentUser = _context.Users.Where(u => u.kullaniciAdi == currentUsername).FirstOrDefault();
            return View(currentUser);
        }
        [HttpPost]
        public IActionResult Index(UserModel userModel)
        {
            var currentUsername = HttpContext.Session.GetString("username");
            userModel.kullaniciAdi = currentUsername;
            ViewData["username"] = currentUsername;
            if (userModel.ad.IsNullOrEmpty()||userModel.soyad.IsNullOrEmpty()||userModel.email.IsNullOrEmpty())
            {
                ModelState.AddModelError("bos", "Lütfen Boş Bırakmayınız");
                return View(userModel);
            }
           
            _context.Entry(userModel).State = EntityState.Modified;
            _context.SaveChanges();
            return View(userModel);
        }
    }
}
