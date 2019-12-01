using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.ManageControl
{
    public partial class AddManager : MaterialSkin.Controls.MaterialForm
    {
        public enum Account
        {
            Update, Add
        }
        public enum Quizs
        {
            Update, Add

        }
        public enum Modules
        {
            Update, Add
        }
        public AddManager()
        {
            InitializeComponent();
          
        }
        public AddManager(Account acc,UserControl control)
        {
            InitializeComponent();
            if (acc == Account.Add)
            {
                panel1.Controls.Add(control);
            }
            else
            {
                panel1.Controls.Add(control);
            }
        }
        public AddManager(Quizs acc, UserControl control)
        {
            InitializeComponent();
            if (acc == Quizs.Add)
            {
                panel1.Controls.Add(control);
            }
            else
            {
                panel1.Controls.Add(control);
            }
        }
        public AddManager(Modules acc, UserControl control)
        {
            InitializeComponent();
            if (acc == Modules.Add)
            {
                panel1.Controls.Add(control);
            }
            else
            {
                panel1.Controls.Add(control);
            }
        }
    }
}
