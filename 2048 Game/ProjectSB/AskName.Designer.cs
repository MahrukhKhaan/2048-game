using System;

namespace ProjectSB
{
    partial class AskName
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
            this.label2 = new System.Windows.Forms.Label();
            this.nameinput = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.playbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Image = global::ProjectSB.Properties.Resources.button;
            this.label1.Location = new System.Drawing.Point(147, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "2048 GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(77, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "HI, PLEASE ENTER YOUR NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameinput
            // 
            this.nameinput.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameinput.Location = new System.Drawing.Point(167, 297);
            this.nameinput.Name = "nameinput";
            this.nameinput.Size = new System.Drawing.Size(187, 31);
            this.nameinput.TabIndex = 2;
            // 
            // backbtn
            // 
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.Yellow;
            this.backbtn.Image = global::ProjectSB.Properties.Resources.button;
            this.backbtn.Location = new System.Drawing.Point(43, 379);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(182, 69);
            this.backbtn.TabIndex = 3;
            this.backbtn.Text = "GO BACK";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // playbtn
            // 
            this.playbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playbtn.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbtn.ForeColor = System.Drawing.Color.Yellow;
            this.playbtn.Image = global::ProjectSB.Properties.Resources.button;
            this.playbtn.Location = new System.Drawing.Point(268, 379);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(195, 69);
            this.playbtn.TabIndex = 4;
            this.playbtn.Text = "LET\'S PLAY";
            this.playbtn.UseVisualStyleBackColor = true;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // AskName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectSB.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 547);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.nameinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AskName";
            this.Text = "2048 Game";
            this.Load += new System.EventHandler(this.AskName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameinput;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button playbtn;
    }
}