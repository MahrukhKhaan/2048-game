namespace ProjectSB
{
    partial class ScoreBoard
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
            this.deletebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deletebtn
            // 
            this.deletebtn.BackgroundImage = global::ProjectSB.Properties.Resources.dustbin;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebtn.Location = new System.Drawing.Point(410, 18);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(57, 61);
            this.deletebtn.TabIndex = 0;
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackgroundImage = global::ProjectSB.Properties.Resources.back;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.Location = new System.Drawing.Point(12, 31);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(65, 48);
            this.backbtn.TabIndex = 1;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.BackgroundImage = global::ProjectSB.Properties.Resources.bg;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Image = global::ProjectSB.Properties.Resources.bg;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(108, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "SCORE BOARD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectSB.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.deletebtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScoreBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button button1;
    }
}

