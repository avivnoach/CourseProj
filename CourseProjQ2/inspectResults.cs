using CourseProjQ2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseProjQ22
{
    public partial class inspectResults : Form
    {
        private List<Result> results;
        private int questionNumber;
        private string clientName;
        public inspectResults(Coordinate coor, List<Result> results, string clientName)
        {
            InitializeComponent();
            this.Left = coor.left;
            this.Top = coor.top;
            questionNumber = 0;
            this.results = results;
            this.clientName = clientName;
            updateQuestion();
        }

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuWindow menu = new menuWindow(new Coordinate(this.Left, this.Top), this.clientName);
            menu.ShowDialog();
        }

        private void updateQuestion() // function updates the fields of the window
        {
            QuestionTextBox.Text = results[questionNumber].question.question;
            correctAnswerTextBox.Text = results[questionNumber].question.correctAns;
            millisecondsLabel.Text = results[questionNumber].time.ToString() + " Milliseconds";
            if(results[questionNumber].correctAns)
            {
                answerLabel.Text = "Yes!";
                answerLabel.ForeColor = Color.Green;
            }
            else
            {
                answerLabel.Text = "No...";
                answerLabel.ForeColor = Color.Red;
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if(questionNumber != 0) // so the index wont be negative
            {
                questionNumber--;
            }
            updateQuestion();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (questionNumber != 9) // so the index wont be out of bounds
            {
                questionNumber++;
            }
            updateQuestion();
        }
    }
}
