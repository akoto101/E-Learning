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
using System.IO;
using System.Configuration;
namespace Elearning.ManageControl
{
    public partial class Module : UserControl
    {
        Database database;
        public Module()
        {
            InitializeComponent();

            database = new Database(new OleDbConnection(Elearning.Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());
            label2.Text = "Add Module";
        }
        String IMGPATH;
        String PDFPATH;
        public Module(int ID , String Title, String Description, String ImagePath , String PDFPath)
        {
            InitializeComponent();

            database = new Database(new OleDbConnection(Elearning.Properties.Settings.Default.ConnectionString), new OleDbCommand());
            database.setAdapter(new OleDbDataAdapter());
            lblID.Visible = true;
            lblID.Text = ID.ToString();
            txtTitle.Text = Title;
            txtDescription.Text = Description;
            txtImagePath.Text = ImagePath;
            txtPDFPath.Text = PDFPath;
            label2.Text = "Add Module";
            IMGPATH = ImagePath;
            PDFPATH = PDFPath;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtDescription.Text == "" || txtImagePath.Text == "" || txtPDFPath.Text == "")
            {
                MessageBox.Show("Please Complete All The Fields");
            }
            else { 
            String[] image = txtImagePath.Text.Split('.');
            String[] pdf = txtPDFPath.Text.Split('.');
            ContentValues values = new ContentValues();
            values.Add("Title",txtTitle.Text);
            values.Add("Image_Path", "Images/"+ txtTitle.Text+"."+image[image.Length - 1] );
            values.Add("PDFPath", "PDFs/" +txtTitle.Text + "." + pdf[pdf.Length - 1]);
            values.Add("Description",txtDescription.Text);
                if (lblID.Visible == false)
                {
                  
                    database.Insert("Module_Data", values);
                    if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/Images/" + txtTitle.Text + "." + image[image.Length - 1]))
                    {
                        File.Copy(txtImagePath.Text, AppDomain.CurrentDomain.BaseDirectory + "/Images/" + txtTitle.Text + "." + image[image.Length - 1]);
                    }
                    if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/PDFs/" + txtTitle.Text + "." + pdf[pdf.Length - 1]))
                    {
                        File.Copy(txtPDFPath.Text, AppDomain.CurrentDomain.BaseDirectory + "/PDFs/" + txtTitle.Text + "." + pdf[pdf.Length - 1]);
                    }
                    MessageBox.Show("Module Added Succesfully");
                }
                else
                {
                    database.Update("Module_Data", values, " ID  = " + lblID.Text);
                    try
                    {

                        if (IMGPATH.Equals(txtImagePath.Text))
                        {

                        }
                        else if (PDFPATH.Equals(txtPDFPath.Text))
                        {

                        }
                        else
                        {
                            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/Images/" + txtTitle.Text + "." + image[image.Length - 1]))
                            {
                                File.Copy(txtImagePath.Text, AppDomain.CurrentDomain.BaseDirectory + "/Images/" + txtTitle.Text + "." + image[image.Length - 1]);
                            }
                            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/PDFs/" + pdf[pdf.Length - 1]))
                            {
                                File.Copy(txtPDFPath.Text, AppDomain.CurrentDomain.BaseDirectory + "/PDFs/" + txtTitle.Text + "." + pdf[pdf.Length - 1]);
                            }
                            MessageBox.Show("Updated Added Succesfully");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occur " + ex);
                    }
                    
                }
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Image";
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {              
                 txtImagePath.Text =  openFileDialog1.FileName;
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select PDF";
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.Filter = "Pdf Files|*.pdf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPDFPath.Text = openFileDialog1.FileName;
            }
        }
    }
}
