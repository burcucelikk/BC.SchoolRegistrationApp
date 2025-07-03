using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Context;
using BC.SchoolRegistrationApp.Dto.Concrete;
using BC.SchoolRegistrationApp.Entity.Entities;
using BC.SchoolRegistrationApp.UI.Helpers;
using DevExpress.CodeParser;
using DevExpress.Utils.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraScheduler.Outlook.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public void SetFormMode(FormMode mode)
        {
            _currentMode = mode;
        }
        private readonly IClassService _classService;
        private readonly IStudentService _studentService;

        private FormMode _currentMode;
        private StudentDto selectedStudent = null;
        private Home home;

        public FrmStudents(IClassService classService, IStudentService studentService)
        {
            InitializeComponent();
            _classService = classService;
            _studentService = studentService;
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ResetView();
            LoadClassList();
            StudentsGrid.DataSource = _studentService.GetAll();
        }
        private void ClassForList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowClassStudents(ClassForList.SelectedItem.ToString(), StudentsGrid);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentMode == FormMode.Add)
                {
                    if (!EditToolHelper.HasEmptyFields(textEdit1.Text, textEdit2.Text, textEdit3.Text, ClassForAdd.SelectedItem))
                    { return; }
                    else
                    {
                        var resultAdd = AddStudent(textEdit1.Text, textEdit2.Text, textEdit3.Text, imageEdit1.Image, ClassForAdd.SelectedItem.ToString());
                        if (resultAdd)
                            MessageBox.Show("Student added successfully.");
                    }
                }
                else if (_currentMode == FormMode.Update)
                {
                    if (selectedStudent == null)
                    {
                        MessageBox.Show("Please search for a student before updating.");
                        return;
                    }

                    var resultUpdate = UpdateStudent(textEdit1.Text, textEdit2.Text, textEdit3.Text, imageEdit1.Image, ClassForAdd.SelectedItem.ToString(), selectedStudent);
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

            selectedStudent = _studentService.Get(x => x.Number == textEdit3.Text);

            if (selectedStudent == null)
            {
                MessageBox.Show($"No student found with number: {textEdit3.Text}");
                return;
            }

            textEdit1.Text = selectedStudent.Name;
            textEdit2.Text = selectedStudent.Surname;
            textEdit3.Text = selectedStudent.Number;
            imageEdit1.Image = ImageHelper.FromBase64(selectedStudent.Photograph);
            ClassForAdd.SelectedItem = selectedStudent.ClassName;
            AddUpdateDeleteGrid.DataSource = new List<StudentDto> { selectedStudent };
        }
        private void AddUpdateDeleteGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = AddUpdateDeleteGrid.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (gridView == null)
                    return;
                var student = gridView.GetFocusedRow() as StudentDto;
                if (student == null)
                    throw new Exception("No student selected");
                if (_currentMode == FormMode.Delete) 
                {
                    var confirm = MessageBox.Show( $"Are you sure you want to delete {student.Name} {student.Surname}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

                    if (confirm == DialogResult.Yes)
                    {
                        _studentService.Delete(student);
                        MessageBox.Show("Student deleted successfully.");
                        ShowClassStudents(student.ClassName, AddUpdateDeleteGrid);
                    }
                }
                else if (_currentMode == FormMode.Update)
                {
                    selectedStudent = student;
                    textEdit1.Text = student.Name;
                    textEdit2.Text = student.Surname;
                    textEdit3.Text = student.Number;
                    imageEdit1.Image = ImageHelper.FromBase64(student.Photograph);
                    ClassForAdd.SelectedItem = student.ClassName;
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
                var student = new StudentDto()
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
        private bool UpdateStudent(string name, string surname, string number, Image photograph, string _class, StudentDto student)
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
                MessageBox.Show("Student hasn't been added. Error: " + ex.Message + "\nInner exception: " + inner);
                return false;
            }
        }
        public void LoadClassList()
        {
            ClassForList.Properties.Items.Clear();
            ClassForAdd.Properties.Items.Clear();
            var classNames = _classService.GetClassNames();
            ClassForList.Properties.Items.AddRange(classNames);
            ClassForAdd.Properties.Items.AddRange(classNames);
        }
        public void SetModeView()
        {
            EditToolHelper.ClearInputs(TextGroup);
            AddUpdateDeleteGrid.DataSource = null;
            TextGroup.Visible = true;
            StudentsGrid.Visible = false;
            ClassForList.Visible = false;
            AddUpdateDeleteGrid.Visible = true;
            searchButton.Visible = _currentMode == FormMode.Add ? false : true;
            bool editView = _currentMode != FormMode.Delete;
            labelControl5.Visible = editView;
            ClassForAdd.Visible = editView;
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
            ClassForList.Visible = true;
            AddUpdateDeleteGrid.Visible = false;
            searchButton.Visible = false;
        }

        public void ShowClassStudents(string selectedClass, GridControl grid)
        {
            var classStudents = _studentService.GetAll(x=>x.Class.Name==selectedClass);
            grid.DataSource = classStudents;
        }
    }
}