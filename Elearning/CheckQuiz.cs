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
    public partial class CheckQuiz : MaterialSkin.Controls.MaterialForm
    {
        int posY = 4;
        public CheckQuiz(List<String> checkAnswer)
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);
            foreach (String a in checkAnswer)
            {
                CorrectAnswers answers = new CorrectAnswers(parseString(a)[0], parseString(a)[1], parseString(a)[2], Boolean.Parse(parseString(a)[3]));
                answers.Top = posY;
                answers.Left = 4;
                posY = (answers.Top + answers.Height + 4);
                this.panel1.Controls.Add(answers);
            }
            
        }
        String[] parseString(String s )
        {
            return s.Split(':'); ;
        }
   
    }
    
}
