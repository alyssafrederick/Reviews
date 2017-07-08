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
    public partial class GuessingGameForm : Form
    {
        int answer;

        public GuessingGameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            answer = random.Next(1, 100);
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (int.Parse(guess.Text) == answer)
            {
                rightORwrong.Text = String.Format("that's correct!");
            }
            else
            {
                if (int.Parse(guess.Text) > answer)
                {
                    rightORwrong.Text = String.Format("you're too high");
                }
                else
                {
                    rightORwrong.Text = String.Format("you're too low");
                }
            }

            rightORwrong.Location = new Point( ClientSize.Width / 2 - rightORwrong.Width / 2, rightORwrong.Location.Y);

        }


    }
}
