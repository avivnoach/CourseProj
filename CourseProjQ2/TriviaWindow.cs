using CourseProjQ2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.CodeDom;

namespace courseProjQ22
{
    public partial class TriviaWindow : Form
    {
        private string clientName;
        private List<Question> questions; // contains the questions
        private List<Result> results; // contains the results
        private int correctAnswerBtn; // comtains the correct answer button number
        private Stopwatch timeMeasure; // for measuring time
        private int questionNumber; // for iterating questions
        private bool started; // flags
        private bool finished;
        public TriviaWindow(Coordinate coor, string clientName)
        {
            InitializeComponent();
            this.Left = coor.left;
            this.Top = coor.top;
            this.clientName = clientName;
            this.results = new List<Result>();
            this.timeMeasure = new Stopwatch();
            this.questionNumber = 0;
            ans1.Hide();
            ans2.Hide();
            ans3.Hide();
            ans4.Hide();
            started = false;
            finished = false;
            questions = Deserializer.desirializeQuestions();
            ShuffleList(questions); // shuffling questions
            questions = questions.GetRange(0, 10); // taking 10 out of the questions
            QuestionTextBox.Text = "Press the Start button to start the game!";
        }

        private void gameFinished()
        {
            ans3.Show();
            ans4.Show();
            finished = true;
            int correctAnswers = 0;
            foreach(Result r in results)
            {
                if (r.correctAns)
                    correctAnswers++;
            }
            QuestionTextBox.Text = "The game Has ended, youv'e got " + correctAnswers + " correct answers out of 10 questions!";
            ans1.Text = "Start Over";
            ans2.Text = "Start New Game";
            ans3.Text = "Check answers";
            ans4.Text = "Back to menu";
            string fileName = "outdata" + DateTime.Now.ToString("yyyy-Mm-ddTHH_mm_ss") + ".txt";
            string fileData = clientName + "'s game" + '\n' + "Grade: " + correctAnswers + "/10" + '\n' + '\n';
            foreach(Result r in results)
            {
                if(r.correctAns)
                {
                    fileData += r.question.question.ToString() + " -- You answered correctly in " + r.time + " milliseconds!" + '\n';
                }
                else
                {
                    fileData += r.question.question.ToString() + " -- You answered wrong in " + r.time + " milliseconds..." + '\n';
                }
            }
            FileStream outFile = File.Create(fileName);
            outFile.Write(Encoding.ASCII.GetBytes(fileData), 0, fileData.Length);
            outFile.Close();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuWindow menu = new menuWindow(new Coordinate(this.Left, this.Top), this.clientName);
            menu.ShowDialog();
        }
        private void generateAnswers(Question q)
        {
            QuestionTextBox.Text = q.question;
            if (q.type == 1)
            {
                Random rnd = new Random();
                this.correctAnswerBtn = rnd.Next(1, 5); // randomizing int for the correct answer order (the wrong ones doesn't matter)
                ans3.Show();
                ans4.Show();
                switch (correctAnswerBtn) // setting the answers in random locations
                {
                    case 1: // each case places the correct answer in a different location
                        ans1.Text = q.correctAns;
                        ans2.Text = (string)q.wrongAns[0];
                        ans3.Text = (string)q.wrongAns[1];
                        ans4.Text = (string)q.wrongAns[2];
                        break;
                    case 2:
                        ans2.Text = q.correctAns;
                        ans3.Text = (string)q.wrongAns[0];
                        ans4.Text = (string)q.wrongAns[1];
                        ans1.Text = (string)q.wrongAns[2];
                        break;
                    case 3:
                        ans3.Text = q.correctAns;
                        ans4.Text = (string)q.wrongAns[0];
                        ans1.Text = (string)q.wrongAns[1];
                        ans2.Text = (string)q.wrongAns[2];
                        break;
                    case 4:
                        ans4.Text = q.correctAns;
                        ans1.Text = (string)q.wrongAns[0];
                        ans2.Text = (string)q.wrongAns[1];
                        ans3.Text = (string)q.wrongAns[2];
                        break;
                }
            }
            else // if its true/false wuestion the order doesn't matter
            {
                if(q.correctAns == "true")
                {
                    this.correctAnswerBtn = 1;
                }
                else
                {
                    this.correctAnswerBtn = 2;
                }
                ans1.Text = "True";
                ans2.Text = "False";
                ans3.Hide(); // no need in the last two answer buttons
                ans4.Hide();
            }
            timeMeasure.Start(); // since the questions already placed on the screen, starting timer
        }
        private void answered(Question q, int answerBtn, double time)
        {
            if(this.correctAnswerBtn == answerBtn)
            {
                this.results.Add(new Result(q, time, true));
            }
            else
            {
                this.results.Add(new Result(q, time, false));
            }
            timeMeasure.Reset();
            if (questionNumber == 9) // if theres no more questions
            {
                gameFinished();
            }
            else
            {
                questionNumber++;
                generateAnswers(questions[questionNumber]);
            }
            
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                ans1.Show();
                ans2.Show();
                ans3.Show();
                ans4.Show();
                generateAnswers(questions[questionNumber]);
                started = true;
            }
        }
        private void ans1_Click(object sender, EventArgs e)
        {
            if(finished) // if the game has finished, the buttons have a different functionality
            {
                results.Clear();
                questionNumber = 0;
                finished = false;
                generateAnswers(questions[questionNumber]);
            }
            else if(started)
            {
                timeMeasure.Stop();
                answered(questions[questionNumber], 1, timeMeasure.ElapsedMilliseconds);
            }
        }
        private void ans2_Click(object sender, EventArgs e)
        {
            if (finished)
            {
                questions = Deserializer.desirializeQuestions();
                ShuffleList(questions);
                questions = questions.GetRange(0, 10);
                results.Clear();
                questionNumber = 0;
                finished = false;
                generateAnswers(questions[questionNumber]);
            }
            else if (started)
            {
                timeMeasure.Stop();
                answered(questions[questionNumber], 2, timeMeasure.ElapsedMilliseconds);
            }
        }
        private void ans3_Click(object sender, EventArgs e)
        {
            if(finished)
            {
                this.Hide();
                inspectResults menu = new inspectResults(new Coordinate(this.Left, this.Top), this.results, this.clientName);
                menu.ShowDialog();
            }
            else if (started)
            {
                timeMeasure.Stop();
                answered(questions[questionNumber], 3, timeMeasure.ElapsedMilliseconds);
            }
        }
        private void ans4_Click(object sender, EventArgs e)
        {
            if(finished)
            {
                this.Hide();
                menuWindow menu = new menuWindow(new Coordinate(this.Left, this.Top), this.clientName);
                menu.ShowDialog();
            }
            else if (started)
            {
                timeMeasure.Stop();
                answered(questions[questionNumber], 4, timeMeasure.ElapsedMilliseconds);
            }
        }
        private void ShuffleList(List<Question> list)
        {
            Random rnd = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Question value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
