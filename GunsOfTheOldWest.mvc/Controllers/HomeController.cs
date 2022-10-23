using GunsOfTheOldWest.mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GunsOfTheOldWest.mvc.Controllers
{
    public class HomeController : Controller
    {
        private Kogels kogels;
        
        
        public HomeController(Kogels kogel)
        {
            kogels = kogel;
            
        }
        
   
        public IActionResult Index()
        {
           
            return View(kogels);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Versturen(string voornaam, string naam, string email, string telefoon)
        {
            kogels.Reset();

            var speler = new Speler(voornaam, naam, email, telefoon);
            return View("Samenvatting", speler);
        }
        
        public IActionResult Schiet()
        {
            if (kogels.aantalKogels > 0)
            {
                if (Random() < 4)
                {
                    return View("Winnaar");
                }
                else
                {
                    kogels.Schiet();
                    return View("Index", kogels);
                }
            }
            else
            {
                return View("Kopen");
            }
            
            
        }
       
        public IActionResult Kopen(int aantal)
        {
            kogels.Kopen(aantal);
            return View("Index", kogels);
        }




        public int Random()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 10);
            return randomNumber;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}