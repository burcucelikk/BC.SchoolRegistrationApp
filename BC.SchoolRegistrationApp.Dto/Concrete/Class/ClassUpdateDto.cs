using BC.SchoolRegistrationApp.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Dto.Concrete.Class
{
    public class ClassUpdateDto :IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
