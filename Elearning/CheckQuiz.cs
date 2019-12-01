using MaterialSkin;
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
    public partial class CheckQuiz : MaterialSkin.Controls.MaterialForm
    {
        int posY = 4;
        int score = 0;
        int countControls = 0;
        Database database;
       
        public CheckQuiz(List<String> checkAnswer,String Title)
        {

            InitializeComponent();
            this.Text = Title;
            database = new Database(new OleDbConnection(Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());

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
                if (Boolean.Parse(parseString(a)[3]))
                {
                    score++;
                }
            }
            DataTable count = database.Select("Quiz",null," Quiz_Title = '" + this.Text +"'");
             countControls = count.Rows.Count;
            DataTable table = database.Select("Score", null, " Quiz_Title = '" + this.Text+"'");
            table.DefaultView.Sort = "ID";
            table = table.DefaultView.ToTable();
            if (table.Rows.Count != 0)
            {
                ContentValues values = new ContentValues();               
                values.Add("Score", score + " / " + countControls);
                values.Add("isPass", score > (countControls / 2) ? "True" : "False");
                database.Update("Score", values, " Quiz_Title = '" + this.Text+"'");
            }
            else
            {
                ContentValues values = new ContentValues();
                values.Add("Quiz_Title", this.Text);
                values.Add("Score", score + " / " + countControls);
                values.Add("isPass", score > (countControls / 2) ? "True" : "False");
                database.Insert("Score", values);
            }
            timer1.Interval = 1000;
            timer1.Start();
        }
        String[] parseString(String s )
        {
            return s.Split(':'); ;
        }

       

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            new Main().Show();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        { i++;
            if (i == 1)
                MessageBox.Show("Your score is " + score + " out of " + countControls, "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(i == 2)
            {
              
                timer1.Stop();

            } 

        }
    }
    
}
