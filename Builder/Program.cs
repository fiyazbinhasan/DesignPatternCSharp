using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ISpecialBuilder mondaySpecial = new MondaySpecialBuilder();

            Diner diner = new Diner(mondaySpecial);
            diner.OrderSpecial();
            var meal = diner.Serve();

            Console.WriteLine($"Appetizer: {meal.Appetizer.Name}");
            Console.WriteLine($"Main course: {meal.MainCourse.Name}");
            Console.WriteLine($"Dessert: {meal.Dessert.Name}");
            Console.WriteLine($"Drink: {meal.Drink.Name}");

            Console.WriteLine("--------------");

            Console.WriteLine($"Meal price ${meal.MealPrice()}");

            Console.ReadLine();
        }
    }
}
