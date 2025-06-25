using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BC.SchoolRegistrationApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeeklyHour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Photograph = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    IsPassed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamType = table.Column<int>(type: "int", nullable: false),
                    LessonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Exam_Lessons_LessonID",
                        column: x => x.LessonID,
                        principalTable: "Lessons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Teachers_Lessons_LessonID",
                        column: x => x.LessonID,
                        principalTable: "Lessons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    LessonID = table.Column<int>(type: "int", nullable: false),
                    ExamID = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Grades_Exam_ExamID",
                        column: x => x.ExamID,
                        principalTable: "Exam",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grades_Lessons_LessonID",
                        column: x => x.LessonID,
                        principalTable: "Lessons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassLessons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    LessonID = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassLessons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClassLessons_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassLessons_Lessons_LessonID",
                        column: x => x.LessonID,
                        principalTable: "Lessons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassLessons_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LessonSchedules",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<int>(type: "int", nullable: false),
                    LessonHour = table.Column<int>(type: "int", nullable: false),
                    ClassLessonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonSchedules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LessonSchedules_ClassLessons_ClassLessonID",
                        column: x => x.ClassLessonID,
                        principalTable: "ClassLessons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "9A" },
                    { 2, "9B" },
                    { 3, "9C" },
                    { 4, "10A" },
                    { 5, "10B" },
                    { 6, "10C" },
                    { 7, "11A" },
                    { 8, "11B" },
                    { 9, "11C" },
                    { 10, "12A" },
                    { 11, "12B" },
                    { 12, "12C" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "Name", "WeeklyHour" },
                values: new object[,]
                {
                    { 1, "English", 4 },
                    { 2, "Turkish", 5 },
                    { 3, "Mathematics", 6 },
                    { 4, "Physics", 4 },
                    { 5, "Chemistry", 2 },
                    { 6, "Biology", 2 },
                    { 7, "History", 2 },
                    { 8, "Geography", 2 },
                    { 9, "Religious Culture and Moral Knowledge", 1 },
                    { 10, "Physical Education and Sports", 2 },
                    { 11, "Visual Arts / Music", 2 },
                    { 12, "Health Knowledge and Traffic Culture", 1 },
                    { 13, "German", 3 }
                });

            migrationBuilder.InsertData(
                table: "Exam",
                columns: new[] { "ID", "ExamType", "LessonID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 1, 2 },
                    { 5, 2, 2 },
                    { 6, 3, 2 },
                    { 7, 1, 3 },
                    { 8, 2, 3 },
                    { 9, 3, 3 },
                    { 10, 1, 4 },
                    { 11, 2, 4 },
                    { 12, 3, 4 },
                    { 13, 1, 5 },
                    { 14, 2, 5 },
                    { 15, 3, 5 },
                    { 16, 1, 6 },
                    { 17, 2, 6 },
                    { 18, 3, 6 },
                    { 19, 1, 7 },
                    { 20, 2, 7 },
                    { 21, 3, 7 },
                    { 22, 1, 8 },
                    { 23, 2, 8 },
                    { 24, 3, 8 },
                    { 25, 1, 9 },
                    { 26, 2, 9 },
                    { 27, 3, 9 },
                    { 28, 1, 10 },
                    { 29, 2, 10 },
                    { 30, 3, 10 },
                    { 31, 1, 11 },
                    { 32, 2, 11 },
                    { 33, 3, 11 },
                    { 34, 1, 12 },
                    { 35, 2, 12 },
                    { 36, 3, 12 },
                    { 37, 1, 13 },
                    { 38, 2, 13 },
                    { 39, 3, 13 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "ClassID", "IsPassed", "Name", "Number", "Photograph", "Surname" },
                values: new object[,]
                {
                    { 1, 1, false, "Elif", "1001", "", "Yılmaz" },
                    { 2, 1, false, "Ahmet", "1002", "", "Demir" },
                    { 3, 1, false, "Zeynep", "1003", "", "Kaya" },
                    { 4, 1, false, "Mehmet", "1004", "", "Aydın" },
                    { 5, 1, false, "Ayşe", "1005", "", "Şahin" },
                    { 6, 2, false, "Ece", "2001", "", "Koç" },
                    { 7, 2, false, "Yusuf", "2002", "", "Arslan" },
                    { 8, 2, false, "Naz", "2003", "", "Çelik" },
                    { 9, 2, false, "Emre", "2004", "", "Bozkurt" },
                    { 10, 2, false, "Melis", "2005", "", "Türkmen" },
                    { 11, 3, false, "Burak", "3001", "", "Öztürk" },
                    { 12, 3, false, "Ceren", "3002", "", "Yıldız" },
                    { 13, 3, false, "Okan", "3003", "", "Kurt" },
                    { 14, 3, false, "Nisa", "3004", "", "Bal" },
                    { 15, 3, false, "Selim", "3005", "", "Er" },
                    { 16, 4, false, "İrem", "4001", "", "Aksoy" },
                    { 17, 4, false, "Berat", "4002", "", "Aslan" },
                    { 18, 4, false, "Deniz", "4003", "", "Taş" },
                    { 19, 4, false, "Esra", "4004", "", "Yalçın" },
                    { 20, 4, false, "Hakan", "4005", "", "Eren" },
                    { 21, 5, false, "Alper", "5001", "", "Şimşek" },
                    { 22, 5, false, "Derya", "5002", "", "Özkan" },
                    { 23, 5, false, "Efe", "5003", "", "Çakır" },
                    { 24, 5, false, "Seda", "5004", "", "Güneş" },
                    { 25, 5, false, "Bora", "5005", "", "Kurtuluş" },
                    { 26, 6, false, "Mert", "6001", "", "Kaplan" },
                    { 27, 6, false, "Gizem", "6002", "", "Durmaz" },
                    { 28, 6, false, "Umut", "6003", "", "Tan" },
                    { 29, 6, false, "Yaren", "6004", "", "Özdemir" },
                    { 30, 6, false, "Kerem", "6005", "", "Boz" },
                    { 31, 7, false, "İlayda", "7001", "", "Sezer" },
                    { 32, 7, false, "Tunahan", "7002", "", "Kurt" },
                    { 33, 7, false, "Melike", "7003", "", "Avcı" },
                    { 34, 7, false, "Harun", "7004", "", "Sönmez" },
                    { 35, 7, false, "Büşra", "7005", "", "Erdoğan" },
                    { 36, 8, false, "Fatih", "8001", "", "İnce" },
                    { 37, 8, false, "Dilara", "8002", "", "Koşar" },
                    { 38, 8, false, "Ali", "8003", "", "Çetin" },
                    { 39, 8, false, "Sena", "8004", "", "Kaya" },
                    { 40, 8, false, "Yiğit", "8005", "", "Acar" },
                    { 41, 9, false, "Zeliha", "9001", "", "Doğan" },
                    { 42, 9, false, "Can", "9002", "", "Yıldırım" },
                    { 43, 9, false, "Rabia", "9003", "", "Er" },
                    { 44, 9, false, "Taha", "9004", "", "Gür" },
                    { 45, 9, false, "Simay", "9005", "", "Polat" },
                    { 46, 10, false, "Furkan", "10001", "", "Kılıç" },
                    { 47, 10, false, "Beyza", "10002", "", "Sarı" },
                    { 48, 10, false, "Talha", "10003", "", "Özer" },
                    { 49, 10, false, "Gül", "10004", "", "Toprak" },
                    { 50, 10, false, "Ozan", "10005", "", "Güneş" },
                    { 51, 11, false, "Selin", "11001", "", "Yavuz" },
                    { 52, 11, false, "Baran", "11002", "", "Yüce" },
                    { 53, 11, false, "Cansu", "11003", "", "Ergin" },
                    { 54, 11, false, "Onur", "11004", "", "Aydın" },
                    { 55, 11, false, "Nehir", "11005", "", "Deniz" },
                    { 56, 12, false, "Serhat", "12001", "", "Çınar" },
                    { 57, 12, false, "Nazlı", "12002", "", "Taşdemir" },
                    { 58, 12, false, "Arda", "12003", "", "Ersoy" },
                    { 59, 12, false, "İdil", "12004", "", "Yücel" },
                    { 60, 12, false, "Melek", "12005", "", "Güler" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "LessonID", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, 1, "Alice", "Johnson" },
                    { 2, 1, "David", "Smith" },
                    { 3, 1, "Can", "Aslan" },
                    { 4, 2, "Merve", "Yılmaz" },
                    { 5, 2, "Ahmet", "Kara" },
                    { 6, 2, "Elif", "Aydın" },
                    { 7, 3, "John", "Doe" },
                    { 8, 3, "Ayşe", "Çelik" },
                    { 9, 3, "Mehmet", "Kurt" },
                    { 10, 3, "Fatma", "Demir" },
                    { 11, 3, "Dilan", "Kaya" },
                    { 12, 4, "Selin", "Aksoy" },
                    { 13, 4, "Kemal", "Öz" },
                    { 14, 5, "Burcu", "Güneş" },
                    { 15, 5, "Tuncay", "Işık" },
                    { 16, 6, "Melisa", "Ersoy" },
                    { 17, 6, "Levent", "Koç" },
                    { 18, 7, "Zeynep", "Polat" },
                    { 19, 7, "Barış", "Can" },
                    { 20, 8, "Sibel", "Yıldırım" },
                    { 21, 8, "Okan", "Şahin" },
                    { 22, 9, "Hasan", "Yüce" },
                    { 23, 10, "Emre", "Kaplan" },
                    { 24, 10, "Buse", "Türkmen" },
                    { 25, 11, "İlknur", "Balcı" },
                    { 26, 12, "Gökhan", "Sezer" },
                    { 27, 13, "Stefan", "Müller" },
                    { 28, 13, "Lena", "Schmidt" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassLessons_ClassID",
                table: "ClassLessons",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassLessons_LessonID",
                table: "ClassLessons",
                column: "LessonID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassLessons_TeacherID",
                table: "ClassLessons",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_LessonID",
                table: "Exam",
                column: "LessonID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_ExamID",
                table: "Grades",
                column: "ExamID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_LessonID",
                table: "Grades",
                column: "LessonID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentID",
                table: "Grades",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_LessonSchedules_ClassLessonID",
                table: "LessonSchedules",
                column: "ClassLessonID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassID",
                table: "Students",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Number",
                table: "Students",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_LessonID",
                table: "Teachers",
                column: "LessonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "LessonSchedules");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ClassLessons");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Lessons");
        }
    }
}
