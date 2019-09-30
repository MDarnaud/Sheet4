using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet4.Models
{
    public class Sandwich
    {
        public string SandwichChosen { get; set; }
        public double TypePrice { get; set; }
        public IEnumerable<SelectListItem> SandwichTypes { get; set; }
        public string SizeChosen { get; set; }
        public double SizePrice { get; set; }
        public IEnumerable<SelectListItem> SizeTypes { get; set; }
        public double MealPrice { get; set; }
        public string MealDealChosen { get; set; }

        

        public double getCost() {
            double cost = (TypePrice * SizePrice) + MealPrice;
            return cost;
        }

        public double getSandwichCost()
        {
            double cost = (TypePrice * SizePrice);
            return cost;
        }

        public double getTax()
        {
            double tax = getCost() * 0.15;
            return tax;
        }

        public double getTotalCost() {
            double totalCost = getCost() + getTax();
            return totalCost;
        }




        /*public enum EnumSandwichTypes
        {
            TheMichaelJackson,
            ThePrince,
            TheBackstreetBoys,
            TheBeyonce
        }

        public enum EnumSandwichSizes
        {
            oneHitWonder,
            blist,
            alist,
            superstar
        }

        public enum EnumMealTypes
        {
            None,
            DrinkAndChips,
            DrinkAndCookies
        }*/



    }
}