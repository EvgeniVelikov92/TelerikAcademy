namespace School
{
    using System;
    using System.Collections.Generic;

    public abstract class School
    {
        private long id;

        public School(string name)
        {
            this.Name = name;
        }

        public School(string name, string comments)
            : this(name)
        {
            this.Comments = comments;
        }

        public School(long id)
        {
            this.Id = id;
        }

        public School(long id, string comments)
        {
            this.Id = id;
            this.Comments = comments;
        }

        public string Name { get; set; }

        public string Comments { get; set; }

        public long Id { get; set; }
    }
}
