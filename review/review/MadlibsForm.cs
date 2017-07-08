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
    public partial class MadlibsForm : Form
    {

        public MadlibsForm()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            sentence.Text = String.Format("She bought {0} {1} {2} from the drive through at McDonalds.", numberAnswer.Text, adjectiveAnswer.Text, nounAnswer.Text);
        }


      
    }
}
