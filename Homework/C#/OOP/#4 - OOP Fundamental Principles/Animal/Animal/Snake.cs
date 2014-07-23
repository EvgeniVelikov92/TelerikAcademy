namespace Animal
{
    using System;
    using System.Collections.Generic;

    public class Snake : Animal
    {
        private const int numberOfLegs = 0;

        public override int GetNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
