using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Frontend.Controllers
{
    public class TestOlusturController : Controller
    {
        private readonly KankammisinContext _context;

        public TestOlusturController(KankammisinContext context)
        {
            _context = context;
        }
        public IActionResult TestOlustur()
        {
            return View(_context.Sorular.ToList());
        }

        [HttpGet]
        public IActionResult YeniTest()
        {
            return View();
        }
        [HttpGet]
        public IActionResult setTest()
        {
            return View();
        }

      

        [HttpPost]
        public IActionResult setTest(TestModel testModels)
        {
            var currentUsername = HttpContext.Session.GetString("username");
        //    string testLinki = "https://localhost:44310/Test/TestCoz?link=" + currentUsername + "-" + testModels.TestId;
            TestModel testModel = new TestModel
            {
                TestCozulmeSayisi = 0,
           //     TestLinki = testLinki,
                TestSahibi = currentUsername,
                TestSoruSayisi = 10,
                TestAdi = testModels.TestAdi
            };
            _context.Testler.Add(testModel);
            _context.SaveChanges();
            HttpContext.Session.SetInt32("baslik", testModel.TestId);

            return RedirectToAction("YeniTest", "TestOlustur"); ;
        }





        [HttpPost]
        public async Task<ActionResult> YeniTest(List<SoruModel> soruModel)
        {


            var currentUsername = HttpContext.Session.GetString("username");
            var _testId = HttpContext.Session.GetInt32("baslik");
            var testModel = _context.Testler.Find(_testId);

            for (int i = 0; i < soruModel.Count; i++)
            {
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
