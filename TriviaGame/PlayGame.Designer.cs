namespace TriviaGame
{
    partial class PlayGame
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
            this.sportsButton = new System.Windows.Forms.RadioButton();
            this.moviesButton = new System.Windows.Forms.RadioButton();
            this.tvShowsButton = new System.Windows.Forms.RadioButton();
            this.musicButton = new System.Windows.Forms.RadioButton();
            this.gamesButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.playNowButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.categoryGroupBox = new System.Windows.Forms.GroupBox();
            this.namesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sportsButton
            // 
            this.sportsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.sportsButton.AutoSize = true;
            this.sportsButton.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sportsButton.Location = new System.Drawing.Point(6, 28);
            this.sportsButton.Name = "sportsButton";
            this.sportsButton.Size = new System.Drawing.Size(69, 31);
            this.sportsButton.TabIndex = 3;
            this.sportsButton.TabStop = true;
            this.sportsButton.Text = "Sports";
            this.sportsButton.UseVisualStyleBackColor = true;
            // 
            // moviesButton
            // 
            this.moviesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.moviesButton.AutoSize = true;
            this.moviesButton.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviesButton.Location = new System.Drawing.Point(103, 28);
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Size = new System.Drawing.Size(77, 31);
            this.moviesButton.TabIndex = 4;
            this.moviesButton.TabStop = true;
            this.moviesButton.Text = "Movies";
            this.moviesButton.UseVisualStyleBackColor = true;
            // 
            // tvShowsButton
            // 
            this.tvShowsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.tvShowsButton.AutoSize = true;
            this.tvShowsButton.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvShowsButton.Location = new System.Drawing.Point(212, 28);
            this.tvShowsButton.Name = "tvShowsButton";
            this.tvShowsButton.Size = new System.Drawing.Size(96, 31);
            this.tvShowsButton.TabIndex = 5;
            this.tvShowsButton.TabStop = true;
            this.tvShowsButton.Text = "TV Shows";
            this.tvShowsButton.UseVisualStyleBackColor = true;
            // 
            // musicButton
            // 
            this.musicButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.musicButton.AutoSize = true;
            this.musicButton.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicButton.Location = new System.Drawing.Point(58, 91);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(69, 31);
            this.musicButton.TabIndex = 6;
            this.musicButton.TabStop = true;
            this.musicButton.Text = "Music";
            this.musicButton.UseVisualStyleBackColor = true;
            // 
            // gamesButton
            // 
            this.gamesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.gamesButton.AutoSize = true;
            this.gamesButton.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesButton.Location = new System.Drawing.Point(160, 91);
            this.gamesButton.Name = "gamesButton";
            this.gamesButton.Size = new System.Drawing.Size(76, 31);
            this.gamesButton.TabIndex = 7;
            this.gamesButton.TabStop = true;
            this.gamesButton.Text = "Games";
            this.gamesButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Trivia Game";
            // 
            // playNowButton
            // 
            this.playNowButton.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playNowButton.Image = global::TriviaGame.Properties.Resources.playgameB;
            this.playNowButton.Location = new System.Drawing.Point(185, 318);
            this.playNowButton.Name = "playNowButton";
            this.playNowButton.Size = new System.Drawing.Size(88, 49);
            this.playNowButton.TabIndex = 12;
            this.playNowButton.UseVisualStyleBackColor = true;
            this.playNowButton.Click += new System.EventHandler(this.playNowButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Image = global::TriviaGame.Properties.Resources.backB;
            this.backButton.Location = new System.Drawing.Point(70, 318);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(88, 49);
            this.backButton.TabIndex = 8;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // categoryGroupBox
            // 
            this.categoryGroupBox.Controls.Add(this.sportsButton);
            this.categoryGroupBox.Controls.Add(this.moviesButton);
            this.categoryGroupBox.Controls.Add(this.tvShowsButton);
            this.categoryGroupBox.Controls.Add(this.musicButton);
            this.categoryGroupBox.Controls.Add(this.gamesButton);
            this.categoryGroupBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryGroupBox.Location = new System.Drawing.Point(12, 72);
            this.categoryGroupBox.Name = "categoryGroupBox";
            this.categoryGroupBox.Size = new System.Drawing.Size(314, 146);
            this.categoryGroupBox.TabIndex = 13;
            this.categoryGroupBox.TabStop = false;
            this.categoryGroupBox.Text = "Choose a Category:";
            // 
            // namesTextBox
            // 
            this.namesTextBox.Location = new System.Drawing.Point(163, 254);
            this.namesTextBox.Name = "namesTextBox";
            this.namesTextBox.Size = new System.Drawing.Size(163, 20);
            this.namesTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter Name for High Scores:";
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namesTextBox);
            this.Controls.Add(this.categoryGroupBox);
            this.Controls.Add(this.playNowButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backButton);
            this.Name = "PlayGame";
            this.Text = "Play Game";
            this.Load += new System.EventHandler(this.PlayGame_Load);
            this.categoryGroupBox.ResumeLayout(false);
            this.categoryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton sportsButton;
        private System.Windows.Forms.RadioButton moviesButton;
        private System.Windows.Forms.RadioButton tvShowsButton;
        private System.Windows.Forms.RadioButton musicButton;
        private System.Windows.Forms.RadioButton gamesButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button playNowButton;
        private System.Windows.Forms.GroupBox categoryGroupBox;
        private System.Windows.Forms.TextBox namesTextBox;
        private System.Windows.Forms.Label label1;
    }
}