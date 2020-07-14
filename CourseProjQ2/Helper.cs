using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

enum questionType { TRUEFALSE, AMERICAN };

namespace CourseProjQ2
{
    // Struct contains the locations of a window
    public class Coordinate
    {
        public int left { get; set; }
        public int top { get; set; }
        public Coordinate(int left, int top)
        {
            this.left = left;
            this.top = top;
        }
    }

    public class Question
    {
        public int number { get; set; }
        public int type { get; set; }
        public string question { get; set; }
        public string correctAns { get; set; }
        public ArrayList wrongAns { get; set; }

        public Question(int num, int type, string Question, string correctAns, string[] wrongAns)
        {
            this.number = num;
            this.type = type;
            this.question = Question;
            this.correctAns = correctAns;
            this.wrongAns = new ArrayList();
            this.wrongAns.AddRange(wrongAns);
        }
    }

    public class Fact
    {
        public int number { get; set; }
        public string topic { get; set; }
        public string fact { get; set; }

        public Fact(int number, string topic, string fact)
        {
            this.number = number;
            this.topic = topic;
            this.fact = fact;
        }
    }

    public class Result
    {
        public Question question { get; set; }
        public double time { get; set; }
        public bool correctAns { get; set; }

        public Result(Question q, double time, bool correctAns)
        {
            this.question = q;
            this.time = time;
            this.correctAns = correctAns;
        }

#pragma warning disable CS0114 // 'Result.ToString()' hides inherited member 'object.ToString()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        public string ToString()
#pragma warning restore CS0114 // 'Result.ToString()' hides inherited member 'object.ToString()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        {
            return "Question: " + question.question + '\n' + "Correct answer: " + question.correctAns;
        }
    }

    public class Deserializer
    {
        public static Queue<Fact> desirializeFacts() // function load the questions from the text file
        {
            Queue<Fact> facts = new Queue<Fact>();
            ArrayList raw = new ArrayList(); // contains the fact before splitting into parts
            raw.AddRange(System.IO.File.ReadAllText("../../../infoData.txt").Split('\n')); // casting from string[] to arrayList
            string[] tempFact = new string[3]; // contains the facts after splitting into facts
            foreach (string f in raw) // for each fact in the arraylist
            {
                tempFact = f.Split(';'); // splitting by the known char ";"
                facts.Enqueue(new Fact(int.Parse(tempFact[0]), tempFact[1], tempFact[2])); // inserting into the fact queue
            }
            return facts;
        }

        public static List<Question> desirializeQuestions()
        {
            List<Question> questions = new List<Question>();
            ArrayList raw = new ArrayList();
            raw.AddRange(System.IO.File.ReadAllText("../../../gameData.txt").Split('\n')); // casting from string[] to arrayList
            string[] tempQuestion = new string[5];
            foreach (string f in raw) // for each fact in the arraylist
            {
                tempQuestion = f.Split(';');
                questions.Add(new Question(int.Parse(tempQuestion[0]), int.Parse(tempQuestion[1]), tempQuestion[2], tempQuestion[3], tempQuestion[4].Split('/')));
            }
            return questions;
        }
    }



}
