using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.Dto.Concrete.Class;
using BC.SchoolRegistrationApp.Dto.Concrete.Student;
using BC.SchoolRegistrationApp.UI.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ResetView();
            LoadClassList();
            StudentsGrid.DataSource = _studentService.GetAll();
        }
        private void ListClass_EditValueChanged(object sender, EventArgs e)
        {
            var selectedClassDto = ListClass.GetSelectedDataRow() as ClassListDto;
            if (selectedClassDto != null)
            {
                ShowClassStudents(selectedClassDto.Name, StudentsGrid);
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentMode == FormMode.Add)
                {
                    var selectedClassDto = ListClass2.GetSelectedDataRow() as ClassListDto;
                    string className = selectedClassDto != null ? selectedClassDto.Name : "";
                    if (EditToolHelper.HasEmptyFields(textEdit1.Text, textEdit2.Text, textEdit3.Text, ListClass2.EditValue))
                        return;


                    bool resultAdd = AddStudent(textEdit1.Text, textEdit2.Text, textEdit3.Text, imageEdit1.Image, className);
                    if (resultAdd)
                        MessageBox.Show("Student added successfully.");
                }
                else if (_currentMode == FormMode.Update)
                {
                    var selectedClassDto = ListClass2.GetSelectedDataRow() as ClassListDto;
                    string className = selectedClassDto != null ? selectedClassDto.Name : "";
                    if (_studentUpdateDto == null)
                    {
                        MessageBox.Show("Please search for a student before updating.");
                        return;
                    }
                    bool resultUpdate = UpdateStudent(textEdit1.Text, textEdit2.Text, textEdit3.Text, imageEdit1.Image, className, _studentUpdateDto);
                    if (resultUpdate)
                        MessageBox.Show("Student updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

            textEdit1.Text = _studentDto.Name;
            textEdit2.Text = _studentDto.Surname;
            textEdit3.Text = _studentDto.Number;
            imageEdit1.Image = ImageHelper.FromBase64(_studentDto.Photograph);

            var classList = _classService.GetAll();
            var selectedClass = classList.FirstOrDefault(c => c.Name == _studentDto.ClassName);
            if (selectedClass != null)
                ListClass2.EditValue = selectedClass.Id;
            else
                ListClass2.EditValue = null;

            AddUpdateDeleteGrid.DataSource = new List<StudentDto> { _studentDto };
            _studentUpdateDto = new StudentUpdateDto
            {
                Id= _studentDto.Id,
                Name = _studentDto.Name,
                Surname = _studentDto.Surname,
                Number = _studentDto.Number,
                Photograph = _studentDto.Photograph,
                ClassName = _studentDto.ClassName
            };
        }

        private void AddUpdateDeleteGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = AddUpdateDeleteGrid.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (gridView == null) return;

                var student = gridView.GetFocusedRow() as StudentDto;
                if (student == null)
                    throw new Exception("No student selected.");

                if (_currentMode == FormMode.Delete)
                {
                    var confirm = MessageBox.Show($"Are you sure you want to delete {student.Name} {student.Surname}?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        _studentService.Delete(student);
                        MessageBox.Show("Student deleted successfully.");
                        ShowClassStudents(student.ClassName, AddUpdateDeleteGrid);
                        EditToolHelper.ClearInputs(TextGroup);
                    }
                }
                else if (_currentMode == FormMode.Update)
                {
                    textEdit1.Text = student.Name;
                    textEdit2.Text = student.Surname;
                    textEdit3.Text = student.Number;
                    imageEdit1.Image = string.IsNullOrWhiteSpace(student.Photograph) ? null : ImageHelper.FromBase64(student.Photograph);

                    var classList = _classService.GetAll();
                    var selectedClass = classList.FirstOrDefault(x => x.Name == student.ClassName);
                    if (selectedClass != null)
                        ListClass2.EditValue = selectedClass.Id;
                    else
                        ListClass2.EditValue = null;
                    AddUpdateDeleteGrid.DataSource = new List<StudentDto> { student };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AddStudent(string name, string surname, string number, Image photograph, string _class)
        {
            try
            {
                string base64Photo = ImageHelper.ToBase64(photograph);
                var student = new StudentAddDto()
                {
                    Name = name,
                    Surname = surname,
                    Number = number,
                    Photograph = base64Photo,
                    ClassName = _class
                };
                _studentService.Add(student);
                EditToolHelper.ClearInputs(TextGroup);
                ShowClassStudents(_class, AddUpdateDeleteGrid);
                return true;
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException != null ? ex.InnerException.Message : "No inner exception";
                MessageBox.Show("Student hasn't been added. Error: " + ex.Message + "\nInner exception: " + inner);
                return false;
            }
        }

        private bool UpdateStudent(string name, string surname, string number, Image photograph, string _class, StudentUpdateDto student)
        {
            try
            {
                student.Name = string.IsNullOrWhiteSpace(name) ? student.Name : name;
                student.Surname = string.IsNullOrWhiteSpace(surname) ? student.Surname : surname;
                student.Number = string.IsNullOrWhiteSpace(number) ? student.Number : number;
                student.Photograph = photograph == null ? student.Photograph : ImageHelper.ToBase64(photograph);
                student.ClassName = string.IsNullOrWhiteSpace(_class) ? student.ClassName : _class;

                _studentService.Update(student); 
                EditToolHelper.ClearInputs(TextGroup);
                ShowClassStudents(_class, AddUpdateDeleteGrid);
                return true;
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException != null ? ex.InnerException.Message : "No inner exception";
                MessageBox.Show("Student hasn't been updated. Error: " + ex.Message + "\nInner exception: " + inner);
                return false;
            }
        }
        private void SetupClassGridLookUpEdit(DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit)
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

            searchButton.Visible = _currentMode == FormMode.Add ? false : true;

            bool editView = _currentMode != FormMode.Delete;

            labelControl5.Visible = editView;
            ListClass2.Visible = editView;
            labelControl1.Visible = editView;
            textEdit1.Visible = editView;
            labelControl2.Visible = editView;
            textEdit2.Visible = editView;
            labelControl3.Visible = true;
            textEdit3.Visible = true;
            labelControl4.Visible = editView;
            imageEdit1.Visible = editView;
        }

        public void ResetView()
        {
            TextGroup.Visible = false;
            StudentsGrid.Visible = true;
            ListClass.Visible = true;
            AddUpdateDeleteGrid.Visible = false;
            searchButton.Visible = false;
        }

        public void ShowClassStudents(string selectedClass, GridControl grid)
        {
            var classStudents = _studentService.GetAll(x => x.Class.Name == selectedClass);
            grid.DataSource = classStudents;
        }


    }
}
