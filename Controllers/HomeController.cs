using Sheet4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            //sandwich types
            List<SelectListItem> sandwichTypesList = new List<SelectListItem>();
            sandwichTypesList.Add(new SelectListItem { Text = "TheMichaelJackson", Value = "TheMichaelJackson" });
            sandwichTypesList.Add(new SelectListItem { Text = "ThePrince", Value = "ThePrince" });
            sandwichTypesList.Add(new SelectListItem { Text = "TheBackstreetBoys", Value = "TheBackstreetBoys" });
            sandwichTypesList.Add(new SelectListItem { Text = "TheBeyonce", Value = "TheBeyonce" });

            //sandwich sizes
            List<SelectListItem> sizeTypesList = new List<SelectListItem>();
            sizeTypesList.Add(new SelectListItem { Text = "oneHitWonder", Value = "oneHitWonder" });
            sizeTypesList.Add(new SelectListItem { Text = "blist", Value = "blist" });
            sizeTypesList.Add(new SelectListItem { Text = "alist", Value = "alist" });
            sizeTypesList.Add(new SelectListItem { Text = "superstar", Value = "superstar" });

            var model = new Sandwich
            {
                SandwichTypes = sandwichTypesList,
                SizeTypes = sizeTypesList,
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Sandwich s)
        {
            
            //its bad but it works
            //types
            if (s.SandwichChosen.Equals("TheMichaelJackson"))
            {
                s.TypePrice = 6;
            }
            else if (s.SandwichChosen.Equals("ThePrince")) {
                s.TypePrice = 8;
            }
            else if (s.SandwichChosen.Equals("TheBackstreetBoys"))
            {
                s.TypePrice = 9;
            }
            else if (s.SandwichChosen.Equals("TheBeyonce"))
            {
                s.TypePrice = 10;
            }

            //debug line: double price = s.TypePrice;

            //sizes
            if (s.SizeChosen.Equals("oneHitWonder"))
            {
                s.SizePrice = 1;
            }
            else if (s.SizeChosen.Equals("blist"))
            {
                s.SizePrice = 1.1;
            }
            else if(s.SizeChosen.Equals("alist"))
            {
                s.SizePrice = 1.2;
            }
            else if (s.SizeChosen.Equals("superstar"))
            {
                s.SizePrice = 1.3;
            }

            //meal deal
            if (s.MealDealChosen.Equals("None"))
            {
                s.MealPrice = 0;
            }
            else if (s.MealDealChosen.Equals("Drink and Chips"))
            {
                s.MealPrice = 3;
            }
            else if (s.MealDealChosen.Equals("Drink and Cookies"))
            {
                s.MealPrice = 4;
            }


            //create Viewbags
            //text
            ViewBag.Sandwich = s.SandwichChosen;
            ViewBag.Size = s.SizeChosen;
            ViewBag.Meal = s.MealDealChosen;

            //prices
            ViewBag.SandwichPrice = s.getSandwichCost();
            ViewBag.MealPrice = s.MealPrice;
            ViewBag.Cost = s.getCost();
            ViewBag.Tax = s.getTax();
            ViewBag.TotalCost = s.getTotalCost();

            return View("Receipt");
        }
    }
}