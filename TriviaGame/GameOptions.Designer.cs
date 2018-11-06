namespace TriviaGame
{
    partial class GameOptions
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
            this.optBackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.optSportsButton = new System.Windows.Forms.RadioButton();
            this.optGamesButton = new System.Windows.Forms.RadioButton();
            this.optMoviesButton = new System.Windows.Forms.RadioButton();
            this.optMusicButton = new System.Windows.Forms.RadioButton();
            this.optTVButton = new System.Windows.Forms.RadioButton();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.optEasyButton = new System.Windows.Forms.RadioButton();
            this.optMedButton = new System.Windows.Forms.RadioButton();
            this.optHardButton = new System.Windows.Forms.RadioButton();
            this.correctAnsTextBox = new System.Windows.Forms.TextBox();
            this.SecAnsTextBox = new System.Windows.Forms.TextBox();
            this.thirdAnsTextBox = new System.Windows.Forms.TextBox();
            this.fourthAnsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // optBackButton
            // 
            this.optBackButton.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBackButton.Image = global::TriviaGame.Properties.Resources.backB;
            this.optBackButton.Location = new System.Drawing.Point(22, 352);
            this.optBackButton.Name = "optBackButton";
            this.optBackButton.Size = new System.Drawing.Size(87, 44);
            this.optBackButton.TabIndex = 5;
            this.optBackButton.UseVisualStyleBackColor = true;
            this.optBackButton.Click += new System.EventHandler(this.optBackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Question Creator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pick a Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Question:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Difficulty Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Correct Answer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Second Answer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Third Answer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fourth Answer:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::TriviaGame.Properties.Resources.backB;
            this.button1.Location = new System.Drawing.Point(128, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 44);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::TriviaGame.Properties.Resources.backB;
            this.button2.Location = new System.Drawing.Point(239, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 44);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // optSportsButton
            // 
            this.optSportsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.optSportsButton.AutoSize = true;
            this.optSportsButton.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSportsButton.Location = new System.Drawing.Point(17, 58);
            this.optSportsButton.Name = "optSportsButton";
            this.optSportsButton.Size = new System.Drawing.Size(50, 25);
            this.optSportsButton.TabIndex = 16;
            this.optSportsButton.TabStop = true;
            this.optSportsButton.Text = "Sports";
            this.optSportsButton.UseVisualStyleBackColor = true;
            // 
            // optGamesButton
            // 
            this.optGamesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.optGamesButton.AutoSize = true;
            this.optGamesButton.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optGamesButton.Location = new System.Drawing.Point(73, 58);
            this.optGamesButton.Name = "optGamesButton";
            this.optGamesButton.Size = new System.Drawing.Size(55, 25);
            this.optGamesButton.TabIndex = 17;
            this.optGamesButton.TabStop = true;
            this.optGamesButton.Text = "Games";
            this.optGamesButton.UseVisualStyleBackColor = true;
            // 
            // optMoviesButton
            // 
            this.optMoviesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.optMoviesButton.AutoSize = true;
            this.optMoviesButton.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMoviesButton.Location = new System.Drawing.Point(265, 58);
            this.optMoviesButton.Name = "optMoviesButton";
            this.optMoviesButton.Size = new System.Drawing.Size(56, 25);
            this.optMoviesButton.TabIndex = 18;
            this.optMoviesButton.TabStop = true;
            this.optMoviesButton.Text = "Movies";
            this.optMoviesButton.UseVisualStyleBackColor = true;
            // 
            // optMusicButton
            // 
            this.optMusicButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.optMusicButton.AutoSize = true;
            this.optMusicButton.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMusicButton.Location = new System.Drawing.Point(208, 58);
            this.optMusicButton.Name = "optMusicButton";
            this.optMusicButton.Size = new System.Drawing.Size(51, 25);
            this.optMusicButton.TabIndex = 19;
            this.optMusicButton.TabStop = true;
            this.optMusicButton.Text = "Music";
            this.optMusicButton.UseVisualStyleBackColor = true;
            // 
            // optTVButton
            // 
            this.optTVButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.optTVButton.AutoSize = true;
            this.optTVButton.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optTVButton.Location = new System.Drawing.Point(134, 58);
            this.optTVButton.Name = "optTVButton";
            this.optTVButton.Size = new System.Drawing.Size(68, 25);
            this.optTVButton.TabIndex = 20;
            this.optTVButton.TabStop = true;
            this.optTVButton.Text = "TV Shows";
            this.optTVButton.UseVisualStyleBackColor = true;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(17, 112);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(304, 20);
            this.questionTextBox.TabIndex = 21;
            // 
            // optEasyButton
            // 
            this.optEasyButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.optEasyButton.AutoSize = true;
            this.optEasyButton.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optEasyButton.Location = new System.Drawing.Point(85, 164);
            this.optEasyButton.Name = "optEasyButton";
            this.optEasyButton.Size = new System.Drawing.Size(43, 25);
            this.optEasyButton.TabIndex = 22;
            this.optEasyButton.TabStop = true;
            this.optEasyButton.Text = "Easy";
            this.optEasyButton.UseVisualStyleBackColor = true;
            // 
            // optMedButton
            // 
            this.optMedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.optMedButton.AutoSize = true;
            this.optMedButton.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMedButton.Location = new System.Drawing.Point(134, 164);
            this.optMedButton.Name = "optMedButton";
            this.optMedButton.Size = new System.Drawing.Size(64, 25);
            this.optMedButton.TabIndex = 23;
            this.optMedButton.TabStop = true;
            this.optMedButton.Text = "Medium";
            this.optMedButton.UseVisualStyleBackColor = true;
            // 
            // optHardButton
            // 
            this.optHardButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.optHardButton.AutoSize = true;
            this.optHardButton.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optHardButton.Location = new System.Drawing.Point(204, 164);
            this.optHardButton.Name = "optHardButton";
            this.optHardButton.Size = new System.Drawing.Size(45, 25);
            this.optHardButton.TabIndex = 24;
            this.optHardButton.TabStop = true;
            this.optHardButton.Text = "Hard";
            this.optHardButton.UseVisualStyleBackColor = true;
            // 
            // correctAnsTextBox
            // 
            this.correctAnsTextBox.Location = new System.Drawing.Point(118, 217);
            this.correctAnsTextBox.Name = "correctAnsTextBox";
            this.correctAnsTextBox.Size = new System.Drawing.Size(203, 20);
            this.correctAnsTextBox.TabIndex = 25;
            // 
            // SecAnsTextBox
            // 
            this.SecAnsTextBox.Location = new System.Drawing.Point(118, 247);
            this.SecAnsTextBox.Name = "SecAnsTextBox";
            this.SecAnsTextBox.Size = new System.Drawing.Size(203, 20);
            this.SecAnsTextBox.TabIndex = 26;
            // 
            // thirdAnsTextBox
            // 
            this.thirdAnsTextBox.Location = new System.Drawing.Point(118, 273);
            this.thirdAnsTextBox.Name = "thirdAnsTextBox";
            this.thirdAnsTextBox.Size = new System.Drawing.Size(203, 20);
            this.thirdAnsTextBox.TabIndex = 27;
            // 
            // fourthAnsTextBox
            // 
            this.fourthAnsTextBox.Location = new System.Drawing.Point(118, 299);
            this.fourthAnsTextBox.Name = "fourthAnsTextBox";
            this.fourthAnsTextBox.Size = new System.Drawing.Size(203, 20);
            this.fourthAnsTextBox.TabIndex = 28;
            // 
            // GameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 436);
            this.Controls.Add(this.fourthAnsTextBox);
            this.Controls.Add(this.thirdAnsTextBox);
            this.Controls.Add(this.SecAnsTextBox);
            this.Controls.Add(this.correctAnsTextBox);
            this.Controls.Add(this.optHardButton);
            this.Controls.Add(this.optMedButton);
            this.Controls.Add(this.optEasyButton);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.optTVButton);
            this.Controls.Add(this.optMusicButton);
            this.Controls.Add(this.optMoviesButton);
            this.Controls.Add(this.optGamesButton);
            this.Controls.Add(this.optSportsButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optBackButton);
            this.Name = "GameOptions";
            this.Text = "GameOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optBackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton optSportsButton;
        private System.Windows.Forms.RadioButton optGamesButton;
        private System.Windows.Forms.RadioButton optMoviesButton;
        private System.Windows.Forms.RadioButton optMusicButton;
        private System.Windows.Forms.RadioButton optTVButton;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.RadioButton optEasyButton;
        private System.Windows.Forms.RadioButton optMedButton;
        private System.Windows.Forms.RadioButton optHardButton;
        private System.Windows.Forms.TextBox correctAnsTextBox;
        private System.Windows.Forms.TextBox SecAnsTextBox;
        private System.Windows.Forms.TextBox thirdAnsTextBox;
        private System.Windows.Forms.TextBox fourthAnsTextBox;
    }
}