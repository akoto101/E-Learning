namespace Elearning
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnManage = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnScores = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDBPath = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Location = new System.Drawing.Point(3, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 569);
            this.panel1.TabIndex = 0;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(846, 26);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(74, 36);
            this.materialRaisedButton2.TabIndex = 6;
            this.materialRaisedButton2.Text = "Logout";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // btnManage
            // 
            this.btnManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManage.AutoSize = true;
            this.btnManage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManage.Depth = 0;
            this.btnManage.Icon = null;
            this.btnManage.Location = new System.Drawing.Point(687, 26);
            this.btnManage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnManage.Name = "btnManage";
            this.btnManage.Primary = true;
            this.btnManage.Size = new System.Drawing.Size(78, 36);
            this.btnManage.TabIndex = 7;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnScores
            // 
            this.btnScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScores.AutoSize = true;
            this.btnScores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnScores.Depth = 0;
            this.btnScores.Icon = null;
            this.btnScores.Location = new System.Drawing.Point(769, 26);
            this.btnScores.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScores.Name = "btnScores";
            this.btnScores.Primary = true;
            this.btnScores.Size = new System.Drawing.Size(72, 36);
            this.btnScores.TabIndex = 8;
            this.btnScores.Text = "Scores";
            this.btnScores.UseVisualStyleBackColor = true;
            // 
            // btnDBPath
            // 
            this.btnDBPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDBPath.AutoSize = true;
            this.btnDBPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDBPath.Depth = 0;
            this.btnDBPath.Icon = null;
            this.btnDBPath.Location = new System.Drawing.Point(551, 26);
            this.btnDBPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDBPath.Name = "btnDBPath";
            this.btnDBPath.Primary = true;
            this.btnDBPath.Size = new System.Drawing.Size(130, 36);
            this.btnDBPath.TabIndex = 9;
            this.btnDBPath.Text = "Database Path";
            this.btnDBPath.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 633);
            this.Controls.Add(this.btnDBPath);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1134, 633);
            this.MinimumSize = new System.Drawing.Size(927, 633);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E Learning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton btnManage;
        private MaterialSkin.Controls.MaterialRaisedButton btnScores;
        private MaterialSkin.Controls.MaterialRaisedButton btnDBPath;
    }
}