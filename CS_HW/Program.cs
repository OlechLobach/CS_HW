using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            string[] districts = { "District1", "District2", "District3" };
            City city = new City("CityName", "CountryName", 1000000, 12345, districts);

            city.DisplayCityInformation();
        }
    }
}