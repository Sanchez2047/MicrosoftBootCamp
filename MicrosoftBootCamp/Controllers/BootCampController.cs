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
        //[HttpGet]
        //[Route("/BootCamp/Edit/{id}")]
        //public IActionResult Edit(int id)
        //{
        //    ViewBag.careers = careers;
        //    ViewBag.studentToEdit = StudentData.GetOne(id);
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult SubmitEditForm(int id, string fName, string lName, string CareerPath)
        //{
        //    Student student = StudentData.GetOne(id);
        //    student.fName = fName;
        //    student.lName = lName;
        //    student.CareerPath = CareerPath;
        //    return Redirect("/BootCamp/StudentInfo");
        //}
        //[HttpGet]
        //[Route("/BootCamp/Delete/{id}")]
        //public IActionResult Delete(int id)
        //{
        //    ViewBag.careers = careers;
        //    ViewBag.studentToDelete = StudentData.GetOne(id);
        //    return View();

        //}
        //[HttpPost]
        //public IActionResult SubmitDeleteForm(int id)
        //{
        //    StudentData.Delete(StudentData.GetOne(id));
        //    return Redirect("/BootCamp/StudentInfo");

        //}
        //[HttpPost]
        //public IActionResult SearchResults(string search)
        //{
        //    ViewBag.SearchResults = StudentData.GetStudents(search);
        //    ViewBag.search = search;
        //    return View();

        //}
    }
}
