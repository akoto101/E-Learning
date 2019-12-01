namespace Elearning.ManageControl
{
    partial class Quiz
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
            this.dropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChoices = new System.Windows.Forms.TextBox();
            this.txtCorrectAnswer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropdown
            // 
            this.dropdown.BackColor = System.Drawing.Color.Transparent;
            this.dropdown.BorderRadius = 3;
            this.dropdown.ForeColor = System.Drawing.Color.White;
            this.dropdown.Items = new string[0];
            this.dropdown.Location = new System.Drawing.Point(8, 33);
            this.dropdown.Name = "dropdown";
            this.dropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dropdown.selectedIndex = -1;
            this.dropdown.Size = new System.Drawing.Size(427, 35);
            this.dropdown.TabIndex = 0;
            this.dropdown.onItemSelected += new System.EventHandler(this.dropdown_onItemSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Module Title";
            // 
            // lblNo
            // 
            this.lblNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(8, 74);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(39, 20);
            this.lblNo.TabIndex = 2;
            this.lblNo.Text = "1.";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(33, 101);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(402, 137);
            this.txtQuestion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choices (* 1 Per line Max 4)";
            // 
            // txtChoices
            // 
            this.txtChoices.Location = new System.Drawing.Point(33, 269);
            this.txtChoices.Multiline = true;
            this.txtChoices.Name = "txtChoices";
            this.txtChoices.Size = new System.Drawing.Size(402, 137);
            this.txtChoices.TabIndex = 5;
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorrectAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorrectAnswer.HintForeColor = System.Drawing.Color.Empty;
            this.txtCorrectAnswer.HintText = "Correct Answer";
            this.txtCorrectAnswer.isPassword = false;
            this.txtCorrectAnswer.LineFocusedColor = System.Drawing.Color.Empty;
            this.txtCorrectAnswer.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.txtCorrectAnswer.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.txtCorrectAnswer.LineThickness = 2;
            this.txtCorrectAnswer.Location = new System.Drawing.Point(33, 413);
            this.txtCorrectAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(402, 44);
            this.txtCorrectAnswer.TabIndex = 7;
            this.txtCorrectAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(266, 464);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(63, 36);
            this.materialRaisedButton2.TabIndex = 10;
            this.materialRaisedButton2.Text = "Clear ";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(140, 464);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(55, 36);
            this.materialRaisedButton1.TabIndex = 9;
            this.materialRaisedButton1.Text = "Save";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(318, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(117, 20);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "1.";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblID.Visible = false;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChoices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropdown);
            this.Name = "Quiz";
            this.Size = new System.Drawing.Size(459, 516);
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.MouseHover += new System.EventHandler(this.Quiz_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown dropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChoices;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCorrectAnswer;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Label lblID;
    }
}
