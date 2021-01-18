using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Frontend.Controllers
{
    public class IstatistikController : Controller
    {
        private KankammisinContext _context;

        public IstatistikController(KankammisinContext context)
        {
            _context = context;
        }



        [Authorize(Roles = "Admin,Kullanici")]
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            _context.RemoveRange(_context.CozulenTest.Where(c => c.cozen.Contains("anonim")).ToList());
            _context.RemoveRange(_context.Istatistik.Where(c => c.cozen.Contains("anonim")).ToList());
            _context.SaveChanges();
            var currentUsername = HttpContext.Session.GetString("username");
            ViewData["username"] = currentUsername;
            var istatistikModels = await _context.Istatistik.Where(i => i.cozulen == currentUsername).ToListAsync();

            return View(istatistikModels);
        }

        [Authorize(Roles = "Admin,Kullanici")]
        [HttpPost]
        public async Task<ActionResult> Index(IstatistikModel istatistikModel)
        {
            var currentUsername = HttpContext.Session.GetString("username");


            return RedirectToAction("CozulmusTest", "Istatistik", istatistikModel);
        }


        [Authorize(Roles = "Admin,Kullanici")]
        [HttpGet]
        public async Task<ActionResult> CozulmusTest(IstatistikModel istatistikModel)
        {
            var currentUsername = HttpContext.Session.GetString("username");
            ViewData["username"] = currentUsername;
            
            var deneme = _context.CozulenTest.Where(c=>c.testId==istatistikModel.testId).FirstOrDefault();
            var soru = await _context.Sorular.Where(s => s.testId == istatistikModel.testId).ToListAsync();

            CozunlenTestSoruModel cozunlenTestSoruModel = new CozunlenTestSoruModel
            {
                SoruModels = soru,
                SecilenCevaplar = deneme.secilenCevaplar,
                Kankalik = istatistikModel.Kankalik,
                Cozen = deneme.cozen,
                TestAdi = istatistikModel.testAdi
            };

            if (istatistikModel.cozulen != currentUsername)
                return RedirectToAction("Error", "Error", new { hata = "Bu Sayfaya Girebilmek İçin Yetkniz Bulunmamaktadır" });


            return View(cozunlenTestSoruModel);
        }



    }
}
