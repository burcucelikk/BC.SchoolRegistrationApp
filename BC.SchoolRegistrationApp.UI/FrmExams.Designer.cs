namespace BC.SchoolRegistrationApp.UI
{
    partial class FrmExams
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
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(120, 135);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(91, 22);
            textEdit1.TabIndex = 0;
            // 
            // textEdit2
            // 
            textEdit2.Location = new System.Drawing.Point(120, 170);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new System.Drawing.Size(91, 22);
            textEdit2.TabIndex = 1;
            // 
            // textEdit3
            // 
            textEdit3.Location = new System.Drawing.Point(120, 205);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new System.Drawing.Size(91, 22);
            textEdit3.TabIndex = 2;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(34, 135);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(46, 16);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "1. Exam";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(34, 171);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(46, 16);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "2. Exam";
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(34, 208);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(46, 16);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "3. Exam";
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new System.Drawing.Point(259, 197);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(60, 27);
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "Save";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(34, 36);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(50, 16);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "Number:";
            // 
            // textEdit4
            // 
            textEdit4.Location = new System.Drawing.Point(99, 30);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new System.Drawing.Size(140, 22);
            textEdit4.TabIndex = 8;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(120, 70);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(89, 16);
            labelControl5.TabIndex = 9;
            labelControl5.Text = "Name Surname";
            // 
            // searchButton
            // 
            searchButton.Location = new System.Drawing.Point(259, 27);
            searchButton.Name = "searchButton";
            searchButton.Size = new System.Drawing.Size(60, 25);
            searchButton.TabIndex = 13;
            searchButton.Text = "SEARCH";
            searchButton.Click += searchButton_Click;
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(345, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(522, 371);
            gridControl1.TabIndex = 14;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.Location = new System.Drawing.Point(751, 5);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Size = new System.Drawing.Size(112, 22);
            comboBoxEdit1.TabIndex = 15;
            // 
            // FrmExams
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(868, 377);
            Controls.Add(comboBoxEdit1);
            Controls.Add(gridControl1);
            Controls.Add(searchButton);
            Controls.Add(labelControl5);
            Controls.Add(textEdit4);
            Controls.Add(labelControl4);
            Controls.Add(simpleButton1);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(textEdit3);
            Controls.Add(textEdit2);
            Controls.Add(textEdit1);
            Name = "FrmExams";
            Text = "FrmExams";
            Load += FrmExams_Load;
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}