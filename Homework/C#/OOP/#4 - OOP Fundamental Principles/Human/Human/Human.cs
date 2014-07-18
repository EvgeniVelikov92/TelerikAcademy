namespace Human
{
    using System;
    using System.Collections.Generic;

    public abstract class Human
    {
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return "Name: " + this.FirstName + " " + this.LastName;
        }
    }
}
