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
        public CheckQuiz()
        {
            InitializeComponent();
            CorrectAnswers answers = new CorrectAnswers();
            answers.Top = posY;
            answers.Left = 4;
            posY = (answers.Top + answers.Height + 4);
            this.panel1.Controls.Add(answers);
        }
        int posY = 4;
        public void Add(String number, String question, String correctAnswer, bool isCorrect)
        {
            CorrectAnswers answers = new CorrectAnswers(number,question,correctAnswer,isCorrect);
            answers.Top = posY;
            answers.Left = 4;
            posY = (answers.Top + answers.Height + 4);
            this.panel1.Controls.Add(answers);
        }
    }
}
