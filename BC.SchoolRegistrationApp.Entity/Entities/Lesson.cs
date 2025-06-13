using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Entity.Entities
{
    public class Lesson : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ClassID {  get; set; }
        public Class Class { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
