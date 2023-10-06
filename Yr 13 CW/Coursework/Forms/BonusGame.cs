using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class frmBonusGame : Coursework.Template
    {
        User thisUser;
        List<User> users = new List<User>();
        int[] easyDummyArray;
        int[] hardDummyArray;
        bool goDown, goUp;
        int speed = 5, ballx = 5, bally = 5, score = 0, cpuPoint = 0;


        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            lblUserPoints.Text = "" + score;
            lblCpuPoints.Text = "" + cpuPoint;
            ball.Top -= bally;
            ball.Left -= ballx;
            cpu.Top += speed;
            if (score < 5)
            {
                if (cpu.Top < 195 || cpu.Top > 720)
                {
                    speed = -speed;
                }
            }
            else
            {
                cpu.Top = ball.Top + 30;
            }
            if (ball.Left < 185)
            {
                ball.Left = 664;
                ballx = -ballx;
                ballx -= 2;
                cpuPoint++;
            }
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 664;
                ballx = -ballx;
                ballx += 2;
                score++;
            }
            if (ball.Top < 185 || ball.Top + ball.Height > ClientSize.Height)
            {
                bally = -bally;
            }
            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballx = -ballx;
            }
            if (goUp == true && player.Top > 185)
            {
                player.Top -= 8;
            }
            if (goDown == true && player.Bottom < 720)
            {
                player.Top += 8;
            }
            if (score > 10)
            {
                gameTimer.Stop();
                lblEnd.Text = "You win!";
                btnBack.Enabled = true;
                btnLogOut.Enabled = true;
                btnExit.Enabled = true;
                btnReplay.Visible = true;
            }
            if (cpuPoint > 10)
            {
                gameTimer.Stop();
                lblEnd.Text = "You lost";
                btnBack.Enabled = true;
                btnLogOut.Enabled = true;
                btnExit.Enabled = true;
            }
        }

        public frmBonusGame(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray) : base(ThisUser)
        {
            InitializeComponent();
            gameTimer.Start();
            thisUser = ThisUser;
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            lblScore.Text = Convert.ToString(score);
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
            btnBack.Enabled = false;
            btnLogOut.Enabled = false;
            btnExit.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmEndScreen(thisUser, easyDummyArray, hardDummyArray).Show();
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if(e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }
        private void button1_click(object sender, EventArgs e)
        {
            this.Close();
            new frmBonusGame(thisUser, easyDummyArray, hardDummyArray).Show();
        }
    }
}
