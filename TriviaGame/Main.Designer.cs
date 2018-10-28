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
            this.startButton = new System.Windows.Forms.Button();
            this.howToButton = new System.Windows.Forms.Button();
            this.hiScoresButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(169, 43);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(152, 61);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // howToButton
            // 
            this.howToButton.FlatAppearance.BorderSize = 0;
            this.howToButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.howToButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.howToButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToButton.Location = new System.Drawing.Point(169, 110);
            this.howToButton.Name = "howToButton";
            this.howToButton.Size = new System.Drawing.Size(152, 61);
            this.howToButton.TabIndex = 1;
            this.howToButton.Text = "Instructions";
            this.howToButton.UseVisualStyleBackColor = true;
            this.howToButton.Click += new System.EventHandler(this.howToButton_Click);
            // 
            // hiScoresButton
            // 
            this.hiScoresButton.FlatAppearance.BorderSize = 0;
            this.hiScoresButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hiScoresButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hiScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiScoresButton.Location = new System.Drawing.Point(169, 177);
            this.hiScoresButton.Name = "hiScoresButton";
            this.hiScoresButton.Size = new System.Drawing.Size(152, 61);
            this.hiScoresButton.TabIndex = 2;
            this.hiScoresButton.Text = "High Scores";
            this.hiScoresButton.UseVisualStyleBackColor = true;
            this.hiScoresButton.Click += new System.EventHandler(this.hiScoresButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.FlatAppearance.BorderSize = 0;
            this.optionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.optionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.optionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsButton.Location = new System.Drawing.Point(169, 244);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(152, 61);
            this.optionsButton.TabIndex = 3;
            this.optionsButton.Text = "Game Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(169, 311);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 61);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit Game";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 441);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.hiScoresButton);
            this.Controls.Add(this.howToButton);
            this.Controls.Add(this.startButton);
            this.Name = "Main";
            this.Text = "Trivia Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button howToButton;
        private System.Windows.Forms.Button hiScoresButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

