using System;
using Xunit;

namespace Builder.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ISpecialBuilder mondaySpecial = new MondaySpecialBuilder();

            Diner director = new Diner(mondaySpecial);
            director.OrderSpecial();
            var meal = director.Serve();

            Assert.Equal(29, meal.MealPrice());
        }
    }
}
