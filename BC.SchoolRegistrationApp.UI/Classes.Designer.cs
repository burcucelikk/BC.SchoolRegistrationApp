namespace BC.SchoolRegistrationApp.UI
{
    partial class Classes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classes));
            overlayPanel = new DevExpress.XtraEditors.PanelControl();
            TextGroup = new DevExpress.XtraEditors.GroupControl();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            flyoutPanelControl = new DevExpress.Utils.FlyoutPanelControl();
            crudFlyoutPanel = new DevExpress.Utils.FlyoutPanel();
            crudGroup = new DevExpress.XtraEditors.GroupControl();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            updateButton = new DevExpress.XtraEditors.SimpleButton();
            addButton = new DevExpress.XtraEditors.SimpleButton();
            lessonLookup = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            TeacherGrid = new DevExpress.XtraGrid.GridControl();
            studentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)overlayPanel).BeginInit();
            overlayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TextGroup).BeginInit();
            TextGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flyoutPanelControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)crudFlyoutPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)crudGroup).BeginInit();
            crudGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lessonLookup.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TeacherGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsGridView).BeginInit();
            SuspendLayout();
            // 
            // overlayPanel
            // 
            overlayPanel.Controls.Add(TextGroup);
            overlayPanel.Controls.Add(flyoutPanelControl);
            overlayPanel.Controls.Add(crudFlyoutPanel);
            overlayPanel.Location = new System.Drawing.Point(0, 0);
            overlayPanel.Name = "overlayPanel";
            overlayPanel.Size = new System.Drawing.Size(868, 377);
            overlayPanel.TabIndex = 29;
            // 
            // TextGroup
            // 
            TextGroup.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            TextGroup.Appearance.BorderColor = System.Drawing.Color.SlateGray;
            TextGroup.Appearance.Options.UseBackColor = true;
            TextGroup.Appearance.Options.UseBorderColor = true;
            TextGroup.Controls.Add(btnClose);
            TextGroup.Location = new System.Drawing.Point(241, 7);
            TextGroup.Name = "TextGroup";
            TextGroup.ShowCaption = false;
            TextGroup.Size = new System.Drawing.Size(386, 362);
            TextGroup.TabIndex = 28;
            TextGroup.Text = "groupControl1";
            // 
            // btnClose
            // 
            btnClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btnClose.Location = new System.Drawing.Point(355, 2);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new System.Drawing.Size(35, 27);
            btnClose.TabIndex = 17;
            // 
            // flyoutPanelControl
            // 
            flyoutPanelControl.FlyoutPanel = crudFlyoutPanel;
            flyoutPanelControl.Location = new System.Drawing.Point(239, 5);
            flyoutPanelControl.Name = "flyoutPanelControl";
            flyoutPanelControl.Size = new System.Drawing.Size(390, 366);
            flyoutPanelControl.TabIndex = 29;
            // 
            // crudFlyoutPanel
            // 
            crudFlyoutPanel.Location = new System.Drawing.Point(239, 5);
            crudFlyoutPanel.Name = "crudFlyoutPanel";
            crudFlyoutPanel.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center;
            crudFlyoutPanel.OwnerControl = overlayPanel;
            crudFlyoutPanel.Size = new System.Drawing.Size(390, 366);
            crudFlyoutPanel.TabIndex = 30;
            // 
            // crudGroup
            // 
            crudGroup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            crudGroup.Controls.Add(deleteButton);
            crudGroup.Controls.Add(updateButton);
            crudGroup.Controls.Add(addButton);
            crudGroup.Location = new System.Drawing.Point(751, 85);
            crudGroup.Name = "crudGroup";
            crudGroup.ShowCaption = false;
            crudGroup.Size = new System.Drawing.Size(108, 203);
            crudGroup.TabIndex = 28;
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
            deleteButton.Text = "DELETE";
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
            updateButton.Text = "UPDATE";
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
            addButton.Text = "ADD";
            // 
            // lessonLookup
            // 
            lessonLookup.EditValue = "";
            lessonLookup.Location = new System.Drawing.Point(745, 15);
            lessonLookup.Name = "lessonLookup";
            lessonLookup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lessonLookup.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder;
            lessonLookup.Properties.PopupFormSize = new System.Drawing.Size(121, 22);
            lessonLookup.Properties.PopupSizeable = false;
            lessonLookup.Properties.PopupView = gridLookUpEdit1View;
            lessonLookup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lessonLookup.Size = new System.Drawing.Size(121, 22);
            lessonLookup.TabIndex = 27;
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
            // TeacherGrid
            // 
            TeacherGrid.Location = new System.Drawing.Point(1, 11);
            TeacherGrid.MainView = studentsGridView;
            TeacherGrid.Name = "TeacherGrid";
            TeacherGrid.Size = new System.Drawing.Size(743, 362);
            TeacherGrid.TabIndex = 26;
            TeacherGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { studentsGridView });
            // 
            // studentsGridView
            // 
            studentsGridView.GridControl = TeacherGrid;
            studentsGridView.Name = "studentsGridView";
            studentsGridView.OptionsBehavior.Editable = false;
            studentsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // Classes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(868, 377);
            Controls.Add(overlayPanel);
            Controls.Add(crudGroup);
            Controls.Add(lessonLookup);
            Controls.Add(TeacherGrid);
            Name = "Classes";
            Text = "Classes";
            ((System.ComponentModel.ISupportInitialize)overlayPanel).EndInit();
            overlayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TextGroup).EndInit();
            TextGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flyoutPanelControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)crudFlyoutPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)crudGroup).EndInit();
            crudGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lessonLookup.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)TeacherGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl overlayPanel;
        private DevExpress.XtraEditors.GroupControl TextGroup;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl;
        private DevExpress.Utils.FlyoutPanel crudFlyoutPanel;
        private DevExpress.XtraEditors.GroupControl crudGroup;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton updateButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.GridLookUpEdit lessonLookup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.GridControl TeacherGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView studentsGridView;
    }
}