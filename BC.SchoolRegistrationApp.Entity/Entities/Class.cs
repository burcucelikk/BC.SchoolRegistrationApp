using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Entity.Entities
{
    public class Class : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<ClassLesson> ClassLessons { get; set; }
    }
}
