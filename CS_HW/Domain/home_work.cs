using System;

namespace Domain
{
    public class City
    {
        private string cityName;
        private string countryName;
        private int population;
        private int areaCode;
        private string[] districts;

        public City(string cityName, string countryName, int population, int areaCode, string[] districts)
        {
            this.cityName = cityName;
            this.countryName = countryName;
            this.population = population;
            this.areaCode = areaCode;
            this.districts = districts;
        }

        public void DisplayCityInformation()
        {
            Console.WriteLine("City: " + cityName);
            Console.WriteLine("Country: " + countryName);
            Console.WriteLine("Population: " + population);
            Console.WriteLine("Area Code: " + areaCode);
            Console.WriteLine("Districts:");

            foreach (string district in districts)
            {
                Console.WriteLine("- " + district);
            }
        }
    }
}