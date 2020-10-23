using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using Frontend.Models;
using Frontend.Validation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Frontend.Controllers
{
    [Authorize(AuthenticationSchemes = "JwtBearer")]
    public class TestController : Controller
    {
        private readonly KankammisinContext _context;

        public TestController(KankammisinContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Kullanici,Admin")]
        public IActionResult Test(UserModel userModel)
        {
            return View(_context.Testler.ToList());
        }


        [Authorize(Roles = "Kullanici,Admin")]
        public IActionResult TestCoz()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
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

        [Authorize(Roles = "Kullanici,Admin")]
        public async Task<ActionResult> GetTest()
        {

            // GetUser(userModel.kullaniciAdi);
            var boslink = _context.Testler.Where(t => t.TestLinki == null);
            _context.RemoveRange(boslink);
            _context.SaveChanges();
            var currentUsername = HttpContext.Session.GetString("username");
            var testModel = await _context.Testler.Where(t => t.TestSahibi.Equals(currentUsername)).ToListAsync();

            if (currentUsername==null)
            {
                return RedirectToAction("noLogin", "Login",new{url= "https://localhost:44310/test/gettest" });
            }
            if (testModel == null)
            {
                ModelState.AddModelError("bostest", "Hiç Testiniz Bulunmamaktadır");
                return View();
            }
            var s = new HttpClient();
            return View(testModel.ToList());
        }

        [Authorize(Roles = "Kullanici,Admin")]
        [HttpGet]
        public async Task<ActionResult> TestCoz(String link)
        {
            var currentUsername = HttpContext.Session.GetString("username");
            if (currentUsername == null)
            {
                return RedirectToAction("noLogin", "Login", new { url = link });
            }
          /*  var varmi = from t in _context.Testler
                join c in _context.CozulenTest on t.TestId equals c.testId
                join i in _context.Istatistik on c.cozen equals i.cozen
                select new{i,cozen=currentUsername};*/
           

            String[] parametreler = link.Split("-");
            if (currentUsername ==parametreler[0])
                return BadRequest("KENDİ TESTİNİZİ ÇÖZEMEZSİNİZ");
            int testid = Int32.Parse(parametreler[1]);
            var soruModels = await _context.Sorular.Where(s => s.testId ==testid).ToListAsync();
            for (int i = 0; i < soruModels.Count; i++)
            {
                soruModels[i].dogruCevap = 5;
            }
            return View(soruModels.ToList());
        }

        [Authorize(Roles = "Kullanici,Admin")]
        public ActionResult TestSil(TestModel testModel)
        {
            ExistCheck e = new ExistCheck(_context);
             e.TestSil(testModel);
            return RedirectToAction("GetTest", "Test");
        }

        [Authorize(Roles = "Kullanici,Admin")]
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
            var testModels = await _context.Testler.Where(t => t.TestId == soru[0].testId).ToListAsync();
            string[] secilen = new String[soruModels.Count];
            for (int i = 0; i < soru.Count; i++)
            {
                if (soru[i].dogruCevap == soruModels[i].dogruCevap)
                {
                    _dogruSayisi++;
                }
                secilen[i] = soru[i].dogruCevap.ToString();
            }
            string result = string.Join("",secilen);

            CozulenTestModel cozulenTestModel = new CozulenTestModel
            {
                testId = soruModels[0].testId,
                cozen = currentUsername,
                secilenCevaplar = result
            };

            
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
            _context.CozulenTest.Add(cozulenTestModel);
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
