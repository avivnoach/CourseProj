using CourseProjQ2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseProjQ22
{
    public partial class LearnWindow : Form
    {
        private Queue<Fact> facts;
        private string clientName;
        public LearnWindow(Coordinate coor, string clientName)
        {
            InitializeComponent();
            this.Left = coor.left;
            this.Top = coor.top;
            this.facts = Deserializer.desirializeFacts();
            this.clientName = clientName;
            nextFact();
        }

        public void nextFact()
        {
            if(this.facts.Count == 0)
            {
                this.facts = Deserializer.desirializeFacts();
            }
            Fact currectFact = this.facts.Dequeue();
            factNumText.Text = "Fact Number " + currectFact.number;
            topicText.Text = "Topic: " + currectFact.topic;
            FactTextBox.Text = currectFact.fact;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            nextFact();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide this window
            menuWindow menu = new menuWindow(new Coordinate(this.Left, this.Top), this.clientName); // build new window 
            menu.ShowDialog(); // show the next window, in case the menu window
        }
    }
}
