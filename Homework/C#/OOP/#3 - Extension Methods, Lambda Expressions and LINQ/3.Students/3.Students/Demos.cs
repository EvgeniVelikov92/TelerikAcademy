namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Demos
    {
        public static void PrintConsole(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void Main()
        {
            var students = new List<Student>
            {
                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Georgiev",
                    FN = 11011001,
                    Tel = "0876543212",
                    Email = "ivangeorgiev@abv.bg",
                    Marks = new List<int> { 4, 5, 6, 4, 6, 3 },
                    GroupNumber = 1,
                    Age = 25
                },
                new Student
                {
                    FirstName = "Stanislava",
                    LastName = "Krasteva",
                    FN = 11011002,
                    Tel = "0873544532",
                    Email = "stanislavakrasteva@gmail.bg",
                    Marks = new List<int> { 2, 6, 6, 6, 4, 5 },
                    GroupNumber = 1,
                    Age = 28
                },
                new Student
                {
                    FirstName = "Georgi",
                    LastName = "Marinov",
                    FN = 11011003,
                    Tel = "0886425892",
                    Email = "georgimarinov@yahoo.bg",
                    Marks = new List<int> { 2, 2, 3, 2, 2, 6 },
                    GroupNumber = 2,
                    Age = 20
                },
                new Student
                {
                    FirstName = "Gergana",
                    LastName = "Hristova",
                    FN = 11011004,
                    Tel = "0886567623",
                    Email = "gerganahristova@yahoo.bg",
                    Marks = new List<int> { 5, 5, 6, 6, 6, 6 },
                    GroupNumber = 2,
                    Age = 19
                },
                new Student
                {
                    FirstName = "Mustafa",
                    LastName = "Yalzaranov",
                    FN = 11011005,
                    Tel = "0886342214",
                    Email = "mustafayalzaranov@gmail.bg",
                    Marks = new List<int> { 4, 2, 4, 2, 2, 3 },
                    GroupNumber = 1,
                    Age = 15
                },
                new Student
                {
                    FirstName = "Malin",
                    LastName = "Vihrenov",
                    FN = 11011006,
                    Tel = "0893458720",
                    Email = "malinvihrenovv@gmail.bg",
                    Marks = new List<int> { 2, 5, 4, 6, 2, 2 },
                    GroupNumber = 1,
                    Age = 23
                },
                new Student
                {
                    FirstName = "Bogomila",
                    LastName = "Yordanova",
                    FN = 11011007,
                    Tel = "0885236892",
                    Email = "bogomilayordanova@abv.bg",
                    Marks = new List<int> { 6, 5, 4, 3, 3, 6 },
                    GroupNumber = 2,
                    Age = 28
                },
                new Student
                {
                    FirstName = "Bogomila",
                    LastName = "Dimitrova",
                    FN = 11011008,
                    Tel = "0898765023",
                    Email = "bogomiladimitrova@abv.bg",
                    Marks = new List<int> { 4, 4, 4, 3, 6, 5 },
                    GroupNumber = 1,
                    Age = 22
                },
                new Student
                {
                    FirstName = "Viktor",
                    LastName = "Mihaylov",
                    FN = 11011009,
                    Tel = "0886346724",
                    Email = "viktormihaylov@abv.bg",
                    Marks = new List<int> { 3, 2, 3, 3, 4, 3 },
                    GroupNumber = 1,
                    Age = 30
                },
                new Student
                {
                    FirstName = "Plamena",
                    LastName = "Dimitrova",
                    FN = 11011010,
                    Tel = "0888569966",
                    Email = "plamenadimitrova@gmail.bg",
                    Marks = new List<int> { 3, 3, 6, 6, 6, 3 },
                    GroupNumber = 2,
                    Age = 24
                }
            };

            // Finds the first name and last name of all students with age between 18 and 24.
            Console.WriteLine("Finds the first name and last name of all students with age between 18 and 24");
            var findStudentsBetwenAges = students.Where(st => st.Age >= 18 && st.Age <= 24);
            PrintConsole(findStudentsBetwenAges);

            Console.WriteLine();

            //Sort the students by first name and last name in descending order.
            Console.WriteLine("Sort the students by first name and last name in descending order.");
            var sortByFirstAndLastName = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);
            PrintConsole(sortByFirstAndLastName);

            Console.WriteLine();

            // Select only the students that are from group number 2 OrderBy First Name
            Console.WriteLine("Select only the students that are from group number 2");
            var selectStudentsTwo = students
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName);
            PrintConsole(selectStudentsTwo);

            Console.WriteLine();

            // Extract all students that have email in abv.bg. Use string methods and LINQ.
            Console.WriteLine("Extract all students that have email in abv.bg");
            var abvEmailStudents = students.Where(st => st.Email.EndsWith("abv.bg"));
            PrintConsole(abvEmailStudents);

            Console.WriteLine();

            // Extract all students with phones on Mtel. Use LINQ.
            Console.WriteLine("Extract all students with phones on Mtel.");
            var mtelPhoneStudents = students.Where(st => st.Tel.StartsWith("088"));
            PrintConsole(mtelPhoneStudents);

            Console.WriteLine();

            // Extracts all students grouped by GroupName and then prints them to the console. Use LINQ.
            Console.WriteLine("Extracts all students grouped by GroupName 1");
            var firstGroupStudents = students.Where(st => st.GroupNumber == 1);
            PrintConsole(firstGroupStudents);

            Console.WriteLine();

            Console.WriteLine("Extracts all students grouped by GroupName 2");
            var secondGroupStudents = students.Where(st => st.GroupNumber == 2);
            PrintConsole(secondGroupStudents);
        }
    }
}
