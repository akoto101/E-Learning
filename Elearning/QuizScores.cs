using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        int posy = 4;
        public QuizScores()
        {
            InitializeComponent();
            database = new Database(new OleDbConnection(Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());
          
          }

        private void txtUser_OnValueChanged(object sender, EventArgs e)
        {
            Load(txtUser.Text);
        }
        void Load(String x)
        {
            panel1.Controls.Clear();
            DataTable table = database.Select("Score", null, " Quiz_Title = '"+x+ "' or Score = '" + x + "' or isPass = '" + x + "' or Email = '" + x + "' or Us = '" + x + "'");
            table.DefaultView.Sort = "ID";
            table = table.DefaultView.ToTable();
            for (int a = 0; a < table.Rows.Count; a++)
            {
                Scores score = new Scores(
                    table.Rows[a]["Quiz_Title"].ToString(),
                    table.Rows[a]["Score"].ToString(),
                    Boolean.Parse(table.Rows[a]["isPass"].ToString()),
                    table.Rows[a]["Email"].ToString(),
                    table.Rows[a]["Us"].ToString());
                if(panel1.Controls.Count != 0) { 
                score.Top = posy;
                posy = posy + score.Top + score.Height;
              
                }
                panel1.Controls.Add(score);
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
