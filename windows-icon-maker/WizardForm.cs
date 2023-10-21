using DevExpress.Utils.Design;
using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace windows_icon_maker
{
    public partial class WizardForm : DevExpress.XtraEditors.XtraForm
    {
        enum Outputs
        {
            ICO,
            MIPMAP
        }

        private Outputs Output
        {
            get
            {
                switch(outputSelection.EditValue.ToString())
                {
                    case "mipmap":
                        return Outputs.MIPMAP;
                    case "ico":
                    default:
                        return Outputs.ICO;
                }
            }
        }
        Bitmap sourceFile = null;
        public WizardForm()
        {
            InitializeComponent();
        }

        private void sourceFileBrowseButton_Click(object sender, EventArgs e)
        {
            if (openSourceImageDialog.ShowDialog() == DialogResult.OK)
            {

                // Get the selected image file path
                string selectedImagePath = openSourceImageDialog.FileName;

                // Load the bitmap without locking it
                using (FileStream stream = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        using (Image image = Image.FromStream(stream))
                        {
                            // Display the image file path in the text box
                            sourceFileEdit.Text = selectedImagePath;

                            // Now you can use the 'image' variable for your operations
                            // For example, you can display it in a PictureBox control:
                            if (sourceFile != null)
                            {
                                sourceFile.Dispose();
                            }

                            // Create a copy to avoid locking the file
                            sourceFile = new Bitmap(image);

                            // Display the source image in the preview picture box
                            ReplacePictureEditImage(sourceFilePicture, new Bitmap(sourceFile));

                            // Resize the images to the required sizes and display them.
                            ReplacePictureEditImage(picture16, ResizeBitmap(sourceFile, 16, 16));
                            ReplacePictureEditImage(picture24, ResizeBitmap(sourceFile, 24, 24));
                            ReplacePictureEditImage(picture32, ResizeBitmap(sourceFile, 32, 32));
                            ReplacePictureEditImage(picture36, ResizeBitmap(sourceFile, 36, 36));
                            ReplacePictureEditImage(picture48, ResizeBitmap(sourceFile, 48, 48));
                            ReplacePictureEditImage(picture48_2, ResizeBitmap(sourceFile, 48, 48));
                            ReplacePictureEditImage(picture64, ResizeBitmap(sourceFile, 64, 64));
                            ReplacePictureEditImage(picture64_2, ResizeBitmap(sourceFile, 64, 64));
                            ReplacePictureEditImage(picture72, ResizeBitmap(sourceFile, 72, 72));
                            ReplacePictureEditImage(picture96, ResizeBitmap(sourceFile, 96, 96));
                            ReplacePictureEditImage(picture96_2, ResizeBitmap(sourceFile, 96, 96));
                            ReplacePictureEditImage(picture128, ResizeBitmap(sourceFile, 128, 128));
                            ReplacePictureEditImage(picture144, ResizeBitmap(sourceFile, 144, 144));
                            ReplacePictureEditImage(picture192, ResizeBitmap(sourceFile, 192, 192));
                            ReplacePictureEditImage(picture256, ResizeBitmap(sourceFile, 256, 256));

                            ReplacePictureEditImage(iconPicture, ResizeBitmap(sourceFile, 64, 64));

                            wizardPage1.AllowNext = true;
                        }
                    }
                    catch (ArgumentException)
                    {
                        // Create an error message box:
                        MessageBox.Show("Invalid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    catch (OutOfMemoryException)
                    {
                        // OutOfMemoryException is thrown when the file format is not supported or the image is corrupt.
                        MessageBox.Show("File format not supported or the image is corrupt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ReplacePictureEditImage(PictureEdit pictureBox, Bitmap bitmap)
        {
            if (pictureBox.Image != null)
                pictureBox.Image.Dispose();

            pictureBox.Image = bitmap;
        }

        private Bitmap ResizeBitmap(Bitmap bitmap, int width, int height)
        {
            Bitmap bmp = new Bitmap(bitmap, new Size(width, height));
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawImage(bmp, width, height);
            }
            return bmp;
        }

        private void wizardControl1_FinishClick(object sender, System.ComponentModel.CancelEventArgs e)
        {
            switch (Output)
            {
                case Outputs.ICO:
                    {
                        if (saveIconDialog.ShowDialog() == DialogResult.OK)
                        {
                            using (var stream = new FileStream(saveIconDialog.FileName, FileMode.Create))
                            {
                                IconFactory.SavePngsAsIcon(new[] {
                                    (Bitmap)picture16.Image,
                                    (Bitmap)picture24.Image,
                                    (Bitmap)picture32.Image,
                                    (Bitmap)picture48.Image,
                                    (Bitmap)picture64.Image,
                                    (Bitmap)picture96.Image,
                                    (Bitmap)picture128.Image,
                                    (Bitmap)picture256.Image
                                }, stream);
                            }

                        }
                    }

                    break;
                case Outputs.MIPMAP:
                    {
                        if (saveMipmapDialog.ShowDialog() == DialogResult.OK)
                        {
                            FileNameDialog dialog = new FileNameDialog();
                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                string path = saveMipmapDialog.SelectedPath;
                                string filename = dialog.FileName;

                                Debugger.Break();
                                SaveBitmap((Bitmap)picture36.Image, path + "\\mipmap-ldpi\\" + filename + ".png");
                                SaveBitmap((Bitmap)picture48.Image, path + "\\mipmap-mdpi\\" + filename + ".png");
                                SaveBitmap((Bitmap)picture72.Image, path + "\\mipmap-hdpi\\" + filename + ".png");
                                SaveBitmap((Bitmap)picture96.Image, path + "\\mipmap-xhdpi\\" + filename + ".png");
                                SaveBitmap((Bitmap)picture144.Image, path + "\\mipmap-xxhdpi\\" + filename + ".png");
                                SaveBitmap((Bitmap)picture192.Image, path + "\\mipmap-xxxhdpi\\" + filename + ".png");
                            }
                        }
                    }
                    break;
            }
        

            // Show a success message.
            XtraMessageBox.Show("Icon saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void SaveBitmap(Bitmap bitmap, string outputPath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(outputPath));
            using (FileStream fs = new FileStream(outputPath, FileMode.Create))
            {
                // Save the Bitmap to the FileStream without locking it
                bitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void wizardControl1_CancelClick(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Show a confirmation dialog to close the app.
            DialogResult result = XtraMessageBox.Show("Are you sure you want to exit the wizard?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Close the form.
                Close();
            }
            else
            {
                // Do nothing.
                e.Cancel = true;
            }
        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == wizardPage1)
            {
                switch(Output)
                {
                    case Outputs.ICO:
                        wizardControl1.SelectedPage = wizardPage2;
                        break;
                    case Outputs.MIPMAP:
                        wizardControl1.SelectedPage = wizardPage3;
                        break;
                }
                e.Handled = true;
            }
            else if(e.Page == wizardPage2)
            {
                wizardControl1.SelectedPage = completionWizardPage1;
            }
        }

        private void wizardControl1_PrevClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == wizardPage3)
            {
                wizardControl1.SelectedPage = wizardPage1;
                e.Handled = true;
            }
        }
    }
}