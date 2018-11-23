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
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Image = global::TriviaGame.Properties.Resources.backB;
            this.backButton.Location = new System.Drawing.Point(349, 825);
            this.backButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(232, 105);
            this.backButton.TabIndex = 4;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 91);
            this.label1.TabIndex = 5;
            this.label1.Text = "High Scores";
            // 
            // scoreDataGridView
            // 
            this.scoreDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.scoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreDataGridView.Location = new System.Drawing.Point(85, 150);
            this.scoreDataGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.scoreDataGridView.Name = "scoreDataGridView";
            this.scoreDataGridView.Size = new System.Drawing.Size(733, 625);
            this.scoreDataGridView.TabIndex = 7;
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 1040);
            this.Controls.Add(this.scoreDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "HighScores";
            this.Text = "HighScores";
            this.Load += new System.EventHandler(this.HighScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView scoreDataGridView;
    }
}