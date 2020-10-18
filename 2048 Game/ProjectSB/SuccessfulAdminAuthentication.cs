using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectSB
{
    public partial class SuccessfulAdminAuthentication : Form
    {
        public SuccessfulAdminAuthentication()
        {
            InitializeComponent();
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            //score not deleted from database
            ScoreBoard obj = new ScoreBoard();
            obj.Show();
            this.Hide(); // redirect to scoreboard.
        }

        private void SuccessfulAdminAuthentication_Load(object sender, EventArgs e)
        {

        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            //selected score deleted from database
            ScoreBoard obj = new ScoreBoard();
            obj.Show();
            this.Hide();
        }
    }
}
