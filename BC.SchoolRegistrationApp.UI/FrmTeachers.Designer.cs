namespace BC.SchoolRegistrationApp.UI
{
    partial class FrmTeachers
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
            TeachersGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)TeachersGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // TeachersGrid
            // 
            TeachersGrid.Location = new System.Drawing.Point(1, -1);
            TeachersGrid.MainView = gridView1;
            TeachersGrid.Name = "TeachersGrid";
            TeachersGrid.Size = new System.Drawing.Size(868, 368);
            TeachersGrid.TabIndex = 0;
            TeachersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = TeachersGrid;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FrmTeachers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(868, 377);
            Controls.Add(TeachersGrid);
            Name = "FrmTeachers";
            Text = "Teachers";
            Load += FrmTeachers_Load;
            ((System.ComponentModel.ISupportInitialize)TeachersGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl TeachersGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}