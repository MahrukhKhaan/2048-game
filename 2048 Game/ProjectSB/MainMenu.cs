using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProjectSB
{
    public partial class MainMenu : Form
    {
        // System.Media.SoundPlayer player = new System.Media.SoundPlayer("D:\SemProSe\The Game\Game\bgm.mp3");
        public MainMenu()
        {
            InitializeComponent();

        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
        }


        private void playbtn_Click(object sender, EventArgs e)
        {
            AskName obj = new AskName();
            obj.Show();
            this.Hide();
        }

        private void scoreboardbtn_Click(object sender, EventArgs e)
        {
            ScoreBoard obj = new ScoreBoard();
            obj.Show();
            this.Hide();
            
            
        }

        private void quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
