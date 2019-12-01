using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning
{
    public partial class Manage : MaterialSkin.Controls.MaterialForm
    {
        int posY = 4;
        Database database;
        public Manage()
        {
            InitializeComponent();

            database = new Database(new OleDbConnection(Elearning.Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            Bunifu.Framework.UI.BunifuFlatButton accountButton = new Bunifu.Framework.UI.BunifuFlatButton();
            //  button.Location = new Point(473, 46);
            accountButton.Size = new Size(473, 46);
            accountButton.Text = "ADD";
            accountButton.Iconimage = null;
            accountButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            accountButton.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accountButton.Normalcolor = Color.FromArgb(0, 131, 143, 1);
            accountButton.OnHovercolor = Color.FromArgb(0, 96, 100, 1);
            accountButton.OnHoverTextColor = Color.White;
            accountButton.Click += AccountButton_Click;
            posY = (accountButton.Top + accountButton.Height + 4);
            panel1.Controls.Add(accountButton);


            DataTable table = database.Select("Signin", null, "");
            table.DefaultView.Sort = "ID";
            table = table.DefaultView.ToTable();
            for (int a = 0; a < table.Rows.Count; a++)
            {
                ManageControl.AccountsUC acc = new ManageControl.AccountsUC(
                     (int)table.Rows[a]["ID"],
                    table.Rows[a]["Us"].ToString(),
                    table.Rows[a]["Em"].ToString(),
                    table.Rows[a]["Pass"].ToString(),
                    table.Rows[a]["Account_Type"].ToString());
            acc.Top = posY;           
                posY = (acc.Top + acc.Height + 4);
                panel1.Controls.Add(acc);
            }
            posY = 4;
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            ManageControl.AddManager add = new ManageControl.AddManager(ManageControl.AddManager.Account.Add , new  ManageControl.Accounts());
            add.ShowDialog();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Bunifu.Framework.UI.BunifuFlatButton ModuleButton = new Bunifu.Framework.UI.BunifuFlatButton();
            //  button.Location = new Point(473, 46);
            ModuleButton.Size = new Size(473, 46);
            ModuleButton.Text = "ADD";
            ModuleButton.Iconimage = null;
            ModuleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ModuleButton.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ModuleButton.Normalcolor = Color.FromArgb(0, 131, 143, 1);
            ModuleButton.OnHovercolor = Color.FromArgb(0, 96, 100, 1);
            ModuleButton.OnHoverTextColor = Color.White;
            ModuleButton.Click += ModuleButton_Click;
            posY = (ModuleButton.Top + ModuleButton.Height + 4);
            panel1.Controls.Add(ModuleButton);
           

            DataTable table = database.Select("Module_Data", null, "");
            table.DefaultView.Sort = "ID";
            table = table.DefaultView.ToTable();
            for (int a = 0; a < table.Rows.Count; a++)
            {
                ManageControl.ModuleUC acc = new ManageControl.ModuleUC(
                    table.Rows[a]["ID"].ToString(),
                    table.Rows[a]["Title"].ToString(),
                    table.Rows[a]["Description"].ToString(),
                    table.Rows[a]["Image_Path"].ToString(),
                    table.Rows[a]["PDFPath"].ToString());
                acc.Top = posY;
                posY = (acc.Top + acc.Height + 4);
                panel1.Controls.Add(acc);
            }
            posY = 4;
        }

        private void ModuleButton_Click(object sender, EventArgs e)
        {
            ManageControl.AddManager add = new ManageControl.AddManager(ManageControl.AddManager.Modules.Add, new ManageControl.Module());
            add.ShowDialog();
        }

        Bunifu.Framework.UI.BunifuDropdown dropdown;
        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            dropdown = new Bunifu.Framework.UI.BunifuDropdown();
            dropdown.Size = new Size(400, 35);
            dropdown.Location = new Point(8, 7);
            dropdown.NomalColor = Color.FromArgb(0, 131, 143, 1);
            dropdown.onHoverColor = Color.FromArgb(0, 96, 100, 1);
            
            panel1.Controls.Add(dropdown);
            DataTable table = database.Select("Module_Data", null, "");
            table.DefaultView.Sort = "ID";
            table = table.DefaultView.ToTable();
            for (int a = 0; a < table.Rows.Count; a++)
            {
                dropdown.AddItem(table.Rows[a]["Title"].ToString());
            }
            dropdown.onItemSelected += Dropdown_onItemSelected;
            posY = (dropdown.Top + dropdown.Height);
            MaterialSkin.Controls.MaterialRaisedButton button = new MaterialSkin.Controls.MaterialRaisedButton();
            button.Text = "Add";
            button.Click += Button_Click;
            button.Location = new Point(412, 6);
            panel1.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ManageControl.AddManager add = new ManageControl.AddManager(ManageControl.AddManager.Quizs.Add, new ManageControl.Quiz());
            add.ShowDialog();
        }

        private void Dropdown_onItemSelected(object sender, EventArgs e)
        {
            DataTable table = database.Select("Quiz", null, " Quiz_Title = '" + dropdown.selectedValue + "'");
            table.DefaultView.Sort = "ID";
            table = table.DefaultView.ToTable();
            for (int a = 0; a < table.Rows.Count; a++)
            {
                ManageControl.QuizUC quiz = new ManageControl.QuizUC(
                   Convert.ToInt32(table.Rows[a]["ID"].ToString()),
                      table.Rows[a]["QuestionNo"].ToString(),
                      dropdown.selectedValue, 
                      table.Rows[a]["Question"].ToString(),
                      new String[] 
                      {
                          table.Rows[a]["A"].ToString(),
                          table.Rows[a]["B"].ToString(),
                          table.Rows[a]["C"].ToString(),
                          table.Rows[a]["D"].ToString()
                      },
                      table.Rows[a]["Correct_Answer"].ToString()
               
                    );
                quiz.Top = posY;
                posY = (quiz.Top + quiz.Height + 4);
                panel1.Controls.Add(quiz);
            }
        }
    }
}
