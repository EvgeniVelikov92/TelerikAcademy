namespace School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person
    {
        public Teacher(string name)
            : base(name)
        {
            this.Name = name;
        }

        public Teacher(string name, IEnumerable<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string name, IEnumerable<Discipline> disciplines, string comments)
            : base(name, comments)
        {
            this.Disciplines = disciplines;
        }

        public IEnumerable<Discipline> Disciplines { get; set; }
    }
}
