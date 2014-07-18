namespace School
{
    using System;
    using System.Collections.Generic;

    public abstract class Person : School
    {
        public Person(string name)
            : base(name)
        {
            this.Name = name;
        }

        public Person(string name, string comments)
            : base(name, comments)
        {
            this.Comments = comments;
        }
    }
}
