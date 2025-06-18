using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Entity.Entities
{
    public enum LessonHour
    {
        [Display(Name = "08:30 - 09:15")] Hour1 = 1,
        [Display(Name = "09:25 - 10:10")] Hour2 = 2,
        [Display(Name = "10:20 - 11:05")] Hour3 = 3,
        [Display(Name = "11:15 - 12:00")] Hour4 = 4,
        [Display(Name = "13:00 - 13:45")] Hour5 = 5,
        [Display(Name = "13:55 - 14:40")] Hour6 = 6,
        [Display(Name = "14:50 - 15:35")] Hour7 = 7,
        [Display(Name = "15:45 - 16:30")] Hour8 = 8
    }
}
