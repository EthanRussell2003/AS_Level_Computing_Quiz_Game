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
    public partial class frmLeaderboard : Coursework.Template
    {
        User thisUser = new User();
        List<User> users = new List<User>();
        int[] easyDummyArray;
        int[] hardDummyArray;
        string difficulty;
        bool admin, help = false;

        private void readFileToList() //Writes users in bin file to a lsit
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

        public frmLeaderboard(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray, string Difficulty, bool Admin) : base(ThisUser)
        {
            thisUser = ThisUser;
            InitializeComponent();
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            admin = Admin;
            difficulty = Difficulty;
            readFileToList();
            lblScore.Text = Convert.ToString(thisUser.Score);
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);

            foreach (User user in users) //Will set the highest scoring users in their respective places and move them accordingly if a user scores higher
            {
                if(Convert.ToInt16(user.Highscore) >= Convert.ToInt16(lblScoreFirst.Text))
                {
                    lblScoreFifth.Text = lblScoreFourth.Text;
                    lblScoreFourth.Text = lblScoreThird.Text;
                    lblScoreThird.Text = lblScoreSecond.Text;
                    lblScoreSecond.Text = lblScoreFirst.Text;
                    lblScoreFirst.Text = Convert.ToString(user.Highscore);

                    lblFifth.Text = lblFourth.Text;
                    lblFourth.Text = lblThird.Text;
                    lblThird.Text = lblSecond.Text;
                    lblSecond.Text = lblFirst.Text;
                    lblFirst.Text = user.Username;

                    pbLeader.Image = user.Icon;
                    lblLeader.Text = ("Highest Scoring Player: " + user.Username);
                }

                else if (user.Highscore >= Convert.ToInt16(lblScoreSecond.Text))
                {
                    lblScoreFifth.Text = lblScoreFourth.Text;
                    lblScoreFourth.Text = lblScoreThird.Text;
                    lblScoreThird.Text = lblScoreSecond.Text;
                    lblScoreSecond.Text = Convert.ToString(user.Highscore);

                    lblFifth.Text = lblFourth.Text;
                    lblFourth.Text = lblThird.Text;
                    lblThird.Text = lblSecond.Text;
                    lblSecond.Text = user.Username;
                }

                else if (user.Highscore >= Convert.ToInt16(lblScoreThird.Text))
                {
                    lblScoreFifth.Text = lblScoreFourth.Text;
                    lblScoreFourth.Text = lblScoreThird.Text;
                    lblScoreThird.Text = Convert.ToString(user.Highscore);

                    lblFifth.Text = lblFourth.Text;
                    lblFourth.Text = lblThird.Text;
                    lblThird.Text = user.Username;
                }
                else if (user.Highscore >= Convert.ToInt16(lblScoreFourth.Text))
                {
                    lblScoreFifth.Text = lblScoreFourth.Text;
                    lblScoreFourth.Text = Convert.ToString(user.Highscore);

                    lblFifth.Text = lblFourth.Text;
                    lblFourth.Text = user.Username;
                }
                else if (user.Highscore >= Convert.ToInt16(lblScoreFifth.Text))
                {
                    lblScoreFifth.Text = Convert.ToString(user.Highscore);

                    lblFifth.Text = user.Username;
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmEndScreen(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnHelp_Click(object sender, EventArgs e) //Help form
        {
            if (help == false)
            {
                picHelp.BringToFront();
                picHelp.Visible = true;
                btnHelp.Text = ("Back to Leaderboard");
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
