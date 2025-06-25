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
    public class StudentSeedData : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            var students = new List<Student>
            {
                // 9A
                new Student { ID = 1, Name = "Elif", Surname = "Yılmaz", Number = "1001", Photograph = "", ClassID = 1, IsPassed = false },
                new Student { ID = 2, Name = "Ahmet", Surname = "Demir", Number = "1002", Photograph = "", ClassID = 1, IsPassed = false },
                new Student { ID = 3, Name = "Zeynep", Surname = "Kaya", Number = "1003", Photograph = "", ClassID = 1, IsPassed = false },
                new Student { ID = 4, Name = "Mehmet", Surname = "Aydın", Number = "1004", Photograph = "", ClassID = 1, IsPassed = false },
                new Student { ID = 5, Name = "Ayşe", Surname = "Şahin", Number = "1005", Photograph = "", ClassID = 1, IsPassed = false },

                // 9B
                new Student { ID = 6, Name = "Ece", Surname = "Koç", Number = "2001", Photograph = "", ClassID = 2, IsPassed = false },
                new Student { ID = 7, Name = "Yusuf", Surname = "Arslan", Number = "2002", Photograph = "", ClassID = 2, IsPassed = false },
                new Student { ID = 8, Name = "Naz", Surname = "Çelik", Number = "2003", Photograph = "", ClassID = 2, IsPassed = false },
                new Student { ID = 9, Name = "Emre", Surname = "Bozkurt", Number = "2004", Photograph = "", ClassID = 2, IsPassed = false },
                new Student { ID = 10, Name = "Melis", Surname = "Türkmen", Number = "2005", Photograph = "", ClassID = 2, IsPassed = false },

                // 9C
                new Student { ID = 11, Name = "Burak", Surname = "Öztürk", Number = "3001", Photograph = "", ClassID = 3, IsPassed = false },
                new Student { ID = 12, Name = "Ceren", Surname = "Yıldız", Number = "3002", Photograph = "", ClassID = 3, IsPassed = false },
                new Student { ID = 13, Name = "Okan", Surname = "Kurt", Number = "3003", Photograph = "", ClassID = 3, IsPassed = false },
                new Student { ID = 14, Name = "Nisa", Surname = "Bal", Number = "3004", Photograph = "", ClassID = 3, IsPassed = false },
                new Student { ID = 15, Name = "Selim", Surname = "Er", Number = "3005", Photograph = "", ClassID = 3, IsPassed = false },

                // 10A
                new Student { ID = 16, Name = "İrem", Surname = "Aksoy", Number = "4001", Photograph = "", ClassID = 4, IsPassed = false },
                new Student { ID = 17, Name = "Berat", Surname = "Aslan", Number = "4002", Photograph = "", ClassID = 4, IsPassed = false },
                new Student { ID = 18, Name = "Deniz", Surname = "Taş", Number = "4003", Photograph = "", ClassID = 4, IsPassed = false },
                new Student { ID = 19, Name = "Esra", Surname = "Yalçın", Number = "4004", Photograph = "", ClassID = 4, IsPassed = false },
                new Student { ID = 20, Name = "Hakan", Surname = "Eren", Number = "4005", Photograph = "", ClassID = 4, IsPassed = false },

                // 10B
                new Student { ID = 21, Name = "Alper", Surname = "Şimşek", Number = "5001", Photograph = "", ClassID = 5, IsPassed = false },
                new Student { ID = 22, Name = "Derya", Surname = "Özkan", Number = "5002", Photograph = "", ClassID = 5, IsPassed = false },
                new Student { ID = 23, Name = "Efe", Surname = "Çakır", Number = "5003", Photograph = "", ClassID = 5, IsPassed = false },
                new Student { ID = 24, Name = "Seda", Surname = "Güneş", Number = "5004", Photograph = "", ClassID = 5, IsPassed = false },
                new Student { ID = 25, Name = "Bora", Surname = "Kurtuluş", Number = "5005", Photograph = "", ClassID = 5, IsPassed = false },

                // 10C
                new Student { ID = 26, Name = "Mert", Surname = "Kaplan", Number = "6001", Photograph = "", ClassID = 6, IsPassed = false },
                new Student { ID = 27, Name = "Gizem", Surname = "Durmaz", Number = "6002", Photograph = "", ClassID = 6, IsPassed = false },
                new Student { ID = 28, Name = "Umut", Surname = "Tan", Number = "6003", Photograph = "", ClassID = 6, IsPassed = false },
                new Student { ID = 29, Name = "Yaren", Surname = "Özdemir", Number = "6004", Photograph = "", ClassID = 6, IsPassed = false },
                new Student { ID = 30, Name = "Kerem", Surname = "Boz", Number = "6005", Photograph = "", ClassID = 6, IsPassed = false },

                // 11A
                new Student { ID = 31, Name = "İlayda", Surname = "Sezer", Number = "7001", Photograph = "", ClassID = 7, IsPassed = false },
                new Student { ID = 32, Name = "Tunahan", Surname = "Kurt", Number = "7002", Photograph = "", ClassID = 7, IsPassed = false },
                new Student { ID = 33, Name = "Melike", Surname = "Avcı", Number = "7003", Photograph = "", ClassID = 7, IsPassed = false },
                new Student { ID = 34, Name = "Harun", Surname = "Sönmez", Number = "7004", Photograph = "", ClassID = 7, IsPassed = false },
                new Student { ID = 35, Name = "Büşra", Surname = "Erdoğan", Number = "7005", Photograph = "", ClassID = 7, IsPassed = false },

                // 11B
                new Student { ID = 36, Name = "Fatih", Surname = "İnce", Number = "8001", Photograph = "", ClassID = 8, IsPassed = false },
                new Student { ID = 37, Name = "Dilara", Surname = "Koşar", Number = "8002", Photograph = "", ClassID = 8, IsPassed = false },
                new Student { ID = 38, Name = "Ali", Surname = "Çetin", Number = "8003", Photograph = "", ClassID = 8, IsPassed = false },
                new Student { ID = 39, Name = "Sena", Surname = "Kaya", Number = "8004", Photograph = "", ClassID = 8, IsPassed = false },
                new Student { ID = 40, Name = "Yiğit", Surname = "Acar", Number = "8005", Photograph = "", ClassID = 8, IsPassed = false },

                // 11C
                new Student { ID = 41, Name = "Zeliha", Surname = "Doğan", Number = "9001", Photograph = "", ClassID = 9, IsPassed = false },
                new Student { ID = 42, Name = "Can", Surname = "Yıldırım", Number = "9002", Photograph = "", ClassID = 9, IsPassed = false },
                new Student { ID = 43, Name = "Rabia", Surname = "Er", Number = "9003", Photograph = "", ClassID = 9, IsPassed = false },
                new Student { ID = 44, Name = "Taha", Surname = "Gür", Number = "9004", Photograph = "", ClassID = 9, IsPassed = false },
                new Student { ID = 45, Name = "Simay", Surname = "Polat", Number = "9005", Photograph = "", ClassID = 9, IsPassed = false },

                // 12A
                new Student { ID = 46, Name = "Furkan", Surname = "Kılıç", Number = "10001", Photograph = "", ClassID = 10, IsPassed = false },
                new Student { ID = 47, Name = "Beyza", Surname = "Sarı", Number = "10002", Photograph = "", ClassID = 10, IsPassed = false },
                new Student { ID = 48, Name = "Talha", Surname = "Özer", Number = "10003", Photograph = "", ClassID = 10, IsPassed = false },
                new Student { ID = 49, Name = "Gül", Surname = "Toprak", Number = "10004", Photograph = "", ClassID = 10, IsPassed = false },
                new Student { ID = 50, Name = "Ozan", Surname = "Güneş", Number = "10005", Photograph = "", ClassID = 10, IsPassed = false },

                // 12B
                new Student { ID = 51, Name = "Selin", Surname = "Yavuz", Number = "11001", Photograph = "", ClassID = 11, IsPassed = false },
                new Student { ID = 52, Name = "Baran", Surname = "Yüce", Number = "11002", Photograph = "", ClassID = 11, IsPassed = false },
                new Student { ID = 53, Name = "Cansu", Surname = "Ergin", Number = "11003", Photograph = "", ClassID = 11, IsPassed = false },
                new Student { ID = 54, Name = "Onur", Surname = "Aydın", Number = "11004", Photograph = "", ClassID = 11, IsPassed = false },
                new Student { ID = 55, Name = "Nehir", Surname = "Deniz", Number = "11005", Photograph = "", ClassID = 11, IsPassed = false },

                // 12C
                new Student { ID = 56, Name = "Serhat", Surname = "Çınar", Number = "12001", Photograph = "", ClassID = 12, IsPassed = false },
                new Student { ID = 57, Name = "Nazlı", Surname = "Taşdemir", Number = "12002", Photograph = "", ClassID = 12, IsPassed = false },
                new Student { ID = 58, Name = "Arda", Surname = "Ersoy", Number = "12003", Photograph = "", ClassID = 12, IsPassed = false },
                new Student { ID = 59, Name = "İdil", Surname = "Yücel", Number = "12004", Photograph = "", ClassID = 12, IsPassed = false },
                new Student { ID = 60, Name = "Melek", Surname = "Güler", Number = "12005", Photograph = "", ClassID = 12, IsPassed = false }

            };
            builder.HasData(students);
        }
    }
}
