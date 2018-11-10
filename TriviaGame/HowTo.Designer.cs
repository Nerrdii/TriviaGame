namespace TriviaGame
{
    partial class HowTo
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
            this.label1 = new System.Windows.Forms.Label();
            this.fullButton = new System.Windows.Forms.Button();
            this.howTBackButton = new System.Windows.Forms.Button();
            this.quickButton = new System.Windows.Forms.Button();
            this.howtoLabeltext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game instructions!";
            // 
            // fullButton
            // 
            this.fullButton.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullButton.Location = new System.Drawing.Point(79, 43);
            this.fullButton.Name = "fullButton";
            this.fullButton.Size = new System.Drawing.Size(86, 36);
            this.fullButton.TabIndex = 1;
            this.fullButton.Text = "Full";
            this.fullButton.UseVisualStyleBackColor = true;
            this.fullButton.Click += new System.EventHandler(this.fullButton_Click);
            // 
            // howTBackButton
            // 
            this.howTBackButton.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howTBackButton.Image = global::TriviaGame.Properties.Resources.backB;
            this.howTBackButton.Location = new System.Drawing.Point(129, 368);
            this.howTBackButton.Name = "howTBackButton";
            this.howTBackButton.Size = new System.Drawing.Size(87, 44);
            this.howTBackButton.TabIndex = 3;
            this.howTBackButton.UseVisualStyleBackColor = true;
            this.howTBackButton.Click += new System.EventHandler(this.howTBackButton_Click);
            // 
            // quickButton
            // 
            this.quickButton.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickButton.Location = new System.Drawing.Point(171, 43);
            this.quickButton.Name = "quickButton";
            this.quickButton.Size = new System.Drawing.Size(86, 36);
            this.quickButton.TabIndex = 4;
            this.quickButton.Text = "Quick";
            this.quickButton.UseVisualStyleBackColor = true;
            this.quickButton.Click += new System.EventHandler(this.quickButton_Click);
            // 
            // howtoLabeltext
            // 
            this.howtoLabeltext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.howtoLabeltext.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howtoLabeltext.Location = new System.Drawing.Point(13, 82);
            this.howtoLabeltext.Name = "howtoLabeltext";
            this.howtoLabeltext.Size = new System.Drawing.Size(313, 283);
            this.howtoLabeltext.TabIndex = 5;
            // 
            // HowTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 436);
            this.Controls.Add(this.howtoLabeltext);
            this.Controls.Add(this.quickButton);
            this.Controls.Add(this.howTBackButton);
            this.Controls.Add(this.fullButton);
            this.Controls.Add(this.label1);
            this.Name = "HowTo";
            this.Text = "How To ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fullButton;
        private System.Windows.Forms.Button howTBackButton;
        private System.Windows.Forms.Button quickButton;
        private System.Windows.Forms.Label howtoLabeltext;
    }
}