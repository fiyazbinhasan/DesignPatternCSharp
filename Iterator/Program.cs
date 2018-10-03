using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            CartItem[] items = {
                new CartItem { 
                    Product = new Product { 
                        Id =1, 
                        Title = "Book", 
                        UnitPrice= 19.99M
                    }, 
                    Quantity = 2
                },
                new CartItem { 
                    Product = new Product { 
                        Id = 2, 
                        Title = "Laptop",
                        UnitPrice = 199.99M
                    },
                    Quantity = 3
                }
            };

            ShoppingCart shoppingCart = new ShoppingCart(items);
            var iterator = shoppingCart.GetIterator();

            Console.WriteLine($"Title\tQuantity\tTotal");
            Console.WriteLine("==============================");

            while (iterator.MoveNext())
            {
                var currentItem = (CartItem) iterator.Current;
                Console.WriteLine($"{currentItem.Product.Title}\t{currentItem.Quantity}\t\t{currentItem.Total}");
            }

            Console.WriteLine("==============================");
            Console.WriteLine($"Net Total:\t\t{shoppingCart.Total()}");
            Console.ReadLine();
        }
    }
}
