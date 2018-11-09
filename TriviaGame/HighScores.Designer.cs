namespace TriviaGame
{
    partial class HighScores
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
            this.hscoreTBackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.scoreDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hscoreTBackButton
            // 
            this.hscoreTBackButton.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hscoreTBackButton.Image = global::TriviaGame.Properties.Resources.backB;
            this.hscoreTBackButton.Location = new System.Drawing.Point(81, 347);
            this.hscoreTBackButton.Name = "hscoreTBackButton";
            this.hscoreTBackButton.Size = new System.Drawing.Size(87, 44);
            this.hscoreTBackButton.TabIndex = 4;
            this.hscoreTBackButton.UseVisualStyleBackColor = true;
            this.hscoreTBackButton.Click += new System.EventHandler(this.howTBackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "High Scores";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::TriviaGame.Properties.Resources.highscoresB;
            this.button1.Location = new System.Drawing.Point(185, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 44);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // scoreDataGridView
            // 
            this.scoreDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.scoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreDataGridView.Location = new System.Drawing.Point(32, 63);
            this.scoreDataGridView.Name = "scoreDataGridView";
            this.scoreDataGridView.Size = new System.Drawing.Size(275, 262);
            this.scoreDataGridView.TabIndex = 7;
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 436);
            this.Controls.Add(this.scoreDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hscoreTBackButton);
            this.Name = "HighScores";
            this.Text = "HighScores";
            this.Load += new System.EventHandler(this.HighScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hscoreTBackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView scoreDataGridView;
    }
}