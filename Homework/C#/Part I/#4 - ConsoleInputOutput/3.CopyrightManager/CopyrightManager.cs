// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

using System;

namespace CopyrightManager
{
    class CopyrightManager
    {
        static void Main()
        {
            Console.Write("FIRM NAME: ");
            string firmName = Console.ReadLine();

            Console.Write("FIRM ADDRESS: ");
            string firmAddress = Console.ReadLine();

            Console.Write("FIRM PHONE: ");
            long firmPhone = long.Parse(Console.ReadLine());

            Console.Write("FIRM FAX: ");
            long firmFax = long.Parse(Console.ReadLine());

            Console.Write("FIRM SITE: ");
            string firmSite = Console.ReadLine();

            string firmManager;

            Console.Write("GENERAL MANAGER FIRST NAME: ");
            string manName = Console.ReadLine();

            Console.Write("GENERAL MANAGER LAST NAME: ");
            string manFamily = Console.ReadLine();

            Console.Write("GENERAL MANAGER PHONE NUMBER: ");
            long manPhone = long.Parse(Console.ReadLine());
            
            firmManager = manName + " " + manFamily;
            
            Console.WriteLine("---------------Copyright Information---------------");
            Console.WriteLine("The firm: {0}, in location: {1}, a phone number: {2}, a fax number: {3}, a web site: {4} and General Manager: {5}", firmName, firmAddress, firmPhone, firmFax, firmSite, firmManager);

            Console.WriteLine("\n----------------Manager Information----------------");
            Console.WriteLine("The General Manager: {0} {1}, a phone number: {2}\n", manName, manFamily, manPhone);
        }
    }
}
