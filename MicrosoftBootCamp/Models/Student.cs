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
        public DateTime JoinDate { get; set; }
        public int Id { get; set; }
        public Student()
        {
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
