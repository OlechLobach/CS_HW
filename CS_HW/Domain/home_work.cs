namespace Domain
{
    public class Website
    {
        private string name;
        private string path;
        private string description;
        private string ipAddress;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPath(string path)
        {
            this.path = path;
        }

        public string GetPath()
        {
            return path;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetIpAddress(string ipAddress)
        {
            this.ipAddress = ipAddress;
        }

        public string GetIpAddress()
        {
            return ipAddress;
        }

        public void PrintWebsiteInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Path: {path}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"IP Address: {ipAddress}");
        }
    }
}