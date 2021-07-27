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
        public static void Delete(Student x) => _students.Remove(x);
        //{
        //    _students.Remove(oldStudent);
        //}

        //Get by ID
        public static Student GetOne(int id)
        {
            //int index = 0;
            foreach (Student student in GetAll())
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
            

            //return _students.Where(Student => Student.Id == id).FirstOrDefault();
        }

        //retrieve list of students

        public static List<Student> GetStudents(string search)
        {
            //List<Student> studentSearch = new List<Student>();
            //foreach (Student student in GetAll())
            //{
            //    if (student.fName.ToLower().Contains(search.ToLower()) || student.lName.ToLower().Contains(search.ToLower()))
            //    {
            //        studentSearch.Add(student);
            //    }
            //}
            //return studentSearch;
            return _students.Where(x => x.fName.Contains(search) || x.lName.Contains(search)).ToList();
        }
    }
}
