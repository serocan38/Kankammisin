using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Frontend.Models;
using IdentityServer4.Extensions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace Frontend.Controllers
{
    public class LoginController : Controller
    {
        const string SessionName = "_Name";

     


        public IActionResult Index()
        {
         //   string username = userModel.kullaniciAdi;
         //   sendUser(userModel);
            return View();
        }

    /*    [HttpPost]
        public ActionResult SendUser(UserModel userModel)
        {
            string username = userModel.kullaniciAdi;
            //   var user =  _userManager.GetUserAsync(HttpContext.User);
            TempData["mydata"] = username;
            return RedirectToAction("GetTest", "Test",TempData["mydata"]);
        }*/
         [HttpPost]
        public ActionResult setUser(UserModel userModel)
        {
            HttpContext.Session.SetString("username", userModel.kullaniciAdi);

            return RedirectToActionPreserveMethod("getTest","Test"); ;
        }


    }
}
