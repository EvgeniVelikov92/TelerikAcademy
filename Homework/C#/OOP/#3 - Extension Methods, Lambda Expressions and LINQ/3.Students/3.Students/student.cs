namespace Students
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return "Name: " + this.FirstName + " " + this.LastName + " FN: " + this.FN + " Group: " + this.GroupNumber + " Age: " + this.Age;
        }
    }
}
