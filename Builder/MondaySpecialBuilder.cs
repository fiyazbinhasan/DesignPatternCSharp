using System;
namespace Builder
{
    public class MondaySpecialBuilder : ISpecialBuilder
    {
        private Meal _meal = new Meal();

        public void Appetizer()
        {
            _meal.Appetizer = new Food 
            { 
                Name = "Swiss Cheese Bread", 
                Price = 5 
            };
        }

        public void MainCourse()
        {
            _meal.MainCourse = new Food 
            { 
                Name = "Luau BBQ Chicken Foil Packs", 
                Price = 15
            };
        }

        public void Dessert()
        {
            _meal.Dessert = new Food
            {
                Name = "Banana Cream Pie",
                Price = 7
            };
        }

        public void Drink()
        {
            _meal.Drink = new Food
            {
                Name = "Ice Lemon Tea",
                Price = 2
            };
        }

        public Meal GetMeal()
        {
            return _meal;
        }
    }
}
