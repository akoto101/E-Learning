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
namespace Elearning
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        int posX = 4;
        int posY = 4;
        List<String> answerKey = new List<String>();
        List<String> selectedAnswer = new List<String>();
        public Form1()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;

            var lines = File.ReadLines(@"Data.txt");
            foreach (var line in lines)
            {
                Quest a = new Quest(parseLine(line)[0], parseLine(line)[1], new String[] { parseLine(line)[2], parseLine(line)[3], parseLine(line)[4], parseLine(line)[5]}, parseLine(line)[6]);
                a.Top = posY;
                a.Left = 4;
                posY = (a.Top + a.Height +4);
                this.panel1.Controls.Add(a);
              //  MessageBox.Show(a.GetCorrectAnswer());
                answerKey.Add(a.GetCorrectAnswer());

                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);


            }

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            lblTime.Text = new DateTime().AddSeconds(counter).ToString("HH:mm:ss");

        }
       
        public void CheckQuiz()
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
                    if (selectedAnswer[i].ToString().ToLower().Trim().Equals(answerKey[i].ToString().ToLower().Trim()))
                    {
                        score += 1;
                      //  MessageBox.Show(score+"");
                       
                       
                    }
                }
                catch (NullReferenceException)
                {

                    
                }
              
            }
            MessageBox.Show(score + "");
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           
            CheckQuiz();
        }
        public String[] parseLine(String a)
        {
            List<String> list = new List<string>();
            String[] arr = a.Split(':');
            String[] choices = arr[2].Split(',');
            list.Add(arr[0].Trim());
            list.Add(arr[1].Trim());
            list.Add(choices[0].Trim());
            list.Add(choices[1].Trim());
            list.Add(choices[2].Trim());
            list.Add(choices[3].Trim());
            list.Add(arr[3].Trim());
            return list.ToArray();
        }
        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        int counter = 3600;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                timer1.Stop();
            lblTime.Text = new DateTime().AddSeconds(counter).ToString("HH:mm:ss");
        }
    }
}
