using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning
{
    public partial class HandoutViewer : MaterialSkin.Controls.MaterialForm
    {
        public HandoutViewer()
        {
           
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);
            
     //       MessageBox.Show(appPath + @"PDFs\dummy.pdf");
           
        }
        public HandoutViewer(String title,String pdfPath)
        {
            InitializeComponent();
            this.Text = title;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);
            String appPath = AppDomain.CurrentDomain.BaseDirectory;
            webBrowser1.Navigate("file:///" + appPath + pdfPath);

        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(this.Text);
            this.Hide();
            form.ShowDialog();
        }
    }
}
