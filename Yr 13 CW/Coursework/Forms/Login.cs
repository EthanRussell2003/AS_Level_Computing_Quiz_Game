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

namespace Coursework
{
    public partial class frmLogin : Form
    {
        User thisUser = new User();
        List<User> users = new List<User>();
        int[] easyDummyArray;
        int[] hardDummyArray;
        bool flag = false, help = false;

        public frmLogin(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray)
        {
            InitializeComponent();
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            readFileToList();
            lblIssue.Visible = false;
            btnLogin.Enabled = false;
            btnRegister.Enabled = false;
        }

        public void btnLogin_Click(object sender, EventArgs e) //Checks if the username and password match the stored username and password data in the bin file
        {
            flag = false;
            foreach (User user in users)
            {
                if (user.Username.Trim() == txtLoginUsername.Text.Trim())
                {
                    flag = true;
                    if (user.Password == txtLoginPassword.Text)
                    {
                        thisUser = user;
                        this.Hide();
                        Forms.frmMain form = new Forms.frmMain(thisUser, easyDummyArray, hardDummyArray);
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        LoginIssue("Incorrect Password");
                    }
                }
                else
                {
                    if (flag == false)
                    {
                        LoginIssue("User does not exist");
                    }
                    else
                    {
                        LoginIssue("Incorrect Password");
                    }
                }
            }
        }
        public void LoginIssue(string message) //If there is an issue logging in it will display the error message
        {
            lblLoginIssue.Visible = true;
            lblLoginIssue.Text = message;
        }

        private void readFileToList() //opens the binary file and writes users to a list of users
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

        private void btnLoginExit_Click(object sender, EventArgs e) //Confirmation message for if a user tries to exit
        {
            string message = "Are you sure you want to exit?";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtLoginPassword_TextChanged(object sender, EventArgs e) //Checking to see if both the username and password fields are filled to enable the login button
        {
            if (txtLoginUsername.Text != "" && txtLoginPassword.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e) //Will check to confirm requirements are met and will save the new user to the bin file
        {
            bool nameUsed = false;
            foreach ( User User in users)
            {
                string UserUppTrim, RegUppTrim;

                UserUppTrim = User.Username.Trim().ToUpper();
                RegUppTrim = txtRegisterUsername.Text.Trim().ToUpper();

                if (User.Username.Trim() == txtRegisterUsername.Text.Trim() || User.Username.ToUpper() == txtRegisterUsername.Text.ToUpper() || UserUppTrim == RegUppTrim)
                    nameUsed = true;
            }
            if (txtRegisterUsername.Text != "" && lblUsernameReq.ForeColor != Color.Red)
            {
                if (txtRegisterPassword.Text != "" && lblPasswordReq.ForeColor != Color.Red && lblPasswordReq2.ForeColor != Color.Red)
                {                
                    if (txtRegisterPassword.Text == txtRegisterConfirm.Text)
                    {
                        if (thisUser.Icon != null)
                        {
                            if (nameUsed != true)
                            {
                                thisUser.Username = txtRegisterUsername.Text;
                                thisUser.Password = txtRegisterPassword.Text;
                                thisUser.Score = 0;
                                thisUser.Admin = false;
                                thisUser.Highscore = 0;
                                users.Add(thisUser);
                                Stream sw;
                                BinaryFormatter bf = new BinaryFormatter();
                                try
                                {
                                    sw = File.OpenWrite("Users.bin");
                                    bf.Serialize(sw, users);
                                    sw.Close();
                                }
                                catch (SerializationException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                readFileToList();
                                this.Hide();
                                Forms.frmMain form = new Forms.frmMain(thisUser, easyDummyArray, hardDummyArray);
                                form.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                RegisterIssue("Username has already been taken");
                            }
                        }
                        else
                        {
                            RegisterIssue("Please select an icon");
                        }
                    }
                    else
                    {
                        RegisterIssue("Passwords do not match");
                    }
                }
                else
                {
                    RegisterIssue("Please enter a valid password");
                }

            }
            else
            {
                RegisterIssue("Please enter a valid username");
            }
        }
        public void RegisterIssue(string message) //Method for when there is an error message when registering
        {
            lblIssue.Visible = true;
            lblIssue.Text = message;
        }

        private void txtRegisterUsername_TextChanged(object sender, EventArgs e) //Checks to see if the username meets requirements and changes the requirement text to green if fulfilled
        {
            if (txtRegisterUsername.Text.Trim().Length >= 5)
            {
                lblUsernameReq.ForeColor = Color.FromArgb(92, 184, 92);
            }
            else
            {
                lblUsernameReq.ForeColor = Color.Red;
            }
            if (txtRegisterUsername.Text != "" && txtRegisterPassword.Text != "" && txtRegisterConfirm.Text != "" && pbChosenIcon.Image != null)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void txtRegisterConfirm_TextChanged(object sender, EventArgs e) //Checks to see if the password meets requirements, match and then changes the requirement text to green if fulfilled
        {
            if (txtRegisterConfirm.Text.Trim().Length >= 5)
            {
                lblConfirmReq.ForeColor = Color.FromArgb(92, 184, 92);
            }
            else
            {
                lblConfirmReq.ForeColor = Color.Red;
            }
            doPasswordsMatch();
            if (txtRegisterUsername.Text != "" && txtRegisterPassword.Text != "" && txtRegisterConfirm.Text != "" && pbChosenIcon.Image != null)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }
        public void doPasswordsMatch() //Checks if passwords match
        {
            if (txtRegisterPassword.Text == txtRegisterConfirm.Text)
            {
                lblConfirmReq.ForeColor = Color.FromArgb(92, 184, 92);
            }
            else
            {
                lblConfirmReq.ForeColor = Color.Red;
            }
        }

        private void txtRegisterPassword_TextChanged(object sender, EventArgs e) //Checks to see if the password meets requirements and then changes the requirement text to green if fulfilled
        {
            if (txtRegisterPassword.Text.Trim().Length >= 5)
            {
                lblPasswordReq.ForeColor = Color.FromArgb(92, 184, 92);
            }
            else
            {
                lblPasswordReq.ForeColor = Color.Red;
            }
            if (txtRegisterPassword.Text.Trim().Any(char.IsDigit) == true)
            {
                lblPasswordReq2.ForeColor = Color.FromArgb(92, 184, 92);
            }
            else
            {
                lblPasswordReq2.ForeColor = Color.Red;
            }
            doPasswordsMatch();
            if (txtRegisterUsername.Text != "" && txtRegisterPassword.Text != "" && txtRegisterConfirm.Text != "" && pbChosenIcon.Image != null)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void Icon1_Click(object sender, EventArgs e) //Will change the selected icon to this icon
        {
            thisUser.Icon = pbIcon1.Image;
            pbChosenIcon.Image = pbIcon1.Image;
            pbIcon1.BorderStyle = BorderStyle.Fixed3D;
            pbIcon2.BorderStyle = BorderStyle.None;
            pbIcon3.BorderStyle = BorderStyle.None;
            if (txtRegisterUsername.Text != "" && txtRegisterPassword.Text != "" && txtRegisterConfirm.Text != "" && pbChosenIcon.Image != null)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void Icon2_Click(object sender, EventArgs e) //Will change the selected icon to this icon
        {
            thisUser.Icon = pbIcon2.Image;
            pbChosenIcon.Image = pbIcon2.Image;
            pbIcon1.BorderStyle = BorderStyle.None;
            pbIcon2.BorderStyle = BorderStyle.Fixed3D;
            pbIcon3.BorderStyle = BorderStyle.None;
            if (txtRegisterUsername.Text != "" && txtRegisterPassword.Text != "" && txtRegisterConfirm.Text != "" && pbChosenIcon.Image != null)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void Icon3_Click(object sender, EventArgs e) //Will change the selected icon to this icon
        {
            thisUser.Icon = pbIcon3.Image;
            pbChosenIcon.Image = pbIcon3.Image;
            pbIcon1.BorderStyle = BorderStyle.None;
            pbIcon2.BorderStyle = BorderStyle.None;
            pbIcon3.BorderStyle = BorderStyle.Fixed3D;
            if (txtRegisterUsername.Text != "" && txtRegisterPassword.Text != "" && txtRegisterConfirm.Text != "" && pbChosenIcon.Image != null)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void rdbAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e) //Will uncensore the password
        {
            if (cbShowPassword.Checked)
            {
                txtLoginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtLoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void cbShowRegisterPassword_CheckedChanged(object sender, EventArgs e) //Will uncensore the password
        {
            if (cbShowRegisterPassword.Checked)
            {
                txtRegisterPassword.UseSystemPasswordChar = false;
                txtRegisterConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtRegisterPassword.UseSystemPasswordChar = true;
                txtRegisterConfirm.UseSystemPasswordChar = true;
            }
        }

        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtLoginUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtLoginUsername_TextChanged(object sender, EventArgs e) //Checks if the username and password fields are filled and enables the login button
        {
            if (txtLoginUsername.Text != "" && txtLoginPassword.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblPasswordReq_Click(object sender, EventArgs e)
        {

        }

        private void btnComplexities_Click(object sender, EventArgs e) //Opens the Code Complexities word document
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\Code Complexities.docx");
        }

        private void btnHelp_Click(object sender, EventArgs e) //Opens the help form
        {
            if (help == false)
            {
                picHelp.BringToFront();
                picHelp.Visible = true;
                btnHelp.Text = ("Back to Login");
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



