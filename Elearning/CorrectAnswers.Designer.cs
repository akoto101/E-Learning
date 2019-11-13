namespace Elearning
{
    partial class CorrectAnswers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(38, 14);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(465, 0);
            this.lblQuestion.MinimumSize = new System.Drawing.Size(465, 20);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(465, 20);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Lorem ipsum dolor sit amet, \r\n";
            this.lblQuestion.SizeChanged += new System.EventHandler(this.lblQuestion_SizeChanged);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(13, 13);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(19, 20);
            this.lblNo.TabIndex = 4;
            this.lblNo.Text = "1.";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Correct Answer : ";
            // 
            // lblAnswer
            // 
            this.lblAnswer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(144, 78);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(324, 20);
            this.lblAnswer.TabIndex = 7;
            this.lblAnswer.Text = "Answer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = global::Elearning.Properties.Resources.ic_check;
            this.pictureBox1.Location = new System.Drawing.Point(478, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CorrectAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblNo);
            this.MinimumSize = new System.Drawing.Size(516, 114);
            this.Name = "CorrectAnswers";
            this.Size = new System.Drawing.Size(516, 114);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
