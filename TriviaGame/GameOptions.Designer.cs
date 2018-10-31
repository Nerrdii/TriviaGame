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
            this.SuspendLayout();
            // 
            // optBackButton
            // 
            this.optBackButton.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBackButton.Image = global::TriviaGame.Properties.Resources.backB;
            this.optBackButton.Location = new System.Drawing.Point(130, 352);
            this.optBackButton.Name = "optBackButton";
            this.optBackButton.Size = new System.Drawing.Size(87, 44);
            this.optBackButton.TabIndex = 5;
            this.optBackButton.UseVisualStyleBackColor = true;
            this.optBackButton.Click += new System.EventHandler(this.optBackButton_Click);
            // 
            // GameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 436);
            this.Controls.Add(this.optBackButton);
            this.Name = "GameOptions";
            this.Text = "GameOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optBackButton;
    }
}