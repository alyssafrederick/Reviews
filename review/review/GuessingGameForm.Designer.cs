namespace review
{
    partial class GuessingGameForm
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
            this.directions = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.TextBox();
            this.rightORwrong = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directions
            // 
            this.directions.AutoSize = true;
            this.directions.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directions.Location = new System.Drawing.Point(27, 21);
            this.directions.Name = "directions";
            this.directions.Size = new System.Drawing.Size(166, 42);
            this.directions.TabIndex = 0;
            this.directions.Text = "guess my number...\r\nit\'s between 0 and 100";
            this.directions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guess
            // 
            this.guess.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess.Location = new System.Drawing.Point(80, 78);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(62, 38);
            this.guess.TabIndex = 1;
            this.guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rightORwrong
            // 
            this.rightORwrong.AutoSize = true;
            this.rightORwrong.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightORwrong.Location = new System.Drawing.Point(27, 190);
            this.rightORwrong.Name = "rightORwrong";
            this.rightORwrong.Size = new System.Drawing.Size(166, 21);
            this.rightORwrong.TabIndex = 2;
            this.rightORwrong.Text = "                          ";
            this.rightORwrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.LightCyan;
            this.next.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(31, 133);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(162, 39);
            this.next.TabIndex = 3;
            this.next.Text = "so am I right?";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(216, 233);
            this.Controls.Add(this.next);
            this.Controls.Add(this.rightORwrong);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.directions);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directions;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.Label rightORwrong;
        private System.Windows.Forms.Button next;
    }
}