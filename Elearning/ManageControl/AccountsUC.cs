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
    public partial class AccountsUC : UserControl
    {
        Database database;
        public AccountsUC()
        {
            InitializeComponent();
            database = new Database(new OleDbConnection(Elearning.Properties.Settings.Default.ConnectionString),new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());
        }
        public AccountsUC(int ID,String user,String email,String pass, String accountType)
        {
            InitializeComponent();
            txtUsername.Text = user;
            txtEmail.Text = email;
            txtPassword.Text = pass;
            lblID.Text = ID.ToString();
            lblAccountType.Text = accountType;
            database = new Database(new OleDbConnection(Elearning.Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                //ContentValues values = new ContentValues();
                //values.Add("Em", txtEmail.Text);
                //database.Delete("Signin", values);
                database.execSql("DELETE FROM Signin WHERE Em = '" + txtEmail.Text + "'");
                this.BackColor = Color.Red;
            }
           
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            ManageControl.AddManager manage = new AddManager(AddManager.Account.Update,new Accounts(Convert.ToInt32(lblID.Text),txtUsername.Text,txtEmail.Text,txtPassword.Text,lblAccountType.Text));
            manage.ShowDialog();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
