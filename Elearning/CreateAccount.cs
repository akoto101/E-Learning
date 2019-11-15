using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace Elearning
{
    public partial class CreateAccount : Form
    {
        Database database;
        public CreateAccount()
        {
            InitializeComponent();
            database = new Database(new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb"),new OleDbCommand());
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtConfirm.Text == "" )
            {
                MessageBox.Show("Please Fill out Information!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                   ContentValues data = new ContentValues();                
                    data.Add("Us", txtUser.Text);
                    data.Add("Pass", txtPassword.Text);
                    data.Add("Em", txtEmail.Text);

                    
                    database.Insert("Signin", data);

                    
                }
                else
                    MessageBox.Show("Password didn't match!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void txtConfirm_OnValueChanged(object sender, EventArgs e)
        {
            txtConfirm.isPassword = true;
        }
    }
}
