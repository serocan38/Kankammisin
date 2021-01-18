using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    [Route("error")]
    public class ErrorController : Controller
    {


        public IActionResult Error(string hata)
        {
            ModelState.AddModelError("error", hata);

            return View();
        }


        [Route("{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            if (statusCode==404)
            {
                return RedirectToAction("Error", "Error", new { hata = "Aradığınız Sayfa Bulunamadı" });
            }
            else if (statusCode==500)
            {
                    return RedirectToAction("Error", "Error", new { hata = "Bir Hata Oluştu" });

            }else if (statusCode==401)
            {
                return RedirectToAction("Error", "Error", new { hata = "Bu Sayfaya Girebilmek İçin Yetkniz Bulunmamaktadır" });
            }else
            return RedirectToAction("Error", "Error", new { hata = "Bilinmeyen Bir Hata Oluştu" });
        }




    }
}
