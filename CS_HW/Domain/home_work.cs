using System;

namespace Domain
{
    public class Airplane
    {
        private string airplaneName;
        private string manufacturer;
        private int yearOfManufacture;
        private string airplaneType;

        public Airplane(string airplaneName, string manufacturer, int yearOfManufacture, string airplaneType)
        {
            this.airplaneName = airplaneName;
            this.manufacturer = manufacturer;
            this.yearOfManufacture = yearOfManufacture;
            this.airplaneType = airplaneType;
        }

        public string GetAirplaneName()
        {
            return airplaneName;
        }

        public void SetAirplaneName(string value)
        {
            airplaneName = value;
        }

        public string GetManufacturer()
        {
            return manufacturer;
        }

        public void SetManufacturer(string value)
        {
            manufacturer = value;
        }

        public int GetYearOfManufacture()
        {
            return yearOfManufacture;
        }

        public void SetYearOfManufacture(int value)
        {
            yearOfManufacture = value;
        }

        public string GetAirplaneType()
        {
            return airplaneType;
        }

        public void SetAirplaneType(string value)
        {
            airplaneType = value;
        }

        public void DisplayAirplaneInformation()
        {
            Console.WriteLine("Airplane Name: " + airplaneName);
            Console.WriteLine("Manufacturer: " + manufacturer);
            Console.WriteLine("Year of Manufacture: " + yearOfManufacture);
            Console.WriteLine("Airplane Type: " + airplaneType);
        }
    }
}