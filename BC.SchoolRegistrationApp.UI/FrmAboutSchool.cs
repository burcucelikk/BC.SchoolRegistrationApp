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
    public partial class FrmAboutSchool : DevExpress.XtraEditors.XtraForm
    {
        public FrmAboutSchool()
        {
            InitializeComponent();
        }

        private void FrmAboutSchool_Load(object sender, EventArgs e)
        {
            LoadImagetoSlider();
        }
        private void LoadImagetoSlider()
        {
            string folderPath = @"C:/Users/burcu/source/repos/BC.SchoolRegistrationApp/BC.SchoolRegistrationApp.UI/photos/school";

            if(!Directory.Exists(folderPath))
                return;

            var imageFiles = Directory.GetFiles(folderPath,"*.jpg");
            SchoolImages.Images.Clear();
            foreach(var imageFile in imageFiles)
            {
                try
                {
                    SchoolImages.Images.Add(Image.FromFile(imageFile));
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Resim yüklenemedi: " + ex.Message);
                }
            }
        }
    }
}