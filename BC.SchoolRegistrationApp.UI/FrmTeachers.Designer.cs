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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeachers));
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            updateButton = new DevExpress.XtraEditors.SimpleButton();
            addButton = new DevExpress.XtraEditors.SimpleButton();
            lessonList = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            TeachersGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            overlayPanel = new DevExpress.XtraEditors.PanelControl();
            crudFlyoutPanel = new DevExpress.Utils.FlyoutPanel();
            crudFlyoutPanelCont = new DevExpress.Utils.FlyoutPanelControl();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lessonList.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TeachersGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)simpleSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)simpleSeparator2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)overlayPanel).BeginInit();
            overlayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)crudFlyoutPanel).BeginInit();
            crudFlyoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)crudFlyoutPanelCont).BeginInit();
            crudFlyoutPanelCont.SuspendLayout();
            SuspendLayout();
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1 });
            layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            layoutControlGroup1.Name = "Root";
            layoutControlGroup1.Size = new System.Drawing.Size(427, 366);
            layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(427, 366);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControl1
            // 
            layoutControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            layoutControl1.Controls.Add(deleteButton);
            layoutControl1.Controls.Add(updateButton);
            layoutControl1.Controls.Add(addButton);
            layoutControl1.Controls.Add(lessonList);
            layoutControl1.Controls.Add(TeachersGrid);
            layoutControl1.Location = new System.Drawing.Point(5, 10);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(860, 363);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
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
            deleteButton.Location = new System.Drawing.Point(580, 323);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(268, 27);
            deleteButton.StyleController = layoutControl1;
            deleteButton.TabIndex = 5;
            deleteButton.Text = "SİL";
            deleteButton.Click += deleteButton_Click;
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
            updateButton.Location = new System.Drawing.Point(290, 323);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(286, 27);
            updateButton.StyleController = layoutControl1;
            updateButton.TabIndex = 4;
            updateButton.Text = "GÜNCELLE";
            updateButton.Click += updateButton_Click;
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
            addButton.Location = new System.Drawing.Point(12, 323);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(274, 27);
            addButton.StyleController = layoutControl1;
            addButton.TabIndex = 3;
            addButton.Text = "EKLE";
            addButton.Click += addButton_Click;
            // 
            // lessonList
            // 
            lessonList.EditValue = "";
            lessonList.Location = new System.Drawing.Point(12, 12);
            lessonList.Name = "lessonList";
            lessonList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lessonList.Properties.PopupView = gridLookUpEdit1View;
            lessonList.Size = new System.Drawing.Size(836, 22);
            lessonList.StyleController = layoutControl1;
            lessonList.TabIndex = 0;
            lessonList.EditValueChanged += lessonList_EditValueChanged;
            // 
            // gridLookUpEdit1View
            // 
            gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // TeachersGrid
            // 
            TeachersGrid.Location = new System.Drawing.Point(12, 38);
            TeachersGrid.MainView = gridView1;
            TeachersGrid.Name = "TeachersGrid";
            TeachersGrid.Size = new System.Drawing.Size(836, 280);
            TeachersGrid.TabIndex = 2;
            TeachersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = TeachersGrid;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, simpleSeparator1, layoutControlItem6, layoutControlItem3, layoutControlItem4, simpleSeparator2 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(860, 363);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = TeachersGrid;
            layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(840, 284);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = lessonList;
            layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(840, 26);
            layoutControlItem2.Text = ",";
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            simpleSeparator1.AllowHotTrack = false;
            simpleSeparator1.Location = new System.Drawing.Point(278, 342);
            simpleSeparator1.Name = "simpleSeparator1";
            simpleSeparator1.Size = new System.Drawing.Size(562, 1);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = addButton;
            layoutControlItem6.Location = new System.Drawing.Point(0, 311);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(278, 32);
            layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = updateButton;
            layoutControlItem3.Location = new System.Drawing.Point(278, 311);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(290, 31);
            layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = deleteButton;
            layoutControlItem4.Location = new System.Drawing.Point(568, 311);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(272, 31);
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // simpleSeparator2
            // 
            simpleSeparator2.AllowHotTrack = false;
            simpleSeparator2.Location = new System.Drawing.Point(0, 310);
            simpleSeparator2.Name = "simpleSeparator2";
            simpleSeparator2.Size = new System.Drawing.Size(840, 1);
            // 
            // overlayPanel
            // 
            overlayPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            overlayPanel.Controls.Add(crudFlyoutPanel);
            overlayPanel.Location = new System.Drawing.Point(5, 5);
            overlayPanel.Name = "overlayPanel";
            overlayPanel.Size = new System.Drawing.Size(860, 368);
            overlayPanel.TabIndex = 1;
            // 
            // crudFlyoutPanel
            // 
            crudFlyoutPanel.Controls.Add(crudFlyoutPanelCont);
            crudFlyoutPanel.Location = new System.Drawing.Point(238, 5);
            crudFlyoutPanel.Name = "crudFlyoutPanel";
            crudFlyoutPanel.Size = new System.Drawing.Size(402, 355);
            crudFlyoutPanel.TabIndex = 0;
            // 
            // crudFlyoutPanelCont
            // 
            crudFlyoutPanelCont.Controls.Add(btnClose);
            crudFlyoutPanelCont.FlyoutPanel = crudFlyoutPanel;
            crudFlyoutPanelCont.Location = new System.Drawing.Point(0, 0);
            crudFlyoutPanelCont.Name = "crudFlyoutPanelCont";
            crudFlyoutPanelCont.Size = new System.Drawing.Size(402, 355);
            crudFlyoutPanelCont.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btnClose.Location = new System.Drawing.Point(367, 0);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new System.Drawing.Size(35, 27);
            btnClose.TabIndex = 17;
            btnClose.Click += btnClose_Click;
            // 
            // FrmTeachers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(868, 377);
            Controls.Add(overlayPanel);
            Controls.Add(layoutControl1);
            Name = "FrmTeachers";
            Text = "Öğretmenler";
            Load += FrmTeachers_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lessonList.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)TeachersGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)simpleSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)simpleSeparator2).EndInit();
            ((System.ComponentModel.ISupportInitialize)overlayPanel).EndInit();
            overlayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)crudFlyoutPanel).EndInit();
            crudFlyoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)crudFlyoutPanelCont).EndInit();
            crudFlyoutPanelCont.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GridLookUpEdit lessonList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.GridControl TeachersGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton updateButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraEditors.PanelControl overlayPanel;
        private DevExpress.Utils.FlyoutPanel crudFlyoutPanel;
        private DevExpress.Utils.FlyoutPanelControl crudFlyoutPanelCont;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}