using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning
{
    public partial class DatabaseManage : MaterialSkin.Controls.MaterialForm
    {
        public DatabaseManage()
        {
            InitializeComponent();
            txtPath.Text = @"|DataDirectory|\Database.mdb";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("Path must not be Empty! I will bring back the default path");
                txtPath.Text = @"|DataDirectory|\Database.mdb";
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("By emptying password, I will consider it default!");
            }
            else
            {
                Properties.Settings.Default.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtPath.Text + ";Jet OLEDB:Database Password = " + Properties.Settings.Default.DBPassword;
                Properties.Settings.Default.DBPassword = txtEmail.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb;Jet OLEDB:Database Password=12345";
            Properties.Settings.Default.DBPassword = "12345";
            Properties.Settings.Default.Save();
            MessageBox.Show("Database Settings Reset Successfull");
            this.Hide();
        }
    }
}
