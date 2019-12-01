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
    public partial class ModuleUC : UserControl
    {
        Database database;
        public ModuleUC()
        {
            InitializeComponent();
            database = new Database(new OleDbConnection(Elearning.Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());
        }
        public ModuleUC(String ID,String Title,String Desc ,String ImgPath,String PDFPath)
        {
            InitializeComponent();
            txtID.Text = ID;
            txtTitle.Text = Title;
            txtDescription.Text = Desc;
            txtImagePath.Text = ImgPath;
            txtPDFPath.Text = PDFPath;
            database = new Database(new OleDbConnection(Elearning.Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());
        }
        private void ModuleUC_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                //ContentValues values = new ContentValues();
                //values.Add("Em", txtEmail.Text);
                //database.Delete("Signin", values);
                database.execSql("DELETE FROM Module_Data WHERE ID = " + txtID.Text + "");
                txtID.ForeColor = Color.White;
                txtTitle.ForeColor = Color.White;
                txtDescription.ForeColor = Color.White;
                txtImagePath.ForeColor = Color.White;
                txtPDFPath.ForeColor = Color.White;
                this.BackColor = Color.Red;
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            ManageControl.AddManager add = new ManageControl.AddManager(ManageControl.AddManager.Modules.Add, new ManageControl.Module(Convert.ToInt32(txtID.Text),txtTitle.Text,txtDescription.Text,txtImagePath.Text,txtPDFPath.Text));
            add.ShowDialog();
        }
    }
}
