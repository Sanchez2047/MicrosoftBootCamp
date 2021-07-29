using Microsoft.AspNetCore.Mvc.Rendering;
using MicrosoftBootCamp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftBootCamp.ViewModels
{
    public class StudentViewModel
    {
        [Required]
        public string fName { get; set; }

        [Required]
        public string lName { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Must select a Career Path")]
        public StudentCareer Career { get; set; }

        public List<SelectListItem> StudentCareers { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(StudentCareer.SelectOne.ToString(), ((int)StudentCareer.SelectOne).ToString()),
            new SelectListItem(StudentCareer.WebDevelopment.ToString(), ((int)StudentCareer.WebDevelopment).ToString()),
            new SelectListItem(StudentCareer.DevOps.ToString(), ((int)StudentCareer.DevOps).ToString()),
            new SelectListItem(StudentCareer.Security.ToString(), ((int)StudentCareer.Security).ToString()),
            new SelectListItem(StudentCareer.MachineLearning.ToString(), ((int)StudentCareer.MachineLearning).ToString()),
            new SelectListItem(StudentCareer.ArtificialIntelligence.ToString(), ((int)StudentCareer.ArtificialIntelligence).ToString())
        };

        public string CareerPath { get; set; }
    }
}
