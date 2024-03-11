namespace Domain
{
    public class Shop
    {
        private string name;
        private string address;
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

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public string GetAddress()
        {
            return address;
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

        public void PrintShopInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Contact Phone: {contactPhone}");
            Console.WriteLine($"Email: {email}");
        }
    }
}