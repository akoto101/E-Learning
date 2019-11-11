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
        public ModuleOverView(Bitmap bmp,String title,String desc)
        {
            InitializeComponent();
            pictureBox1.Image = bmp;
            lblTitle.Text = title;
            lbldesc.Text = desc;
        }
    }
}
