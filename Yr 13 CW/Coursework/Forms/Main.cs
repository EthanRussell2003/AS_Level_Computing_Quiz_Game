using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class frmMain : Template
    {
        User thisUser;
        int[] easyDummyArray;
        int[] hardDummyArray;
        string difficulty;
        bool admin, help = false;
        public frmMain(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray) : base (ThisUser)
        {
            InitializeComponent();
            thisUser = ThisUser;
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            thisUser.Score = 0;
            lblScore.Text = Convert.ToString(thisUser.Score);
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
            if (thisUser.Admin == true)
            {
                btnAdmin.Visible = true;
            }
        }

        public void btnAddQuestion_Click(object sender, EventArgs e)
        {
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
        }

        private void btnAdmin_Click(object sender, EventArgs e) //Brings user to admin menu form (Only appears for admin users)
        {
            this.Close();
            new frmAdmin(thisUser, easyDummyArray, hardDummyArray).Show();
        }

        private void btnEasy_Click(object sender, EventArgs e) //Bring the user to easy mode forms
        {
            difficulty = "easy";
            this.Close();
            new frmQuestionDragDrop(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnHard_Click(object sender, EventArgs e) //Bring the user to hard mode forms
        {
            difficulty = "hard";
            this.Close();
            new frmHardQuestionDragDrop(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e) //When button is clicked it will open the google form for feedback
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSfTGkIqJguxJmJDo5Nq5nsyoIr-CCoQtamR2OBjIgLIJHbEFQ/viewform?usp=sf_link");
        }

        private void btnHelp_Click(object sender, EventArgs e) //Help form
        {
            if (help == false)
            {
                picHelp.BringToFront();
                picHelp.Visible = true;
                btnHelp.Text = ("Back to Menu");
                help = true;
            }
            else
            {
                picHelp.SendToBack();
                picHelp.Visible = false;
                btnHelp.Text = ("Help");
                help = false;
            }
        }
    }
}
