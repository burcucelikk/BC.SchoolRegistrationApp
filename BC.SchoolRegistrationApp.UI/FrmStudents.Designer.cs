namespace BC.SchoolRegistrationApp.UI
{
    partial class FrmStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudents));
            StudentsGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ClassForList = new DevExpress.XtraEditors.ComboBoxEdit();
            TextGroup = new DevExpress.XtraEditors.GroupControl();
            imageEdit1 = new DevExpress.XtraEditors.ImageEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            Save = new DevExpress.XtraEditors.SimpleButton();
            ClassForAdd = new DevExpress.XtraEditors.ComboBoxEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            AddUpdateDeleteGrid = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClassForList.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TextGroup).BeginInit();
            TextGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClassForAdd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddUpdateDeleteGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            SuspendLayout();
            // 
            // StudentsGrid
            // 
            StudentsGrid.Location = new System.Drawing.Point(3, 2);
            StudentsGrid.MainView = gridView1;
            StudentsGrid.Name = "StudentsGrid";
            StudentsGrid.Size = new System.Drawing.Size(864, 373);
            StudentsGrid.TabIndex = 8;
            StudentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = StudentsGrid;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ClassForList
            // 
            ClassForList.Location = new System.Drawing.Point(740, 7);
            ClassForList.Name = "ClassForList";
            ClassForList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ClassForList.Size = new System.Drawing.Size(127, 22);
            ClassForList.TabIndex = 9;
            ClassForList.SelectedIndexChanged += ClassForList_SelectedIndexChanged;
            // 
            // TextGroup
            // 
            TextGroup.Controls.Add(imageEdit1);
            TextGroup.Controls.Add(labelControl5);
            TextGroup.Controls.Add(labelControl4);
            TextGroup.Controls.Add(labelControl3);
            TextGroup.Controls.Add(labelControl2);
            TextGroup.Controls.Add(labelControl1);
            TextGroup.Controls.Add(Save);
            TextGroup.Controls.Add(ClassForAdd);
            TextGroup.Controls.Add(textEdit3);
            TextGroup.Controls.Add(textEdit2);
            TextGroup.Controls.Add(textEdit1);
            TextGroup.Location = new System.Drawing.Point(3, 2);
            TextGroup.Name = "TextGroup";
            TextGroup.Size = new System.Drawing.Size(395, 373);
            TextGroup.TabIndex = 10;
            // 
            // imageEdit1
            // 
            imageEdit1.Location = new System.Drawing.Point(128, 148);
            imageEdit1.Name = "imageEdit1";
            imageEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            imageEdit1.Size = new System.Drawing.Size(156, 22);
            imageEdit1.TabIndex = 11;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(78, 39);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(47, 16);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "CLASS: ";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(33, 148);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(89, 16);
            labelControl4.TabIndex = 9;
            labelControl4.Text = "PHOTOGRAPH: ";
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(65, 122);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(57, 16);
            labelControl3.TabIndex = 8;
            labelControl3.Text = "NUMBER: ";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(56, 94);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(66, 16);
            labelControl2.TabIndex = 7;
            labelControl2.Text = "SURNAME: ";
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(80, 67);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(42, 16);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "NAME: ";
            // 
            // Save
            // 
            Save.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Save.Appearance.Options.UseFont = true;
            Save.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("Save.ImageOptions.Image");
            Save.Location = new System.Drawing.Point(151, 299);
            Save.Name = "Save";
            Save.Size = new System.Drawing.Size(105, 36);
            Save.TabIndex = 5;
            Save.Text = "SAVE";
            Save.Click += Save_Click;
            // 
            // ClassForAdd
            // 
            ClassForAdd.Location = new System.Drawing.Point(128, 36);
            ClassForAdd.Name = "ClassForAdd";
            ClassForAdd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ClassForAdd.Size = new System.Drawing.Size(156, 22);
            ClassForAdd.TabIndex = 4;
            // 
            // textEdit3
            // 
            textEdit3.Location = new System.Drawing.Point(128, 120);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            textEdit3.Size = new System.Drawing.Size(156, 22);
            textEdit3.TabIndex = 2;
            // 
            // textEdit2
            // 
            textEdit2.Location = new System.Drawing.Point(128, 92);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new System.Drawing.Size(156, 22);
            textEdit2.TabIndex = 1;
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(128, 64);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(156, 22);
            textEdit1.TabIndex = 0;
            // 
            // AddUpdateDeleteGrid
            // 
            AddUpdateDeleteGrid.Location = new System.Drawing.Point(396, 2);
            AddUpdateDeleteGrid.MainView = gridView2;
            AddUpdateDeleteGrid.Name = "AddUpdateDeleteGrid";
            AddUpdateDeleteGrid.Size = new System.Drawing.Size(471, 373);
            AddUpdateDeleteGrid.TabIndex = 11;
            AddUpdateDeleteGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.GridControl = AddUpdateDeleteGrid;
            gridView2.Name = "gridView2";
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // FrmStudents
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(868, 377);
            Controls.Add(AddUpdateDeleteGrid);
            Controls.Add(TextGroup);
            Controls.Add(ClassForList);
            Controls.Add(StudentsGrid);
            Name = "FrmStudents";
            Text = "Students";
            Load += FrmStudents_Load;
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClassForList.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TextGroup).EndInit();
            TextGroup.ResumeLayout(false);
            TextGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClassForAdd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddUpdateDeleteGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl StudentsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ComboBoxEdit ClassForList;
        private DevExpress.XtraEditors.GroupControl TextGroup;
        private DevExpress.XtraEditors.ComboBoxEdit ClassForAdd;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton Save;
        private DevExpress.XtraGrid.GridControl AddUpdateDeleteGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ImageEdit imageEdit1;
    }
}