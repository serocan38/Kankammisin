using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;
using Frontend.Validation;
using IdentityServer4.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class TestOlusturController : Controller
    {
        private readonly KankammisinContext _context;
        public TestOlusturController(KankammisinContext context)
        {
            _context = context;
        }

        public IActionResult YeniTest(int soruSayisi)
        {
            ViewData["username"] = HttpContext.Session.GetString("username");
            ViewData["sayi"] = soruSayisi;
            return View();
        }
        [HttpGet]
        public IActionResult setTest()
        {
            var currentUsername = HttpContext.Session.GetString("username");
            ViewData["username"] = currentUsername;
            if (currentUsername == null)
            {
                HttpContext.Session.SetString("username","https://kankammisin.tashteam/testolustur/settest" );
                return RedirectToAction("Index", "Login");
            }

            return View();
        }

        [HttpPost]
        public IActionResult setTest(TestModel testModels)
        {
            var currentUsername = HttpContext.Session.GetString("username");
            ViewData["username"] = currentUsername;
            if (testModels.TestSoruSayisi>12 || testModels.TestSoruSayisi<3)
            {
                ModelState.AddModelError("sorusayisi", "Min Soru Sayısı 3, Max Soru Sayısı 12 Olmalıdır");
                return View();
            }
            if (testModels.TestAdi.IsNullOrEmpty())
            {
                ModelState.AddModelError("sorusayisi", "Lütfen Testinize Bir İsim Veriniz");
                return View();
            }
            //    string testLinki = "https://localhost:44310/Test/TestCoz?link=" + currentUsername + "-" + testModels.TestId;
            TestModel testModel = new TestModel
            {
                TestCozulmeSayisi = 0,
                TestSahibi = currentUsername,
                TestSoruSayisi = testModels.TestSoruSayisi,
                TestAdi = testModels.TestAdi
            };
            ExistCheck e = new ExistCheck(_context);
            if (e.testExist(testModels.TestAdi,currentUsername))
            {
                ModelState.AddModelError("testExist", "Aynı İsimde Testiniz Bulunmaktadır.");
                return setTest();
            }

            _context.Testler.Add(testModel);
            _context.SaveChanges();
            HttpContext.Session.SetInt32("baslik", testModel.TestId);

            return RedirectToAction("YeniTest", "TestOlustur", new {soruSayisi = testModels.TestSoruSayisi }); ;
        }




        [HttpPost]
        public async Task<ActionResult> YeniTest(List<SoruModel> soruModel)
        {


            var currentUsername = HttpContext.Session.GetString("username");
            var _testId = HttpContext.Session.GetInt32("baslik");
            var testModel = _context.Testler.Find(_testId);
            if (_testId==null)
            {
                return RedirectToAction("setTest", "TestOlustur");
            }
            for (int i = 0; i < soruModel.Count; i++)
            {
                if (soruModel[i].soru.IsNullOrEmpty() || soruModel[i].cevap1.IsNullOrEmpty() || soruModel[i].cevap2.IsNullOrEmpty() || soruModel[i].cevap3.IsNullOrEmpty() || soruModel[i].cevap4.IsNullOrEmpty()||soruModel[i].dogruCevap==0 )
                {
                    ModelState.AddModelError("bos", "Lütfen Tüm Boşlukları Doldurunuz");
                    ViewData["sayi"] = soruModel.Count;
                    return View();
                }
                soruModel[i].soruAdi = testModel.TestAdi + "-" +(int)( i + 1);
                soruModel[i].testId = (int)_testId;
                _context.Sorular.Add(soruModel[i]);

            }
            string testLinki = "https://localhost:44310/Test/TestCoz?link=" + currentUsername + "-" + _testId;
            _context.Testler.Find(_testId).TestLinki =testLinki;
            _context.SaveChanges();
            return RedirectToAction("GetTest", "Test");
        }

        

       

    }
}
