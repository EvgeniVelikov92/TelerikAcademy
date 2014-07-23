namespace Animal
{
    using System;
    using System.Collections.Generic;

    public class Cat : Animal
    {
        private const int numberOfLegs = 4;

        public override string Greet()
        {
            return "Mqu!";
        }

        public void Sleep()
        {
            Console.WriteLine("Mrr!");
        }

        public override int GetNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
