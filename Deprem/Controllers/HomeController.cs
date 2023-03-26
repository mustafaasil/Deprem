using Deprem.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Deprem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {

            string url = "https://api.orhanaydogdu.com.tr/deprem/kandilli/live";

            HttpClient client = new HttpClient();

            HttpResponseMessage cevap = await client.GetAsync(url);


            string? json = await cevap.Content.ReadAsStringAsync();

            dynamic? data = JsonConvert.DeserializeObject(json);

            List<string> iller = new List<string>();

            List<decimal> siddetler = new List<decimal>();

            List<dynamic> tarihler = new List<dynamic>();

            Deprem deprem = new Deprem();

            int count = data.result.Count;
            for (int i = 0; i < count; i++)
            {
                if (i < data.result.Count)
                {
                    deprem.Il = data.result[i].title;
                    deprem.Siddet = data.result[i].mag;
                    deprem.Tarih = data.result[i].date;

                    if (/*deprem.Il.Contains("BINGOL") &&*/ (deprem.Siddet > 2.0m))
                    {
                        iller.Add(deprem.Il);
                        siddetler.Add(deprem.Siddet);
                        tarihler.Add(deprem.Tarih);
                    }
                }
                ViewBag.Il = iller;
                ViewBag.Siddet = siddetler;
                ViewBag.Tarih = tarihler;

            }
            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Elazig(Deprem deprem)
        {
            string url = "https://api.orhanaydogdu.com.tr/deprem/kandilli/live";

            HttpClient client = new HttpClient();

            HttpResponseMessage cevap = await client.GetAsync(url);


            string? json = await cevap.Content.ReadAsStringAsync();

            dynamic? data = JsonConvert.DeserializeObject(json);

            List<string> iller = new List<string>();
            List<decimal> siddetler = new List<decimal>();
            List<dynamic> tarihler = new List<dynamic>();

            int count = data.result.Count;
            for (int i = 0; i < count; i++)
            {
                if (i < data.result.Count)
                {
                    deprem.Il = data.result[i].title;
                    deprem.Siddet = data.result[i].mag;
                    deprem.Tarih = data.result[i].date;

                    if (deprem.Il.Contains("ELAZIG") && (deprem.Siddet > 2.0m))
                    {
                        iller.Add(deprem.Il);
                        siddetler.Add(deprem.Siddet);
                        tarihler.Add(deprem.Tarih);
                    }
                }
                ViewBag.IlElazig = iller;
                ViewBag.SiddetElazig = siddetler;
                ViewBag.TarihElazig = tarihler;

            }
            return View();

        }

        public async Task<IActionResult> Malatya(Deprem deprem)
        {
            string url = "https://api.orhanaydogdu.com.tr/deprem/kandilli/live";

            HttpClient client = new HttpClient();

            HttpResponseMessage cevap = await client.GetAsync(url);


            string? json = await cevap.Content.ReadAsStringAsync();

            dynamic? data = JsonConvert.DeserializeObject(json);

            List<string> iller = new List<string>();
            List<decimal> siddetler = new List<decimal>();
            List<dynamic> tarihler = new List<dynamic>();

            int count = data.result.Count;
            for (int i = 0; i < count; i++)
            {
                if (i < data.result.Count)
                {
                    deprem.Il = data.result[i].title;
                    deprem.Siddet = data.result[i].mag;
                    deprem.Tarih = data.result[i].date;

                    if (deprem.Il.Contains("MALATYA") && (deprem.Siddet > 2.0m))
                    {
                        iller.Add(deprem.Il);
                        siddetler.Add(deprem.Siddet);
                        tarihler.Add(deprem.Tarih);
                    }
                }
                ViewBag.IlMalatya = iller;
                ViewBag.SiddetMalatya = siddetler;
                ViewBag.TarihMalatya = tarihler;

            }
            return View();

        }

        public async Task<IActionResult> Maras(Deprem deprem)
        {
            string url = "https://api.orhanaydogdu.com.tr/deprem/kandilli/live";

            HttpClient client = new HttpClient();

            HttpResponseMessage cevap = await client.GetAsync(url);


            string? json = await cevap.Content.ReadAsStringAsync();

            dynamic? data = JsonConvert.DeserializeObject(json);

            List<string> iller = new List<string>();
            List<decimal> siddetler = new List<decimal>();
            List<dynamic> tarihler = new List<dynamic>();

            int count = data.result.Count;
            for (int i = 0; i < count; i++)
            {
                if (i < data.result.Count)
                {
                    deprem.Il = data.result[i].title;
                    deprem.Siddet = data.result[i].mag;
                    deprem.Tarih = data.result[i].date;

                    if (deprem.Il.Contains("KAHRAMANMARAS") && (deprem.Siddet > 2.0m))
                    {
                        iller.Add(deprem.Il);
                        siddetler.Add(deprem.Siddet);
                        tarihler.Add(deprem.Tarih);
                    }
                }
                ViewBag.IlMaras = iller;
                ViewBag.SiddetMaras = siddetler;
                ViewBag.TarihMaras = tarihler;

            }
            return View();

        }

        public async Task<IActionResult> Hatay(Deprem deprem)
        {
            string url = "https://api.orhanaydogdu.com.tr/deprem/kandilli/live";

            HttpClient client = new HttpClient();

            HttpResponseMessage cevap = await client.GetAsync(url);


            string? json = await cevap.Content.ReadAsStringAsync();

            dynamic? data = JsonConvert.DeserializeObject(json);

            List<string> iller = new List<string>();
            List<decimal> siddetler = new List<decimal>();
            List<dynamic> tarihler = new List<dynamic>();

            int count = data.result.Count;
            for (int i = 0; i < count; i++)
            {
                if (i < data.result.Count)
                {
                    deprem.Il = data.result[i].title;
                    deprem.Siddet = data.result[i].mag;
                    deprem.Tarih = data.result[i].date;

                    if (deprem.Il.Contains("HATAY") && (deprem.Siddet > 2.0m))
                    {
                        iller.Add(deprem.Il);
                        siddetler.Add(deprem.Siddet);
                        tarihler.Add(deprem.Tarih);
                    }
                }
                ViewBag.IlHatay = iller;
                ViewBag.SiddetHatay = siddetler;
                ViewBag.TarihHatay = tarihler;

            }
            return View();

        }

        public async Task<IActionResult> Adiyaman(Deprem deprem)
        {
            string url = "https://api.orhanaydogdu.com.tr/deprem/kandilli/live";

            HttpClient client = new HttpClient();

            HttpResponseMessage cevap = await client.GetAsync(url);


            string? json = await cevap.Content.ReadAsStringAsync();

            dynamic? data = JsonConvert.DeserializeObject(json);

            List<string> iller = new List<string>();
            List<decimal> siddetler = new List<decimal>();
            List<dynamic> tarihler = new List<dynamic>();

            int count = data.result.Count;
            for (int i = 0; i < count; i++)
            {
                if (i < data.result.Count)
                {
                    deprem.Il = data.result[i].title;
                    deprem.Siddet = data.result[i].mag;
                    deprem.Tarih = data.result[i].date;

                    if (deprem.Il.Contains("ADIYAMAN") && (deprem.Siddet > 2.0m))
                    {
                        iller.Add(deprem.Il);
                        siddetler.Add(deprem.Siddet);
                        tarihler.Add(deprem.Tarih);
                    }
                }
                ViewBag.IlAdiyaman = iller;
                ViewBag.SiddetAdiyaman = siddetler;
                ViewBag.TarihAdiyaman = tarihler;

            }
            return View();

        }

        public async Task<IActionResult> Antep(Deprem deprem)
        {
            string url = "https://api.orhanaydogdu.com.tr/deprem/kandilli/live";

            HttpClient client = new HttpClient();

            HttpResponseMessage cevap = await client.GetAsync(url);


            string? json = await cevap.Content.ReadAsStringAsync();

            dynamic? data = JsonConvert.DeserializeObject(json);

            List<string> iller = new List<string>();
            List<decimal> siddetler = new List<decimal>();
            List<dynamic> tarihler = new List<dynamic>();

            int count = data.result.Count;
            for (int i = 0; i < count; i++)
            {
                if (i < data.result.Count)
                {
                    deprem.Il = data.result[i].title;
                    deprem.Siddet = data.result[i].mag;
                    deprem.Tarih = data.result[i].date;

                    if (deprem.Il.Contains("GAZIANTEP") && (deprem.Siddet > 2.0m))
                    {
                        iller.Add(deprem.Il);
                        siddetler.Add(deprem.Siddet);
                        tarihler.Add(deprem.Tarih);
                    }
                }
                ViewBag.IlAntep = iller;
                ViewBag.SiddetAntep = siddetler;
                ViewBag.TarihAntep = tarihler;

            }
            return View();

        }

        public async Task<IActionResult> Bingol(Deprem deprem)
        {
            string url = "https://api.orhanaydogdu.com.tr/deprem/kandilli/live";

            HttpClient client = new HttpClient();

            HttpResponseMessage cevap = await client.GetAsync(url);


            string? json = await cevap.Content.ReadAsStringAsync();

            dynamic? data = JsonConvert.DeserializeObject(json);

            List<string> iller = new List<string>();
            List<decimal> siddetler = new List<decimal>();
            List<dynamic> tarihler = new List<dynamic>();

            int count = data.result.Count;
            for (int i = 0; i < count; i++)
            {
                if (i < data.result.Count)
                {
                    deprem.Il = data.result[i].title;
                    deprem.Siddet = data.result[i].mag;
                    deprem.Tarih = data.result[i].date;

                    if (deprem.Il.Contains("BINGOL") && (deprem.Siddet > 2.0m))
                    {
                        iller.Add(deprem.Il);
                        siddetler.Add(deprem.Siddet);
                        tarihler.Add(deprem.Tarih);
                    }
                }
                ViewBag.IlBingol = iller;
                ViewBag.SiddetBingol = siddetler;
                ViewBag.TarihBingol = tarihler;

            }
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}