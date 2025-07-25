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
            studentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            classFilterLookup = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            addButton = new DevExpress.XtraEditors.SimpleButton();
            updateButton = new DevExpress.XtraEditors.SimpleButton();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            crudGroup = new DevExpress.XtraEditors.GroupControl();
            overlayPanel = new DevExpress.XtraEditors.PanelControl();
            crudFlyoutPanel = new DevExpress.Utils.FlyoutPanel();
            flyoutPanelControl = new DevExpress.Utils.FlyoutPanelControl();
            TextGroup = new DevExpress.XtraEditors.GroupControl();
            gradesGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            classInputLookup = new DevExpress.XtraEditors.GridLookUpEdit();
            classLookupGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classFilterLookup.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)crudGroup).BeginInit();
            crudGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)overlayPanel).BeginInit();
            overlayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)crudFlyoutPanel).BeginInit();
            crudFlyoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flyoutPanelControl).BeginInit();
            flyoutPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TextGroup).BeginInit();
            TextGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classInputLookup.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classLookupGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // StudentsGrid
            // 
            StudentsGrid.Location = new System.Drawing.Point(3, 5);
            StudentsGrid.MainView = studentsGridView;
            StudentsGrid.Name = "StudentsGrid";
            StudentsGrid.Size = new System.Drawing.Size(743, 362);
            StudentsGrid.TabIndex = 8;
            StudentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { studentsGridView });
            // 
            // studentsGridView
            // 
            studentsGridView.GridControl = StudentsGrid;
            studentsGridView.Name = "studentsGridView";
            studentsGridView.OptionsBehavior.Editable = false;
            studentsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // classFilterLookup
            // 
            classFilterLookup.EditValue = "";
            classFilterLookup.Location = new System.Drawing.Point(746, 9);
            classFilterLookup.Name = "classFilterLookup";
            classFilterLookup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            classFilterLookup.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder;
            classFilterLookup.Properties.PopupFormSize = new System.Drawing.Size(121, 22);
            classFilterLookup.Properties.PopupSizeable = false;
            classFilterLookup.Properties.PopupView = gridLookUpEdit1View;
            classFilterLookup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            classFilterLookup.Size = new System.Drawing.Size(121, 22);
            classFilterLookup.TabIndex = 12;
            classFilterLookup.EditValueChanged += classFilterLookup_EditValueChanged;
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
            // addButton
            // 
            addButton.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            addButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            addButton.Appearance.ForeColor = System.Drawing.Color.White;
            addButton.Appearance.Options.UseBackColor = true;
            addButton.Appearance.Options.UseBorderColor = true;
            addButton.Appearance.Options.UseFont = true;
            addButton.Appearance.Options.UseForeColor = true;
            addButton.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(79, 168, 255);
            addButton.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            addButton.AppearanceHovered.Options.UseBackColor = true;
            addButton.AppearanceHovered.Options.UseFont = true;
            addButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("addButton.ImageOptions.Image");
            addButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            addButton.Location = new System.Drawing.Point(11, 33);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(85, 36);
            addButton.TabIndex = 17;
            addButton.Text = "EKLE";
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            updateButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            updateButton.Appearance.ForeColor = System.Drawing.Color.White;
            updateButton.Appearance.Options.UseBackColor = true;
            updateButton.Appearance.Options.UseBorderColor = true;
            updateButton.Appearance.Options.UseFont = true;
            updateButton.Appearance.Options.UseForeColor = true;
            updateButton.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(85, 167, 120);
            updateButton.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            updateButton.AppearanceHovered.Options.UseBackColor = true;
            updateButton.AppearanceHovered.Options.UseFont = true;
            updateButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("updateButton.ImageOptions.Image");
            updateButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            updateButton.Location = new System.Drawing.Point(11, 89);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(85, 36);
            updateButton.TabIndex = 18;
            updateButton.Text = "GÜNCELLE";
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Appearance.BackColor = System.Drawing.Color.Firebrick;
            deleteButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            deleteButton.Appearance.ForeColor = System.Drawing.Color.White;
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.Appearance.Options.UseBorderColor = true;
            deleteButton.Appearance.Options.UseFont = true;
            deleteButton.Appearance.Options.UseForeColor = true;
            deleteButton.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(204, 76, 76);
            deleteButton.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            deleteButton.AppearanceHovered.Options.UseBackColor = true;
            deleteButton.AppearanceHovered.Options.UseFont = true;
            deleteButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("deleteButton.ImageOptions.Image");
            deleteButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            deleteButton.Location = new System.Drawing.Point(11, 142);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(85, 36);
            deleteButton.TabIndex = 19;
            deleteButton.Text = "SİL";
            deleteButton.Click += deleteButton_Click;
            // 
            // crudGroup
            // 
            crudGroup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            crudGroup.Controls.Add(deleteButton);
            crudGroup.Controls.Add(updateButton);
            crudGroup.Controls.Add(addButton);
            crudGroup.Location = new System.Drawing.Point(752, 77);
            crudGroup.Name = "crudGroup";
            crudGroup.ShowCaption = false;
            crudGroup.Size = new System.Drawing.Size(108, 203);
            crudGroup.TabIndex = 22;
            // 
            // overlayPanel
            // 
            overlayPanel.Controls.Add(crudFlyoutPanel);
            overlayPanel.Location = new System.Drawing.Point(-1, 5);
            overlayPanel.Name = "overlayPanel";
            overlayPanel.Size = new System.Drawing.Size(720, 372);
            overlayPanel.TabIndex = 23;
            // 
            // crudFlyoutPanel
            // 
            crudFlyoutPanel.Controls.Add(flyoutPanelControl);
            crudFlyoutPanel.Location = new System.Drawing.Point(243, 3);
            crudFlyoutPanel.Name = "crudFlyoutPanel";
            crudFlyoutPanel.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center;
            crudFlyoutPanel.OwnerControl = crudGroup;
            crudFlyoutPanel.Size = new System.Drawing.Size(390, 366);
            crudFlyoutPanel.TabIndex = 1;
            // 
            // flyoutPanelControl
            // 
            flyoutPanelControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flyoutPanelControl.Controls.Add(TextGroup);
            flyoutPanelControl.FlyoutPanel = crudFlyoutPanel;
            flyoutPanelControl.Location = new System.Drawing.Point(0, 0);
            flyoutPanelControl.Name = "flyoutPanelControl";
            flyoutPanelControl.Size = new System.Drawing.Size(390, 366);
            flyoutPanelControl.TabIndex = 0;
            // 
            // TextGroup
            // 
            TextGroup.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            TextGroup.Appearance.BorderColor = System.Drawing.Color.SlateGray;
            TextGroup.Appearance.Options.UseBackColor = true;
            TextGroup.Appearance.Options.UseBorderColor = true;
            TextGroup.Controls.Add(gradesGrid);
            TextGroup.Controls.Add(checkEdit1);
            TextGroup.Controls.Add(btnClose);
            TextGroup.Controls.Add(searchButton);
            TextGroup.Controls.Add(deleteBtn);
            TextGroup.Controls.Add(classInputLookup);
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
            TextGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            TextGroup.Location = new System.Drawing.Point(2, 2);
            TextGroup.Name = "TextGroup";
            TextGroup.ShowCaption = false;
            TextGroup.Size = new System.Drawing.Size(386, 362);
            TextGroup.TabIndex = 21;
            // 
            // gradesGrid
            // 
            gradesGrid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gradesGrid.Location = new System.Drawing.Point(0, 33);
            gradesGrid.MainView = gridView1;
            gradesGrid.Name = "gradesGrid";
            gradesGrid.Size = new System.Drawing.Size(385, 328);
            gradesGrid.TabIndex = 18;
            gradesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gradesGrid.Visible = false;
            // 
            // gridView1
            // 
            gridView1.GridControl = gradesGrid;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // checkEdit1
            // 
            checkEdit1.Location = new System.Drawing.Point(41, 265);
            checkEdit1.Name = "checkEdit1";
            checkEdit1.Properties.Caption = "IS PASSED:";
            checkEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            checkEdit1.Size = new System.Drawing.Size(114, 24);
            checkEdit1.TabIndex = 17;
            // 
            // btnClose
            // 
            btnClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btnClose.Location = new System.Drawing.Point(345, 0);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new System.Drawing.Size(35, 27);
            btnClose.TabIndex = 16;
            btnClose.Click += btnClose_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new System.Drawing.Point(312, 136);
            searchButton.Name = "searchButton";
            searchButton.Size = new System.Drawing.Size(60, 25);
            searchButton.TabIndex = 15;
            searchButton.Text = "SEARCH";
            searchButton.Click += searchButton_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            deleteBtn.Appearance.Options.UseFont = true;
            deleteBtn.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("deleteBtn.ImageOptions.Image");
            deleteBtn.Location = new System.Drawing.Point(155, 301);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new System.Drawing.Size(115, 39);
            deleteBtn.TabIndex = 14;
            deleteBtn.Text = "SİL";
            deleteBtn.Click += deleteBtn_Click;
            // 
            // classInputLookup
            // 
            classInputLookup.EditValue = "";
            classInputLookup.Location = new System.Drawing.Point(134, 42);
            classInputLookup.Name = "classInputLookup";
            classInputLookup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            classInputLookup.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder;
            classInputLookup.Properties.PopupFormSize = new System.Drawing.Size(156, 22);
            classInputLookup.Properties.PopupSizeable = false;
            classInputLookup.Properties.PopupView = classLookupGridView;
            classInputLookup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            classInputLookup.Size = new System.Drawing.Size(156, 22);
            classInputLookup.TabIndex = 13;
            // 
            // classLookupGridView
            // 
            classLookupGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            classLookupGridView.Name = "classLookupGridView";
            classLookupGridView.OptionsBehavior.Editable = false;
            classLookupGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            classLookupGridView.OptionsView.ShowColumnHeaders = false;
            classLookupGridView.OptionsView.ShowGroupPanel = false;
            classLookupGridView.OptionsView.ShowIndicator = false;
            classLookupGridView.RowHeight = 25;
            // 
            // imageEdit1
            // 
            imageEdit1.Location = new System.Drawing.Point(134, 166);
            imageEdit1.Name = "imageEdit1";
            imageEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            imageEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            imageEdit1.Size = new System.Drawing.Size(156, 22);
            imageEdit1.TabIndex = 11;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(70, 46);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(40, 16);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "SINIF: ";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(25, 167);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(73, 16);
            labelControl4.TabIndex = 9;
            labelControl4.Text = "FOTOĞRAF: ";
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(57, 141);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(59, 16);
            labelControl3.TabIndex = 8;
            labelControl3.Text = "NUMARA: ";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(48, 113);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(49, 16);
            labelControl2.TabIndex = 7;
            labelControl2.Text = "SOYAD: ";
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(72, 86);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(25, 16);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "AD: ";
            // 
            // Save
            // 
            Save.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Save.Appearance.Options.UseFont = true;
            Save.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("Save.ImageOptions.Image");
            Save.Location = new System.Drawing.Point(155, 301);
            Save.Name = "Save";
            Save.Size = new System.Drawing.Size(115, 39);
            Save.TabIndex = 5;
            Save.Text = "KAYDET";
            Save.Click += Save_Click;
            // 
            // textEdit3
            // 
            textEdit3.Location = new System.Drawing.Point(134, 138);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            textEdit3.Properties.MaskSettings.Set("mask", "d");
            textEdit3.Size = new System.Drawing.Size(156, 22);
            textEdit3.TabIndex = 2;
            // 
            // textEdit2
            // 
            textEdit2.Location = new System.Drawing.Point(134, 110);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new System.Drawing.Size(156, 22);
            textEdit2.TabIndex = 1;
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(134, 82);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(156, 22);
            textEdit1.TabIndex = 0;
            // 
            // FrmStudents
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(868, 377);
            Controls.Add(overlayPanel);
            Controls.Add(crudGroup);
            Controls.Add(classFilterLookup);
            Controls.Add(StudentsGrid);
            Name = "FrmStudents";
            Text = "Öğrenciler";
            Load += FrmStudents_Load;
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)classFilterLookup.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)crudGroup).EndInit();
            crudGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)overlayPanel).EndInit();
            overlayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)crudFlyoutPanel).EndInit();
            crudFlyoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flyoutPanelControl).EndInit();
            flyoutPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TextGroup).EndInit();
            TextGroup.ResumeLayout(false);
            TextGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)classInputLookup.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)classLookupGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl StudentsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView studentsGridView;
        private DevExpress.XtraEditors.GridLookUpEdit classFilterLookup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.SimpleButton updateButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.GroupControl crudGroup;
        private DevExpress.XtraEditors.PanelControl overlayPanel;
        private DevExpress.Utils.FlyoutPanel crudFlyoutPanel;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl;
        private DevExpress.XtraEditors.GroupControl TextGroup;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraEditors.GridLookUpEdit classInputLookup;
        private DevExpress.XtraGrid.Views.Grid.GridView classLookupGridView;
        private DevExpress.XtraEditors.ImageEdit imageEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Save;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraGrid.GridControl gradesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}