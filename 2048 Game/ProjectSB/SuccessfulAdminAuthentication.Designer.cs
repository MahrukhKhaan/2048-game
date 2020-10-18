namespace ProjectSB
{
    partial class SuccessfulAdminAuthentication
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
            this.yesbtn = new System.Windows.Forms.Button();
            this.nobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Are you sure you want to delete all scores?";
            // 
            // yesbtn
            // 
            this.yesbtn.BackColor = System.Drawing.Color.Transparent;
            this.yesbtn.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yesbtn.Image = global::ProjectSB.Properties.Resources.bg;
            this.yesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yesbtn.Location = new System.Drawing.Point(63, 141);
            this.yesbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(100, 37);
            this.yesbtn.TabIndex = 12;
            this.yesbtn.Text = "YES";
            this.yesbtn.UseVisualStyleBackColor = false;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
            // 
            // nobtn
            // 
            this.nobtn.BackColor = System.Drawing.Color.Transparent;
            this.nobtn.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nobtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nobtn.Image = global::ProjectSB.Properties.Resources.bg;
            this.nobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nobtn.Location = new System.Drawing.Point(193, 141);
            this.nobtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(100, 37);
            this.nobtn.TabIndex = 13;
            this.nobtn.Text = "NO";
            this.nobtn.UseVisualStyleBackColor = false;
            this.nobtn.Click += new System.EventHandler(this.nobtn_Click);
            // 
            // SuccessfulAdminAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectSB.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(367, 243);
            this.Controls.Add(this.nobtn);
            this.Controls.Add(this.yesbtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuccessfulAdminAuthentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Authentication";
            this.Load += new System.EventHandler(this.SuccessfulAdminAuthentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesbtn;
        private System.Windows.Forms.Button nobtn;
    }
}