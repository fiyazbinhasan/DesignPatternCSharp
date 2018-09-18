using System.Collections.Generic;

namespace Builder
{
    public class Meal
    {
        public Food Appetizer { get; set; }
        public Food MainCourse { get; set; }
        public Food Dessert { get; set; }
        public Food Drink { get; set; }

        public decimal MealPrice()
        {
            return Appetizer.Price + MainCourse.Price + Dessert.Price + Drink.Price;
        }
    }

    public class Food
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}