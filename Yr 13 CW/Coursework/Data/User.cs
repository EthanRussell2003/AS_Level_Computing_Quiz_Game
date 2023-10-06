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
    [Serializable]
    public class User
    {
        string username, password;
        int score, highscore;
        bool admin;
        Image icon;

        public User()
        {
            username = "";
            password = "";
            score = 0;
            highscore = 0;
            admin = false;
            icon = null;
        }
        public User(string username, string password, int score, int highscore, bool admin, Image icon)
        {
            Username = username;
            Password = password;
            Highscore = highscore;
            Admin = admin;
            Icon = icon;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int Highscore
        {
            get { return highscore; }
            set { highscore = value; }
        }

        public bool Admin
        {
            get { return admin; }
            set { admin = value; }
        }

        public Image Icon
        {
            get { return icon; }
            set { icon = value; }
        }
    }
}
