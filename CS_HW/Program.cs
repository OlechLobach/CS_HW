using System;
using Domain;
namespace MainProject
{
    class Program
    {
        static void Main()
        {
            Domain.Shop shop = new Domain.Shop();
            shop.SetName("Example Shop");
            shop.SetAddress("123 Main St");
            shop.SetDescription("This is an example shop.");
            shop.SetContactPhone("123-456-7890");
            shop.SetEmail("example@example.com");

            shop.PrintShopInfo();
        }
    }
}