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
using IdentityServer4.Extensions;
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
        public ActionResult TestIstatistik(string testAdi)
        {
            string currentUsername = HttpContext.Session.GetString("username");
            ViewData["username"] = currentUsername;
            var istatistikModel = _context.Istatistik.Where(i => i.testAdi == testAdi && i.cozulen == currentUsername).ToList();
            var liste = istatistikModel.Where(i => i.Kankalik == "BFF").ToList();
            List<String> a = new List<string>();
            if (!liste.IsNullOrEmpty())
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    a.Add(liste[i].cozen);
                }
            }
            TestAdiTestModel testAdiTestModel = new TestAdiTestModel
            {
                TestAdi = testAdi,
                IstatistikModels = istatistikModel,
                bfflist = a
            };
            if (istatistikModel.Count != 0)
            {
                var cozulenKullanici = istatistikModel.Where(i => i.cozulen == currentUsername);
                if (cozulenKullanici.FirstOrDefault().cozulen != currentUsername)
                    return RedirectToAction("Error", "Error", new { hata = "Bu Sayfaya Girebilmek İçin Yetkniz Bulunmamaktadır" });
            }


            return View(testAdiTestModel);
        }

        [Authorize(Roles = "Kullanici,Admin")]
        public async Task<ActionResult> GetTest()
        {

            // GetUser(userModel.kullaniciAdi);
            var boslink = _context.Testler.Where(t => t.TestLinki == null);
            _context.RemoveRange(boslink);
            _context.SaveChanges();
            var currentUsername = HttpContext.Session.GetString("username");
            ViewData["username"] = currentUsername;

            var testModel = await _context.Testler.Where(t => t.TestSahibi.Equals(currentUsername)).ToListAsync();
            foreach (var a in testModel)
            {
                a.TestCozulmeSayisi = _context.CozulenTest.Where(c => c.testId == a.TestId).Count();
            }

            _context.SaveChanges();
            if (currentUsername == null)
            {
                return RedirectToAction("noLogin", "Login", new { url = "http://kankammisin.tashteam/test/gettest" });
            }
            var s = new HttpClient();
            return View(testModel.ToList());
        }



        public ActionResult TestCoz(String link)
        {
            var currentUsername = HttpContext.Session.GetString("username");
            ViewData["username"] = currentUsername;

            String[] parametreler = link.Split("-");
            if (currentUsername == parametreler[0])
            {
                return RedirectToAction("Error", "Error", new { hata = "Maalesef Kendi Testinizi Çözemezsiniz" });
            }

            var cozulmusmu = _context.CozulenTest.Where(c => c.cozen == currentUsername);
            if (cozulmusmu.Count()==0)
            {
                return RedirectToAction("Error", "Error", new { hata = "Bu Testi Daha Önce Çözmüşsünüz" });
            }
            int testid = Int32.Parse(parametreler[1]);
            var soruModels = _context.Sorular.Where(s => s.testId == testid).ToList();
            for (int i = 0; i < soruModels.Count; i++)
            {
                soruModels[i].dogruCevap = 5;
            }


            var testModel = _context.Testler.Where(t => t.TestId == soruModels[0].testId).FirstOrDefault();
            ViewData["testAdi"] = testModel.TestAdi;



            return View(soruModels.ToList());
        }




        [Authorize(Roles = "Kullanici,Admin")]
        public ActionResult TestSil(TestModel testModel)
        {
            ExistCheck e = new ExistCheck(_context);
            e.TestSil(testModel);
            return RedirectToAction("GetTest", "Test");
        }

        [HttpPost]
        public async Task<ActionResult> TestCoz(List<SoruModel> soru)
        {
            int _dogruSayisi = 0;
            var currentUsername = HttpContext.Session.GetString("username");
            string UUID = "anonim" + System.Guid.NewGuid();


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
            string result = string.Join("", secilen);

            CozulenTestModel cozulenTestModel = new CozulenTestModel();

            cozulenTestModel.testId = soruModels[0].testId;
            cozulenTestModel.secilenCevaplar = result;
            int _yanlisSayisi = soru.Count - _dogruSayisi;
            IstatistikModel istatistik = new IstatistikModel
            {
                testAdi = testModels[0].TestAdi,
                YanlisSayisi = _yanlisSayisi,
                testId = testModels[0].TestId,
                DogruSayisi = _dogruSayisi,
                cozulen = testModels[0].TestSahibi,
                Kankalik = KankalikHesapla(soru.Count, _dogruSayisi)
            };

            if (currentUsername.IsNullOrEmpty())
            {
                cozulenTestModel.cozen = UUID;
                istatistik.cozen = UUID;
            }
            
            else
            {
                cozulenTestModel.cozen = currentUsername;
                istatistik.cozen = currentUsername;
            }
            _context.CozulenTest.Add(cozulenTestModel);
            _context.Istatistik.Add(istatistik);
            _context.SaveChanges();
            HttpContext.Session.SetString("uuid", UUID);
            HttpContext.Session.SetString("testadi", istatistik.testAdi);

            if (currentUsername.IsNullOrEmpty())
            {
                return RedirectToAction("AnonymusRegister", "Register");
            }
            return RedirectToAction("GetTest", "Test");
        }






        private string KankalikHesapla(int soruSayisi, int dogruSayisi)
        {
            float yuzdelik = (float)((float)dogruSayisi / soruSayisi * 100.0);
            if (yuzdelik >= 100)
                return "BFF";
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
