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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string[] correctUsernames = { "Abe", "alyssa", "britt", "zoe", "arielle" };
        string[] correctPasswords = { "123", "frederick", "gronemeyer", "plotkin", "carabet" };

        private void next_Click(object sender, EventArgs e)
        {
            goodLabel.Visible = false;
            somethingswrongLabel.Visible = false;

            bool foundLogin = false;

            for (int a = 0; a < correctUsernames.Length; a++)
            {
                if (password.Text == correctPasswords[a] && username.Text == correctUsernames[a])
                {
                    foundLogin = true;
                }
            }

            if (foundLogin)
            {
                goodLabel.Visible = true;
            }
            else
            {
                somethingswrongLabel.Visible = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    }
}
