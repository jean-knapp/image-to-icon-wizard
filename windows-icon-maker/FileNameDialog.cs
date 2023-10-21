using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_icon_maker
{
    public partial class FileNameDialog : DevExpress.XtraEditors.XtraForm
    {
        public string FileName
        {
            get
            {
                return fileNameEdit.Text;
            }
        }

        public FileNameDialog()
        {
            InitializeComponent();
        }
    }
}