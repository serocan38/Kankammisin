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
            var currentUsername = HttpContext.Session.GetString("username");
            var istatistikModels = await _context.Istatistik.Where(i => i.cozulen == currentUsername).ToListAsync();

            return View(istatistikModels);
        }

        [Authorize(Roles = "Admin,Kullanici")]
        [HttpPost]
        public async Task<ActionResult> Index(IstatistikModel istatistikModel)
        {
            var currentUsername = HttpContext.Session.GetString("username");


            return RedirectToAction("CozulmusTest","Istatistik",istatistikModel);
        }


        [Authorize(Roles = "Admin,Kullanici")]
        [HttpGet]
        public async Task<ActionResult> CozulmusTest(IstatistikModel istatistikModel)
        {
            var currentUsername = HttpContext.Session.GetString("username");
            var cozulentest = from i in _context.Istatistik
                join t in _context.Testler on i.testAdi equals t.TestAdi
                where i.cozulen == currentUsername
                select new CozulenTestModel
                {
                    testId = t.TestId,
                    cozen = i.cozen,
                };
            var deneme = _context.CozulenTest.Where(c => c.cozen == istatistikModel.cozen).FirstOrDefault();
            var soru = await _context.Sorular.Where(s => s.testId == cozulentest.FirstOrDefault().testId).ToListAsync();
           
            CozunlenTestSoruModel cozunlenTestSoruModel = new CozunlenTestSoruModel();

            cozunlenTestSoruModel.SoruModels = soru;
            cozunlenTestSoruModel.SecilenCevaplar = deneme.secilenCevaplar;

            return View(cozunlenTestSoruModel);
        }



    }
}
