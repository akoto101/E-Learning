using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Data.OleDb;

namespace Elearning
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        int posX = 4;
        int posY = 4;
        List<String> answerKey = new List<String>();
        List<String> selectedAnswer = new List<String>();
        List<String> question = new List<string>();
        List<String> checkAnswer = new List<String>();

        Database database;

        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        int counter = 3600;
        public Form1()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;

            database = new Database(new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb"), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);

            lblTime.Text = new DateTime().AddSeconds(counter).ToString("HH:mm:ss");

        }
        public Form1(String Title)
        {
            InitializeComponent();
            this.Text = Title;

            database = new Database(new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb"), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);

            lblTime.Text = new DateTime().AddSeconds(counter).ToString("HH:mm:ss");

        }
        public void CheckQuiz()
        {
            panel1.Visible = false;
            timer1.Stop();
            DialogResult result = MessageBox.Show("Are you sure to submit? ", "Finish", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {

                int score = 0;
            selectedAnswer.Clear();
            foreach (Quest q in panel1.Controls)
            {
                selectedAnswer.Add(q.GetSelected());
               // MessageBox.Show(q.GetSelected());
            }
           
            for (int i = 0; i < selectedAnswer.Count; i++)
            {
                try
                {
                    bool checkAnswer = selectedAnswer[i].ToString().ToLower().Trim().Equals(answerKey[i].ToString().ToLower().Trim());
                    this.checkAnswer.Add((i + 1).ToString() + ":" + question[i] + ":" + answerKey[i] + ":" + checkAnswer);                 
                }
                catch (NullReferenceException)
                {

                    
                }
              
            }


                this.Hide();
                CheckQuiz quiz = quiz = new CheckQuiz(checkAnswer);
                quiz.Show();
                
            }
            else
            {
                panel1.Visible = true;
                timer1.Start();
            }
                
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           
            CheckQuiz();
        }
      
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                timer1.Stop();
            lblTime.Text = new DateTime().AddSeconds(counter).ToString("HH:mm:ss");
        }
        int tickStart = 0;
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            DataTable table = database.Select("Quiz", null, " Quiz_Title = '" + this.Text+"'");
         
            tickStart += 1;
            if (tickStart == 1)
            {
                for (int a = 0; a < table.Rows.Count; a++)
                {
                    Quest quiz = new Quest(table.Rows[a]["QuestionNo"].ToString(),
                        table.Rows[a]["Question"].ToString(),
                        new String[] { table.Rows[a]["A"].ToString(), table.Rows[a]["B"].ToString(), table.Rows[a]["C"].ToString(), table.Rows[a]["D"].ToString() },
                        table.Rows[a]["Correct_Answer"].ToString());
                    quiz.Top = posY;
                    quiz.Left = 4;
                    posY = (quiz.Top + quiz.Height + 4);
                    this.panel1.Controls.Add(quiz);
                    //  MessageBox.Show(a.GetCorrectAnswer());
                    answerKey.Add(quiz.GetCorrectAnswer());
                    question.Add(quiz.GetQuestion());



                }

                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000; // 1 second
                timer1.Start();
            }
        }

    }
}
