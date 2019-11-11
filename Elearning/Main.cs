using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.IO;

namespace Elearning
{
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        int posX = 50;
        int posY = 10;

        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);


            //ModuleOverView module = new ModuleOverView();
            //module.Top = posY;
            //module.Left = posX;
            //posX = (10 + module.Width + module.Left);
            //ModuleOverView module1 = new ModuleOverView();
            //module1.Top = posY;
            //module1.Left = posX;
            //posX = (10 + module1.Width + module1.Left);
            //ModuleOverView module2 = new ModuleOverView();
            //module2.Top = posY;
            //module2.Left = posX;
            //this.panel1.Controls.Add(module);
            //this.panel1.Controls.Add(module1);
            //this.panel1.Controls.Add(module2);
            var lines = File.ReadLines(@"Module_Data.txt");
            int i = 0;
            foreach (var line in lines)
            {
                i++;
                ModuleOverView module = new ModuleOverView(new Bitmap(parseLine(line)[0]), parseLine(line)[1], parseLine(line)[2]);
                module.Top = posY;
                module.Left = posX;
                posX = (10 + module.Width + module.Left);
                if (0 == i % 3)
                {
                    posY = (10 + module.Height + module.Top);
                    posX = 50;
                    
                }
                this.panel1.Controls.Add(module);
            }
        }
        public String[] parseLine(String a)
        {
            List<String> list = new List<string>();
            String[] arr = a.Split(':');
         
            list.Add(arr[0].Trim());
            list.Add(arr[1].Trim());
           
            list.Add(arr[2].Trim());
            return list.ToArray();
        }
    }
}
