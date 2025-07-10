using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.Dto.Concrete.Student;
using DevExpress.XtraEditors;
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
    public partial class FrmExams : DevExpress.XtraEditors.XtraForm
    {
        private readonly IClassService _classService;
        private readonly IStudentService _studentService;

        private FormMode _currentMode;
        private StudentListDto _studentListDto = null;
        private StudentAddDto _studentAddDto = null;
        private StudentUpdateDto _studentUpdateDto = null;
        private StudentDto _studentDto = null;
        private Home home;
        private FrmStudents frmStudents;
        public FrmExams()
        {
            InitializeComponent();
        }

        private void FrmExams_Load(object sender, EventArgs e)
        {
            frmStudents.LoadClassList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}