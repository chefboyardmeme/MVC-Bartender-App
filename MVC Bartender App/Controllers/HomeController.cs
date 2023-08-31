using Microsoft.AspNetCore.Mvc;
using MVC_Bartender_App.Models;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;

namespace MVC_Bartender_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        //ordered drink id
        private static int id = 0;
        //List of Ordered Drinks
        public static List<Drink> OrderList = new List<Drink>();
        //Menu List
        private static List<Drink> Menu = new List<Drink>()
        {
            new Drink{Name = "North Cali Mojito", Description = "Sauvignon Blanc, Gin, Ginger Liquor, Pineapple Juice, Cucumber & Basil", Price=12},
            new Drink{Name ="Pirate Jack", Description = "Honey Jack, Vanilla Absolute, Bailey's and Rum Raisin ", Price = 12.5},
            new Drink{Name ="Boozy Creamsicle", Description = "Skyy Vodka, Orange Cream Soda, Vanilla Ice Cream, Orange Puree", Price = 14.5},
            new Drink{Name ="Pina Colada Royale", Description = "Malibu & White Rum, Pineapple, Coconut Milk, Creme de Cacao, Vanilla Bean", Price = 12.5},
            new Drink{Name ="Caliente Margarita", Description = "Jalapeno El Jimador, Cilantro Triple Sec, Lime Sour, Agave Nectar", Price = 13},
            new Drink{Name ="Presidente Margarita", Description = "Avion Silver, St. Germain, Grand Marnier, Lime Juice, Agave Nectar", Price = 16},
            new Drink{Name ="Big Island Punch", Description = "Southern Comfort, Dragonberry Bacardi, Mango, Lemon & Lime", Price = 13},
            new Drink{Name ="Camaro Red Sangria", Description ="Blackberry & Cherry Infused Vodka Merlot, Fresh Fruits", Price = 12.5}
        };
        


        public IActionResult Index()
        {
            return View(Menu);
        }

        public ActionResult Order(Drink drink)
        { 
            drink.Id = id++;
            OrderList.Add(drink);
            return RedirectToAction("Index");
        }

        public IActionResult OrderQueue()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}