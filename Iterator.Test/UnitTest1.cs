using System;
using Xunit;

namespace Iterator.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
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

            Assert.IsAssignableFrom<IIterator>(shoppingCart.GetIterator());
            Assert.IsType<ShoppingCartIterator>(shoppingCart.GetIterator());
        }
    }
}
