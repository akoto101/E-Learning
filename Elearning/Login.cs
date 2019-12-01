using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning
{
    public partial class Login : Form
    {
        Database database;
        public Login()
        {
            InitializeComponent();
            database = new Database(new OleDbConnection(Properties.Settings.Default.ConnectionString), new OleDbCommand());
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            database.setAdapter(new OleDbDataAdapter());
            DataTable dt = database.Select("Signin",null,"Us = '" +txtUser.Text +"' and Pass = '" +txtPassword.Text+"'");
            var rows = dt.Select("Us = '" + txtUser.Text + "' and Pass = '" + txtPassword.Text + "'");
                if (txtUser.Text.Equals("") || txtPassword.Text.Equals(""))
                {
                   
                        MessageBox.Show("Enter Credentials!", "Oopps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    

                }
                else if (rows.Count() != 0)
                {
                  Properties.Settings.Default.UserType = rows[0]["Account_Type"].ToString();
                Properties.Settings.Default.Save();
                    MessageBox.Show("Credentials Accepted!", "Login Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    new Main().ShowDialog();
                }
                else {
                
                        MessageBox.Show("Incorrect Username or Password!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    
                 }
            
          
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateAccount().Show();
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }
    }
}
