using System;
namespace Builder
{
    public class Diner
    {
        private ISpecialBuilder _specialBuilder;

        public Diner(ISpecialBuilder specialBuilder)
        {
            _specialBuilder = specialBuilder;
        }

        public Meal Serve()
        {
            return _specialBuilder.GetMeal();
        }

        public void OrderSpecial()
        {
            _specialBuilder.Appetizer();
            _specialBuilder.MainCourse();
            _specialBuilder.Dessert();
            _specialBuilder.Drink();
        }
    }
}
