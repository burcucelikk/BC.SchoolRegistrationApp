using BC.SchoolRegistrationApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.Seeds
{
    public class ClassSeedData : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            var classes = new[]
            {
                new Class { ID = 1, Name = "9A" },
                new Class { ID = 2, Name = "9B" },
                new Class { ID = 3, Name = "9C" },
                new Class { ID = 4, Name = "10A" },
                new Class { ID = 5, Name = "10B" },
                new Class { ID = 6, Name = "10C" },
                new Class { ID = 7, Name = "11A" },
                new Class { ID = 8, Name = "11B" },
                new Class { ID = 9, Name = "11C" },
                new Class { ID = 10, Name = "12A" },
                new Class { ID = 11, Name = "12B" },
                new Class { ID = 12, Name = "12C" },
            };
            builder.HasData(classes);
        }
    }
}
