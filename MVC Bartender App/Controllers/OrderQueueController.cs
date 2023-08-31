using Microsoft.AspNetCore.Mvc;
using MVC_Bartender_App.Models;

namespace MVC_Bartender_App.Controllers
{
    public class OrderQueueController : Controller
    {
        //List that holds ordered drinks
        private static List<Drink> ReadyToServe = new List<Drink>();

        //function to call view
        public ActionResult OrderQueue()
        {
            return View(HomeController.OrderList);
        }

        //Add drink to queue
        public ActionResult AddToQueue(Drink drink)
        {
            ReadyToServe.Add(drink);
            var drinkToRemove = HomeController.OrderList.Where(x => x.Id == drink.Id); // x rep an object in Orders            
            HomeController.OrderList.Remove(drinkToRemove.FirstOrDefault());
            ReadyToServe.RemoveAll(x => x.Id == drink.Id);
            return RedirectToAction("OrderQueue");
        }
    }
}

