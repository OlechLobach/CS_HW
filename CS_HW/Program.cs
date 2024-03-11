using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            DateTime dob = new DateTime(1990, 1, 1);
            Employee employee = new Employee("John Doe", dob, "123-456-7890", "john.doe@example.com", "Manager", "Manage daily operations");

            employee.DisplayEmployeeInformation();
        }
    }
}