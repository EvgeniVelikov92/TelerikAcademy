namespace Animal
{
    using System;
    using System.Collections.Generic;

    public abstract class Animal
    {
        private string name;

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidAnimalNameException("Name cannot null or empty");
                }

                if (value.Length < 6)
                {
                    throw new InvalidAnimalNameException("Name is too short", value);
                }

                this.name = value;
            }
        }

        public virtual string Greet()
        {
            return "I am an animal";
        }

        public override string ToString()
        {
            return this.GetType().Name + ": " + this.Name + " " + this.GetNumberOfLegs();
        }

        public abstract int GetNumberOfLegs();
    }
}
