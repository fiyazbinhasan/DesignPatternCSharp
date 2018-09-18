using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Person husband = new Person
            {
                Name = "Jon Doe",
                Address = new Address
                {
                    FlatNo = "12/3",
                    StreetNo = "456 Main Street",
                    City = "New York",
                    Country = "USA"
                }
            };

            Person wife = new Person
            {
                Name = "Jane Doe",
                Address = new Address
                {
                    FlatNo = "7/89",
                    StreetNo = "101 Secondary Street",
                    City = "Toronto",
                    Country = "Cannada"
                }
            };

            Couple couple = new Couple
            {
                Husband = husband,
                Wife = wife
            };

            Console.WriteLine($"{husband.Name} Address: {husband.Address}");
            Console.WriteLine($"{wife.Name} Address: {wife.Address}");

            Console.WriteLine($"===================================");
            couple.PersonMovedIn(wife);
            Console.WriteLine($"===================================");

            switch (couple.WhoMovedIn.Name)
            {
                case "Jon Doe":
                    couple.Address = (Address)wife.Address.Clone();
                    break;
                case "Jane Doe":
                    couple.Address = (Address)husband.Address.Clone();
                    break;
            }

            Console.WriteLine($"{couple.Husband.Name} & {couple.Wife.Name} Address : {couple.Address}");

            Console.ReadLine();
        }
    }
}
