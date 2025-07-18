using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Context;
using BC.SchoolRegistrationApp.UI.Helpers;
using DevExpress.XtraBars;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BC.SchoolRegistrationApp.UI.FrmStudents;

namespace BC.SchoolRegistrationApp.UI
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IClassService _classService;
        private readonly IStudentService _studentService;
        private readonly IGradeService _gradeService;
        private readonly ILessonService _lessonService;
        private readonly ITeacherService _teacherService;

        private FormMode _currentMode;

        private FrmTeachers frmTeachers;
        private FrmStudents frmStudents;
        private FrmAboutSchool frmAboutSchool;
        public Home(IClassService classService, IStudentService studentService, ILessonService lessonService, ITeacherService teacherService, IGradeService gradeService)
        {
            InitializeComponent();
            _classService = classService;
            _studentService = studentService;
            _lessonService = lessonService;
            _teacherService = teacherService;
            _gradeService = gradeService;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            FormHelper.ShowForm(ref frmAboutSchool, () => new FrmAboutSchool(), this);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelper.ShowForm(ref frmAboutSchool, () => new FrmAboutSchool(), this);
        }
        private void studentsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStudents = FormHelper.ShowForm(ref frmStudents, () => new FrmStudents(_classService, _studentService, _gradeService), this);
            frmStudents.ResetView();
            frmStudents.CloseFlyoutPanel();
        }
        private void teachersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTeachers = FormHelper.ShowForm(ref frmTeachers, () => new FrmTeachers(_teacherService,_lessonService), this);
        }

    }
}