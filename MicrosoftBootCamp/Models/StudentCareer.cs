using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftBootCamp.Models
{
    public enum StudentCareer
    {
        [Display(Name = "**Select One**")]
        SelectOne,

        [Display(Name = "Web Development")]
        WebDevelopment,

        DevOps,

        Security,

        [Display(Name = "Machine Learning")]
        MachineLearning,

        [Display(Name = "Artificial Intelligence")]
        ArtificialIntelligence
    }
}
