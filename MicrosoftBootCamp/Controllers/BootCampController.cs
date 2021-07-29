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
                StudentData.Add(student);
                return Redirect("/BootCamp/StudentInfo");
            }
            return View(studentViewModel);
        }
        public IActionResult StudentInfo()
        {
            List<Student> students = new List<Student>(StudentData.GetAll());
            return View(students);
        }
        [HttpGet]
        [Route("/BootCamp/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            Student student = StudentData.GetOne(id);
            StudentViewModel studentViewModel = new StudentViewModel
            {
                fName = student.fName,
                lName = student.lName,
                Career = student.Career,
                Id = student.Id
            };

            return View(studentViewModel);
        }
        [HttpPost]
        public IActionResult Edit(StudentViewModel studentViewModel)
        {
            if (ModelState.IsValid) 
            { 
                Student student = StudentData.GetOne(studentViewModel.Id);
                student.fName = studentViewModel.fName;
                student.lName = studentViewModel.lName;
                student.Career = studentViewModel.Career;
                return Redirect("/BootCamp/StudentInfo");
            }
            return View(studentViewModel);
        }

        [HttpGet]
        [Route("/BootCamp/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            return View(StudentData.GetOne(id));
        }

        [HttpPost]
        public IActionResult SubmitDelete(int id)
        {
            StudentData.Delete(StudentData.GetOne(id));
            return Redirect("/BootCamp/StudentInfo");

        }
        //[HttpPost]
        //public IActionResult SearchResults(string search)
        //{
        //    ViewBag.SearchResults = StudentData.GetStudents(search);
        //    ViewBag.search = search;
        //    return View();

        //}
    }
}
