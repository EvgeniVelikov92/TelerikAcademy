namespace Animal
{
    using System;
    using System.Collections.Generic;

    public class InvalidAnimalNameException : ApplicationException
    {
        public string ErrorName { get; set; }



        public InvalidAnimalNameException(string msg)
            : base(msg)
        {

        }

        public InvalidAnimalNameException(string msg, string value)
            : base(msg)
        {
            this.ErrorName = value;
        }

        public override string Message
        {
            get
            {
                return base.Message + ": " + this.ErrorName;
            }
        }
    }
}
