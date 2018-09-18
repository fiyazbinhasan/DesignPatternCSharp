using System;
namespace Prototype
{
    public class Couple
    {
        public Person Husband{ get; set; }
        public Person Wife { get; set; }
        public Address Address { get; set; }
        public Person WhoMovedIn { get; private set; }

        public void PersonMovedIn(Person person)
        {
            WhoMovedIn = person;

            Console.WriteLine($"{person.Name} moved in");
        }
    }
}
