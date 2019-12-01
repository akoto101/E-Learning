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
    public partial class QuizScores : MaterialSkin.Controls.MaterialForm

    {
        Database database;
        public QuizScores()
        {
            InitializeComponent();
            database = new Database(new OleDbConnection(Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());
        }
    }
}
