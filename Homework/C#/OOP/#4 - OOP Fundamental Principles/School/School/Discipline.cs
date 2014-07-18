namespace School
{
    using System;
    using System.Collections.Generic;

    public class Discipline : School
    {
        public Discipline(string name)
            : base(name)
        {
            this.Name = name;
        }

        public Discipline(string name, int numberOfLecture)
            : base(name)
        {
            this.NumberOfLecture = numberOfLecture;
        }

        public Discipline(string name, int numberOfLecture, IEnumerable<string> exercises)
            : this(name, numberOfLecture)
        {
            this.Exercises = exercises;
        }

        public Discipline(string name, int numberOfLecture, IEnumerable<string> exercises, string comments)
            : base(name, comments)
        {
            this.NumberOfLecture = numberOfLecture;
            this.Exercises = Exercises;
        }

        public int NumberOfLecture { get; set; }

        public IEnumerable<string> Exercises { get; set; }
    }
}
