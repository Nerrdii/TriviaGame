namespace TriviaGame
{
    partial class PlayNow
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
            this.label3 = new System.Windows.Forms.Label();
            this.questDisplayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answerButton1 = new System.Windows.Forms.RadioButton();
            this.answerButton2 = new System.Windows.Forms.RadioButton();
            this.answerButton3 = new System.Windows.Forms.RadioButton();
            this.answerButton4 = new System.Windows.Forms.RadioButton();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Trivia Game";
            // 
            // questDisplayLabel
            // 
            this.questDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questDisplayLabel.Location = new System.Drawing.Point(13, 68);
            this.questDisplayLabel.Name = "questDisplayLabel";
            this.questDisplayLabel.Size = new System.Drawing.Size(313, 56);
            this.questDisplayLabel.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select One";
            // 
            // answerButton1
            // 
            this.answerButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerButton1.Location = new System.Drawing.Point(21, 183);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(133, 47);
            this.answerButton1.TabIndex = 15;
            this.answerButton1.TabStop = true;
            this.answerButton1.UseVisualStyleBackColor = true;
            // 
            // answerButton2
            // 
            this.answerButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerButton2.Location = new System.Drawing.Point(183, 183);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(133, 47);
            this.answerButton2.TabIndex = 16;
            this.answerButton2.TabStop = true;
            this.answerButton2.UseVisualStyleBackColor = true;
            // 
            // answerButton3
            // 
            this.answerButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerButton3.Location = new System.Drawing.Point(21, 240);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(133, 47);
            this.answerButton3.TabIndex = 17;
            this.answerButton3.TabStop = true;
            this.answerButton3.UseVisualStyleBackColor = true;
            // 
            // answerButton4
            // 
            this.answerButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerButton4.Location = new System.Drawing.Point(183, 240);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(133, 47);
            this.answerButton4.TabIndex = 18;
            this.answerButton4.TabStop = true;
            this.answerButton4.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Image = global::TriviaGame.Properties.Resources.quitB;
            this.backButton.Location = new System.Drawing.Point(129, 328);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(88, 49);
            this.backButton.TabIndex = 19;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // PlayNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 436);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.answerButton4);
            this.Controls.Add(this.answerButton3);
            this.Controls.Add(this.answerButton2);
            this.Controls.Add(this.answerButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questDisplayLabel);
            this.Controls.Add(this.label3);
            this.Name = "PlayNow";
            this.Text = "PlayNow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label questDisplayLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton answerButton1;
        private System.Windows.Forms.RadioButton answerButton2;
        private System.Windows.Forms.RadioButton answerButton3;
        private System.Windows.Forms.RadioButton answerButton4;
        private System.Windows.Forms.Button backButton;
    }
}