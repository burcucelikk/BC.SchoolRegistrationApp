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
            TextGroup = new DevExpress.XtraEditors.GroupControl();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            ListClass2 = new DevExpress.XtraEditors.GridLookUpEdit();
            gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            imageEdit1 = new DevExpress.XtraEditors.ImageEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            Save = new DevExpress.XtraEditors.SimpleButton();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            AddUpdateDeleteGrid = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ListClass = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TextGroup).BeginInit();
            TextGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListClass2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddUpdateDeleteGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListClass.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
            SuspendLayout();
            // 
            // StudentsGrid
            // 
            StudentsGrid.Location = new System.Drawing.Point(3, 5);
            StudentsGrid.MainView = gridView1;
            StudentsGrid.Name = "StudentsGrid";
            StudentsGrid.Size = new System.Drawing.Size(748, 362);
            StudentsGrid.TabIndex = 8;
            StudentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = StudentsGrid;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // TextGroup
            // 
            TextGroup.Controls.Add(deleteButton);
            TextGroup.Controls.Add(ListClass2);
            TextGroup.Controls.Add(searchButton);
            TextGroup.Controls.Add(imageEdit1);
            TextGroup.Controls.Add(labelControl5);
            TextGroup.Controls.Add(labelControl4);
            TextGroup.Controls.Add(labelControl3);
            TextGroup.Controls.Add(labelControl2);
            TextGroup.Controls.Add(labelControl1);
            TextGroup.Controls.Add(Save);
            TextGroup.Controls.Add(textEdit3);
            TextGroup.Controls.Add(textEdit2);
            TextGroup.Controls.Add(textEdit1);
            TextGroup.Location = new System.Drawing.Point(3, 4);
            TextGroup.Name = "TextGroup";
            TextGroup.Size = new System.Drawing.Size(395, 361);
            TextGroup.TabIndex = 10;
            // 
            // deleteButton
            // 
            deleteButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            deleteButton.Appearance.Options.UseFont = true;
            deleteButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("deleteButton.ImageOptions.Image");
            deleteButton.Location = new System.Drawing.Point(142, 256);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(115, 36);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "DELETE";
            deleteButton.Click += deleteButton_Click;
            // 
            // ListClass2
            // 
            ListClass2.EditValue = "";
            ListClass2.Location = new System.Drawing.Point(130, 53);
            ListClass2.Name = "ListClass2";
            ListClass2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ListClass2.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder;
            ListClass2.Properties.PopupFormSize = new System.Drawing.Size(156, 22);
            ListClass2.Properties.PopupSizeable = false;
            ListClass2.Properties.PopupView = gridView3;
            ListClass2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ListClass2.Size = new System.Drawing.Size(156, 22);
            ListClass2.TabIndex = 13;
            // 
            // gridView3
            // 
            gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView3.Name = "gridView3";
            gridView3.OptionsBehavior.Editable = false;
            gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView3.OptionsView.ShowColumnHeaders = false;
            gridView3.OptionsView.ShowGroupPanel = false;
            gridView3.OptionsView.ShowIndicator = false;
            gridView3.RowHeight = 25;
            // 
            // searchButton
            // 
            searchButton.Location = new System.Drawing.Point(301, 147);
            searchButton.Name = "searchButton";
            searchButton.Size = new System.Drawing.Size(60, 25);
            searchButton.TabIndex = 12;
            searchButton.Text = "SEARCH";
            searchButton.Click += searchButton_Click;
            // 
            // imageEdit1
            // 
            imageEdit1.Location = new System.Drawing.Point(130, 177);
            imageEdit1.Name = "imageEdit1";
            imageEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            imageEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            imageEdit1.Size = new System.Drawing.Size(156, 22);
            imageEdit1.TabIndex = 11;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(80, 56);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(47, 16);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "CLASS: ";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(35, 177);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(89, 16);
            labelControl4.TabIndex = 9;
            labelControl4.Text = "PHOTOGRAPH: ";
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(67, 151);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(57, 16);
            labelControl3.TabIndex = 8;
            labelControl3.Text = "NUMBER: ";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(58, 123);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(66, 16);
            labelControl2.TabIndex = 7;
            labelControl2.Text = "SURNAME: ";
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(82, 96);
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
            Save.Location = new System.Drawing.Point(152, 256);
            Save.Name = "Save";
            Save.Size = new System.Drawing.Size(105, 36);
            Save.TabIndex = 5;
            Save.Text = "SAVE";
            Save.Click += Save_Click;
            // 
            // textEdit3
            // 
            textEdit3.Location = new System.Drawing.Point(130, 149);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            textEdit3.Properties.MaskSettings.Set("mask", "d");
            textEdit3.Size = new System.Drawing.Size(156, 22);
            textEdit3.TabIndex = 2;
            // 
            // textEdit2
            // 
            textEdit2.Location = new System.Drawing.Point(130, 121);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new System.Drawing.Size(156, 22);
            textEdit2.TabIndex = 1;
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(130, 93);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(156, 22);
            textEdit1.TabIndex = 0;
            // 
            // AddUpdateDeleteGrid
            // 
            AddUpdateDeleteGrid.Location = new System.Drawing.Point(396, 4);
            AddUpdateDeleteGrid.MainView = gridView2;
            AddUpdateDeleteGrid.Name = "AddUpdateDeleteGrid";
            AddUpdateDeleteGrid.Size = new System.Drawing.Size(471, 363);
            AddUpdateDeleteGrid.TabIndex = 11;
            AddUpdateDeleteGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            AddUpdateDeleteGrid.DoubleClick += AddUpdateDeleteGrid_DoubleClick;
            // 
            // gridView2
            // 
            gridView2.GridControl = AddUpdateDeleteGrid;
            gridView2.Name = "gridView2";
            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsView.ShowGroupPanel = false;
            gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // ListClass
            // 
            ListClass.EditValue = "";
            ListClass.Location = new System.Drawing.Point(746, 5);
            ListClass.Name = "ListClass";
            ListClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ListClass.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder;
            ListClass.Properties.PopupFormSize = new System.Drawing.Size(121, 22);
            ListClass.Properties.PopupSizeable = false;
            ListClass.Properties.PopupView = gridLookUpEdit1View;
            ListClass.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ListClass.Size = new System.Drawing.Size(121, 22);
            ListClass.TabIndex = 12;
            ListClass.EditValueChanged += ListClass_EditValueChanged;
            // 
            // gridLookUpEdit1View
            // 
            gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            gridLookUpEdit1View.OptionsBehavior.Editable = false;
            gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
            gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            gridLookUpEdit1View.OptionsView.ShowIndicator = false;
            gridLookUpEdit1View.RowHeight = 25;
            // 
            // FrmStudents
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(868, 377);
            Controls.Add(ListClass);
            Controls.Add(AddUpdateDeleteGrid);
            Controls.Add(TextGroup);
            Controls.Add(StudentsGrid);
            Name = "FrmStudents";
            Text = "Students";
            Load += FrmStudents_Load;
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TextGroup).EndInit();
            TextGroup.ResumeLayout(false);
            TextGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListClass2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddUpdateDeleteGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListClass.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl StudentsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl TextGroup;
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
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.GridLookUpEdit ListClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit ListClass2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
    }
}