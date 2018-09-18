using System;
namespace Builder
{
    public class SundaySpecialBuilder : ISpecialBuilder
    {
        private Meal _meal = new Meal();

        public void Appetizer()
        {
            _meal.Appetizer = new Food
            {
                Name = "Garlic Tomato Bruschetta",
                Price = 5
            };
        }

        public void MainCourse()
        {
            _meal.MainCourse = new Food
            {
                Name = "Chicken and Asparagus Skillet Supper",
                Price = 25
            };
        }

        public void Dessert()
        {
            _meal.Dessert = new Food
            {
                Name = "Cinnamon Coffee Cake",
                Price = 6
            };
        }

        public void Drink()
        {
            _meal.Drink = new Food
            {
                Name = "Lemonade",
                Price = 9
            };
        }

        public Meal GetMeal()
        {
            return _meal;
        }
    }
}
