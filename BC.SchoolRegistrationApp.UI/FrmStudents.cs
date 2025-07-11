using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.Dto.Concrete.Class;
using BC.SchoolRegistrationApp.Dto.Concrete.Student;
using BC.SchoolRegistrationApp.UI.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
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
        public enum FormMode
        {
            Add,
            Update,
            Delete
        }

        private FormMode _currentMode;
        private readonly IClassService _classService;
        private readonly IStudentService _studentService;

        private StudentUpdateDto _studentUpdateDto = null;
        private StudentDto _studentDto = new StudentDto();

        public FrmStudents(IClassService classService, IStudentService studentService)
        {
            InitializeComponent();
            _classService = classService;
            _studentService = studentService;
        }

        public void SetFormMode(FormMode mode)
        {
            _currentMode = mode;
            EditToolHelper.ClearInputs(TextGroup);
            ListClass2.Properties.NullText = "Classes";
            ListClass2.EditValue = null;
            _studentUpdateDto = null;
        }
        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ResetView();
            LoadClassList();
            StudentsGrid.DataSource = _studentService.GetAll();
            CallStudentGrid(StudentsGrid);
        }
        private void ListClass_EditValueChanged(object sender, EventArgs e)
        {
            var selectedClassDto = ListClass.GetSelectedDataRow() as ClassListDto;
            if (selectedClassDto != null)
                ShowClassStudents(selectedClassDto.Name, StudentsGrid);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            var selectedClassDto = ListClass2.GetSelectedDataRow() as ClassListDto;
            string className = selectedClassDto != null ? selectedClassDto.Name : "";
            bool result = _currentMode switch
            {
                FormMode.Add => AddStudent(textEdit1.Text, textEdit2.Text, textEdit3.Text, imageEdit1.Image, className),
                FormMode.Update when _studentUpdateDto != null =>
                    UpdateStudent(textEdit1.Text, textEdit2.Text, textEdit3.Text, imageEdit1.Image, className, _studentUpdateDto),
                _ => false
            };

            if (_currentMode == FormMode.Update && _studentUpdateDto == null)
            {
                MessageBox.Show("Please search for a student before updating.");
                return;
            }

            if (result)
                MessageBox.Show($"Student {_currentMode.ToString().ToLower()}ed successfully.");
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

            FillFormFromStudentDto(_studentDto);
            AddUpdateDeleteGrid.DataSource = new List<StudentDto> { _studentDto };
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
                deleteButton.Visible = false;
                deleteButton.Enabled = false;
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
                deleteButton.Visible = true;
                deleteButton.Enabled = true;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteStudent(_studentDto);
        }
        private void AddUpdateDeleteGrid_DoubleClick(object sender, EventArgs e)
        {
            var gridView = AddUpdateDeleteGrid.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView == null) return;

            var student = gridView.GetFocusedRow() as StudentDto;
            DeleteStudent(_studentDto);
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
        public void LoadClassList()
        {
            SetupClassGridLookUpEdit(ListClass);
            SetupClassGridLookUpEdit(ListClass2);
        }
        public void SetModeView()
        {
            EditToolHelper.ClearInputs(TextGroup);
            AddUpdateDeleteGrid.DataSource = null;

            TextGroup.Visible = true;
            StudentsGrid.Visible = false;
            ListClass.Visible = false;
            AddUpdateDeleteGrid.Visible = true;
            if (_currentMode == FormMode.Add)
            {
                foreach (Control ctrl in TextGroup.Controls)
                {
                    ctrl.Visible = true;
                    ctrl.Enabled = true;
                    if (ctrl is TextEdit textEdit)
                        textEdit.ReadOnly = false;
                }
                searchButton.Visible = false;
                deleteButton.Visible = false;
                deleteButton.Enabled = false;
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
            }
        }
        public void ResetView()
        {
            TextGroup.Visible = false;
            StudentsGrid.Visible = true;
            ListClass.Visible = true;
            AddUpdateDeleteGrid.Visible = false;
        }
        public void ShowClassStudents(string selectedClass, GridControl grid)
        {
            var classStudents = _studentService.GetAll(x => x.Class.Name == selectedClass);
            grid.DataSource = classStudents;
            CallStudentGrid(grid);
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

                if (gridView.Columns["Id"] != null)
                    gridView.Columns["Id"].Visible = false;

                if (gridView.Columns["colDetail"] == null)
                {
                    EditToolHelper.AddButtonColumn(gridView, grid, "Grades", "Grades", studentGradesIcon);
                    EditToolHelper.AddButtonColumn(gridView, grid, "Detail", "Detail", studentDetailIcon);
                    gridView.RowCellClick += StudentsGrid_RowCellDoubleClick;
                }
            }
        }
        private void FillFormFromStudentDto(StudentDto dto)
        {
            textEdit1.Text = dto.Name;
            textEdit2.Text = dto.Surname;
            textEdit3.Text = dto.Number;
            imageEdit1.Image = string.IsNullOrWhiteSpace(dto.Photograph) ? null : ImageHelper.FromBase64(dto.Photograph);

            var classList = _classService.GetAll();
            var selectedClass = classList.FirstOrDefault(c => c.Name == dto.ClassName);
            ListClass2.EditValue = selectedClass?.Id;
        }
        private bool AddStudent(string name, string surname, string number, Image photograph, string className)
        {
            try
            {
                string base64Photo = ImageHelper.ToBase64(photograph);
                var student = DtoHelper.CreateStudentAddDtoFromDto(name, surname, number, base64Photo, className);
                _studentService.Add(student);
                EditToolHelper.ClearInputs(TextGroup);
                ShowClassStudents(className, AddUpdateDeleteGrid);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student hasn't been added. Error: " + ex.Message);
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
                student.ClassName = string.IsNullOrWhiteSpace(className) ? student.ClassName : className;

                _studentService.Update(student);
                EditToolHelper.ClearInputs(TextGroup);
                ShowClassStudents(className, AddUpdateDeleteGrid);
                return true;
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException != null ? ex.InnerException.Message : "No inner exception";
                MessageBox.Show("Student hasn't been updated. Error: " + ex.Message + "\nInner exception: " + inner);
                return false;
            }
        }
        private void DeleteStudent(StudentDto student)
        {
            if (student == null)
            {
                MessageBox.Show("No student selected.");
                return;
            }

            var confirm = MessageBox.Show($"Are you sure you want to delete {student.Name} {student.Surname}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _studentService.Delete(student);
                    MessageBox.Show("Student deleted successfully.");
                    ShowClassStudents(student.ClassName, AddUpdateDeleteGrid);
                    EditToolHelper.ClearInputs(TextGroup);
                    _studentDto = null;
                    _studentUpdateDto = null;
                    deleteButton.Enabled = true;
                    deleteButton.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the student:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void StudentsGrid_RowCellDoubleClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "Detail")
            {
                var view = sender as GridView;
                var student = view.GetRow(e.RowHandle) as StudentListDto;

                if (student != null)
                {
                    MessageBox.Show($"Detay açılacak: {student.Name} {student.Surname}");
                }
            }
            else if (e.Column.FieldName == "Grades")
            {
                var view = sender as GridView;
                var student = view.GetRow(e.RowHandle) as StudentListDto;

                if (student != null)
                {
                    MessageBox.Show($"Notlar açılacak: {student.Name} {student.Surname}");
                }
            }
        }
    }
}
