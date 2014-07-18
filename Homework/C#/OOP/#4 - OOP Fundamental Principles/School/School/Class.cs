namespace School
{
    using System;
    using System.Collections.Generic;

    public abstract class Class : School
    {
        public Class(long id)
            : base(id)
        {
            this.Id = id;
        }

        public Class(long id, IEnumerable<Student> students)
            : base(id)
        {
            this.Students = students;
        }

        public Class(long id, IEnumerable<Student> students, IEnumerable<Teacher> teachers)
            : base(id)
        {
            this.Students = students;
            this.Teachers = teachers;
        }

        public Class(long id, string comments, IEnumerable<Student> students, IEnumerable<Teacher> teachers)
            : base(id, comments)
        {
            this.Students = students;
            this.Teachers = teachers;
        }

        public IEnumerable<Student> Students { get; set; }

        public IEnumerable<Teacher> Teachers { get; set; }
    }
}
