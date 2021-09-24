using System;

namespace AS2
{

    public class Student
    {
        private int _id;

        public int Id
        {
            get{ return _id; }
            set
            { 
                if(value < 0)
                {
                    _id = -1;
                }
                else
                {
                    _id = value;
                }
            }
        }

        public string GivenName { get; set; }

        public string Surname { get; set; }

        public Status _status;
        public Status Status { get; set; }

        public DateTime StartDate { get; set;}
        public DateTime EndDate { get; set;}
        public DateTime GraduationDate { get; set;}
    }
}