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
    public class TeacherSeedData : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            var teachers = new List<Teacher>
            {
                // English (ID = 1)
                new Teacher { ID = 1, Name = "Alice", Surname = "Johnson", LessonID = 1 },
                new Teacher { ID = 2, Name = "David", Surname = "Smith", LessonID = 1 },
                new Teacher { ID = 3, Name = "Can", Surname = "Aslan", LessonID = 1 },

                // Turkish (ID = 2)
                new Teacher { ID = 4, Name = "Merve", Surname = "Yılmaz", LessonID = 2 },
                new Teacher { ID = 5, Name = "Ahmet", Surname = "Kara", LessonID = 2 },
                new Teacher { ID = 6, Name = "Elif", Surname = "Aydın", LessonID = 2 },

                // Mathematics (ID = 3)
                new Teacher { ID = 7, Name = "John", Surname = "Doe", LessonID = 3 },
                new Teacher { ID = 8, Name = "Ayşe", Surname = "Çelik", LessonID = 3 },
                new Teacher { ID = 9, Name = "Mehmet", Surname = "Kurt", LessonID = 3 },
                new Teacher { ID = 10, Name = "Fatma", Surname = "Demir", LessonID = 3 },
                new Teacher { ID = 11, Name = "Dilan", Surname = "Kaya", LessonID = 3 },


                // Physics (ID = 4)
                new Teacher { ID = 12, Name = "Selin", Surname = "Aksoy", LessonID = 4 },
                new Teacher { ID = 13, Name = "Kemal", Surname = "Öz", LessonID = 4 },

                // Chemistry (ID = 5)
                new Teacher { ID = 14, Name = "Burcu", Surname = "Güneş", LessonID = 5 },
                new Teacher { ID = 15, Name = "Tuncay", Surname = "Işık", LessonID = 5 },

                // Biology (ID = 6)
                new Teacher { ID = 16, Name = "Melisa", Surname = "Ersoy", LessonID = 6 },
                new Teacher { ID = 17, Name = "Levent", Surname = "Koç", LessonID = 6 },

                // History (ID = 7)
                new Teacher { ID = 18, Name = "Zeynep", Surname = "Polat", LessonID = 7 },
                new Teacher { ID = 19, Name = "Barış", Surname = "Can", LessonID = 7 },

                // Geography (ID = 8)
                new Teacher { ID = 20, Name = "Sibel", Surname = "Yıldırım", LessonID = 8 },
                new Teacher { ID = 21, Name = "Okan", Surname = "Şahin", LessonID = 8 },

                // Religious Culture and Moral Knowledge (ID = 9)
                new Teacher { ID = 22, Name = "Hasan", Surname = "Yüce", LessonID = 9 },

                // Physical Education and Sports (ID = 10)
                new Teacher { ID = 23, Name = "Emre", Surname = "Kaplan", LessonID = 10 },
                new Teacher { ID = 24, Name = "Buse", Surname = "Türkmen", LessonID = 10 },

                // Visual Arts / Music (ID = 11)
                new Teacher { ID = 25, Name = "İlknur", Surname = "Balcı", LessonID = 11 },

                // Health Knowledge and Traffic Culture (ID = 12)
                new Teacher { ID = 26, Name = "Gökhan", Surname = "Sezer", LessonID = 12 },

                // German (ID = 13)
                new Teacher { ID = 27, Name = "Stefan", Surname = "Müller", LessonID = 13 },
                new Teacher { ID = 28, Name = "Lena", Surname = "Schmidt", LessonID = 13 },

            };
            builder.HasData(teachers);
        }
    }
}
