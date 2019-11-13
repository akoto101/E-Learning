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
    public partial class CorrectAnswers : UserControl
    {
        public CorrectAnswers()
        {
            InitializeComponent();
        }
        public CorrectAnswers(String number,String question,String correctAnswer,bool isCorrect)
        {
            lblNo.Text = number;
            lblQuestion.Text = question;
            lblAnswer.Text = correctAnswer;
            pictureBox1.Image = isCorrect ? Properties.Resources.ic_check : Properties.Resources.ic_wrongs;
        }

        private void lblQuestion_SizeChanged(object sender, EventArgs e)
        {
            this.Height += lblQuestion.Height - 50;
        }
    }
}
