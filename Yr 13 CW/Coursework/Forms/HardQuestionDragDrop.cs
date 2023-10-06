using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class frmHardQuestionDragDrop : Coursework.Template
    {
        User thisUser;
        public static String selectedPicture;
        public static int tempScore;
        int score = 0;
        int[] easyDummyArray;
        int[] hardDummyArray;
        bool answer1, answer2, answer3, admin, help = false;
        int hardListLength, hard;
        string difficulty;

        public frmHardQuestionDragDrop(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray, string Difficulty, bool Admin) : base(ThisUser)
        {
            InitializeComponent();
            thisUser = ThisUser;
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            admin = Admin;
            if (Admin == true)
            {
                btnContinue.Text = ("Back to admin");
            }
            difficulty = Difficulty;
            picBus.AllowDrop = true;
            picRing.AllowDrop = true;
            picStar.AllowDrop = true;
            picBusAdvantage.AllowDrop = true;
            picRingAdvantage.AllowDrop = true;
            picStarAdvantage.AllowDrop = true;
            picAnswer1Correct.Visible = false;
            picAnswer2Correct.Visible = false;
            picAnswer3Correct.Visible = false;
            picAnswer1Wrong.Visible = false;
            picAnswer2Wrong.Visible = false;
            picAnswer3Wrong.Visible = false;
            lblScore.Text = Convert.ToString(thisUser.Score);
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
            if (hardDummyArray != null) //Checks if the dummy array is filled
            {
                hardListLength = hardDummyArray.Length;
                foreach (int num in hardDummyArray)
                {
                    if (num == 1)
                    {
                        hard++;
                    }
                }
                if (hard == hardListLength)
                {
                    MessageBox.Show("Randomised questions have been exhausted. They will now repeat");
                    foreach (int num in hardDummyArray)
                    {
                        for (int a = 0; a < hardListLength; a++)
                        {
                            hardDummyArray[a] = 0;
                        }
                    }
                }
            }
        }

        private void picRingAdvantage_MouseDown(object sender, MouseEventArgs e) //For dragging the images
        {
            selectedPicture = picRingAdvantage.Tag.ToString();
            picRingAdvantage.DoDragDrop(picRingAdvantage.Image, DragDropEffects.Copy);
        }

        private void picBusAdvantage_MouseDown(object sender, MouseEventArgs e) //For dragging the images
        {
            selectedPicture = picBusAdvantage.Tag.ToString();
            picBusAdvantage.DoDragDrop(picBusAdvantage.Image, DragDropEffects.Copy);
        }

        private void picStarAdvantage_MouseDown(object sender, MouseEventArgs e) //For dragging the images
        {
            selectedPicture = picStarAdvantage.Tag.ToString();
            picStarAdvantage.DoDragDrop(picStarAdvantage.Image, DragDropEffects.Copy);
        }

        private void picBus_DragDrop(object sender, DragEventArgs e) //Updating a picture box if it recieves a dropped image
        {
            picAnswer1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            picAnswer1.Visible = true;
            picBus.AllowDrop = false;
            if (selectedPicture == picBus.Tag.ToString())
            {
                answer1 = true;
                selectedPicture = "";
                score += 2;
            }
            else
            {
                answer1 = false;
                selectedPicture = "";
            }
        }

        private void picRing_DragDrop(object sender, DragEventArgs e) //Updating a picture box if it recieves a dropped image
        {
            picAnswer2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            picAnswer2.Visible = true;
            picRing.AllowDrop = false;
            if (selectedPicture == picRing.Tag.ToString())
            {
                answer2 = true;
                selectedPicture = "";
                score += 2;
            }
            else
            {
                answer2 = false;
                selectedPicture = "";
            }
        }

        private void picStar_DragDrop(object sender, DragEventArgs e) //Updating a picture box if it recieves a dropped image
        {
            picAnswer3.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            picAnswer3.Visible = true;
            picStar.AllowDrop = false;
            if (selectedPicture == picStar.Tag.ToString())
            {
                answer3 = true;
                selectedPicture = "";
                score += 2;
            }
            else
            {
                answer3 = false;
                selectedPicture = "";
            }
        }

        private void picBus_DragEnter(object sender, DragEventArgs e) //Copies the picture
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void picRing_DragEnter(object sender, DragEventArgs e) //Copies the picture
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void picStar_DragEnter(object sender, DragEventArgs e) //Copies the picture
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnHelp_Click(object sender, EventArgs e) //Help form
        {
            if (help == false)
            {
                picHelp.BringToFront();
                picHelp.Visible = true;
                btnHelp.Text = ("Back to Question");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmHardQuestionDragDrop(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e) //Submit button, reveals if answers are correct or incorrect and displays score
        {
            if (answer1 == true)
            {
                picAnswer1Correct.Visible = true;
            }
            else
            {
                picAnswer1Wrong.Visible = true;
            }
            if (answer2 == true)
            {
                picAnswer2Correct.Visible = true;
            }
            else
            {
                picAnswer2Wrong.Visible = true;
            }
            if (answer3 == true)
            {
                picAnswer3Correct.Visible = true;
            }
            else
            {
                picAnswer3Wrong.Visible = true;
            }
            btnSubmit.Enabled = false;
            btnReset.Enabled = false;
            btnContinue.Visible = true;
            thisUser.Score += score;
            lblScore.Text = Convert.ToString(thisUser.Score);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                this.Close();
                new frmAdmin(thisUser, easyDummyArray, hardDummyArray).Show();
            }
            else
            {
                this.Close();
                new frmHardQuestionTextBox(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e) //Confirmation message if the user clicks the main menu button
        {
            string message = "This will return you to the main menu.\nAre you sure you want to go back?\nUnsaved data will be lost\n(Data is only saved when the quiz is finished)";
            string title = "Main Menu";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                new frmMain(thisUser, easyDummyArray, hardDummyArray).Show();
            }
        }
    }
}
