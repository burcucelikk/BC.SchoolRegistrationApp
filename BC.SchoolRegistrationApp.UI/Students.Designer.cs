namespace BC.SchoolRegistrationApp.UI
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            textEdit5 = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(359, 39);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(495, 332);
            gridControl1.TabIndex = 2;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(pictureEdit1);
            groupControl1.Controls.Add(textEdit5);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(textEdit3);
            groupControl1.Controls.Add(textEdit2);
            groupControl1.Controls.Add(textEdit1);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new Point(4, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.ShowCaption = false;
            groupControl1.Size = new Size(355, 371);
            groupControl1.TabIndex = 11;
            groupControl1.Text = "groupControl1";
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new Point(180, 243);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit1.Size = new Size(135, 119);
            pictureEdit1.TabIndex = 17;
            // 
            // textEdit5
            // 
            textEdit5.Location = new Point(168, 136);
            textEdit5.Name = "textEdit5";
            textEdit5.Size = new Size(163, 22);
            textEdit5.TabIndex = 16;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(10, 241);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(137, 22);
            labelControl4.TabIndex = 15;
            labelControl4.Text = "PHOTOGRAPF :";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(54, 136);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(91, 22);
            labelControl5.TabIndex = 14;
            labelControl5.Text = "NUMBER :";
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(168, 95);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(162, 22);
            textEdit3.TabIndex = 12;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(168, 52);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(162, 22);
            textEdit2.TabIndex = 11;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(168, 10);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(162, 22);
            textEdit1.TabIndex = 10;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(45, 95);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(102, 22);
            labelControl3.TabIndex = 9;
            labelControl3.Text = "SURNAME :";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(82, 52);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(65, 22);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "NAME :";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(110, 10);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(35, 22);
            labelControl1.TabIndex = 7;
            labelControl1.Text = "ID :";
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.EditValue = "Choose A Class";
            comboBoxEdit1.Location = new Point(694, 11);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Properties.Sorted = true;
            comboBoxEdit1.Size = new Size(146, 22);
            comboBoxEdit1.TabIndex = 12;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(557, 9);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(126, 22);
            labelControl6.TabIndex = 16;
            labelControl6.Text = "CLASS NAME :";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 370);
            Controls.Add(labelControl6);
            Controls.Add(comboBoxEdit1);
            Controls.Add(groupControl1);
            Controls.Add(gridControl1);
            Name = "Students";
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}