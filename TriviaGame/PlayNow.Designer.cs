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
            this.answerButton1 = new System.Windows.Forms.RadioButton();
            this.answerButton2 = new System.Windows.Forms.RadioButton();
            this.answerButton3 = new System.Windows.Forms.RadioButton();
            this.answerButton4 = new System.Windows.Forms.RadioButton();
            this.answersGroupBox = new System.Windows.Forms.GroupBox();
            this.quitbutton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.answersGroupBox.SuspendLayout();
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
            this.questDisplayLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questDisplayLabel.Location = new System.Drawing.Point(13, 44);
            this.questDisplayLabel.Name = "questDisplayLabel";
            this.questDisplayLabel.Size = new System.Drawing.Size(313, 101);
            this.questDisplayLabel.TabIndex = 13;
            this.questDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerButton1
            // 
            this.answerButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerButton1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton1.Location = new System.Drawing.Point(6, 27);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(151, 47);
            this.answerButton1.TabIndex = 15;
            this.answerButton1.TabStop = true;
            this.answerButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerButton1.UseVisualStyleBackColor = true;
            // 
            // answerButton2
            // 
            this.answerButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerButton2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton2.Location = new System.Drawing.Point(163, 27);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(145, 47);
            this.answerButton2.TabIndex = 16;
            this.answerButton2.TabStop = true;
            this.answerButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerButton2.UseVisualStyleBackColor = true;
            // 
            // answerButton3
            // 
            this.answerButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerButton3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton3.Location = new System.Drawing.Point(6, 89);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(151, 47);
            this.answerButton3.TabIndex = 17;
            this.answerButton3.TabStop = true;
            this.answerButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerButton3.UseVisualStyleBackColor = true;
            // 
            // answerButton4
            // 
            this.answerButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerButton4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton4.Location = new System.Drawing.Point(163, 89);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(145, 47);
            this.answerButton4.TabIndex = 18;
            this.answerButton4.TabStop = true;
            this.answerButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerButton4.UseVisualStyleBackColor = true;
            // 
            // answersGroupBox
            // 
            this.answersGroupBox.Controls.Add(this.answerButton1);
            this.answersGroupBox.Controls.Add(this.answerButton2);
            this.answersGroupBox.Controls.Add(this.answerButton3);
            this.answersGroupBox.Controls.Add(this.answerButton4);
            this.answersGroupBox.Location = new System.Drawing.Point(13, 158);
            this.answersGroupBox.Name = "answersGroupBox";
            this.answersGroupBox.Size = new System.Drawing.Size(314, 142);
            this.answersGroupBox.TabIndex = 21;
            this.answersGroupBox.TabStop = false;
            this.answersGroupBox.Text = "Select One";
            // 
            // quitbutton
            // 
            this.quitbutton.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitbutton.Image = global::TriviaGame.Properties.Resources.quitB;
            this.quitbutton.Location = new System.Drawing.Point(75, 328);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(88, 49);
            this.quitbutton.TabIndex = 22;
            this.quitbutton.UseVisualStyleBackColor = true;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Image = global::TriviaGame.Properties.Resources.nextB;
            this.nextButton.Location = new System.Drawing.Point(169, 328);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(88, 49);
            this.nextButton.TabIndex = 20;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // PlayNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 436);
            this.Controls.Add(this.quitbutton);
            this.Controls.Add(this.answersGroupBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.questDisplayLabel);
            this.Controls.Add(this.label3);
            this.Name = "PlayNow";
            this.Text = "PlayNow";
            this.Load += new System.EventHandler(this.PlayNow_Load);
            this.answersGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label questDisplayLabel;
        private System.Windows.Forms.RadioButton answerButton1;
        private System.Windows.Forms.RadioButton answerButton2;
        private System.Windows.Forms.RadioButton answerButton3;
        private System.Windows.Forms.RadioButton answerButton4;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.GroupBox answersGroupBox;
        private System.Windows.Forms.Button quitbutton;
    }
}