namespace Domain
{
    public class Journal
    {
        private string name;
        private int yearFounded;
        private string description;
        private string contactPhone;
        private string email;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetYearFounded(int year)
        {
            yearFounded = year;
        }

        public int GetYearFounded()
        {
            return yearFounded;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetContactPhone(string phone)
        {
            contactPhone = phone;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return email;
        }

        public void PrintJournalInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Year Founded: {yearFounded}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Contact Phone: {contactPhone}");
            Console.WriteLine($"Email: {email}");
        }
    }
}