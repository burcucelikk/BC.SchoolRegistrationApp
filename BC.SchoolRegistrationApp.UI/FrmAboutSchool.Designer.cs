namespace BC.SchoolRegistrationApp.UI
{
    partial class FrmAboutSchool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SchoolImages = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)SchoolImages).BeginInit();
            SuspendLayout();
            // 
            // SchoolImages
            // 
            SchoolImages.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            SchoolImages.AllowLooping = true;
            SchoolImages.AnimationTime = 300;
            SchoolImages.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            SchoolImages.AutoSlideInterval = 3000;
            SchoolImages.Location = new System.Drawing.Point(234, 12);
            SchoolImages.Name = "SchoolImages";
            SchoolImages.Size = new System.Drawing.Size(419, 219);
            SchoolImages.TabIndex = 0;
            SchoolImages.Text = "ımageSlider1";
            // 
            // FrmAboutSchool
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(868, 377);
            Controls.Add(SchoolImages);
            Name = "FrmAboutSchool";
            Text = "FrmAboutSchool";
            Load += FrmAboutSchool_Load;
            ((System.ComponentModel.ISupportInitialize)SchoolImages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider SchoolImages;
    }
}