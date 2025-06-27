using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Context;
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
        private Student selectedStudent = null;
        Home home;

        public FrmStudents(IClassService classService, IStudentService studentService, FormMode currentMode)
        {
            InitializeComponent();
            _classService = classService;
            _studentService = studentService;
            _currentMode = currentMode;
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ResetView();

            var classNames = _classService.GetClassNames();
            ClassForList.Properties.Items.Clear();
            ClassForList.Properties.Items.AddRange(classNames);
            ClassForAdd.Properties.Items.Clear();
            ClassForAdd.Properties.Items.AddRange(classNames);
            var students = _studentService.GetAll();
            StudentsGrid.DataSource = students;
        }

        private void ClassForList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowClassStudents(ClassForList.SelectedItem.ToString(),StudentsGrid);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentMode == FormMode.Add)
                {
                    if (!FormHelper.HasEmptyFields(textEdit1.Text, textEdit2.Text, textEdit3.Text, ClassForAdd.SelectedItem))
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

        private bool AddStudent(string name, string surname, string number, Image photograph, string _class)
        {
            try
            {
                string base64Photo = ImageHelper.ToBase64(photograph);
                int selectedClassId = _classService.GetIDByName(_class);
                var student = new Student()
                {
                    Name = name,
                    Surname = surname,
                    Number = number,
                    Photograph = base64Photo,
                    ClassID = selectedClassId
                };
                _studentService.Add(student);
                FormHelper.ClearInputs(TextGroup);
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

        public void ShowTextGroupView()
        {
            TextGroup.Visible = true;
            StudentsGrid.Visible = false;
            ClassForList.Visible = false;
            AddUpdateDeleteGrid.Visible = true;
        }
        public void ResetView()
        {
            TextGroup.Visible = false;
            StudentsGrid.Visible = true;
            ClassForList.Visible = true;
            AddUpdateDeleteGrid.Visible = false;
        }
        public void ShowClassStudents(string selectedClass, GridControl grid)
        {
            var classStudents = _studentService.GetStudentsByClassName(selectedClass);
            grid.DataSource = classStudents;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEdit3.Text))
            {
                MessageBox.Show("Please enter a student number.");
                return;
            }

            selectedStudent = _studentService.GetAll(x => x.Number == textEdit3.Text).FirstOrDefault();

            if (selectedStudent == null)
            {
                MessageBox.Show($"No student found with number: {textEdit3.Text}");
                return;
            }

            textEdit1.Text = selectedStudent.Name;
            textEdit2.Text = selectedStudent.Surname;
            textEdit3.Text = selectedStudent.Number;
            imageEdit1.Image = ImageHelper.FromBase64(selectedStudent.Photograph);
            ClassForAdd.SelectedItem = _classService.GetById(selectedStudent.ClassID).Name;
        }
        private bool UpdateStudent(string name, string surname, string number, Image photograph, string _class, Student student)
        {
            try
            {
                student.Name = string.IsNullOrWhiteSpace(name) ? student.Name : name;
                student.Surname = string.IsNullOrWhiteSpace(surname) ? student.Surname : surname;
                student.Number = string.IsNullOrWhiteSpace(number) ? student.Number : number;
                student.Photograph = photograph == null ? student.Photograph : ImageHelper.ToBase64(photograph);
                student.ClassID = string.IsNullOrWhiteSpace(_class) ? student.ClassID : _classService.GetIDByName(_class);
                _studentService.Update(student);
                FormHelper.ClearInputs(TextGroup);
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

    }
}