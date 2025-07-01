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
        private readonly ILessonService _lessonService;
        private readonly ITeacherService _teacherService;

        private FormMode _currentMode;

        private FrmTeachers frmTeachers;
        private FrmStudents frmStudents;
        private FrmAboutSchool frmAboutSchool;
        public Home(IClassService classService, IStudentService studentService, ILessonService lessonService, ITeacherService teacherService)
        {
            InitializeComponent();
            _classService = classService;
            _studentService = studentService;
            _lessonService = lessonService;
            _teacherService = teacherService;
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
            frmStudents = FormHelper.ShowForm(ref frmStudents, () => new FrmStudents(_classService, _studentService), this);
            frmStudents.ResetView();
        }
        private void teachersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTeachers = FormHelper.ShowForm(ref frmTeachers, () => new FrmTeachers(_teacherService,_lessonService), this);
        }
        private void AddButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStudents = FormHelper.ShowForm(ref frmStudents, () => new FrmStudents(_classService, _studentService), this);
            frmStudents.SetFormMode(FormMode.Add);
            frmStudents.SetModeView();
        }

        private void UpdateButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStudents = FormHelper.ShowForm(ref frmStudents, () => new FrmStudents(_classService, _studentService), this);
            frmStudents.SetFormMode(FormMode.Update);
            frmStudents.SetModeView();
        }

        private void DeleteButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStudents = FormHelper.ShowForm(ref frmStudents, () => new FrmStudents(_classService, _studentService), this);
            frmStudents.SetFormMode(FormMode.Delete);
            frmStudents.SetModeView();
        }

    }
}