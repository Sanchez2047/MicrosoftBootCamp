using Microsoft.AspNetCore.Mvc;
using MicrosoftBootCamp.DataLayer;
using MicrosoftBootCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftBootCamp.Controllers
{
    public class BootCampController : Controller
    {
        private static List<string> careers = new List<string>
        {
            "Career Path",
            "Web Development",
            "Devops",
            "Security",
            "Machine Learning",
            "Artificial Intelligence"
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddStudent()
        {
            ViewBag.careers = careers;
            return View();
        }
        [HttpPost]
        [Route("/BootCamp/AddStudent")]
        public IActionResult NewStudent(Student student)
        {
            StudentData.Add(student);
            return Redirect("/BootCamp/StudentInfo");
        }
        public IActionResult StudentInfo()
        {
            ViewBag.students = StudentData.GetAll();
            return View();
        }
        [HttpGet]
        [Route("/BootCamp/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewBag.careers = careers;
            ViewBag.studentToEdit = StudentData.GetOne(id);
            return View();
        }
        [HttpPost]
        public IActionResult SubmitEditForm(int id, string fName, string lName, string CareerPath)
        {
            Student student = StudentData.GetOne(id);
            student.fName = fName;
            student.lName = lName;
            student.CareerPath = CareerPath;
            return Redirect("/BootCamp/StudentInfo");
        }
        [HttpGet]
        [Route("/BootCamp/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            ViewBag.careers = careers;
            ViewBag.studentToDelete = StudentData.GetOne(id);
            return View();

        }
        [HttpPost]
        public IActionResult SubmitDeleteForm(int id)
        {
            StudentData.Delete(StudentData.GetOne(id));
            return Redirect("/BootCamp/StudentInfo");

        }
        [HttpPost]
        public IActionResult SearchResults(string search)
        {
            ViewBag.SearchResults = StudentData.GetStudents(search);
            ViewBag.search = search;
            return View();

        }
    }
}
