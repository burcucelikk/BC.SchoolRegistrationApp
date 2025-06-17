using DevExpress.XtraBars;
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
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        FrmStudents frmStudents;
        FrmAboutSchool frmAboutSchool;
        public Home()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAboutForm();
            
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowStudentsForm();
            frmStudents.ResetView();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ShowAboutForm();
        }
        private void ShowStudentsForm()
        {
            if (frmStudents == null || frmStudents.IsDisposed)
            {
                frmStudents = new FrmStudents();
                frmStudents.MdiParent = this;
                frmStudents.Show();
            }
            else
                frmStudents.BringToFront();
        }
        private void ShowAboutForm()
        {
            if (frmAboutSchool == null || frmAboutSchool.IsDisposed)
            {
                frmAboutSchool = new FrmAboutSchool();
                frmAboutSchool.MdiParent = this;
                frmAboutSchool.Show();
            }
            else
                frmAboutSchool.BringToFront();
        }
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmStudents != null && !frmStudents.IsDisposed)
            {
                frmStudents.ShowAddView(); // Add işlemi için görünümü değiştir
                frmStudents.BringToFront(); // Öğrenci formunu en öne getir
            }
            else
            {
                // Eğer form açık değilse önce aç, sonra ShowAddView uygula
                ShowStudentsForm();
                frmStudents.ShowAddView();
            }
        }
    }
}