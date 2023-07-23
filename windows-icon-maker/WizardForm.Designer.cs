namespace windows_icon_maker
{
    partial class WizardForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizardForm));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.sourceFileBrowseButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sourceFileEdit = new DevExpress.XtraEditors.TextEdit();
            this.sourceFilePicture = new DevExpress.XtraEditors.PictureEdit();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.iconPicture = new DevExpress.XtraEditors.PictureEdit();
            this.wizardPage2 = new DevExpress.XtraWizard.WizardPage();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.picture64 = new DevExpress.XtraEditors.PictureEdit();
            this.picture256 = new DevExpress.XtraEditors.PictureEdit();
            this.picture128 = new DevExpress.XtraEditors.PictureEdit();
            this.picture96 = new DevExpress.XtraEditors.PictureEdit();
            this.picture48 = new DevExpress.XtraEditors.PictureEdit();
            this.picture32 = new DevExpress.XtraEditors.PictureEdit();
            this.picture24 = new DevExpress.XtraEditors.PictureEdit();
            this.picture16 = new DevExpress.XtraEditors.PictureEdit();
            this.openSourceImageDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.saveIconDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFileEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFilePicture.Properties)).BeginInit();
            this.completionWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture.Properties)).BeginInit();
            this.wizardPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture64.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture256.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture128.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture96.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture48.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture32.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture24.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture16.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage2);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("wizardControl1.ImageOptions.Image")));
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.wizardPage2,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(677, 432);
            this.wizardControl1.Text = "Image-to-Icon Wizard";
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_CancelClick);
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.IntroductionText = resources.GetString("welcomeWizardPage1.IntroductionText");
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(460, 300);
            this.welcomeWizardPage1.Text = "Welcome to the Image-to-Icon Wizard";
            // 
            // wizardPage1
            // 
            this.wizardPage1.AllowNext = false;
            this.wizardPage1.Controls.Add(this.sourceFileBrowseButton);
            this.wizardPage1.Controls.Add(this.labelControl1);
            this.wizardPage1.Controls.Add(this.sourceFileEdit);
            this.wizardPage1.Controls.Add(this.sourceFilePicture);
            this.wizardPage1.DescriptionText = "Select the source image file to generate the icon. The file should have a 1:1 rat" +
    "io, and is recomended to have a width of at least 256px.";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(645, 289);
            this.wizardPage1.Text = "Source image";
            // 
            // sourceFileBrowseButton
            // 
            this.sourceFileBrowseButton.Location = new System.Drawing.Point(305, 49);
            this.sourceFileBrowseButton.Name = "sourceFileBrowseButton";
            this.sourceFileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.sourceFileBrowseButton.TabIndex = 3;
            this.sourceFileBrowseButton.Text = "Browse";
            this.sourceFileBrowseButton.Click += new System.EventHandler(this.sourceFileBrowseButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Source image path";
            // 
            // sourceFileEdit
            // 
            this.sourceFileEdit.Location = new System.Drawing.Point(3, 22);
            this.sourceFileEdit.Name = "sourceFileEdit";
            this.sourceFileEdit.Properties.ReadOnly = true;
            this.sourceFileEdit.Size = new System.Drawing.Size(377, 20);
            this.sourceFileEdit.TabIndex = 1;
            // 
            // sourceFilePicture
            // 
            this.sourceFilePicture.Location = new System.Drawing.Point(386, 22);
            this.sourceFilePicture.Name = "sourceFilePicture";
            this.sourceFilePicture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.sourceFilePicture.Properties.ShowMenu = false;
            this.sourceFilePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.sourceFilePicture.Size = new System.Drawing.Size(256, 256);
            this.sourceFilePicture.TabIndex = 0;
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Controls.Add(this.iconPicture);
            this.completionWizardPage1.FinishText = "The images were converted to an Icon successfully.";
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.ProceedText = "To save the Icon File, click Finish";
            this.completionWizardPage1.Size = new System.Drawing.Size(460, 300);
            this.completionWizardPage1.Text = "Icon Conversion";
            // 
            // iconPicture
            // 
            this.iconPicture.Location = new System.Drawing.Point(396, 0);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.iconPicture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.iconPicture.Properties.ShowMenu = false;
            this.iconPicture.Size = new System.Drawing.Size(64, 64);
            this.iconPicture.TabIndex = 8;
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.labelControl9);
            this.wizardPage2.Controls.Add(this.labelControl8);
            this.wizardPage2.Controls.Add(this.labelControl7);
            this.wizardPage2.Controls.Add(this.labelControl6);
            this.wizardPage2.Controls.Add(this.labelControl5);
            this.wizardPage2.Controls.Add(this.labelControl4);
            this.wizardPage2.Controls.Add(this.labelControl3);
            this.wizardPage2.Controls.Add(this.labelControl2);
            this.wizardPage2.Controls.Add(this.picture64);
            this.wizardPage2.Controls.Add(this.picture256);
            this.wizardPage2.Controls.Add(this.picture128);
            this.wizardPage2.Controls.Add(this.picture96);
            this.wizardPage2.Controls.Add(this.picture48);
            this.wizardPage2.Controls.Add(this.picture32);
            this.wizardPage2.Controls.Add(this.picture24);
            this.wizardPage2.Controls.Add(this.picture16);
            this.wizardPage2.DescriptionText = "Your icon, with different sizes, should look like the ones below. If you are sati" +
    "sfied, click Next. If not, click Back and replace the Source File.";
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(645, 289);
            this.wizardPage2.Text = "Icon Preview";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(375, 274);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 13);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "256x256";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(211, 274);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "128x128";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(79, 242);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "96x96";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(275, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "64x64";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(191, 66);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "48x48";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(123, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "32x32";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(63, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "24x24";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "16x16";
            // 
            // picture64
            // 
            this.picture64.Location = new System.Drawing.Point(275, 12);
            this.picture64.Name = "picture64";
            this.picture64.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picture64.Properties.ShowMenu = false;
            this.picture64.Size = new System.Drawing.Size(64, 64);
            this.picture64.TabIndex = 7;
            // 
            // picture256
            // 
            this.picture256.Location = new System.Drawing.Point(375, 12);
            this.picture256.Name = "picture256";
            this.picture256.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picture256.Properties.ShowMenu = false;
            this.picture256.Size = new System.Drawing.Size(256, 256);
            this.picture256.TabIndex = 6;
            // 
            // picture128
            // 
            this.picture128.Location = new System.Drawing.Point(211, 140);
            this.picture128.Name = "picture128";
            this.picture128.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picture128.Properties.ShowMenu = false;
            this.picture128.Size = new System.Drawing.Size(128, 128);
            this.picture128.TabIndex = 5;
            // 
            // picture96
            // 
            this.picture96.Location = new System.Drawing.Point(79, 140);
            this.picture96.Name = "picture96";
            this.picture96.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picture96.Properties.ShowMenu = false;
            this.picture96.Size = new System.Drawing.Size(96, 96);
            this.picture96.TabIndex = 4;
            // 
            // picture48
            // 
            this.picture48.Location = new System.Drawing.Point(191, 12);
            this.picture48.Name = "picture48";
            this.picture48.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picture48.Properties.ShowMenu = false;
            this.picture48.Size = new System.Drawing.Size(48, 48);
            this.picture48.TabIndex = 3;
            // 
            // picture32
            // 
            this.picture32.Location = new System.Drawing.Point(123, 12);
            this.picture32.Name = "picture32";
            this.picture32.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picture32.Properties.ShowMenu = false;
            this.picture32.Size = new System.Drawing.Size(32, 32);
            this.picture32.TabIndex = 2;
            // 
            // picture24
            // 
            this.picture24.Location = new System.Drawing.Point(63, 12);
            this.picture24.Name = "picture24";
            this.picture24.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picture24.Properties.ShowMenu = false;
            this.picture24.Size = new System.Drawing.Size(24, 24);
            this.picture24.TabIndex = 1;
            // 
            // picture16
            // 
            this.picture16.Location = new System.Drawing.Point(11, 12);
            this.picture16.Name = "picture16";
            this.picture16.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picture16.Properties.ShowMenu = false;
            this.picture16.Size = new System.Drawing.Size(16, 16);
            this.picture16.TabIndex = 0;
            // 
            // openSourceImageDialog
            // 
            this.openSourceImageDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.ico";
            // 
            // saveIconDialog
            // 
            this.saveIconDialog.Filter = "Icon Files (*.ico)|*.ico";
            // 
            // WizardForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 432);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("WizardForm1.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WizardForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image-to-Icon Wizard";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFileEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFilePicture.Properties)).EndInit();
            this.completionWizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture.Properties)).EndInit();
            this.wizardPage2.ResumeLayout(false);
            this.wizardPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture64.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture256.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture128.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture96.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture48.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture32.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture24.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture16.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraEditors.PictureEdit sourceFilePicture;
        private DevExpress.XtraEditors.SimpleButton sourceFileBrowseButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit sourceFileEdit;
        private DevExpress.XtraEditors.XtraOpenFileDialog openSourceImageDialog;
        private DevExpress.XtraWizard.WizardPage wizardPage2;
        private DevExpress.XtraEditors.PictureEdit picture16;
        private DevExpress.XtraEditors.PictureEdit picture256;
        private DevExpress.XtraEditors.PictureEdit picture128;
        private DevExpress.XtraEditors.PictureEdit picture96;
        private DevExpress.XtraEditors.PictureEdit picture48;
        private DevExpress.XtraEditors.PictureEdit picture32;
        private DevExpress.XtraEditors.PictureEdit picture24;
        private DevExpress.XtraEditors.PictureEdit picture64;
        private DevExpress.XtraEditors.XtraSaveFileDialog saveIconDialog;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.PictureEdit iconPicture;
    }
}