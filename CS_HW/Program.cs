using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            Airplane airplane = new Airplane("Boeing 747", "Boeing", 1989, "Passenger");

            airplane.DisplayAirplaneInformation();
        }
    }
}