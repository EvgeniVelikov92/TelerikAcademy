namespace Animal
{
    using System;
    using System.Collections.Generic;

    public class Dog : Animal
    {
        private const int numberOfLegs = 4;

        public override string Greet()
        {
            return base.Greet() + " Djav!";
        }

        public void Run()
        {
            Console.WriteLine("I am running");
        }

        public override int GetNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
