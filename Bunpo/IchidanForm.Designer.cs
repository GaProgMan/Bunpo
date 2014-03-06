namespace Bunpo
{
    partial class IchidanForm
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
            this.ichidanPictureBox = new System.Windows.Forms.PictureBox();
            this.ichidanDescriptionLabel = new System.Windows.Forms.Label();
            this.examplePictureBox = new System.Windows.Forms.PictureBox();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ichidanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Location = new System.Drawing.Point(110, 234);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 30);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "&Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ichidanPictureBox
            // 
            this.ichidanPictureBox.Location = new System.Drawing.Point(55, 10);
            this.ichidanPictureBox.Name = "ichidanPictureBox";
            this.ichidanPictureBox.Size = new System.Drawing.Size(100, 50);
            this.ichidanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ichidanPictureBox.TabIndex = 5;
            this.ichidanPictureBox.TabStop = false;
            // 
            // ichidanDescriptionLabel
            // 
            this.ichidanDescriptionLabel.AutoSize = true;
            this.ichidanDescriptionLabel.Location = new System.Drawing.Point(51, 96);
            this.ichidanDescriptionLabel.Name = "ichidanDescriptionLabel";
            this.ichidanDescriptionLabel.Size = new System.Drawing.Size(38, 23);
            this.ichidanDescriptionLabel.TabIndex = 0;
            this.ichidanDescriptionLabel.Text = "Label";
            this.ichidanDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ichidanDescriptionLabel.UseCompatibleTextRendering = true;
            this.ichidanDescriptionLabel.UseMnemonic = false;
            // 
            // examplePictureBox
            // 
            this.examplePictureBox.Location = new System.Drawing.Point(79, 151);
            this.examplePictureBox.Name = "examplePictureBox";
            this.examplePictureBox.Size = new System.Drawing.Size(136, 50);
            this.examplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.examplePictureBox.TabIndex = 7;
            this.examplePictureBox.TabStop = false;
            // 
            // exampleLabel
            // 
            this.exampleLabel.Location = new System.Drawing.Point(55, 204);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(184, 27);
            this.exampleLabel.TabIndex = 0;
            this.exampleLabel.Text = "exampleLabel";
            this.exampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exampleLabel.UseCompatibleTextRendering = true;
            this.exampleLabel.UseMnemonic = false;
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = true;
            this.nextButton.Location = new System.Drawing.Point(207, 234);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 30);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "->";
            this.nextButton.UseMnemonic = false;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // IchidanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(294, 276);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.exampleLabel);
            this.Controls.Add(this.examplePictureBox);
            this.Controls.Add(this.ichidanDescriptionLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ichidanPictureBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(110, 34);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IchidanForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ichidan Verbs";
            ((System.ComponentModel.ISupportInitialize)(this.ichidanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox ichidanPictureBox;
        private System.Windows.Forms.Label ichidanDescriptionLabel;
        private System.Windows.Forms.PictureBox examplePictureBox;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.Button nextButton;
    }
}