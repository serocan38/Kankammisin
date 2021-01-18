using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Frontend.Models;
using Frontend.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Frontend.Controllers
{
    public class AdminController : Controller
    {
        KankammisinContext _kankammisinContext;
        public AdminController(KankammisinContext kankammisinContext)
        {
            _kankammisinContext = kankammisinContext;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        [Route("/admin")]
        public ActionResult Admin()
        {
            var tumKullanicilar = _kankammisinContext.Users.ToList();
            IList<UserModel> uList = tumKullanicilar;
            ViewData["username"] = HttpContext.Session.GetString("username"); 

            return View(tumKullanicilar);
        }
        [Authorize(Roles = "Admin")]
        [Route("/istatiktik")]

        public ActionResult Aistatistik(UserModel userModel)
        {
            UserClaimModel userClaimModel = new UserClaimModel();
            userClaimModel.userModel = userModel;
            //  var c = _kankammisinContext.UserOperationClaims.Where(u => u.UserId == userModel.Id).FirstOrDefault();
            var j = from uoc in _kankammisinContext.UserOperationClaims
                    join user in _kankammisinContext.Users on uoc.UserId equals user.Id
                    join o in _kankammisinContext.OperationClaims on uoc.OperationClaimId equals o.Id
                    where user.kullaniciAdi == userModel.kullaniciAdi
                    select new OperationClaim { Id = uoc.OperationClaimId, Name = o.Name };

            List<string> uList = new List<string> { "Admin", "Kullanici" };
            ViewBag.uList = new SelectList(uList);
            userClaimModel.kullaniciTuru = j.FirstOrDefault().Name;


            return View(userClaimModel);
        }
        [Route("/istatistik")]
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Aistatistik(UserClaimModel userClaimModel)
        {
            var a = _kankammisinContext.UserOperationClaims.Where(k => k.UserId == userClaimModel.userModel.Id);
            if (a.FirstOrDefault().OperationClaimId == 2)
            {
                a.FirstOrDefault().OperationClaimId = 1;
                userClaimModel.kullaniciTuru = "Admin";
            }
            else
            {
                a.FirstOrDefault().OperationClaimId = 2;
                userClaimModel.kullaniciTuru = "Kullanici";
            }


            _kankammisinContext.SaveChanges();
            userClaimModel.userModel = _kankammisinContext.Users.Find(userClaimModel.userModel.Id);
            return View(userClaimModel);
        }

        [Authorize(Roles = "Admin")]
        [Route("/atest")]
        public ActionResult ATest()
        {
            var tumTestler = _kankammisinContext.Testler.ToList();
            IList<TestModel> uList = tumTestler;
            ViewData["username"] = HttpContext.Session.GetString("username"); ;
            return View(tumTestler);
        }


        [Authorize(Roles = "Admin")]
        public ActionResult ATestGor(TestModel testModel)
        {
            var soru = _kankammisinContext.Sorular.Where(s => s.testId == testModel.TestId).ToList();
            return View(soru);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult AtestSil(TestModel testModel)
        {
            ExistCheck e= new ExistCheck(_kankammisinContext);
            e.TestSil(testModel);
            return RedirectToAction("ATest","Admin");
        }

    }
}
