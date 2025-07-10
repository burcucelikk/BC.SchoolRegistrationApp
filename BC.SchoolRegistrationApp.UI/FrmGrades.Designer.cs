namespace BC.SchoolRegistrationApp.UI
{
    partial class FrmGrades
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
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Location = new System.Drawing.Point(266, 38);
            searchButton.Name = "searchButton";
            searchButton.Size = new System.Drawing.Size(60, 25);
            searchButton.TabIndex = 24;
            searchButton.Text = "SEARCH";
            searchButton.Click += searchButton_Click;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(127, 81);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(89, 16);
            labelControl5.TabIndex = 23;
            labelControl5.Text = "Name Surname";
            // 
            // textEdit4
            // 
            textEdit4.Location = new System.Drawing.Point(106, 41);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new System.Drawing.Size(140, 22);
            textEdit4.TabIndex = 22;
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(41, 47);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(50, 16);
            labelControl4.TabIndex = 21;
            labelControl4.Text = "Number:";
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new System.Drawing.Point(266, 208);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(60, 27);
            simpleButton1.TabIndex = 20;
            simpleButton1.Text = "Save";
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(41, 219);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(46, 16);
            labelControl3.TabIndex = 19;
            labelControl3.Text = "3. Exam";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(41, 182);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(46, 16);
            labelControl2.TabIndex = 18;
            labelControl2.Text = "2. Exam";
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(41, 146);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(46, 16);
            labelControl1.TabIndex = 17;
            labelControl1.Text = "1. Exam";
            // 
            // textEdit3
            // 
            textEdit3.Location = new System.Drawing.Point(127, 216);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new System.Drawing.Size(91, 22);
            textEdit3.TabIndex = 16;
            // 
            // textEdit2
            // 
            textEdit2.Location = new System.Drawing.Point(127, 181);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new System.Drawing.Size(91, 22);
            textEdit2.TabIndex = 15;
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(127, 146);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(91, 22);
            textEdit1.TabIndex = 14;
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.Location = new System.Drawing.Point(750, 5);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Size = new System.Drawing.Size(112, 22);
            comboBoxEdit1.TabIndex = 26;
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(344, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(522, 371);
            gridControl1.TabIndex = 25;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FrmGrades
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
            Name = "FrmGrades";
            Text = "FrmGrades";
            Load += FrmGrades_Load;
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}