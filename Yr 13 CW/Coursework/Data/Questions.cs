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
    public class Questions
    {
        string question;
        string answer1;
        string answer2;
        string answer3;
        string correctAnswer;
        bool hard;

        public Questions()
        {
            question = "";
            answer1 = "";
            answer2 = "";
            answer3 = "";
            correctAnswer = "";
            hard = false;
        }

        public Questions(string question, string answer1, string answer2, string answer3, string correctAnswer, bool hard)
        {
            Question = question;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            CorrectAnswer = correctAnswer;
            Hard = hard;
        }

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string Answer1
        {
            get { return answer1; }
            set { answer1 = value; }
        }

        public string Answer2
        {
            get { return answer2; }
            set { answer2 = value; }
        }

        public string Answer3
        {
            get { return answer3; }
            set { answer3 = value; }
        }

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }
        public bool Hard
        {
            get { return hard; }
            set { hard = value; }
        }
    }
}
