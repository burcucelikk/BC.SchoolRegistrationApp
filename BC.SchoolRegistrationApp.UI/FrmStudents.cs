using BC.SchoolRegistrationApp.DAL.Context;
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
    public partial class FrmStudents : DevExpress.XtraEditors.XtraForm
    {
        AppDbContext dbContext;
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ResetView();
        }

        private void ClassForList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedClass = ClassForList.SelectedItem.ToString();
            var students = dbContext.Students;
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