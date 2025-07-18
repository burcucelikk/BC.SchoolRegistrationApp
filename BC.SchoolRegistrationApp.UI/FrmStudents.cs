using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.Dto.Concrete.Class;
using BC.SchoolRegistrationApp.Dto.Concrete.Grade;
using BC.SchoolRegistrationApp.Dto.Concrete.Student;
using BC.SchoolRegistrationApp.UI.Constants;
using BC.SchoolRegistrationApp.UI.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BC.SchoolRegistrationApp.UI
{
    public partial class FrmStudents : DevExpress.XtraEditors.XtraForm
    {
        public enum FormMode { None, Add, Update, Delete, Detail}

        private FormMode _currentMode= FormMode.None;
        private readonly IClassService _classService;
        private readonly IStudentService _studentService;
        private readonly IGradeService _gradeService;

        private StudentUpdateDto _studentUpdateDto = null;
        private StudentDto _studentDto = new StudentDto();

        public FrmStudents(IClassService classService, IStudentService studentService, IGradeService gradeService)
        {
            InitializeComponent();
            _classService = classService;
            _studentService = studentService;
            _gradeService = gradeService;
        }
        public void SetFormMode(FormMode mode)
        {
            _currentMode = mode;
            DevExpToolHelper.ClearInputs(TextGroup);
            classInputLookup.Properties.NullText = "Classes";
            classInputLookup.EditValue = null;
            _studentUpdateDto = null;
        }
        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ResetView();
            LoadClassList();
            StudentsGrid.Enabled = true;
            StudentsGrid.DataSource = _studentService.GetAll();
            CallStudentGrid(StudentsGrid);
            crudFlyoutPanel.OwnerControl = this;
            overlayPanel.Visible = false;
        }
        private void classFilterLookup_EditValueChanged(object sender, EventArgs e)
        {
            var selectedClassDto = classFilterLookup.GetSelectedDataRow() as ClassListDto;
            if (selectedClassDto != null)
                ShowClassStudents(selectedClassDto.Name, StudentsGrid);
        }
        private void StudentsGrid_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var view = sender as GridView;
            var student = view.GetRow(e.RowHandle) as StudentListDto;
            if (student == null) return;
            if (e.Column.FieldName == "Detail")
            {
                var studentDetails = _studentService.GetDetailById(student.Id);
                _currentMode = FormMode.Detail;
                if (studentDetails != null)
                {
                    ShowFlyoutModePanel(_currentMode);
                    FillStudentDetailDto(studentDetails);
                }
            }
            else if (e.Column.FieldName == "Grades")
            {
                var gradeDetails = _gradeService.GetGradesByStudentId(student.Id);
                _currentMode = FormMode.None;
                if (gradeDetails != null)
                {
                    ShowFlyoutGridPanel(_currentMode, gradesGrid);
                    LoadGradesToGrid(gradeDetails);
                }
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEdit3.Text))
            {
                MessageBox.Show("Please enter a student number.");
                return;
            }

            _studentDto = _studentService.Get(x => x.Number == textEdit3.Text);
            if (_studentDto == null)
            {
                MessageBox.Show($"No student found this number: {textEdit3.Text}");
                return;
            }

            FillStudentDto(_studentDto);
            _studentUpdateDto = DtoHelper.CreateStudentUpdateDtoFromDto(_studentDto);

            if (_currentMode == FormMode.Update)
            {
                foreach (Control ctrl in TextGroup.Controls)
                {
                    ctrl.Enabled = true;
                    ctrl.Visible = true;
                    if (ctrl is TextEdit textEdit)
                        textEdit.ReadOnly = false;
                }
                deleteBtn.Visible = false;
                deleteBtn.Enabled = false;
            }
            else if (_currentMode == FormMode.Delete)
            {
                foreach (Control ctrl in TextGroup.Controls)
                {
                    ctrl.Visible = true;
                    ctrl.Enabled = false;
                    if (ctrl is TextEdit textEdit)
                        textEdit.ReadOnly = true;
                    if (ctrl == textEdit3 || ctrl == labelControl3 || ctrl == searchButton)
                    {
                        ctrl.Enabled = true;
                        ctrl.Visible = true;
                        continue;
                    }
                }
                textEdit3.ReadOnly = false;
                deleteBtn.Visible = true;
                deleteBtn.Enabled = true;
                btnClose.Visible = true;
                btnClose.Enabled = true;
            }
            gradesGrid.Visible = false;
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            bool result = DeleteStudent(_studentDto);
            if (result)
            {
                MessageBox.Show($"Student {_currentMode.ToString().ToLower()}ed successfully.");
                CloseFlyoutPanel();
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            var selectedClassDto = classInputLookup.GetSelectedDataRow() as ClassListDto;
            string className = selectedClassDto?.Name ?? "";

            bool result = _currentMode switch
            {
                FormMode.Add => AddStudent(textEdit1.Text, textEdit2.Text, textEdit3.Text, imageEdit1.Image, className),
                FormMode.Update when _studentUpdateDto != null => UpdateStudent(textEdit1.Text, textEdit2.Text, textEdit3.Text, imageEdit1.Image, className, _studentUpdateDto),
                _ => false
            };

            if (_currentMode == FormMode.Update && _studentUpdateDto == null)
            {
                MessageBox.Show(Messages.StudentNotSelected);
                return;
            }

            if (result)
            {
                MessageBox.Show(string.Format(Messages.OperationSuccessful, "Student", _currentMode.ToString().ToLower()));
                CloseFlyoutPanel();
            }
        }
        private void addButton_Click(object sender, EventArgs e) => ShowFlyoutModePanel(FormMode.Add);
        private void updateButton_Click(object sender, EventArgs e) => ShowFlyoutModePanel(FormMode.Update);
        private void deleteButton_Click(object sender, EventArgs e) => ShowFlyoutModePanel(FormMode.Delete);
        private void btnClose_Click(object sender, EventArgs e) => CloseFlyoutPanel();


        public void LoadClassList()
        {
            SetupClassGridLookUpEdit(classInputLookup);
            SetupClassGridLookUpEdit(classFilterLookup);
            overlayPanel.Visible = false;
            ResetView();
        }
        public void ShowClassStudents(string selectedClass, GridControl grid)
        {
            var classStudents = _studentService.GetAll(x => x.Class.Name == selectedClass);
            grid.DataSource = classStudents;
            CallStudentGrid(grid);
        }
        private bool AddStudent(string name, string surname, string number, Image photograph, string className)
        {
            try
            {
                var selectedClass = classInputLookup.GetSelectedDataRow() as ClassListDto;
                if (selectedClass == null)
                {
                    MessageBox.Show(string.Format(Messages.SelectItem, "class"));
                    return false;
                }

                var student = DtoHelper.CreateStudentAddDtoFromDto(
                    name, surname, number, ImageHelper.ToBase64(photograph), selectedClass.Id);
                _studentService.Add(student);
                DevExpToolHelper.ClearInputs(TextGroup);
                ShowClassStudents(className, StudentsGrid);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(Messages.OperationFailed, "Student", "add", ex.Message));
                return false;
            }
        }
        private bool UpdateStudent(string name, string surname, string number, Image photograph, string className, StudentUpdateDto student)
        {
            try
            {
                student.Name = string.IsNullOrWhiteSpace(name) ? student.Name : name;
                student.Surname = string.IsNullOrWhiteSpace(surname) ? student.Surname : surname;
                student.Number = string.IsNullOrWhiteSpace(number) ? student.Number : number;
                student.Photograph = photograph == null ? student.Photograph : ImageHelper.ToBase64(photograph);
                student.Class = string.IsNullOrWhiteSpace(className) ? student.Class : className;

                _studentService.Update(student);
                DevExpToolHelper.ClearInputs(TextGroup);
                ShowClassStudents(className, StudentsGrid);
                return true;
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException != null ? ex.InnerException.Message : Messages.InnerException;
                MessageBox.Show(string.Format(Messages.OperationFailed, "Student", "update", ex.Message + "\n" + inner));
                return false;
            }
        }
        private bool DeleteStudent(StudentDto student)
        {
            if (student == null)
            {
                MessageBox.Show(Messages.StudentNotSelected);
                return false;
            }

            var confirm = MessageBox.Show(
                string.Format(Messages.AreYouSureToDelete, student.Name + " " + student.Surname),
                Messages.ConfirmDeleteTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _studentService.Delete(student);
                    ShowClassStudents(student.Class, StudentsGrid);
                    DevExpToolHelper.ClearInputs(TextGroup);
                    _studentDto = null;
                    _studentUpdateDto = null;
                    deleteBtn.Enabled = true;
                    deleteBtn.Visible = true;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(Messages.OperationFailed, "Student", "delete", ex.Message));
                    return false;
                }
            }
            return false;
        }
        private void FillStudentDto(StudentDto dto)
        {
            textEdit1.Text = dto.Name;
            textEdit2.Text = dto.Surname;
            textEdit3.Text = dto.Number;
            imageEdit1.Image = string.IsNullOrWhiteSpace(dto.Photograph) ? null : ImageHelper.FromBase64(dto.Photograph);

            var selectedClass = _classService.GetAll().FirstOrDefault(c => c.Name == dto.Class);
            classInputLookup.EditValue = selectedClass?.Id;
        }
        private void FillStudentDetailDto(StudentDetailDto dto)
        {
            textEdit1.Text = dto.Name;
            textEdit2.Text = dto.Surname;
            textEdit3.Text = dto.Number;
            imageEdit1.Image = string.IsNullOrWhiteSpace(dto.Photograph) ? null : ImageHelper.FromBase64(dto.Photograph);
            checkEdit1.Checked = dto.IsPassed;
            var selectedClass = _classService.GetAll().FirstOrDefault(c => c.Name == dto.Class);
            classInputLookup.EditValue = selectedClass?.Id;
        }
        private void CallStudentGrid(GridControl grid)
        {
            var studentGradesIcon = "C:/Users/burcu/source/repos/BC.SchoolRegistrationApp/BC.SchoolRegistrationApp.UI/photos/icons/studentGrades.png";
            var studentDetailIcon = "C:/Users/burcu/source/repos/BC.SchoolRegistrationApp/BC.SchoolRegistrationApp.UI/photos/icons/studentInfo.png";
            if (grid.MainView is GridView gridView)
            {
                gridView.OptionsBehavior.Editable = false;
                gridView.OptionsBehavior.ReadOnly = false;
                gridView.PopulateColumns();
                gridView.Columns["Id"].Visible = false;

                if (gridView.Columns.ColumnByFieldName("Grades") == null)
                    DevExpToolHelper.AddButtonColumn(gridView, grid, "Grades", "Grades", studentGradesIcon);

                if (gridView.Columns.ColumnByFieldName("Detail") == null)
                    DevExpToolHelper.AddButtonColumn(gridView, grid, "Detail", "Detail", studentDetailIcon);
                
                gridView.RowCellClick -= StudentsGrid_RowCellClick;
                gridView.RowCellClick += StudentsGrid_RowCellClick;
                gridView.OptionsView.ColumnAutoWidth = true;
                gridView.BestFitColumns();
            }
        }
        private void SetupClassGridLookUpEdit(GridLookUpEdit gridLookUpEdit)
        {
            var classList = _classService.GetAll();
            gridLookUpEdit.Properties.DataSource = classList;
            gridLookUpEdit.Properties.DisplayMember = "Name";
            gridLookUpEdit.Properties.ValueMember = "Id";
            gridLookUpEdit.Properties.NullText = "Classes";
            gridLookUpEdit.EditValue = null;
            gridLookUpEdit.Properties.View.Columns.Clear();
            gridLookUpEdit.Properties.View.Columns.AddVisible("Name", "Class");
        }
        private void LoadGradesToGrid(List<GradeDetailDto> grades)
        {
            gradesGrid.DataSource = grades;

            if (gradesGrid.MainView is GridView gridView)
            {
                gridView.PopulateColumns();

                gridView.Columns["Id"].Visible = false;
                gridView.Columns["StudentId"].Visible = false;

                gridView.OptionsBehavior.Editable = false;
                gridView.OptionsView.ColumnAutoWidth = true;
                gridView.BestFitColumns();
            }
        }
        public void SetModeView()
        {
            DevExpToolHelper.ClearInputs(TextGroup);
            TextGroup.Visible = true;
            classFilterLookup.Enabled = false;
            if (_currentMode == FormMode.None)
            {
                foreach(Control ctrl in TextGroup.Controls)
                {
                    ctrl.Visible = false;
                    ctrl.Enabled = false;
                }
            }
            else if (_currentMode == FormMode.Add)
            {
                foreach (Control ctrl in TextGroup.Controls)
                {
                    ctrl.Visible = true;
                    ctrl.Enabled = true;
                    if (ctrl is TextEdit textEdit)
                        textEdit.ReadOnly = false;
                    if (ctrl == searchButton || ctrl == deleteBtn || ctrl == searchButton || ctrl == checkEdit1 || ctrl== gradesGrid)
                    {
                        ctrl.Enabled = false;
                        ctrl.Visible = false;
                        continue;
                    }
                }
            }
            else if (_currentMode == FormMode.Update || _currentMode == FormMode.Delete)
            {
                foreach (Control ctrl in TextGroup.Controls)
                {
                    ctrl.Visible = false;
                    ctrl.Enabled = false;
                    if (ctrl == textEdit3 || ctrl == labelControl3 || ctrl == searchButton)
                    {
                        ctrl.Enabled = true;
                        ctrl.Visible = true;
                        continue;
                    }
                }
                gradesGrid.Visible = false;
            }
            else if (_currentMode == FormMode.Detail)
            {
                foreach(Control ctrl in TextGroup.Controls)
                {
                    ctrl.Visible = true;
                    ctrl.Enabled = false;
                    if (ctrl is TextEdit textEdit)
                        textEdit.ReadOnly = true;
                    if (ctrl == deleteBtn || ctrl == Save  || ctrl == searchButton)
                    {
                        ctrl.Enabled = false;
                        ctrl.Visible = false;
                        continue;
                    }
                }
                gradesGrid.Visible = false;
            }
            btnClose.Visible = true;
            btnClose.Enabled = true;
        }
        public void ResetView()
        {
            TextGroup.Visible = false;
            StudentsGrid.Visible = true;
            classFilterLookup.Visible = true;
            classFilterLookup.Enabled = true;
            overlayPanel.Visible = false;
            gradesGrid.Visible = false;
        }

        private void ShowFlyoutModePanel(FormMode mode)
        {
            _currentMode = mode;
            SetFormMode(_currentMode);
            SetModeView();

            overlayPanel.Visible = true;
            overlayPanel.BringToFront();

            crudFlyoutPanel.OwnerControl = this;
            crudFlyoutPanel.ShowPopup();
        }
        private void ShowFlyoutGridPanel(FormMode mode, Control control)
        {
            _currentMode = mode;
            SetFormMode(_currentMode);
            SetModeView();

            control.Visible = true;
            control.Enabled = true;

            overlayPanel.Visible = true;
            overlayPanel.BringToFront();

            crudFlyoutPanel.OwnerControl = this;
            crudFlyoutPanel.ShowPopup();
        }
        public void CloseFlyoutPanel()
        {
            
            crudFlyoutPanel.HidePopup();
            ResetView();
        }
    }
}
