//using MicrosoftBootCamp.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace MicrosoftBootCamp.DataLayer
//{
//    public class StudentData
//    {

//        public static List<Student> GetStudents(string search)
//        {
//            List<Student> studentSearch = new List<Student>();
//            foreach (Student student in GetAll())
//            {
//                if (student.fName.ToLower().Contains(search.ToLower()) || student.lName.ToLower().Contains(search.ToLower()))
//                {
//                    studentSearch.Add(student);
//                }
//            }
//            return studentSearch;
//            //return _students.Where(x => x.fName.Contains(search) || x.lName.Contains(search)).ToList();
//        }
//    }
//}
