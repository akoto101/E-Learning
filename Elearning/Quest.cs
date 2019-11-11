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
    public partial class Quest : UserControl
    {
        String correctAnswer = "";
        public Quest()
        {
            InitializeComponent();
        }
        public Quest(String no, String question , String[] answers, String correctAnswer)
        {
            InitializeComponent();
            this.correctAnswer = correctAnswer;
            lblNo.Text = no;
            lblQuestion.Text = question;
            rbA.Text = answers[0];
            rbB.Text = answers[1];
            rbC.Text = answers[2];
            rbD.Text = answers[3];


        }
        public String GetCorrectAnswer() { return correctAnswer; }
        public String GetSelected()
        {
            if (rbA.Checked)
            {
                return rbA.Text;
            }
            if (rbB.Checked)
            {
                return rbB.Text;
            }
            if (rbC.Checked)
            {
                return rbC.Text;
            }
            if (rbD.Checked)
            {
                return rbD.Text;
            }
            return null;
        }
        public bool IsCorrect() { return GetCorrectAnswer().Equals(GetSelected()); }

        private void lblQuestion_SizeChanged(object sender, EventArgs e)
        {
            this.Height += lblQuestion.Height - 50;
        }
    }
}
