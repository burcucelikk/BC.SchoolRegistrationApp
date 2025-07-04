using BC.SchoolRegistrationApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Student
{
    public class StudentDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public string? Photograph { get; set; }
        public int ClassID { get; set; }
        public ClassDto Class { get; set; }
        public bool IsPassed { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
