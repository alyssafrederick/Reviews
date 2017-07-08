using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace review
{
    public partial class RockPaperScissors : Form
    {
        public RockPaperScissors()
        {
            InitializeComponent();
        }

        int computersPick;
        int yourPick = 0;

        private void RockPaperScissors_Load(object sender, EventArgs e)
        {
            
        }

        private void next_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            computersPick = random.Next(1, 4);
            
            if (computersPick == 1)
            {
                computerspick.Text = "rock";
            }
            if (computersPick == 2)
            {
                computerspick.Text = "paper";
            }
            if (computersPick == 3)
            {
                computerspick.Text = "scissors";
            }

           
            if (computersPick == 1 && yourPick == 2)
            {
                youlabel.Text = "you";
                winorlose.Text = "won";
            }
            else if (computersPick == 3 && yourPick == 1)
            {
                youlabel.Text = "you";
                winorlose.Text = "won";
            }
            else if (computersPick == 2 && yourPick == 3)
            {
                youlabel.Text = "you";
                winorlose.Text = "won";
            }
            else if (computersPick == 1 && yourPick == 1 || computersPick == 2 && yourPick == 2 || computersPick == 3 && yourPick == 3)
            {
                youlabel.Text = "we";
                winorlose.Text = "tied";
            }
            else
            {
                winorlose.Text = "lose";
            }

            Ipickedlabel.Visible = true;
            computerspick.Visible = true;
            youlabel.Visible = true;
            winorlose.Visible = true;
        }

        private void rock_Click(object sender, EventArgs e)
        {
            Ipickedlabel.Visible = false;
            computerspick.Visible = false;
            youlabel.Visible = false;
            winorlose.Visible = false;
            yourPick = 1;
        }

        private void paper_Click(object sender, EventArgs e)
        {
            Ipickedlabel.Visible = false;
            computerspick.Visible = false;
            youlabel.Visible = false;
            winorlose.Visible = false;
            yourPick = 2;
        }


        private void scissors_Click(object sender, EventArgs e)
        {
            Ipickedlabel.Visible = false;
            computerspick.Visible = false;
            youlabel.Visible = false;
            winorlose.Visible = false;
            yourPick = 3;
        }
    }
}
