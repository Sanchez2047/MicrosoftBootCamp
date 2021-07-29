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
        [Required(ErrorMessage = ">>First Name Required<<")]
        public string fName { get; set; }

        [Required(ErrorMessage = ">>Last Name Required<<")]
        public string lName { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = ">>Must select a Career Path<<")]
        public StudentCareer Career { get; set; }

        public List<SelectListItem> StudentCareers { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(StudentCareer.zzSelect_Onezz.ToString().Replace('_', ' ').Replace('z','*'), ((int)StudentCareer.zzSelect_Onezz).ToString() ),
            new SelectListItem(StudentCareer.Web_Development.ToString().Replace('_', ' '), ((int)StudentCareer.Web_Development).ToString() ),
            new SelectListItem(StudentCareer.DevOps.ToString().Replace('_', ' '), ((int)StudentCareer.DevOps).ToString() ),
            new SelectListItem(StudentCareer.Security.ToString().Replace('_', ' '), ((int)StudentCareer.Security).ToString() ),
            new SelectListItem(StudentCareer.Machine_Learning.ToString().Replace('_', ' '), ((int)StudentCareer.Machine_Learning).ToString() ),
            new SelectListItem(StudentCareer.Artificial_Intelligence.ToString().Replace('_', ' '), ((int)StudentCareer.Artificial_Intelligence).ToString() )

        };

        public int Id { get; set; }
        public StudentViewModel()
        {}
        public StudentViewModel(string fname, string lname, StudentCareer career)
        {
            this.fName = fname;
            this.lName = lname;
            this.Career = career;
        }

    }
}
