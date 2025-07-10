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
    public partial class FrmGrades : DevExpress.XtraEditors.XtraForm
    {
        private FrmStudents frmStudents;
        public FrmGrades()
        {
            InitializeComponent();
        }

        private void FrmGrades_Load(object sender, EventArgs e)
        {
            frmStudents.LoadClassList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEdit4.Text))
            {
                MessageBox.Show("Please enter a student number.");
                return;
            }
        }
    }
}