namespace review
{
    partial class RockPaperScissors
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
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.scissors = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.Ipickedlabel = new System.Windows.Forms.Label();
            this.computerspick = new System.Windows.Forms.Label();
            this.youlabel = new System.Windows.Forms.Label();
            this.winorlose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rock
            // 
            this.rock.Font = new System.Drawing.Font("Andy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rock.Location = new System.Drawing.Point(12, 12);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(101, 39);
            this.rock.TabIndex = 0;
            this.rock.Text = "rock";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // paper
            // 
            this.paper.Font = new System.Drawing.Font("Andy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paper.Location = new System.Drawing.Point(12, 57);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(101, 39);
            this.paper.TabIndex = 1;
            this.paper.Text = "paper";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // scissors
            // 
            this.scissors.Font = new System.Drawing.Font("Andy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissors.Location = new System.Drawing.Point(12, 103);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(101, 39);
            this.scissors.TabIndex = 2;
            this.scissors.Text = "scissors";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Andy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(138, 65);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(45, 25);
            this.next.TabIndex = 3;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Ipickedlabel
            // 
            this.Ipickedlabel.AutoSize = true;
            this.Ipickedlabel.Font = new System.Drawing.Font("Andy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ipickedlabel.Location = new System.Drawing.Point(198, 24);
            this.Ipickedlabel.Name = "Ipickedlabel";
            this.Ipickedlabel.Size = new System.Drawing.Size(81, 27);
            this.Ipickedlabel.TabIndex = 4;
            this.Ipickedlabel.Text = "I picked";
            this.Ipickedlabel.Visible = false;
            // 
            // computerspick
            // 
            this.computerspick.AutoSize = true;
            this.computerspick.Font = new System.Drawing.Font("Andy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerspick.Location = new System.Drawing.Point(203, 51);
            this.computerspick.Name = "computerspick";
            this.computerspick.Size = new System.Drawing.Size(0, 27);
            this.computerspick.TabIndex = 5;
            // 
            // youlabel
            // 
            this.youlabel.AutoSize = true;
            this.youlabel.Font = new System.Drawing.Font("Andy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youlabel.Location = new System.Drawing.Point(214, 78);
            this.youlabel.Name = "youlabel";
            this.youlabel.Size = new System.Drawing.Size(43, 27);
            this.youlabel.TabIndex = 6;
            this.youlabel.Text = "you";
            this.youlabel.Visible = false;
            // 
            // winorlose
            // 
            this.winorlose.AutoSize = true;
            this.winorlose.Font = new System.Drawing.Font("Andy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winorlose.Location = new System.Drawing.Point(214, 105);
            this.winorlose.Name = "winorlose";
            this.winorlose.Size = new System.Drawing.Size(0, 27);
            this.winorlose.TabIndex = 7;
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(291, 154);
            this.Controls.Add(this.winorlose);
            this.Controls.Add(this.youlabel);
            this.Controls.Add(this.computerspick);
            this.Controls.Add(this.Ipickedlabel);
            this.Controls.Add(this.next);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Name = "RockPaperScissors";
            this.Text = "RockPaperScissors";
            this.Load += new System.EventHandler(this.RockPaperScissors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label Ipickedlabel;
        private System.Windows.Forms.Label computerspick;
        private System.Windows.Forms.Label youlabel;
        private System.Windows.Forms.Label winorlose;
    }
}