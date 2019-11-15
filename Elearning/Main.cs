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
using System.Data.OleDb;

namespace Elearning
{
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        int posX = 50;
        int posY = 10;
        Database database;
        public Main()
        {
            InitializeComponent();

            database = new Database(new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb"), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);

            int i = 0;
        
           
           DataTable table = database.Select("Module_Data",null,"");
           table.DefaultView.Sort = "ID";
           table = table.DefaultView.ToTable();

            for (int a = 0; a < table.Rows.Count;a++) { 
                ModuleOverView module = new ModuleOverView(
                    new Bitmap(table.Rows[a]["Image_Path"].ToString()), 
                    table.Rows[a]["Title"].ToString(),
                    table.Rows[a]["Description"].ToString(),
                    table.Rows[a]["PDFPath"].ToString());
                module.Top = posY;
                module.Left = posX;
                i += 1;
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

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {

        }
    }
}
