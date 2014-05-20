// A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

namespace MarketingFirm
{
    class MarketingFirm
    {
        static void Main()
        {
            string firstName, lastName;
            byte age;
            int id;
            char gender;

            Console.Write(" Please enter your First Name:   ");
            firstName = Console.ReadLine();

            Console.Write(" Please enter your Last Name:    ");
            lastName = Console.ReadLine();

            Console.Write(" Please enter your Age:          ");
            age = byte.Parse(Console.ReadLine());

            Console.Write(" Please enter your ID Number:    ");
            id = int.Parse(Console.ReadLine());

            Console.Write(" Please enter your Gender (m/f): ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(" The Person: {0} {1}\n", firstName, lastName);
            Console.WriteLine(" He is {0} years old\n", age);
            Console.WriteLine(" Whit ID: {0}\n", id);

            if (gender == 'm' || gender == 'M')
            {
                Console.WriteLine(" Your gender is: Male");
            }
            else if (gender == 'f' || gender == 'F')
            {
                Console.WriteLine(" Your gender is: Female");
            }
            Console.WriteLine();
        }
    }
}
