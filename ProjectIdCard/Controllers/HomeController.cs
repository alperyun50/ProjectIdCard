using Microsoft.AspNetCore.Mvc;
using ProjectIdCard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectIdCard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public int Index3()
        {
            return 24;
        }

        public IActionResult Index5()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap(){ID=1, KitapAd="80 günde devri alem", Yazar="Jules Verne"},
                new Kitap(){ID=2, KitapAd="Cesur yeni dünya", Yazar="Aldous Huxley"},
                new Kitap(){ID=3, KitapAd="Ben Robot", Yazar="Isaac Asimov"}
            };

            return View(ktp);
        }
    }
}
