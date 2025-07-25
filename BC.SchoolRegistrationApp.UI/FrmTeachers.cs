using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.Dto.Concrete.Lesson;
using BC.SchoolRegistrationApp.Dto.Concrete.Student;
using BC.SchoolRegistrationApp.Dto.Concrete.Teacher;
using BC.SchoolRegistrationApp.UI.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmTeachers : DevExpress.XtraEditors.XtraForm
    {
        public enum FormMode { None, Add, Update, Delete, Detail }

        private FormMode _currentMode = FormMode.None;
        private readonly ITeacherService _teacherService;
        private readonly ILessonService _lessonService;

        public FrmTeachers(ITeacherService teacherService, ILessonService lessonService)
        {
            InitializeComponent();
            _teacherService = teacherService;
            _lessonService = lessonService;
        }
        private void FrmTeachers_Load(object sender, EventArgs e)
        {
            ResetView();
            LoadTeacherList();
            LoadLessonList();
            SetupGrid(TeachersGrid);
        }
        private void lessonList_EditValueChanged(object sender, EventArgs e)
        {
            var selectedLessonDto = lessonList.GetSelectedDataRow() as LessonListDto;
            if (selectedLessonDto != null)
                ShowLessonTeachers(selectedLessonDto.Name, TeachersGrid);
        }
        private void addButton_Click(object sender, EventArgs e) => ShowFlyoutModePanel(FormMode.Add);
        private void updateButton_Click(object sender, EventArgs e) => ShowFlyoutModePanel(FormMode.Update);
        private void deleteButton_Click(object sender, EventArgs e) => ShowFlyoutModePanel(FormMode.Delete);
        private void btnClose_Click(object sender, EventArgs e) => CloseFlyoutPanel();
        private void LoadTeacherList()
        {
            TeachersGrid.DataSource = _teacherService.GetAll();
        }
        private void LoadLessonList()
        {
            SetupGridLookUp(lessonList);
        }
        private void SetupGridLookUp(GridLookUpEdit gridLookUpEdit)
        {
            var lessons = _lessonService.GetAll();
            gridLookUpEdit.Properties.DataSource = lessons;
            gridLookUpEdit.Properties.DisplayMember = "Name";
            gridLookUpEdit.Properties.ValueMember = "Id";
            gridLookUpEdit.Properties.NullText = "Seçiniz";
            gridLookUpEdit.EditValue = null;
            gridLookUpEdit.Properties.View.Columns.Clear();
            gridLookUpEdit.Properties.View.Columns.AddVisible("Name", "Ders");
        }
        public void ResetView()
        {
            TeachersGrid.Visible = true;
            lessonList.Visible = true;
            lessonList.Enabled = true;
            overlayPanel.Visible = false;
        }
        private void ShowFlyoutModePanel(FormMode mode)
        {
            _currentMode = mode;
            SetFormMode(_currentMode);

            overlayPanel.Visible = true;
            overlayPanel.BringToFront();

            crudFlyoutPanel.OwnerControl = this;
            crudFlyoutPanel.ShowPopup();
        }
        public void SetFormMode(FormMode mode)
        {
            _currentMode = mode;
            //DevExpToolHelper.ClearInputs(TextGroup);
            //classInputLookup.Properties.NullText = "Classes";
            //classInputLookup.EditValue = null;
            //_studentUpdateDto = null;
        }
        private void ShowLessonTeachers(string selectedLesson, GridControl grid)
        {
            var teachers = _teacherService.GetAll(x => x.Lesson.Name == selectedLesson);
            grid.DataSource = teachers;
            SetupGrid(grid);
        }
        private void SetupGrid(GridControl grid)
        {
            var iconPath = "C:/Users/burcu/source/repos/BC.SchoolRegistrationApp/BC.SchoolRegistrationApp.UI/photos/icons/studentInfo.png";
            if (grid.MainView is GridView view)
            {
                view.OptionsBehavior.Editable = false;
                view.PopulateColumns();
                view.Columns["Id"].Visible = false;

                if (view.Columns.ColumnByFieldName("Detay") == null)
                    DevExpToolHelper.AddButtonColumn(view, grid, "Detay", "Detay", iconPath);

                view.RowCellClick -= TeachersGrid_RowCellClick;
                view.RowCellClick += TeachersGrid_RowCellClick;

                view.BestFitColumns();
            }
        }

        private void TeachersGrid_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var view = sender as GridView;
            var student = view.GetRow(e.RowHandle) as TeacherListDto;
            if (student == null) return;
            if (e.Column.FieldName == "Detay")
            {
                var studentDetails = _teacherService.GetDetailById(student.Id);
                _currentMode = FormMode.Detail;
                if (studentDetails != null)
                {
                    ShowFlyoutModePanel(_currentMode);
                }
            }
        }
        public void CloseFlyoutPanel()
        {
            if (crudFlyoutPanel != null && crudFlyoutPanel.Visible)
            {
                crudFlyoutPanel.HidePopup();
                ResetView();

                TeachersGrid.Enabled = false;

                Timer timer = new Timer();
                timer.Interval = 500;
                timer.Tick += (s, e) =>
                {
                    TeachersGrid.Enabled = true;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }
            else
                ResetView();
        }
    }
}