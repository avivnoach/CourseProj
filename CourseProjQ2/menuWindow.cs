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

namespace courseProjQ22
{
    public partial class menuWindow : Form
    {
        private string clientName;
        public menuWindow(Coordinate coor, string clientName)
        {
            InitializeComponent();
            this.Left = coor.left;
            this.Top = coor.top;
            this.clientName = clientName;
            menuText.Text = "Hello " + clientName + "!";
            instructionsText.Text = "What would you like to do?";
        }

        private void learnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LearnWindow menu = new LearnWindow(new Coordinate(this.Left, this.Top), this.clientName);
            menu.ShowDialog();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TriviaWindow menu = new TriviaWindow(new Coordinate(this.Left, this.Top), this.clientName);
            menu.ShowDialog();
        }
    }
}
