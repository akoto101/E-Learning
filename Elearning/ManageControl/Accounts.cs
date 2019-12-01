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
    public partial class Accounts : UserControl
    {
        Database database;
        public Accounts()
        {
            InitializeComponent();
           
            database = new Database(new OleDbConnection(Elearning.Properties.Settings.Default.ConnectionString),new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());

            label2.Text = "Create Account";
        }
        int ID = 0;
        public Accounts(int Id,String username, String email,String password,String accountType)
        {
            InitializeComponent();

            database = new Database(new OleDbConnection(Elearning.Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());
            lblID.Text = Id.ToString();
            txtUser.Text = username;
            txtEmail.Text = email;
            txtPassword.Text = password;
            label2.Text = "Update Account";
            if (accountType == "Admin")
                rbAdmin.Checked = true;
            else rbStudent.Checked = true;
            lblID.Visible = true;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (!rbAdmin.Checked && !rbStudent.Checked)
            {
                MessageBox.Show("Select Account Type!");
            }
            else if (txtUser.Text == "")
                MessageBox.Show("Please Enter Username!");
            else if (txtEmail.Text == "")
                MessageBox.Show("Please Enter Email!");
            else if (txtPassword.Text == "")
                MessageBox.Show("Please Enter Password!");
            else
            {
                if (lblID.Visible == true)
                {
                    ContentValues values = new ContentValues();
                    values.Add("Account_Type", rbAdmin.Checked ? "Admin" : "User");
                    values.Add("Us", txtUser.Text);
                    values.Add("Pass", txtPassword.Text);
                    values.Add("Em", txtEmail.Text);
                    database.Update("Signin", values, " ID = " + lblID.Text);
                   

                }
                else
                {
                    ContentValues values = new ContentValues();
                    values.Add("Account_Type", rbAdmin.Checked ? "Admin" : "User");
                    values.Add("Us", txtUser.Text);
                    values.Add("Pass", txtPassword.Text);
                    values.Add("Em", txtEmail.Text);
                    database.Insert("Signin", values);
                }
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtUser.Text = "";
            rbAdmin.Checked = false;
            rbStudent.Checked = false;
        }
    }
}
