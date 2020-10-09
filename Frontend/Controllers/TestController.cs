using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Frontend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Frontend.Controllers
{

    public class TestController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly KankammisinContext _context;

        public TestController(KankammisinContext context)
        {
            _context = context;

        }

        [Authorize]
        public IActionResult Test(UserModel userModel)
        {

            return View(_context.Testler.ToList());
        }

   

        public IActionResult TestCoz()
        {
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testModel = await _context.Testler
                .FirstOrDefaultAsync(m => m.TestId == id);
            if (testModel == null)
            {
                return NotFound();
            }

            return View(testModel);
        }

       
        public async Task<ActionResult> GetTest()
        {
            // GetUser(userModel.kullaniciAdi);
            var boslink = _context.Testler.Where(t => t.TestLinki == null);
            _context.RemoveRange(boslink);
            _context.SaveChanges();
            var currentUsername = HttpContext.Session.GetString("username");
            var testModel = await _context.Testler.Where(t => t.TestSahibi.Equals(currentUsername)).ToListAsync(); 
            
            if (testModel == null)
            {
                return BadRequest("Hiç Testiniz Bulnmamaktadır.");
            }
            return View(testModel.ToList());
        }




   /*     [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task<ActionResult> YeniTest(List<SoruModel> soruModel)
        {
            var currentUsername = HttpContext.Session.GetString("username");
            var testId = HttpContext.Session.GetInt32("baslik");
            var testModel = await _context.Testler.FirstOrDefaultAsync(t => t.TestSahibi == currentUsername);

            for (int i = 0; i < soruModel.Count; i++)
            {
                soruModel[i].soruAdi = testModel.TestAdi+"-"+i+1;
                soruModel[i].testId = (int) testId;
                _context.Sorular.Add(soruModel[i]);

            }
            string testLinki = "https://localhost:44310/Test/TestCoz?link=" + currentUsername + "-" + testModel.TestId;



            _context.Testler.Add(testModel);
            _context.SaveChanges();
            return RedirectToAction("GetTest","Test");
        }
   */

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<ActionResult> TestCoz(String link)
        {
            var currentUsername = HttpContext.Session.GetString("username");
            if (currentUsername==null)
            {
                return BadRequest("LÜTFEN GİRİŞ YAPINIZ");
            }
            String[] parametreler = link.Split("-");
            if (currentUsername ==parametreler[0])
                return BadRequest("KENDİ TESTİNİZİ ÇÖZEMEZSİNİZ");
            int testid = Int32.Parse(parametreler[1]);
            var soruModels = await _context.Sorular.Where(s => s.testId ==testid).ToListAsync();


            return View(soruModels.ToList());
        }


        [HttpPost]
        public async Task<ActionResult> TestCoz(List<SoruModel> soru)
        {
            int _dogruSayisi = 0;
            var currentUsername = HttpContext.Session.GetString("username");
            if (currentUsername == null)
            {
                return BadRequest("LÜTFEN GİRİŞ YAPINIZ");
            }
            
            var soruModels = await _context.Sorular.Where(s => s.testId == soru[0].testId).ToListAsync();
            var testModels= await _context.Testler.Where(t => t.TestId== soru[0].testId).ToListAsync();


            for (int i = 0; i < soru.Count; i++)
            {
                if (soru[i].dogruCevap == soruModels[i].dogruCevap)
                    _dogruSayisi++;
            }
            int _yanlisSayisi = soru.Count - _dogruSayisi;
            IstatistikModel istatistik = new IstatistikModel
            {
                testAdi = testModels[0].TestAdi,
                YanlisSayisi = _yanlisSayisi,
                DogruSayisi = _dogruSayisi,
                cozen = currentUsername,
                cozulen = testModels[0].TestSahibi,
                Kankalik = KankalikHesapla(soru.Count,_dogruSayisi)
                
            };

            _context.Istatistik.Add(istatistik);
            _context.SaveChanges();

            return RedirectToAction("GetTest","Test");
        }

        private string KankalikHesapla(int soruSayisi, int dogruSayisi)
        {
            float yuzdelik = (float)((float)dogruSayisi / soruSayisi * 100.0);
            if (yuzdelik >= 100)
                return "BFF.";
            if (yuzdelik > 93)
                return "Sırdaş Kankam.";
            if (yuzdelik > 65)
                return "Kankam";
            if (yuzdelik > 33)
                return "Sıradan Arkadaş.";
            if (yuzdelik > 6)
                return "Aramızdaki Arkadaşlığı Gözden Geçirmeliyiz.";
            else
                return "Bu kim?";
        }
    }


}
