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
            foreach (Student student in GetAll())
            {
                if (student.Id == id)
                {
                    newStudent = student;
                }
            }
            return newStudent;
        }

        //retrieve list of students

        public static List<Student> GetStudents(string search)
        {
            List<Student> studentSearch = new List<Student>();
            foreach (Student student in GetAll())
            {
                if (student.fName.ToLower() == search.ToLower() || student.lName.ToLower() == search.ToLower())
                {
                    studentSearch.Add(student);
                }
            }
            return studentSearch;
        }
    }
}
