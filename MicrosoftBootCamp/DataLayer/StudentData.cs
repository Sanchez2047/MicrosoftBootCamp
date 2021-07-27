using MicrosoftBootCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftBootCamp.DataLayer
{
    public class StudentData
    {
        //store students
        private static List<Student> _students = new List<Student>();
        //add students
        public static void Add(Student newStudent)
        {
            _students.Add(newStudent);
        }
        //retrieve all students
        public static IEnumerable<Student> GetAll()
        {
            return _students;
        }
        //delete student
         public static void Delete(Student oldStudent)
        {
            _students.Remove(oldStudent);
        }

        //Get by ID
        public static Student GetOne(int id)
        {
            Student newStudent = new Student();
            foreach(Student student in GetAll())
            {
                if (student.Id == id)
                {
                    newStudent = student;
                }
            }
            return newStudent;
        }

        //retrieve one student

        //public static Student GetStudent(string fName="",string lName = "")
        //{
        //    public static Index;

        //    if(_students.Contains(fName))
        //    {
        //        Index = _students.IndexOf(fName);
        //        return _students[Index];
        //    }
        //    else if(_students.Contains(lName))
        //    {
        //        Index = _students.IndexOf(lName);
        //        return _students[Index];
        //    }
        //    else
        //    {
                
        //    }
        //}

    }
}
