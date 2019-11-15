using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning
{
    public partial class ModuleOverView : UserControl
    {
        public ModuleOverView()
        {
            InitializeComponent();
        }
        String Path = "";
        public ModuleOverView(Bitmap bmp,String title,String desc,String pdfPath)
        {
            InitializeComponent();
            pictureBox1.Image = bmp;
            lblTitle.Text = title;
            lbldesc.Text = desc;
            Path = pdfPath;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            HandoutViewer hV = new HandoutViewer(lblTitle.Text, Path);
            Form tmp = this.FindForm();
            tmp.Hide();
            tmp.Dispose();
            hV.ShowDialog();
        }
    }
}
