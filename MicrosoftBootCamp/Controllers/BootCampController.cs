using Microsoft.AspNetCore.Mvc;
using MicrosoftBootCamp.DataLayer;
using MicrosoftBootCamp.Models;
using MicrosoftBootCamp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftBootCamp.Controllers
{
    public class BootCampController : Controller
    {
        private StudentDbContext _context;

        public BootCampController(StudentDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddStudent()
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            return View(studentViewModel);
        }

        [HttpPost]
        //[Route("/BootCamp/AddStudent")]
        public IActionResult AddStudent(StudentViewModel studentViewModel)
        {
            if (ModelState.IsValid)
            {
                Student student = new Student
                {
                    fName = studentViewModel.fName,
                    lName = studentViewModel.lName,
                    Career = studentViewModel.Career

                };
                _context.Students.Add(student);
                _context.SaveChanges();
                return Redirect("/BootCamp/StudentInfo");
            }
            return View(studentViewModel);
        }

        public IActionResult StudentInfo()
        {
            List<Student> students = _context.Students.ToList();
            return View(students);
        }

        [HttpGet]
        [Route("/BootCamp/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            Student student = _context.Students.Find(id);
            StudentViewModel studentViewModel = new StudentViewModel
            {
                fName = student.fName,
                lName = student.lName,
                Career = student.Career,
                JoinDate = student.JoinDate,
                Id = student.Id
            };
            return View(studentViewModel);
        }

        [HttpPost]
        public IActionResult Edit(StudentViewModel studentViewModel)
        {
            if (ModelState.IsValid)
            {
                Student student = _context.Students.Find(studentViewModel.Id);
                student.fName = studentViewModel.fName;
                student.lName = studentViewModel.lName;
                student.Career = studentViewModel.Career;
                student.JoinDate = studentViewModel.JoinDate;
                _context.SaveChanges();
                return Redirect("/BootCamp/StudentInfo");
            }
            return View(studentViewModel);
        }

        [HttpGet]
        [Route("/BootCamp/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            return View(_context.Students.Find(id));
        }

        [HttpPost]
        public IActionResult SubmitDelete(int id)
        {
            _context.Students.Remove(_context.Students.Find(id));
            _context.SaveChanges();
            return Redirect("/BootCamp/StudentInfo");
        }

        [HttpPost]
        public IActionResult SearchResults(string search)
        {
            if (search != null)
            {
                List<Student> students = new List<Student>();
                foreach (Student student in _context.Students.ToList())
                {
                    if (student.fName.ToLower().Contains(search.ToLower()) || student.lName.ToLower().Contains(search.ToLower()))
                    {
                        students.Add(student);
                    }
                }
                ViewBag.search = search;
                return View(students);
            }
            return Redirect("StudentInfo");
        }
    }
}
