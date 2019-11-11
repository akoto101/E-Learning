namespace Elearning
{
    partial class Quest
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
            this.lblNo = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbA = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbB = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbD = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbC = new MaterialSkin.Controls.MaterialRadioButton();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(14, 11);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(19, 20);
            this.lblNo.TabIndex = 2;
            this.lblNo.Text = "1.";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(39, 11);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(445, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(203, 20);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Lorem ipsum dolor sit amet, \r\n";
            this.lblQuestion.SizeChanged += new System.EventHandler(this.lblQuestion_SizeChanged);
            // 
            // rbA
            // 
            this.rbA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbA.AutoSize = true;
            this.rbA.Depth = 0;
            this.rbA.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbA.Location = new System.Drawing.Point(36, 76);
            this.rbA.Margin = new System.Windows.Forms.Padding(0);
            this.rbA.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbA.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbA.Name = "rbA";
            this.rbA.Ripple = true;
            this.rbA.Size = new System.Drawing.Size(163, 30);
            this.rbA.TabIndex = 4;
            this.rbA.TabStop = true;
            this.rbA.Text = "materialRadioButton1";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbB.AutoSize = true;
            this.rbB.Depth = 0;
            this.rbB.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbB.Location = new System.Drawing.Point(36, 112);
            this.rbB.Margin = new System.Windows.Forms.Padding(0);
            this.rbB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbB.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbB.Name = "rbB";
            this.rbB.Ripple = true;
            this.rbB.Size = new System.Drawing.Size(163, 30);
            this.rbB.TabIndex = 5;
            this.rbB.TabStop = true;
            this.rbB.Text = "materialRadioButton2";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbD.AutoSize = true;
            this.rbD.Depth = 0;
            this.rbD.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbD.Location = new System.Drawing.Point(288, 108);
            this.rbD.Margin = new System.Windows.Forms.Padding(0);
            this.rbD.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbD.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbD.Name = "rbD";
            this.rbD.Ripple = true;
            this.rbD.Size = new System.Drawing.Size(163, 30);
            this.rbD.TabIndex = 7;
            this.rbD.TabStop = true;
            this.rbD.Text = "materialRadioButton3";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbC.AutoSize = true;
            this.rbC.Depth = 0;
            this.rbC.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbC.Location = new System.Drawing.Point(288, 72);
            this.rbC.Margin = new System.Windows.Forms.Padding(0);
            this.rbC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbC.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbC.Name = "rbC";
            this.rbC.Ripple = true;
            this.rbC.Size = new System.Drawing.Size(163, 30);
            this.rbC.TabIndex = 6;
            this.rbC.TabStop = true;
            this.rbC.Text = "materialRadioButton4";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // Quest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblNo);
            this.Name = "Quest";
            this.Size = new System.Drawing.Size(505, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblQuestion;
        private MaterialSkin.Controls.MaterialRadioButton rbA;
        private MaterialSkin.Controls.MaterialRadioButton rbB;
        private MaterialSkin.Controls.MaterialRadioButton rbD;
        private MaterialSkin.Controls.MaterialRadioButton rbC;
    }
}
