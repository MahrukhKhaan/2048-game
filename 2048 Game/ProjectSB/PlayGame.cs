using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Media;

namespace ProjectSB
{
    public partial class PlayGame : Form
    {
        
        SoundPlayer sound = new SoundPlayer(Application.StartupPath + "/andiem.wav");//winning sound
        SoundPlayer sound2 = new SoundPlayer(Application.StartupPath + "/blip.wav");//losing sound
        Random Rd = new Random();
       // bool tryagain = true;
        static ArrayList seq1 = new ArrayList();//sequence1
        public PlayGame()
        {
            /*The up and down movement and the right and left movement do the opposite operation, that is,
            one increases the sequence while the other decreases
            their common point is to add the numbers in the texts and add the existing score.
            */
            InitializeComponent();
            
            gameoverlbl.Hide();
           // aboutbtn.Enabled = false;
           // newbtn.Enabled = false;
            
        }

        // this function sets the color of the numbers and the blank tiles
        public void color()
        {
            Label[,] Game = {
                             {tile1,tile2,tile3,tile4},
                             {tile5,tile6,tile7,tile8},
                             {tile9,tile10,tile11,tile12},
                             {tile13,tile14,tile15,tile16}
                             };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[i, j].Text == "")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.DarkMagenta;
                    }
                    if (Game[i, j].Text == "2")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.LightGray;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "4")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Gray;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "8")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Orange;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "16")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.OrangeRed;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "32")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.DarkOrange;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "64")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.LightPink;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "128")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Red;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "256")
                    {
                        Game[i, j].BackColor = Color.DarkRed;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "512")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.LightBlue;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "1024")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Blue;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "2048")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Green;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }

                }
            }
        }
        public void generateNum()
        {
        seq1.Clear();
        Label[,] Game = {                                   //adding all tiles to the array 'seq1'
                            {tile1,tile2,tile3,tile4},
                            {tile5,tile6,tile7,tile8},
                            {tile9,tile10,tile11,tile12},
                            {tile13,tile14,tile15,tile16}
                         }; 
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[i, j].Text == "")
                    {
                        seq1.Add(i * 4 + j + 1); // Since there are 16 tiles and 2 nesting loops
                    }
                }
            }
            if (seq1.Count > 0)                    //produces '2' on every move on a random tile
            {               
                int fillnum = int.Parse(seq1[Rd.Next(0, seq1.Count - 1)].ToString());
                int irand = (fillnum - 1) / 4;
                int jrand = (fillnum - 1) - irand * 4;
                int seq2 = Rd.Next(1, 10);  
                Game[irand, jrand].Text = "2";
            }
            color();
        }

        public void upwardMovement() //upward movement operation
        {
            bool upwardcontrol = true;
            bool match = false;
            bool newnum = false;
            Label[,] Game = { //throwing the tiles into the series
                             {tile1,tile2,tile3,tile4},
                             {tile5,tile6,tile7,tile8},
                             {tile9,tile10,tile11,tile12},
                             {tile13,tile14,tile15,tile16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int total = 0;
                for (int j = 0; j < 4; j++)
                {
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[k, i].Text != "")
                        {
                            if (Game[k, i].Text == Game[j, i].Text)
                            {
                                match = true;
                            }
                            break;
                        }
                    }
                    if (Game[j, i].Text == "")
                    {
                        total++; //if a text of the same number value is filled up, it collects the score
                    }
                    else
                    {
                        //produces a tile on upward movement
                        for (int m = j; m >= 0; m--)
                        {
                            if (Game[m, i].Text == "")
                            {
                                newnum = true;
                                break;          
                            }
                        }
                        if (j + 1 < 4)
                        {
                            bool extranum = true;

                            for (int k = j + 1; k < 4; k++)
                            {
                                if (Game[k, i].Text != "")
                                {
                                    if (Game[j, i].Text == Game[k, i].Text) //if there are numbers to add, performs SCORE addition
                                    {
                                        upwardcontrol = false;
                                        //score addition is equal to twice the number of tile matched                       
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[j, i].Text) * 2).ToString();

                                        newnum = true;
                                        extranum = false;
                                        Game[j, i].Text = (int.Parse(Game[j, i].Text) * 2).ToString();
                                        if (total != 0)
                                        {
                                            Game[j - total, i].Text = Game[j, i].Text;
                                            Game[j, i].Text = "";

                                        }
                                        Game[k, i].Text = "";

                                        break;

                                    }
                                    break;
                                }
                            }
                            if (extranum == true && total != 0)
                            {
                                upwardcontrol = false;
                                Game[j - total, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }
                        else
                        {
                            if (total != 0)
                            {
                                upwardcontrol = false;
                                Game[j - total, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }


                    }
                }
            }
            if (upwardcontrol == false && match == true)
            {
                sound.Play();
            }
            if (upwardcontrol == false && match == false)
            {
                sound2.Play();
            }
            if (newnum == true)
            {
                generateNum();
            }

        }
        private void playgame_Load(object sender, EventArgs e)
        {
            generateNum();
            generateNum();// the numbers that will be given when the game starts
        }
        public void downwardMovement() //downward movement operation
        {
            bool downwardcontrol = true;
            bool match = false;
            bool newnum = false;
            Label[,] Game = {
                             {tile1,tile2,tile3,tile4},
                             {tile5,tile6,tile7,tile8},
                             {tile9,tile10,tile11,tile12},
                             {tile13,tile14,tile15,tile16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int total = 0;
                for (int j = 3; j >= 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (Game[k, i].Text != "")
                        {
                            if (Game[k, i].Text == Game[j, i].Text)
                            {
                                match = true;
                            }
                            break;
                        }
                    }
                    if (Game[j, i].Text == "")
                    {
                        total++;
                    }
                    else
                    {
                        for (int m = j + 1; m <= 3; m++)
                        {
                            if (Game[m, i].Text == "")
                            {
                                newnum = true;
                                break;
                            }
                        }
                        if (j - 1 >= 0)
                        {
                            bool extranum = true;

                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (Game[k, i].Text != "")
                                {
                                    if (Game[j, i].Text == Game[k, i].Text)
                                    {
                                        downwardcontrol = false;
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[j, i].Text) * 2).ToString();

                                        newnum = true;
                                        extranum = false;
                                        Game[j, i].Text = (int.Parse(Game[j, i].Text) * 2).ToString();
                                        if (total != 0)
                                        {
                                            Game[j + total, i].Text = Game[j, i].Text;
                                            Game[j, i].Text = "";

                                        }
                                        Game[k, i].Text = "";
                                        break;

                                    }
                                    break;
                                }
                            }
                            if (extranum == true && total != 0)
                            {
                                downwardcontrol = false;
                                Game[j + total, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }
                        else
                        {
                            if (total != 0)
                            {
                                downwardcontrol = false;
                                Game[j + total, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }


                    }
                }
            }
            if (downwardcontrol == false && match == true)
            {
                sound.Play();
            }
            if (downwardcontrol == false && match == false)
            {
                sound2.Play();
            }
            if (newnum == true)
            {
                generateNum();
            }
        }
        public void leftMovement() //left movement operation
        {
            bool leftcontrol = true;
            bool match = false;
            bool newnum = false;
            Label[,] Game = {
                             {tile1,tile2,tile3,tile4},
                             {tile5,tile6,tile7,tile8},
                             {tile9,tile10,tile11,tile12},
                             {tile13,tile14,tile15,tile16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int total = 0;
                for (int j = 0; j < 4; j++)
                {

                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[i, k].Text != "")
                        {
                            if (Game[i, j].Text == Game[i, k].Text)
                            {
                                match = true;
                            }
                            break;
                        }
                    }
                    if (Game[i, j].Text == "")
                    {
                        total++;
                    }
                    else
                    {
                        for (int m = j - 1; m >= 0; m--)
                        {
                            if (Game[i, m].Text == "")
                            {
                                newnum = true;
                                break;
                            }
                        }
                        if (j + 1 < 4)
                        {
                            bool extranum = true;

                            for (int k = j + 1; k < 4; k++)
                            {
                                if (Game[i, k].Text != "")
                                {

                                    if (Game[i, j].Text == Game[i, k].Text)
                                    {
                                        leftcontrol = false;
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[i, j].Text) * 2).ToString();

                                        newnum = true;
                                        extranum = false;
                                        Game[i, j].Text = (int.Parse(Game[i, j].Text) * 2).ToString();
                                        if (total != 0)
                                        {
                                            Game[i, j - total].Text = Game[i, j].Text;
                                            Game[i, j].Text = "";

                                        }
                                        Game[i, k].Text = "";
                                        break;

                                    }
                                    break;
                                }
                            }
                            if (extranum == true && total != 0)
                            {
                                leftcontrol = false;
                                Game[i, j - total].Text = Game[i, j].Text;
                                Game[i, j].Text = "";

                            }
                        }
                        else
                        {
                            if (total != 0)
                            {
                                leftcontrol = false;
                                Game[i, j - total].Text = Game[i, j].Text;
                                Game[i, j].Text = "";

                            }
                        }


                    }
                }
            }
            if (leftcontrol == false && match == true)
            {
                sound.Play();
            }
            if (leftcontrol == false && match == false)
            {
                sound2.Play();
            }
            if (newnum == true)
            {
                generateNum();
            }
        }
        public void rightMovement() //right movement operation
        {
            bool rightcontrol = true;
            bool match = false;
            bool newnum = false;
            Label[,] Game = { 
                             {tile1,tile2,tile3,tile4},
                             {tile5,tile6,tile7,tile8},
                             {tile9,tile10,tile11,tile12},
                             {tile13,tile14,tile15,tile16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int total = 0;
                for (int j = 3; j >= 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (Game[i, k].Text != "")
                        {
                            if (Game[i, k].Text == Game[i, j].Text)
                            {
                                match = true;
                            }
                            break;
                        }
                    }
                    if (Game[i, j].Text == "")
                    {
                        total++;
                    }
                    else
                    {
                        for (int m = j + 1; m < 4; m++)
                        {
                            if (Game[i, m].Text == "")
                            {
                                newnum = true;
                                break;
                            }
                        }
                        if (j - 1 >= 0)
                        {
                            bool extranum = true;

                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (Game[i, k].Text != "")
                                {


                                    if (Game[i, j].Text == Game[i, k].Text)
                                    {
                                        rightcontrol = false;
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[i, j].Text) * 2).ToString();

                                        newnum = true;
                                        extranum = false;
                                        Game[i, j].Text = (int.Parse(Game[i, j].Text) * 2).ToString();
                                        if (total != 0)
                                        {
                                            Game[i, j + total].Text = Game[i, j].Text;
                                            Game[i, j].Text = "";

                                        }
                                        Game[i, k].Text = "";
                                        break;

                                    }
                                    break;
                                }
                            }
                            if (extranum == true && total != 0)
                            {
                                rightcontrol = false;
                                Game[i, j + total].Text = Game[i, j].Text;
                                Game[i, j].Text = "";

                            }
                        }
                        else
                        {
                            if (total != 0)
                            {
                                rightcontrol = false;
                                Game[i, j + total].Text = Game[i, j].Text;
                                Game[i, j].Text = "";

                            }
                        }
                    }
                }
            }
            if (rightcontrol == false && match == true)
            {
                sound.Play();
            }
            if (rightcontrol == false && match == false)
            {
                sound2.Play();
            }
            if (newnum == true)
            {
                generateNum();
            }
        }
        public bool writeNum()      //checks the bool value of generating a new number
        {
            Label[,] Game = {
                             {tile1,tile2,tile3,tile4},
                             {tile5,tile6,tile7,tile8},
                             {tile9,tile10,tile11,tile12},
                             {tile13,tile14,tile15,tile16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[i, j].Text == "")
                    {
                        return false;
                    }
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[i, j].Text != "")
                        {
                            if (Game[i, j].Text == Game[i, k].Text)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[j, i].Text == "")
                    {
                        return false;
                    }
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[k, i].Text != "")
                        {
                            if (Game[j, i].Text == Game[k, i].Text)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
            }
            return true;
        }


        private void playgame_KeyDown(object sender, KeyEventArgs e)
        {

            if (writeNum() == false) //the value of generating a new number must return 0 so that we can use the keys
            {


                if (e.KeyCode == Keys.Up)
                {
                    upwardMovement(); //works when up arrow is pressed

                }
                if (e.KeyCode == Keys.Down)
                {
                    downwardMovement(); //works when down arrow is pressed
                }
                if (e.KeyCode == Keys.Left)
                {
                    leftMovement(); //works when left arrow is pressed
                }
                if (e.KeyCode == Keys.Right)
                {
                    rightMovement(); //works when right arrow is pressed
                }
            }
            else
            {
                // continueToolStripMenuItem.Visible = false;
                // lblGameOver.Text = "GAME OVER";//if the game ends, we place this on the screen.
                //tryagain = false;
                gameoverlbl.Visible = true;  // meanwhile the data is stored in the database.
                
                MainMenu obj = new MainMenu();
                obj.Show();
                this.Hide(); // redirect to main menu

                /* btnNewGame.Visible = true;
                 btnExit.Visible = true;
                 btnExit.Enabled = true;
                 btnNewGame.Enabled = true;*/
                this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.playgame_KeyDown);
            }
        }

  
       // private void gameoverlbl_Click(object sender, EventArgs e)
       // {

//        }

  //      private void newbtn_Click(object sender, EventArgs e)
    //    {
           //  lbl2048.Focus(); 
      //  }

        //private void aboutbtn_Click(object sender, EventArgs e)
        //{
       
            //lbl2048.Focus();
        //}

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        

        private void rstrtBtn_Click(object sender, EventArgs e)
        {
            PlayGame obj = new PlayGame();
            obj.Show();
            this.Hide();
        }

        private void newbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void gameoverlbl_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
