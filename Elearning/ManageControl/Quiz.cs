using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Elearning.ManageControl
{
    public partial class Quiz : UserControl
    {
        Database database;
        public Quiz()
        {


            InitializeComponent();

            database = new Database(new OleDbConnection(Elearning.Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());
            Loads();
        }
        public Quiz(int Id,String QuizTitle,String QuizNo,String Question , String[] choices ,String correctAnswer)
        {
            InitializeComponent();
            
            database = new Database(new OleDbConnection(Elearning.Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());
            lblID.Text = Id.ToString();
            lblID.Visible = true;
            lblNo.Text = QuizNo;
          //  Loads();
            txtQuestion.Text = Question;
            foreach (String a in choices)
            {
                txtChoices.AppendText(a  + Environment.NewLine);
            }
            txtCorrectAnswer.Text = correctAnswer;
            dropdown.AddItem(QuizTitle);
        }

        private void dropdown_onItemSelected(object sender, EventArgs e)
        { 
            if(lblID.Visible == false)
        {
                DataTable table = database.Select("Quiz", null, "");
                table.DefaultView.Sort = "ID";
                table = table.DefaultView.ToTable();
                lblNo.Text = (table.Rows.Count + 1).ToString();
            }
           
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            ContentValues values = new ContentValues();
            values.Add("Quiz_Title",dropdown.selectedValue);
            values.Add("QuestionNo", lblNo.Text);
            values.Add("Question",txtQuestion.Text);
            String[] choices = txtChoices.Text.Split('\n');
            values.Add("A", choices[0]);
            values.Add("B", choices[1]);
            values.Add("C", choices[2]);
            values.Add("D", choices[3]);
            values.Add("Correct_Answer", txtCorrectAnswer.Text);
            if (lblID.Visible == false)
            {
                database.Insert("Quiz", values);
                MessageBox.Show("Data Added Succesfully");
            }
            else
            {
                database.Update("Quiz", values," ID = " + lblID.Text);
                MessageBox.Show("Data Updated Succesfully");
            }
          
        }

        private void Quiz_Load(object sender, EventArgs e)
        {

        }
        public void Loads()
        {
            DataTable table = database.Select("Module_Data", null, "");
            table.DefaultView.Sort = "ID";
            table = table.DefaultView.ToTable();
            for (int a = 0; a < table.Rows.Count; a++)
            {
                dropdown.AddItem(table.Rows[a]["Title"].ToString());
            }
        }
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void Quiz_MouseHover(object sender, EventArgs e)
        {
          //  Loads();
        }
    }
}
