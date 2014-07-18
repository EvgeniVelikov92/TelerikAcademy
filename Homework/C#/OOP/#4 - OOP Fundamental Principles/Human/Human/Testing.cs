namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Testing
    {
        static void Main()
        {
            // Testing Worker
            Worker ivanIvanov = new Worker("Ivan", "Ivanov");
            double ivanIvanovWeekSalary =  ivanIvanov.WeekSalary;
            double ivanIvanovWorkHoursPerDay = ivanIvanov.WeekSalary;
            ivanIvanovWeekSalary = 500;
            ivanIvanovWorkHoursPerDay = 8;

            ivanIvanov.MoneyPerHour(400, 6);
            Console.Write(ivanIvanov + " ");
            Console.WriteLine("{0:C2}", ivanIvanov.MoneyPerHour(ivanIvanovWeekSalary, ivanIvanovWorkHoursPerDay));

            var worker = new List<Worker>
            {
                new Worker
                {
                    FirstName = "Georgi",
                    LastName = "Georgiev",
                    PerHour = 8.88
                },
                new Worker
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    PerHour = 8.38
                },
                new Worker
                {
                    FirstName = "Plamen",
                    LastName = "Plamenov",
                    PerHour = 7
                },
                new Worker
                {
                    FirstName = "Petar",
                    LastName = "Petrov",
                    PerHour = 7.38
                },
                new Worker
                {
                    FirstName = "Gergana",
                    LastName = "Ivanova",
                    PerHour = 7.98
                },
                new Worker
                {
                    FirstName = "Maya",
                    LastName = "Dimitrova",
                    PerHour = 12.36
                },
                new Worker
                {
                    FirstName = "Hristina",
                    LastName = "Miroslavova",
                    PerHour = 5.73
                },
                new Worker
                {
                    FirstName = "Ashley",
                    LastName = "Dobreva",
                    PerHour = 9.96
                },
                new Worker
                {
                    FirstName = "Miroslav",
                    LastName = "Dimitrov",
                    PerHour = 3.64
                },
                new Worker
                {
                    FirstName = "Maria",
                    LastName = "Ilieva",
                    PerHour = 6.97
                },

            };
            
            // Testing Student
            var students = new List<Student>
            {
                new Student
                {
                    FirstName = "Georgi",
                    LastName = "Georgiev",
                    Grade = { 4, 5, 6, 3, 4 }
                },
                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Grade = { 5, 3, 5, 5, 6 }
                },
                new Student
                {
                    FirstName = "Plamen",
                    LastName = "Plamenov",
                    Grade = { 3, 6, 4, 5, 3 }
                },
                new Student
                {
                    FirstName = "Petar",
                    LastName = "Petrov",
                    Grade = { 5, 6, 5, 5, 6 }
                },
                new Student
                {
                    FirstName = "Gergana",
                    LastName = "Ivanova",
                    Grade = { 6, 4, 5, 6, 6 }
                },
                new Student
                {
                    FirstName = "Maya",
                    LastName = "Dimitrova",
                    Grade = { 6, 6, 6, 6, 6 }
                },
                new Student
                {
                    FirstName = "Hristina",
                    LastName = "Miroslavova",
                    Grade = { 5, 6, 3, 4, 4 }
                },
                new Student
                {
                    FirstName = "Ashley",
                    LastName = "Dobreva",
                    Grade = { 5, 6, 5, 6, 6 }
                },
                new Student
                {
                    FirstName = "Miroslav",
                    LastName = "Dimitrov",
                    Grade = { 3, 3, 4, 5, 3 }
                },
                new Student
                {
                    FirstName = "Maria",
                    LastName = "Ilieva",
                    Grade = { 5, 6, 6, 3, 6 }
                },
            };

            var sortGradeStudents = students.OrderBy(x => x.Grade);
            Console.WriteLine(sortGradeStudents);

            var sortMoneyWorker = worker.OrderByDescending(x => x.PerHour);
            Console.WriteLine(sortMoneyWorker);
        }
    }
}
