using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext DbContext;
        public HomeController(MyContext context){
            DbContext=context;
        }
        public IActionResult Index()
        {
            List<Chef> allChefs = DbContext.Chefs
            .Include(dish => dish.CreatedDishes)
            .ToList();
            return View(allChefs);
        }

        [HttpGet("new")]
        public IActionResult Add()
        {
            return View();
        }
        
        [HttpPost("chef/new")]
        public IActionResult AddingChef(Chef newChef){
            if(ModelState.IsValid){
                DbContext.Add(newChef);
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Add");
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> allDishes = DbContext.Dishes
            .Include(chef => chef.Creator)
            .OrderBy(first => first.CreatedAt)
            .ToList();
            return View(allDishes);
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            ViewBag.allChefs = DbContext.Chefs
            .ToList();
            return View();
        }

        [HttpPost("dishes/new/add")]
        public IActionResult AddingDish(Dish newDish){
            if(ModelState.IsValid){
                DbContext.Add(newDish);
                DbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            return RedirectToAction("NewDish");
        }





        public IActionResult Privacy()
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
