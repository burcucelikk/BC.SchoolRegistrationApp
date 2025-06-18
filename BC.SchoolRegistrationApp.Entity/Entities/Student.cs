using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Entity.Entities
{
    public class Student : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Number { get; set; }
        public string Photograph { get; set; }

        public int ClassID { get; set; }
        public Class Class { get; set; }
        public bool IsPassed { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
