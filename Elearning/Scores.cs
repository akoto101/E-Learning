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
    public partial class Scores : UserControl
    {
    
        public Scores()
        {
            InitializeComponent();

        }
        public Scores(String Title ,String Score,bool isPass,String user,String email)
        {
            InitializeComponent();
            panelColor.BackColor = isPass ? Color.Green : Color.Red;
            lblTitle.Text = Title;
            lblScore.Text = Score;
        }
    }
}
