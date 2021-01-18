using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Frontend.Models;
using IdentityServer4.Extensions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Frontend.Controllers
{
    public class RegisterController : Controller
    {
        private readonly KankammisinContext _context;
        Uri baseAddress = new Uri("https://localhost:44388/api/");
        private IAuthService _authService;
        private IUserService _userService;
        public RegisterController(KankammisinContext context, IAuthService authService, IUserService userService)
        {
            _context = context;
            _authService = authService;
            _userService = userService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AnonymusRegister()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Aregister(RegisterModel user)
        {
            var cozen = HttpContext.Session.GetString("uuid");

            var httpclient = new HttpClient();
            using (var handler = new HttpClientHandler())
            {
                handler.ServerCertificateCustomValidationCallback = (request, cert, chain, errors) => true;
                using (var client = new HttpClient(handler))
                {
                    client.BaseAddress = baseAddress;
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type",
                        "application/x-www-form-urlencoded; charset=utf-8");

                    /*    HttpResponseMessage Res = await client.GetAsync("auth/register?kullaniciadi=" + model.RegisterModels.kullaniciadi +
                                                                        "&email=" + model.RegisterModels.email +
                                                                        "&password=" + model.RegisterModels.password +
                                                                        "&ad=" + model.RegisterModels.ad +
                                                                        "&soyad=" + model.RegisterModels.soyad);
                    */
                    HttpResponseMessage resNews =
                        await client.PostAsync("auth/register", new StringContent(JsonConvert.SerializeObject(user),
                            Encoding.UTF8, "application/json"));

                    if (resNews.IsSuccessStatusCode)
                    {
                        var result = _userService.GetByUsername(user.kullaniciadi);
                        HttpContext.Session.SetString("username", user.kullaniciadi);
                        var token = _authService.CreateAccessToken(result);
                        HttpContext.Session.SetString("JWToken", token.Data.Token);

                        _context.CozulenTest.Where(c => c.cozen == cozen).FirstOrDefault().cozen = user.kullaniciadi;
                        _context.Istatistik.Where(c => c.cozen == cozen).FirstOrDefault().cozen = user.kullaniciadi;
                        _context.SaveChanges();
                        HttpContext.Session.Remove("uuid");



                        return RedirectToAction("GetTest", "Test");

                    }
                    else
                    {
                        ModelState.AddModelError("kullanicihata", "Kullanıcı Adı veya Şifre Yanlış");
                        return RedirectToAction("AnonymusRegister", "Register");
                    }
                }
            }


        }

    }
}
