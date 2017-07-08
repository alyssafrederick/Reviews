namespace review
{
    partial class MadlibsForm
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
            this.numberAnswer = new System.Windows.Forms.TextBox();
            this.nounAnswer = new System.Windows.Forms.TextBox();
            this.adjectiveAnswer = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.nounLabel = new System.Windows.Forms.Label();
            this.adjectiveLabel = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.sentence = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberAnswer
            // 
            this.numberAnswer.BackColor = System.Drawing.Color.LightCyan;
            this.numberAnswer.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberAnswer.Location = new System.Drawing.Point(12, 154);
            this.numberAnswer.Name = "numberAnswer";
            this.numberAnswer.Size = new System.Drawing.Size(190, 29);
            this.numberAnswer.TabIndex = 0;
            this.numberAnswer.Text = "???";
            this.numberAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nounAnswer
            // 
            this.nounAnswer.BackColor = System.Drawing.Color.LightCyan;
            this.nounAnswer.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nounAnswer.Location = new System.Drawing.Point(276, 52);
            this.nounAnswer.Name = "nounAnswer";
            this.nounAnswer.Size = new System.Drawing.Size(190, 29);
            this.nounAnswer.TabIndex = 1;
            this.nounAnswer.Text = "???";
            this.nounAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adjectiveAnswer
            // 
            this.adjectiveAnswer.BackColor = System.Drawing.Color.LightCyan;
            this.adjectiveAnswer.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjectiveAnswer.Location = new System.Drawing.Point(534, 154);
            this.adjectiveAnswer.Name = "adjectiveAnswer";
            this.adjectiveAnswer.Size = new System.Drawing.Size(190, 29);
            this.adjectiveAnswer.TabIndex = 2;
            this.adjectiveAnswer.Text = "???";
            this.adjectiveAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(32, 121);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(147, 21);
            this.numberLabel.TabIndex = 3;
            this.numberLabel.Text = "give me a number?";
            // 
            // nounLabel
            // 
            this.nounLabel.AutoSize = true;
            this.nounLabel.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nounLabel.Location = new System.Drawing.Point(283, 18);
            this.nounLabel.Name = "nounLabel";
            this.nounLabel.Size = new System.Drawing.Size(174, 21);
            this.nounLabel.TabIndex = 4;
            this.nounLabel.Text = "give me a plural noun?";
            // 
            // adjectiveLabel
            // 
            this.adjectiveLabel.AutoSize = true;
            this.adjectiveLabel.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjectiveLabel.Location = new System.Drawing.Point(548, 121);
            this.adjectiveLabel.Name = "adjectiveLabel";
            this.adjectiveLabel.Size = new System.Drawing.Size(161, 21);
            this.adjectiveLabel.TabIndex = 5;
            this.adjectiveLabel.Text = "give me an adjective?";
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.LightCyan;
            this.next.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(307, 191);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(128, 43);
            this.next.TabIndex = 6;
            this.next.Text = "so what\'s next?";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // sentence
            // 
            this.sentence.AutoSize = true;
            this.sentence.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentence.Location = new System.Drawing.Point(85, 296);
            this.sentence.Name = "sentence";
            this.sentence.Size = new System.Drawing.Size(22, 21);
            this.sentence.TabIndex = 7;
            this.sentence.Text = "  ";
            // 
            // Form1
            // 
            this.AcceptButton = this.next;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(736, 429);
            this.Controls.Add(this.sentence);
            this.Controls.Add(this.next);
            this.Controls.Add(this.adjectiveLabel);
            this.Controls.Add(this.nounLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.adjectiveAnswer);
            this.Controls.Add(this.nounAnswer);
            this.Controls.Add(this.numberAnswer);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberAnswer;
        private System.Windows.Forms.TextBox nounAnswer;
        private System.Windows.Forms.TextBox adjectiveAnswer;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label nounLabel;
        private System.Windows.Forms.Label adjectiveLabel;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label sentence;
    }
}

