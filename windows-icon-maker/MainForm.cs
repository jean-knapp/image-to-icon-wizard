using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using windows_knapp_winforms.Forms;

namespace windows_icon_maker
{
    public partial class MainForm : BaseForm
    {
        Bitmap OriginalBitmap = null;
        string OriginalFilePath { get; set; } = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void openBaseImageButton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Portable Network Graphic (*.png)|*.png|JPEG (*.jpg;*.jpeg;*.jpe;*.jfif;*.jfi)|*.jpg;*.jpeg;*.jpe;*.jfif;*.jfi|Bitmap (*.bmp)|*.bmp|Graphics Interchange Format (*.gif)|*.gif|Icon (*.ico)|*.ico|Tagged Image File Format (*.tif)|*.tiff|Exchangeable image file format (*.exif)|*.exif|EMF (*.emf)|*.emf|WMF (*.wmf)|*.wmf"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OriginalBitmap = (Bitmap)Bitmap.FromFile(dialog.FileName);

                    ReplacePictureboxImage(pictureBox1, OriginalBitmap);

                    OriginalFilePath = dialog.FileName;

                    ReplacePictureboxImage(pictureBox256, ResizeBitmap(OriginalBitmap, 256, 256));
                    ReplacePictureboxImage(pictureBox48, ResizeBitmap(OriginalBitmap, 48, 48));
                    ReplacePictureboxImage(pictureBox32, ResizeBitmap(OriginalBitmap, 32, 32));
                    ReplacePictureboxImage(pictureBox16, ResizeBitmap(OriginalBitmap, 16, 16));
                } catch (Exception)
                {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        private void ReplacePictureboxImage(PictureBox pictureBox, Bitmap bitmap)
        {
            if (pictureBox.Image != null)
                pictureBox.Image.Dispose();

            pictureBox.Image = bitmap;
        }

        private Bitmap ResizeBitmap(Bitmap bitmap, int width, int height)
        {
            Bitmap bmp = new Bitmap(bitmap, new Size(width, height));
            using (Graphics graphics = Graphics.FromImage(bmp)) {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawImage(bmp, width, height);
            }
            return bmp;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Icon (*.ico)|*.ico"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new FileStream(dialog.FileName, FileMode.Create))
                {
                    IconFactory.SavePngsAsIcon(new[] { (Bitmap)pictureBox16.Image, (Bitmap)pictureBox32.Image, (Bitmap)pictureBox48.Image, (Bitmap)pictureBox256.Image }, stream);
                }
            }
        }
    }
}
