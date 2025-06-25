using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Context;
using BC.SchoolRegistrationApp.Entity.Entities;
using DevExpress.Utils.Helpers;
using DevExpress.XtraEditors;
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

namespace BC.SchoolRegistrationApp.UI
{
    public partial class FrmStudents : DevExpress.XtraEditors.XtraForm
    {
        private readonly IClassService _classService;
        private readonly IStudentService _studentService;

        Home home;
        public enum FormMode
        {
            Add,
            Update,
            Delete
        }

        public FrmStudents(IClassService classService, IStudentService studentService)
        {
            InitializeComponent();
            _classService = classService;
            _studentService = studentService;
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
            var selectedClass = ClassForList.SelectedItem.ToString();
            var classStudents = _studentService.GetStudentsByClassName(selectedClass);
            StudentsGrid.DataSource = classStudents;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                var resultAdd= AddStudent(textEdit1.Text, textEdit2.Text, textEdit3.Text, imageEdit1.Image, ClassForAdd.SelectedItem.ToString());
                if(resultAdd)
                    MessageBox.Show("Öğrenci başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearTextGroupInputs()
        {
            foreach (Control control in TextGroup.Controls)
            {
                if (control is TextEdit textEdit)
                    textEdit.Text = string.Empty;

                else if (control is ComboBoxEdit comboBoxEdit)
                    comboBoxEdit.SelectedIndex = -1;

                else if (control is ImageEdit imageEdit)
                    imageEdit.Image = null;
            }
        }
        private bool AddStudent(string name, string surname, string number, Image photograph, string _class)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textEdit1.Text) || string.IsNullOrWhiteSpace(textEdit2.Text) || string.IsNullOrWhiteSpace(textEdit3.Text) || ClassForAdd.SelectedItem.ToString() == null)
                {
                    MessageBox.Show("Boş alanları doldurunuz.");
                    return false;
                }
                else
                {
                    string base64Photo = "";
                    if(photograph != null)
                    {
                        using (MemoryStream memory=new MemoryStream())
                        {
                            photograph.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);
                            base64Photo= Convert.ToBase64String(memory.ToArray());
                        }
                    }
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
                    ClearTextGroupInputs();
                    AddUpdateDeleteGrid.DataSource = _studentService.GetStudentsByClassName(_class);
                    return true;
                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException != null ? ex.InnerException.Message : "No inner exception";
                MessageBox.Show("Student hasn't been added. Error: " + ex.Message + "\nInner exception: " + inner);
                return false;
            }
        }
        private void UpdateStudent(string name, string surname, string number, string _class)
        {

        }
        public void ShowAddView()
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
    }
}