namespace Human
{
    using System;
    using System.Collections.Generic;

    public class Student : Human
    {
        private List<int> grade;

        public Student();

        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, List<int> grade)
            : this(firstName, lastName)
        {
            this.Grade = grade;
        }

        public List<int> Grade { get; set; }
    }
}
