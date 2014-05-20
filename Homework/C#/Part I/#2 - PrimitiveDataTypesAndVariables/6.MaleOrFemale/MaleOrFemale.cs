// Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

using System;

namespace MaleOrFemale
{
    class MaleOrFemale
    {
        static void Main()
        {
            string gender;
            bool isMale = true;

            Console.Write("Please enter a your Gender: ");
            gender = Console.ReadLine();

            Console.WriteLine(gender + "    " + isMale);
        }
    }
}
