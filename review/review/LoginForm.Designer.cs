namespace review
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.somethingswrongLabel = new System.Windows.Forms.Label();
            this.goodLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(104, 26);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(241, 29);
            this.username.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(12, 29);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(88, 21);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "username :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(14, 61);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(92, 21);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "password : ";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(104, 58);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(241, 29);
            this.password.TabIndex = 3;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.LightCyan;
            this.next.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(137, 98);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(94, 34);
            this.next.TabIndex = 4;
            this.next.Text = "let\'s go!";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // somethingswrongLabel
            // 
            this.somethingswrongLabel.AutoSize = true;
            this.somethingswrongLabel.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somethingswrongLabel.Location = new System.Drawing.Point(94, 142);
            this.somethingswrongLabel.Name = "somethingswrongLabel";
            this.somethingswrongLabel.Size = new System.Drawing.Size(187, 21);
            this.somethingswrongLabel.TabIndex = 5;
            this.somethingswrongLabel.Text = "uhh... something\'s wrong";
            this.somethingswrongLabel.Visible = false;
            // 
            // goodLabel
            // 
            this.goodLabel.AutoSize = true;
            this.goodLabel.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodLabel.Location = new System.Drawing.Point(130, 142);
            this.goodLabel.Name = "goodLabel";
            this.goodLabel.Size = new System.Drawing.Size(106, 21);
            this.goodLabel.TabIndex = 6;
            this.goodLabel.Text = "and you\'re in!";
            this.goodLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.next;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(365, 181);
            this.Controls.Add(this.goodLabel);
            this.Controls.Add(this.somethingswrongLabel);
            this.Controls.Add(this.next);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.username);
            this.Name = "LoginForm";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label somethingswrongLabel;
        private System.Windows.Forms.Label goodLabel;
    }
}