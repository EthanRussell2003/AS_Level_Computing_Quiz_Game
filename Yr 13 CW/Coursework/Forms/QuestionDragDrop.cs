using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class frmQuestionDragDrop : Template
    {
        User thisUser;
        public static String selectedPicture;
        public static int tempScore;
        int score = 0;
        int[] easyDummyArray;
        int[] hardDummyArray;
        string difficulty;
        int easyListLength, easy;
        bool answer1, answer2, answer3, admin, help = false;

        public frmQuestionDragDrop(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray, string Difficulty, bool Admin) : base(ThisUser)
        {
            InitializeComponent();
            thisUser = ThisUser;
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            difficulty = Difficulty;
            admin = Admin;
            if (Admin == true)
            {
                btnContinue.Text = ("Back to admin");
            }
        }

        private void frmQuestionDragDrop_Load_1(object sender, EventArgs e)
        {
            picCPU.AllowDrop = true;
            picGPU.AllowDrop = true;
            picPSU.AllowDrop = true;
            picAnswer1.AllowDrop = true;
            picAnswer2.AllowDrop = true;
            picAnswer3.AllowDrop = true;
            picAnswer1Correct.Visible = false;
            picAnswer2Correct.Visible = false;
            picAnswer3Correct.Visible = false;
            picAnswer1Wrong.Visible = false;
            picAnswer2Wrong.Visible = false;
            picAnswer3Wrong.Visible = false;
            lblScore.Text = Convert.ToString(thisUser.Score);
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
            if (easyDummyArray != null) //Checks if the dummy array is filled
            {
                easyListLength = easyDummyArray.Length;
                foreach (int num in easyDummyArray)
                {
                    if (num == 1)
                    {
                        easy++;
                    }
                }
                if (easy == easyListLength)
                {
                    MessageBox.Show("Randomised questions have been exhausted. They will now repeat");
                    foreach (int num in easyDummyArray)
                    {
                        for (int a = 0; a < easyListLength; a++)
                        {
                            easyDummyArray[a] = 0;
                        }
                    }
                }
            }
        }

        private void picCPU_Click(object sender, EventArgs e)
        {

        }

        private void picCPU_MouseDown(object sender, MouseEventArgs e) //For dragging the images
        {
            selectedPicture = picCPU.Tag.ToString();
            picCPU.DoDragDrop(picCPU.Image, DragDropEffects.Copy);
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

        private void picAnswer1_DragDrop(object sender, DragEventArgs e) //Updating a picture box if it recieves a dropped image
        {
            {
                picAnswer1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                picAnswer1.AllowDrop = false;
                if (selectedPicture == picAnswer1.Tag.ToString())
                {
                    answer1 = true;
                    selectedPicture = "";
                    score += 1;
                }
                else
                {
                    answer1 = false;
                    selectedPicture = "";
                }
            }
        }

        private void picAnswer1_DragEnter(object sender, DragEventArgs e) //Copies the picture
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void picGPU_MouseDown(object sender, MouseEventArgs e) //For dragging the images
        {
            selectedPicture = picGPU.Tag.ToString();
            picGPU.DoDragDrop(picGPU.Image, DragDropEffects.Copy);
        }

        private void picPSU_MouseDown(object sender, MouseEventArgs e) //For dragging the images
        {
            selectedPicture = picPSU.Tag.ToString();
            picPSU.DoDragDrop(picPSU.Image, DragDropEffects.Copy);
        }

        private void picAnswer3_DragDrop(object sender, DragEventArgs e) //Updating a picture box if it recieves a dropped image
        {
            picAnswer3.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            picAnswer3.AllowDrop = false;
            if (selectedPicture == picAnswer3.Tag.ToString())
            {
                answer3 = true;
                selectedPicture = "";
                score += 1;
            }
            else
            {
                answer3 = false;
                selectedPicture = "";
            }
        }
        private void picAnswer3_DragEnter(object sender, DragEventArgs e) //Copies the picture
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void picAnswer2_DragDrop(object sender, DragEventArgs e) //Updating a picture box if it recieves a dropped image
        {
            {
                picAnswer2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                picAnswer2.AllowDrop = false;
                if (selectedPicture == picAnswer2.Tag.ToString())
                {
                    answer2 = true;
                    selectedPicture = "";
                    score += 1;
                }
                else
                {
                    answer2 = false;
                    selectedPicture = "";
                }
            }
        }

        private void picAnswer2_DragEnter(object sender, DragEventArgs e) //Copies the picture
        {
            e.Effect = DragDropEffects.Copy;
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
                new frmQuestionTextEntry(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
            }
        }

        private void picAnswer1Wrong_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

        private void picAnswer1Correct_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmQuestionDragDrop(thisUser, easyDummyArray, hardDummyArray, difficulty, admin).Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e) //Submit button, reveals if answers are correct or incorrect and displays score
        {
            if(answer1 == true)
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
    }
}
