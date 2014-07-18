namespace School
{
    using System;
    using System.Collections.Generic;

    public class Student : Person
    {
        public Student(string name)
            : base(name)
        {
            this.Name = name;
        }

        public Student(string name, long id)
            : base(name)
        {
            this.Id = id;
        }

        public Student(string name, string comments, long id)
            : base(name, comments)
        {
            this.Id = id;
        }

        public long Id { get; set; }
    }
}
