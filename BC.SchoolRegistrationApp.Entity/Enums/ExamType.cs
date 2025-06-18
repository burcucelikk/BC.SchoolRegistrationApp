using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Entity.Enums
{
    public enum ExamType
    {
        [Display(Name = "First Exam")]
        First = 1,

        [Display(Name = "Second Exam")]
        Second = 2,

        [Display(Name = "Third Exam")]
        Third = 3
    }
}
