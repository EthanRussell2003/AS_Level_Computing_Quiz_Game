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
using Coursework.Data;

namespace Coursework.Forms
{
    public partial class frmUserEdit : Coursework.Template
    {
        User thisUser;
        User currentUser;
        List<User> users = new List<User>();
        bool canSave;
        Image tempIcon;
        int[] easyDummyArray;
        int[] hardDummyArray;
        bool sameUser, help = false;

        public frmUserEdit(User ThisUser, int[] EasyDummyArray, int[] HardDummyArray) : base(ThisUser)
        {
            InitializeComponent();
            thisUser = ThisUser;
            easyDummyArray = EasyDummyArray;
            hardDummyArray = HardDummyArray;
            readFileToList();
            pbIcon1.Enabled = false;
            pbIcon2.Enabled = false;
            pbIcon3.Enabled = false;
            cbAdmin.Items.Insert(0, true);
            cbAdmin.Items.Insert(1, false);
            cbAdmin.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtHighscore.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            foreach (User user in users) //Will add each user to the user combo box
            {
                if (thisUser.Username != lblMasterAdmin.Text)
                {
                    if(user.Username != lblMasterAdmin.Text)
                    {
                        cbUser.Items.Add(user.Username);
                    }
                }
                else
                {
                    cbUser.Items.Add(user.Username);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdmin(thisUser, easyDummyArray, hardDummyArray).Show();
        }

        private void readFileToList() //Reads each user in the bin file to a list
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

        private void pbIcon3_Click(object sender, EventArgs e) //Set the selected icon to this new icon
        {
            tempIcon = thisUser.Icon;
            currentUser.Icon = pbIcon3.Image;
            pbIcon1.BorderStyle = BorderStyle.None;
            pbIcon2.BorderStyle = BorderStyle.None;
            pbIcon3.BorderStyle = BorderStyle.Fixed3D;
            pbIconCurrent.Image = pbIcon3.Image;
            if (cbUser.Text != "" && cbAdmin.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtHighscore.Text != "" && pbIconCurrent != null)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }

        }

        private void pbIcon2_Click(object sender, EventArgs e) //Set the selected icon to this new icon
        {
            tempIcon = thisUser.Icon;
            currentUser.Icon = pbIcon2.Image;
            pbIcon1.BorderStyle = BorderStyle.None;
            pbIcon2.BorderStyle = BorderStyle.Fixed3D;
            pbIcon3.BorderStyle = BorderStyle.None;
            pbIconCurrent.Image = pbIcon2.Image;
            if (cbUser.Text != "" && cbAdmin.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtHighscore.Text != "" && pbIconCurrent != null)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void pbIcon1_Click(object sender, EventArgs e) //Set the selected icon to this new icon
        {
            tempIcon = thisUser.Icon;
            currentUser.Icon = pbIcon1.Image;
            pbIcon1.BorderStyle = BorderStyle.Fixed3D;
            pbIcon2.BorderStyle = BorderStyle.None;
            pbIcon3.BorderStyle = BorderStyle.None;
            pbIconCurrent.Image = pbIcon1.Image;
            if (cbUser.Text != "" && cbAdmin.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtHighscore.Text != "" && pbIconCurrent != null)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e) //When user is selected it will set each corresponding field to the correct information from the users data
        {
            readFileToList();
            foreach (User user in users)
            {
                if(cbUser.Text == user.Username)
                {
                    pbIcon1.Enabled = true;
                    pbIcon2.Enabled = true;
                    pbIcon3.Enabled = true;
                    cbAdmin.Enabled = true;
                    txtUsername.Enabled = true;
                    txtPassword.Enabled = true;
                    btnDelete.Enabled = true;
                    pbIcon1.BorderStyle = BorderStyle.None;
                    pbIcon2.BorderStyle = BorderStyle.None;
                    pbIcon3.BorderStyle = BorderStyle.None;
                    currentUser = user;
                    txtUsername.Text = user.Username;
                    txtPassword.Text = user.Password;
                    txtHighscore.Text = Convert.ToString(user.Highscore);
                    cbAdmin.Text = Convert.ToString(user.Admin);
                    pbIconCurrent.Image = user.Icon;
                    sameUser = false;
                    lblIssue.Visible = false;
                    if (cbUser.Text != "" && cbAdmin.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtHighscore.Text != "" && pbIconCurrent != null)
                    {
                        btnSave.Enabled = true;
                    }
                    else
                    {
                        btnSave.Enabled = false;
                    }
                    if (user.Username == thisUser.Username)
                    {
                        try
                        {
                            btnDelete.Enabled = false;
                            sameUser = true;
                            throw new CustomException("You will not be able to delete a user \n that is currently in use");
                        }
                        catch (CustomException ex)
                        {
                            lblIssue.Text = (ex.Message);
                            lblIssue.Visible = true;
                        }
                    }
                    if (user.Username == "ethanAdmin")
                    {
                        btnDelete.Enabled = false;
                        cbAdmin.Enabled = false;
                        txtUsername.Enabled = false;
                    }
                }
            }
        }

        private void cbUser_KeyPress(object sender, KeyPressEventArgs e) //Stops user from typing in combo box
        {
            e.Handled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) //Confirmation message if the user clicks the delete button
        {
            string message = "Are you sure you want to delete this User?";
            string title = "Delete User";                               
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                users.Remove(currentUser);
                Stream sw;
                BinaryFormatter cf = new BinaryFormatter();
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
                this.Close();
                new frmUserEdit(thisUser, easyDummyArray, hardDummyArray).Show();
            }
        }

        private void cbAdmin_KeyPress(object sender, KeyPressEventArgs e) //Stops user from typing in combo box
        {
            e.Handled = true;
        }

        public void issue(string message) //Displays the error message
        {
            lblIssue.Visible = true;
            lblIssue.Text = message;
        }

        private void btnSave_Click(object sender, EventArgs e) //Confirms each field is filled correctly and saves the users data
        {
            canSave = false;
            users.Remove(currentUser);
            Stream sw;
            BinaryFormatter cf = new BinaryFormatter();
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
            readFileToList();
            foreach (User user in users)
            {
                    if (txtUsername.Text != "")
                    {
                        if (txtPassword.Text != "")
                        {
                            if (txtHighscore.Text != "")
                            {
                                if (txtUsername.Text.Trim().Length >= 5)
                                {
                                    if (txtPassword.Text.Trim().Length >= 5)
                                    {
                                        if (txtPassword.Text.Trim().Any(char.IsDigit) == true)
                                        {
                                            if (txtUsername.Text == cbUser.Text)
                                            {
                                                canSave = true;
                                                break;
                                            }
                                            else
                                            {
                                                foreach (User user1 in users)
                                                {
                                                    if (txtUsername.Text.Trim() == user1.Username.Trim() && txtUsername.Text.Trim() != thisUser.Username)
                                                    {
                                                        issue("Username already taken");
                                                        canSave = false;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        canSave = true;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            issue("Password must contain a number");
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        issue("Password must be 5 or more characters");
                                        break;
                                    }
                                }
                                else
                                {
                                    issue("Username must be 5 or more characters");
                                    break;
                                }
                            }
                            else
                            {
                                issue("Please enter a highscore");
                                break;
                            }
                        }
                        else
                        {
                            issue("Please enter a password");
                            break;
                        }
                    }
                    else
                    {
                        issue("Please enter a username");
                        break;
                    }
                }
            if(canSave == true) //Confirms the user can be saved
            {
                if(sameUser == true && cbAdmin.Text == "False")
                {
                    string message = "Saving now will revoke your admin privileges \n you will be unable to access admin facilities with this account unless changed by another admin \n Are you sure you want to continue?";
                    string title = "Save data";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        currentUser.Username = txtUsername.Text;
                        currentUser.Password = txtPassword.Text;
                        currentUser.Highscore = Convert.ToInt16(txtHighscore.Text);
                        currentUser.Admin = Convert.ToBoolean(cbAdmin.Text);
                        currentUser.Score = 0;
                        users.Add(currentUser);
                        Stream se;
                        BinaryFormatter bf = new BinaryFormatter();
                        try
                        {
                            se = File.OpenWrite("Users.bin");
                            bf.Serialize(se, users);
                            se.Close();
                        }
                        catch (SerializationException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        readFileToList();
                        if (sameUser == true)
                        {
                            thisUser = currentUser;
                        }
                        if (thisUser.Admin != true)
                        {
                            this.Close();
                            new frmMain(thisUser, easyDummyArray, hardDummyArray).Show();
                        }
                        else
                        {
                            this.Close();
                            new frmUserEdit(thisUser, easyDummyArray, hardDummyArray).Show();
                        }
                    }
                }
                else
                {
                    currentUser.Username = txtUsername.Text;
                    currentUser.Password = txtPassword.Text;
                    currentUser.Highscore = Convert.ToInt16(txtHighscore.Text);
                    currentUser.Admin = Convert.ToBoolean(cbAdmin.Text);
                    currentUser.Score = 0;
                    users.Add(currentUser);
                    Stream se;
                    BinaryFormatter bf = new BinaryFormatter();
                    try
                    {
                        se = File.OpenWrite("Users.bin");
                        bf.Serialize(se, users);
                        se.Close();
                    }
                    catch (SerializationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    readFileToList();
                    if (sameUser == true)
                    {
                        thisUser = currentUser;
                    }
                    if (thisUser.Admin != true)
                    {
                        this.Close();
                        new frmMain(thisUser, easyDummyArray, hardDummyArray).Show();
                    }
                    else
                    {
                        this.Close();
                        new frmUserEdit(thisUser, easyDummyArray, hardDummyArray).Show();
                    }
                }
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) //Confirms each field is filled correctly to enable the save button
        {
            if (cbUser.Text != "" && cbAdmin.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtHighscore.Text != "" && pbIconCurrent != null)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void cbAdmin_SelectedIndexChanged(object sender, EventArgs e) //Confirms each field is filled correctly to enable the save button
        {
            if (cbUser.Text != "" && cbAdmin.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtHighscore.Text != "" && pbIconCurrent != null)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e) //Confirms each field is filled correctly to enable the save button
        {
            if (cbUser.Text != "" && cbAdmin.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtHighscore.Text != "" && pbIconCurrent != null)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtHighscore_TextChanged(object sender, EventArgs e) //Confirms each field is filled correctly to enable the save button
        {
            if (cbUser.Text != "" && cbAdmin.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtHighscore.Text != "" && pbIconCurrent != null)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e) //Help form
        {
            if (help == false)
            {
                picHelp.BringToFront();
                picHelp.Visible = true;
                btnHelp.Text = ("Back to User Data");
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

