using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Builder
{
    public interface ISpecialBuilder
    {
        void Appetizer();
        void MainCourse();
        void Dessert();
        void Drink();
        Meal GetMeal();
    }
}