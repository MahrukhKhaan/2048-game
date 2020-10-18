namespace   ProjectSB
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.playbtn = new System.Windows.Forms.Button();
            this.scoreboardbtn = new System.Windows.Forms.Button();
            this.quitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Image = global::ProjectSB.Properties.Resources.button;
            this.label1.Location = new System.Drawing.Point(130, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "2048 GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playbtn
            // 
            this.playbtn.BackColor = System.Drawing.Color.Black;
            this.playbtn.BackgroundImage = global::ProjectSB.Properties.Resources.button;
            this.playbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playbtn.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbtn.ForeColor = System.Drawing.Color.Yellow;
            this.playbtn.Location = new System.Drawing.Point(138, 196);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(224, 76);
            this.playbtn.TabIndex = 1;
            this.playbtn.Text = "PLAY";
            this.playbtn.UseVisualStyleBackColor = false;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // scoreboardbtn
            // 
            this.scoreboardbtn.BackColor = System.Drawing.Color.Black;
            this.scoreboardbtn.BackgroundImage = global::ProjectSB.Properties.Resources.button;
            this.scoreboardbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scoreboardbtn.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardbtn.ForeColor = System.Drawing.Color.Yellow;
            this.scoreboardbtn.Location = new System.Drawing.Point(138, 303);
            this.scoreboardbtn.Name = "scoreboardbtn";
            this.scoreboardbtn.Size = new System.Drawing.Size(224, 87);
            this.scoreboardbtn.TabIndex = 2;
            this.scoreboardbtn.Text = "SCOREBOARD";
            this.scoreboardbtn.UseVisualStyleBackColor = false;
            this.scoreboardbtn.Click += new System.EventHandler(this.scoreboardbtn_Click);
            // 
            // quitbtn
            // 
            this.quitbtn.BackColor = System.Drawing.Color.Black;
            this.quitbtn.BackgroundImage = global::ProjectSB.Properties.Resources.button;
            this.quitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitbtn.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitbtn.ForeColor = System.Drawing.Color.Yellow;
            this.quitbtn.Location = new System.Drawing.Point(138, 428);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.Size = new System.Drawing.Size(224, 73);
            this.quitbtn.TabIndex = 3;
            this.quitbtn.Text = "QUIT";
            this.quitbtn.UseVisualStyleBackColor = false;
            this.quitbtn.Click += new System.EventHandler(this.quitbtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectSB.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 547);
            this.Controls.Add(this.quitbtn);
            this.Controls.Add(this.scoreboardbtn);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "2048 Game";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.Button scoreboardbtn;
        private System.Windows.Forms.Button quitbtn;
    }
}

