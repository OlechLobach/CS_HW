using System;

namespace Domain
{
    public class Employee
    {
        private string fullName;
        private DateTime dateOfBirth;
        private string contactNumber;
        private string workEmail;
        private string position;
        private string jobDescription;

        public Employee(string fullName, DateTime dateOfBirth, string contactNumber, string workEmail, string position, string jobDescription)
        {
            this.fullName = fullName;
            this.dateOfBirth = dateOfBirth;
            this.contactNumber = contactNumber;
            this.workEmail = workEmail;
            this.position = position;
            this.jobDescription = jobDescription;
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public string WorkEmail
        {
            get { return workEmail; }
            set { workEmail = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }

        public void DisplayEmployeeInformation()
        {
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Date of Birth: " + dateOfBirth.ToShortDateString());
            Console.WriteLine("Contact Number: " + contactNumber);
            Console.WriteLine("Work Email: " + workEmail);
            Console.WriteLine("Position: " + position);
            Console.WriteLine("Job Description: " + jobDescription);
        }
    }
}