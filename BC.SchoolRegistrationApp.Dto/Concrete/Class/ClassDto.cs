using BC.SchoolRegistrationApp.Dto.Base;
using BC.SchoolRegistrationApp.Dto.Concrete.Student;
using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Class
{
    public class ClassDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
