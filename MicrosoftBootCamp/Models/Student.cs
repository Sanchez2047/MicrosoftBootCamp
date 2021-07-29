using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftBootCamp.Models
{
    public class Student
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public StudentCareer Career { get; set; }
        public DateTime JoinDate { get; }
        public int Id { get; }
        private static int _nextId = 1;
        public Student()
        {
            this.Id = _nextId;
            _nextId++;
            this.JoinDate = DateTime.Now;
        }
        public Student(string fname, string lname, StudentCareer career) : this()
        {
            this.fName = fname;
            this.lName = lname;
            this.Career = career;
        }

    }
}
