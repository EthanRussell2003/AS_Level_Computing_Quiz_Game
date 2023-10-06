using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Coursework.Forms
{
    public partial class frmEndScreen : Template
    {
        User thisUser;
        List<User> users = new List<User>();
        int[] easyDummyArray;
        int[] hardDummyArray;
        bool replay, admin, highscore = false, help = false;
        string difficulty;

        public frmEndScreen(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray, string Difficulty, bool Admin) : base(ThisUser)
        {
            InitializeComponent();
            thisUser = ThisUser;
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            admin = Admin;
            if (admin == true)
            {
                btnAdmin.Visible = true;
                lblCongratulate.Text = ("Welcome admin");
            }
            difficulty = Difficulty;
            lblScore.Text = Convert.ToString(thisUser.Score);
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);

            if (Difficulty == "easy") //Easy variable congratulations messages
            {
                if (ThisUser.Score == 0)
                {
                    lblCongratulate.Text = ("You finished the quiz with a score of " + ThisUser.Score + ". You may want to revise over these topics.");
                }
                else if (ThisUser.Score <= 6 && ThisUser.Score > 0)
                {
                    lblCongratulate.Text = ("You finished the quiz with a score of " + ThisUser.Score + ". Good attempt! Better luck next time.");
                }
                else if (ThisUser.Score >= 7 && ThisUser.Score <= 11)
                {
                    lblCongratulate.Text = ("You finished the quiz with a score of " + ThisUser.Score + ". Good job! Next attempt could be even better!");
                }
                else if (ThisUser.Score >= 12 && ThisUser.Score <= 14)
                {
                    lblCongratulate.Text = ("You finished the quiz with a score of " + ThisUser.Score + ". Excellent! Nearly a perfect score!");
                }
                else if (ThisUser.Score == 15)
                {
                    lblCongratulate.Text = ("You finished the quiz with a score of " + ThisUser.Score + ". A perfect easy mode score! Let's see if you can master hard mode!");
                }
                if (ThisUser.Score == 15 && ThisUser.Highscore == 30)
                {
                    lblCongratulate.Text = ("You finished the quiz with a score of " + ThisUser.Score + ". A perfect easy mode score!");
                }
            }
            else if (Difficulty == "hard") //Hard variable congratulations messages
            {
                if (ThisUser.Score >= 0 && ThisUser.Score <= 2)
                {
                    lblCongratulate.Text = ("You finished the quiz with a score of: " + ThisUser.Score + ". You may want to stick to easy mode.");
                }
                else if (ThisUser.Score <= 12 && ThisUser.Score > 2)
                {
                    lblCongratulate.Text = ("You finished the quiz with a score of: " + ThisUser.Score + ". Good attempt! Better luck next time.");
                }
                else if (ThisUser.Score >= 13 && ThisUser.Score <= 25)
                {
                    lblCongratulate.Text = ("You finished the quiz with a score of: " + ThisUser.Score + ". Good job! Next attempt could be even better!");
                }
                else if (ThisUser.Score >= 26 && ThisUser.Score <= 28)
                {
                    lblCongratulate.Text = ("You finished the quiz with a score of: " + ThisUser.Score + ". Excellent! Nearly a perfect score!");
                }
                else if (ThisUser.Score == 30)
                {
                    lblCongratulate.Text = ("You finished the quiz with a score of: " + ThisUser.Score + ". A perfect score! You've mastered the quiz!");
                }
            }
            if (thisUser.Score < thisUser.Highscore && thisUser.Highscore != 0) //Highscore variable congratulations messages
            {
                lblHighscoreInfo.Text = ("You didn't beat your current highscore of " + thisUser.Highscore);
            }
            else if (thisUser.Score == thisUser.Highscore && thisUser.Highscore == 0)
            {
                lblHighscoreInfo.Text = ("Score some points to set a highscore!");
            }
            else if (thisUser.Score > thisUser.Highscore && thisUser.Highscore != 0)
            {
                thisUser.Highscore = thisUser.Score;
                lblHighscoreInfo.Text = ("   You beat your previous highscore!\n Your new highscore is " + thisUser.Highscore);
                highscore = true;
            }
            else if (thisUser.Score == thisUser.Highscore)
            {
                lblHighscoreInfo.Text = ("You got the same score as your current highscore of " + thisUser.Highscore + "!");
            }
            if (thisUser.Score == thisUser.Highscore - 1 && thisUser.Score != 0)
            {
                lblHighscoreInfo.Text = ("You were so close to beating your current highscore of " + thisUser.Highscore + "!");
            }
            if (thisUser.Score == thisUser.Highscore - 2 && thisUser.Score != 0)
            {
                lblHighscoreInfo.Text = ("You were close to beating your current highscore of " + thisUser.Highscore + "!");
            }
            if (difficulty == "easy" && thisUser.Highscore == 15)
            {
                lblHighscoreInfo.Text = ("You'll have to play hard mode to get a highscore higher than 15!");
                if (highscore == true)
                {
                    lblHighscoreInfo.Text = ("Your new highscore is 15! You'll have to play hard mode to get a score higher than 15!");
                }
            }
            if (thisUser.Highscore == 30)
            {
                lblHighscoreInfo.Text = ("You can't get a higher highscore, excellent job!");
            }
            if (thisUser.Score > thisUser.Highscore)
            {
                if (thisUser.Highscore == 0)
                {
                    thisUser.Highscore = thisUser.Score;
                    lblHighscoreInfo.Text = ("You've set your highscore!\n Your highscore has been set at " + thisUser.Highscore);
                    highscore = true;
                }
                Stream sr; //Saving players highscore to binary file
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    sr = File.OpenRead("Users.bin");
                    users = (List<User>)bf.Deserialize(sr);
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                foreach (User User in users)
                {
                    if (User.Username == thisUser.Username)
                    {
                        Stream sw;
                        BinaryFormatter cf = new BinaryFormatter();
                        User.Highscore = thisUser.Highscore;

                        try
                        {
                            sw = File.OpenWrite("Users.bin");
                            cf.Serialize(sw, users);
                            sw.Close();
                        }
                        catch (SerializationException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
            if (thisUser.Highscore >= 15) //Unlocks the bonus game
            {
                lblBonus.Text = ("Your highscore is high enough to play the bonus game!");
                btnBonusGame.Enabled = true;
            }
            lblHighscore.Text = Convert.ToString(thisUser.Highscore); //Sets the highscore
        }
        public void frmEndScreen_Load(object sender, EventArgs e)
        {
        }

        private void readFileToList() //Method for saving to binary file
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                sr = File.OpenRead("Users.bin");
                users = (List<User>)bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLeaderboard_Click(object sender, EventArgs e) //Takes user to respective form when button is clicked
        {
            this.Close();
            new frmLeaderboard(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin(thisUser, easyDummyArray, hardDummyArray).Show();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain(thisUser, easyDummyArray, hardDummyArray).Show();
        }

        private void btnReplayHard_Click(object sender, EventArgs e) //Takes user to start of the quiz in the hard difficulty also resets the score
        {
            thisUser.Score = 0;
            difficulty = "hard";
            admin = false;
            this.Close();
            new frmHardQuestionDragDrop(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnReplayEasy_Click(object sender, EventArgs e) //Takes user to start of the quiz in the easy difficulty also resets the score
        {
            thisUser.Score = 0;
            difficulty = "easy";
            admin = false;
            this.Close();
            new frmQuestionDragDrop(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnBonusGame_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmBreakout(thisUser, easyDummyArray, hardDummyArray, replay, difficulty, admin).Show();
        }

        private void btnHelp_Click(object sender, EventArgs e) //Help form
        {
            if (help == false) 
            {
                picHelp.BringToFront();
                picHelp.Visible = true;
                btnHelp.Text = ("Back to End Screen");
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdmin(thisUser, easyDummyArray, hardDummyArray).Show();
        }

        private void lblHighscoreInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
