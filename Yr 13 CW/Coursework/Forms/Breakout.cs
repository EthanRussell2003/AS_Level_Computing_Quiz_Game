using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class frmBreakout : Form
    {
        bool goRight, goLeft, replay, admin;
        int speed = 12, ballx = 9, bally = 9, score = 0;
        private Random rnd = new Random();
        User thisUser = new User();
        List<User> users = new List<User>();
        int[] easyDummyArray;
        int[] hardDummyArray;
        string difficulty;

        public frmBreakout(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray, bool Replay, string Difficulty, bool Admin)
        {
            InitializeComponent();
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            admin = Admin;
            difficulty = Difficulty;
            thisUser = ThisUser;
            replay = Replay;
            lblDisplayUsername.Text = thisUser.Username;
            imgIcon.Image = thisUser.Icon;

            foreach (Control x in this.Controls) //Sets a random colour for each block
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    x.BackColor = randomColor;
                }
            }
        }

        private void frmBreakout_Load(object sender, EventArgs e) //Displays confirmation message for user to read instructions
        {
            if (replay == false)
            {
                string message = "Use the 'left' and 'right' arrow keys to move left and right \n Press 'Yes' to start or 'No' to go back to the end screen";
                string title = "Instructions";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    timer1.Enabled = true;
                }
                if (result == DialogResult.No)
                {
                    this.Close();
                    new frmEndScreen(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
                }
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //Each time the timer ticks it will move the ball by the set amount and move the player if the correlating button is pressed
        {
            pbBall.Left += ballx;
            pbBall.Top += bally;
            lblScore.Text = Convert.ToString(score);

            if (goLeft) { btnPlayer.Left -= speed; }
            if (goRight) { btnPlayer.Left += speed; }

            if (btnPlayer.Left < 1)
            {
                goLeft = false;
            }
            else if (btnPlayer.Left + btnPlayer.Width > 1200) //Stops player from moving out of bounds
            {
                goRight = false;
            }
            if (pbBall.Left + pbBall.Width > ClientSize.Width || pbBall.Left < 0)
            {
                ballx = -ballx;
            }

            if (pbBall.Top < 105 || pbBall.Bounds.IntersectsWith(btnPlayer.Bounds)) //Makes the ball bounce if it hits the player
            {
                bally = -bally;
            }

            if (pbBall.Top + pbBall.Height > ClientSize.Height) //Ends game if ball hits the edge of the play field
            {
                gameOver();
                string message = "You lost. Would you like to play again?";
                string title = "You lost";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    replay = true;
                    this.Close();
                    new frmBreakout(thisUser, easyDummyArray, hardDummyArray, replay, difficulty, admin).Show();
                }
                if (result == DialogResult.No)
                {
                    replay = false;
                    this.Close();
                    new frmEndScreen(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
                }
            }
            foreach (Control x in this.Controls) //Removes block if the balls hits it and adds to the score
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    if (pbBall.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        bally = -bally;
                        score++;
                    }
                }
            }

            if (score == 32) //Ends the game when all blocks are hit
            {
                gameOver();
                string message = "You win! Would you like to play again?";
                string title = "You won";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    replay = true;
                    this.Close();
                    new frmBreakout(thisUser, easyDummyArray, hardDummyArray, replay, difficulty, admin).Show();
                }
                if (result == DialogResult.No)
                {
                    this.Close();
                    new frmEndScreen(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
                }
            }
        }

        private void frmBreakout_KeyUp(object sender, KeyEventArgs e) //Stops the player from moving when the button has stopped being pressed
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void frmBreakout_KeyDown(object sender, KeyEventArgs e) //Moves the play if the button is pressed
        {
            if (e.KeyCode == Keys.Left && btnPlayer.Left > 0)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && btnPlayer.Left + btnPlayer.Width < 1200)
            {
                goRight = true;
            }
        }

        private void gameOver() //Stops the timer when needed
        {
            timer1.Stop();
        }
    }
}
