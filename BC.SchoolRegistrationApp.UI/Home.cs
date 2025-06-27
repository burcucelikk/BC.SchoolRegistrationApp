using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Context;
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

        private FormMode _currentMode;

        FrmStudents frmStudents;
        FrmAboutSchool frmAboutSchool;
        public Home(IClassService classService, IStudentService studentService)
        {
            InitializeComponent();
            _classService = classService;
            _studentService = studentService;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            ShowAboutForm();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAboutForm();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowStudentsForm();
            frmStudents.ResetView();
        }

        private void AddButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowStudentsForm();
            frmStudents.SetFormMode(FormMode.Add);
            frmStudents.ShowTextGroupView();
        }

        private void UpdateButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowStudentsForm();
            frmStudents.SetFormMode(FormMode.Update);
            frmStudents.ShowTextGroupView();
        }

        private void DeleteButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _currentMode = FormMode.Delete;
        }
        private void ShowAboutForm()
        {
            if (frmAboutSchool == null || frmAboutSchool.IsDisposed)
            {
                frmAboutSchool = new FrmAboutSchool();
                frmAboutSchool.MdiParent = this;
                frmAboutSchool.Show();
            }
            else
                frmAboutSchool.BringToFront();
        }
        private void ShowStudentsForm()
        {
            if (frmStudents == null || frmStudents.IsDisposed)
            {
                frmStudents = new FrmStudents(_classService, _studentService, _currentMode);
                frmStudents.MdiParent = this;
                frmStudents.Show();
            }
            else
            {
                frmStudents.BringToFront();
            }
        }
    }
}