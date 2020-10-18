using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSB
{
    public partial class AskName : Form
    {
        public AskName()
        {
            InitializeComponent();
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu obj = new MainMenu();
            obj.Show();
            
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            if (nameinput.Text == string.Empty)
            {
                MessageBox.Show("Please enter your name.");
            }
            
            else
            {
                PlayGame obj = new PlayGame();
                obj.Show();
                this.Hide();
            }

        }

        private void AskName_Load(object sender, EventArgs e)
        {

        }


    }
}
