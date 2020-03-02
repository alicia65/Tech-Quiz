using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech_Quiz
{

    public partial class Form1 : Form
    {

        //Global variable for the quiz

        // Question text and the correct answer

        private readonly SortedList<string, bool> Questions = new SortedList<string, bool>()
          {
            {"SSD are faster than HDD", true},
            {"Microsoft owns GitHub", true},
            {"100 is the ASCII code for 'A", false}
          };

        private int QuestionNumber = -1; // Current question number - start before the first question
        private int Score = 0; // User's score

        public Form1()
        {
            InitializeComponent();
            ShowNextQuestion();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            //Make sure at least one checkbox is checked
            if (rdoTrue.Checked || rdoFalse.Checked)
            {
                CheckAnswer();
                ShowNextQuestion();
            }
        }

        private void ShowNextQuestion()
        {
            QuestionNumber++;

            if (QuestionNumber < Questions.Count)
            {
                KeyValuePair<String, bool> question = Questions.ElementAt(QuestionNumber);
                string questionText = question.Key;
                txtQuestion.Text = questionText;

                //Uncheck both RadioButtons
                rdoTrue.Checked = false;
                rdoFalse.Checked = false;
            }

            else
            {
                btnCheckAnswer.Enabled = false;
                btnCheckAnswer.Text = "Quiz over!";
                MessageBox.Show($"Your score is{Score}", "Quiz Over!");
            }
        }

        private void CheckAnswer()
        {
            //Compare to answer stored in Questions Sorted
            // Make sure QuestionNumber value is withing range
            if (QuestionNumber < Questions.Count)
            {
                KeyValuePair<String, bool> question = Questions.ElementAt(QuestionNumber);
                bool correctAnswer = question.Value;

                if (correctAnswer == true && rdoTrue.Checked == true)
                {
                    Score++;
                }

                if (correctAnswer == false && rdoFalse.Checked == true)
                {
                    Score++;
                }

                lblScore.Text = $"Score: {Score}";
            }

        }
    }
}
   

    

