namespace Human
{
    using System;
    using System.Collections.Generic;

    public class Worker : Human
    {
        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Worker();

        public double WeekSalary { get; set; }

        public double WorkHoursPerDay { get; set; }

        public double PerHour { get; set; }

        public double MoneyPerHour(double weekSalary, double workHoursPerDay)
        {
            double moneyPerHour = (weekSalary / (7 * workHoursPerDay));

            return moneyPerHour;
        }
    }
}
