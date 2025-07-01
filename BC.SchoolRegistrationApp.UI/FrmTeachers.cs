using BC.SchoolRegistrationApp.BL.Service;
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

namespace BC.SchoolRegistrationApp.UI
{
    public partial class FrmTeachers : DevExpress.XtraEditors.XtraForm
    {
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
            TeachersGrid.DataSource = _teacherService.GetAll();
        }
    }
}