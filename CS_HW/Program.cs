using System;
using Domain;
namespace MainProject
{
    class Program
    {
        static void Main()
        {
            Website website = new Website();
            website.SetName("Example Website");
            website.SetPath("/example");
            website.SetDescription("This is an example website.");
            website.SetIpAddress("192.168.1.1");

            website.PrintWebsiteInfo();
        }
    }
}