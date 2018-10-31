namespace TriviaGame
{
    partial class Main
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
            this.exitButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.hiScoresButton = new System.Windows.Forms.Button();
            this.howToButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Image = global::TriviaGame.Properties.Resources.exitB;
            this.exitButton.Location = new System.Drawing.Point(89, 315);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 61);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.FlatAppearance.BorderSize = 0;
            this.optionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.optionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.optionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsButton.Image = global::TriviaGame.Properties.Resources.optionsB;
            this.optionsButton.Location = new System.Drawing.Point(89, 248);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(152, 61);
            this.optionsButton.TabIndex = 3;
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // hiScoresButton
            // 
            this.hiScoresButton.FlatAppearance.BorderSize = 0;
            this.hiScoresButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hiScoresButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hiScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiScoresButton.Image = global::TriviaGame.Properties.Resources.scoresB;
            this.hiScoresButton.Location = new System.Drawing.Point(89, 181);
            this.hiScoresButton.Name = "hiScoresButton";
            this.hiScoresButton.Size = new System.Drawing.Size(152, 61);
            this.hiScoresButton.TabIndex = 2;
            this.hiScoresButton.UseVisualStyleBackColor = true;
            this.hiScoresButton.Click += new System.EventHandler(this.hiScoresButton_Click);
            // 
            // howToButton
            // 
            this.howToButton.FlatAppearance.BorderSize = 0;
            this.howToButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.howToButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.howToButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToButton.Image = global::TriviaGame.Properties.Resources.howtoB;
            this.howToButton.Location = new System.Drawing.Point(89, 114);
            this.howToButton.Name = "howToButton";
            this.howToButton.Size = new System.Drawing.Size(152, 61);
            this.howToButton.TabIndex = 1;
            this.howToButton.UseVisualStyleBackColor = true;
            this.howToButton.Click += new System.EventHandler(this.howToButton_Click);
            // 
            // playButton
            // 
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Image = global::TriviaGame.Properties.Resources.playB;
            this.playButton.Location = new System.Drawing.Point(89, 47);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(152, 61);
            this.playButton.TabIndex = 0;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 436);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.hiScoresButton);
            this.Controls.Add(this.howToButton);
            this.Controls.Add(this.playButton);
            this.Name = "Main";
            this.Text = "Trivia Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button howToButton;
        private System.Windows.Forms.Button hiScoresButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

