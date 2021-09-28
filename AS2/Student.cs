using System;

namespace AS2
{

    public class Student
    {
        public readonly int _id;

        public string GivenName { get; set; }

        public string Surname { get; set; }

        public Status _status;
        public Status Status { get; set; }

        public DateTime StartDate { get; set;}
        public DateTime EndDate { get; set;}
        public DateTime GraduationDate { get; set;}
    }
}