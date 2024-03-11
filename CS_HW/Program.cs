using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            Domain.Journal journal = new Domain.Journal();
            journal.SetName("Example Journal");
            journal.SetYearFounded(1990);
            journal.SetDescription("This is an example journal.");
            journal.SetContactPhone("123-456-7890");
            journal.SetEmail("example@example.com");

            journal.PrintJournalInfo();
        }
    }
}