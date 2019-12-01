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
    public partial class QuizUC : UserControl
    {
        String cAnswer = "";
        public QuizUC()
        {
            InitializeComponent();
        }
        Database database;
        String[] choices;
        String Quiz_Title = "";
        public QuizUC(int ID,String No,String Quiz_Title ,String Question,String[] choices ,String CorrectAnswer)
        {
            InitializeComponent();
            lblID.Text = ID.ToString();
            lblNo.Text = No;
            lblQuestion.Text = Question;
            rbA.Text = choices[0];
            rbB.Text = choices[1];
            rbC.Text = choices[2];
            rbD.Text = choices[3];
            cAnswer = CorrectAnswer;
            this.Quiz_Title = Quiz_Title;
            this.choices = choices;
            database = new Database(new OleDbConnection(Elearning.Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());
        }

        private void lblQuestion_SizeChanged(object sender, EventArgs e)
        {
            this.Height += lblQuestion.Height - 50;
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                //ContentValues values = new ContentValues();
                //values.Add("Em", txtEmail.Text);
                //database.Delete("Signin", values);
                database.execSql("DELETE FROM Quiz WHERE Question = '" + lblQuestion.Text + "'");
                lblQuestion.ForeColor = Color.White;
                lblNo.ForeColor = Color.White;
                rbA.ForeColor = Color.White;
                rbB.ForeColor = Color.White;
                rbC.ForeColor = Color.White;
                rbD.ForeColor = Color.White;
                this.BackColor = Color.Red;
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            ManageControl.AddManager manage = new AddManager(AddManager.Quizs.Update,new Quiz(Convert.ToInt32(lblID.Text), Quiz_Title, lblNo.Text,lblQuestion.Text,choices,cAnswer));
            manage.ShowDialog();
        }
    }
}
