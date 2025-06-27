namespace BC.SchoolRegistrationApp.UI
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            AddButton = new DevExpress.XtraBars.BarButtonItem();
            UpdateButton = new DevExpress.XtraBars.BarButtonItem();
            DeleteButton = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5, barButtonItem6, barButtonItem7, AddButton, UpdateButton, DeleteButton, barButtonItem11, barButtonItem12, barButtonItem13 });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 15;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new System.Drawing.Size(868, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 1;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "HOME";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem2.ImageOptions.Image");
            barButtonItem2.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem2.ImageOptions.LargeImage");
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // barButtonItem3
            // 
            barButtonItem3.AccessibleDescription = "ST";
            barButtonItem3.Caption = "STUDENTS";
            barButtonItem3.Id = 3;
            barButtonItem3.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem3.ImageOptions.Image");
            barButtonItem3.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem3.ImageOptions.LargeImage");
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.ItemClick += barButtonItem3_ItemClick;
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "TEACHERS";
            barButtonItem4.Id = 4;
            barButtonItem4.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem4.ImageOptions.Image");
            barButtonItem4.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem4.ImageOptions.LargeImage");
            barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "CLASSES";
            barButtonItem5.Id = 5;
            barButtonItem5.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem5.ImageOptions.Image");
            barButtonItem5.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem5.ImageOptions.LargeImage");
            barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "LESSONS";
            barButtonItem6.Id = 6;
            barButtonItem6.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem6.ImageOptions.Image");
            barButtonItem6.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem6.ImageOptions.LargeImage");
            barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            barButtonItem7.Caption = "GRADES";
            barButtonItem7.Id = 7;
            barButtonItem7.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem7.ImageOptions.Image");
            barButtonItem7.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem7.ImageOptions.LargeImage");
            barButtonItem7.Name = "barButtonItem7";
            // 
            // AddButton
            // 
            AddButton.Caption = "ADD";
            AddButton.Id = 8;
            AddButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("AddButton.ImageOptions.Image");
            AddButton.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("AddButton.ImageOptions.LargeImage");
            AddButton.Name = "AddButton";
            AddButton.ItemClick += AddButton_ItemClick;
            // 
            // UpdateButton
            // 
            UpdateButton.Caption = "UPDATE";
            UpdateButton.Id = 9;
            UpdateButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("UpdateButton.ImageOptions.Image");
            UpdateButton.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("UpdateButton.ImageOptions.LargeImage");
            UpdateButton.Name = "UpdateButton";
            UpdateButton.ItemClick += UpdateButton_ItemClick;
            // 
            // DeleteButton
            // 
            DeleteButton.Caption = "DELETE";
            DeleteButton.Id = 10;
            DeleteButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("DeleteButton.ImageOptions.Image");
            DeleteButton.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("DeleteButton.ImageOptions.LargeImage");
            DeleteButton.Name = "DeleteButton";
            DeleteButton.ItemClick += DeleteButton_ItemClick;
            // 
            // barButtonItem11
            // 
            barButtonItem11.Caption = "LESSON SCHEDULE";
            barButtonItem11.Id = 11;
            barButtonItem11.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem11.ImageOptions.Image");
            barButtonItem11.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem11.ImageOptions.LargeImage");
            barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            barButtonItem12.Caption = "SAVE";
            barButtonItem12.Id = 12;
            barButtonItem12.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem12.ImageOptions.Image");
            barButtonItem12.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem12.ImageOptions.LargeImage");
            barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            barButtonItem13.Caption = "barButtonItem13";
            barButtonItem13.Id = 14;
            barButtonItem13.Name = "barButtonItem13";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup3, ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "BC School";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.AllowTextClipping = false;
            ribbonPageGroup1.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem3, true);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem4, true);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem5, true);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem6, true);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem7, true);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.AllowTextClipping = false;
            ribbonPageGroup3.ItemLinks.Add(AddButton);
            ribbonPageGroup3.ItemLinks.Add(UpdateButton);
            ribbonPageGroup3.ItemLinks.Add(DeleteButton);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.AllowTextClipping = false;
            ribbonPageGroup2.ItemLinks.Add(barButtonItem11);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new System.Drawing.Point(0, 569);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new System.Drawing.Size(868, 30);
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(868, 599);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IsMdiContainer = true;
            Name = "Home";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem AddButton;
        private DevExpress.XtraBars.BarButtonItem UpdateButton;
        private DevExpress.XtraBars.BarButtonItem DeleteButton;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}