namespace Bunpo
{
    partial class VerbForm
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
            this.verbPictureBox = new System.Windows.Forms.PictureBox();
            this.ichdanButton = new System.Windows.Forms.Button();
            this.yodanButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.verbPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // verbPictureBox
            // 
            this.verbPictureBox.Location = new System.Drawing.Point(55, 10);
            this.verbPictureBox.Name = "verbPictureBox";
            this.verbPictureBox.Size = new System.Drawing.Size(100, 50);
            this.verbPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.verbPictureBox.TabIndex = 0;
            this.verbPictureBox.TabStop = false;
            // 
            // ichdanButton
            // 
            this.ichdanButton.AutoSize = true;
            this.ichdanButton.Location = new System.Drawing.Point(12, 172);
            this.ichdanButton.Name = "ichdanButton";
            this.ichdanButton.Size = new System.Drawing.Size(75, 30);
            this.ichdanButton.TabIndex = 1;
            this.ichdanButton.Text = "&Ichidan";
            this.ichdanButton.UseCompatibleTextRendering = true;
            this.ichdanButton.UseVisualStyleBackColor = true;
            this.ichdanButton.Click += new System.EventHandler(this.ichdanButton_Click);
            // 
            // yodanButton
            // 
            this.yodanButton.AutoSize = true;
            this.yodanButton.Location = new System.Drawing.Point(93, 172);
            this.yodanButton.Name = "yodanButton";
            this.yodanButton.Size = new System.Drawing.Size(75, 30);
            this.yodanButton.TabIndex = 2;
            this.yodanButton.Text = "&Yodan";
            this.yodanButton.UseCompatibleTextRendering = true;
            this.yodanButton.UseVisualStyleBackColor = true;
            this.yodanButton.Click += new System.EventHandler(this.yodanButton_Click);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Location = new System.Drawing.Point(110, 234);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 30);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "&Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // VerbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(294, 276);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.yodanButton);
            this.Controls.Add(this.ichdanButton);
            this.Controls.Add(this.verbPictureBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "VerbForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verbs";
            ((System.ComponentModel.ISupportInitialize)(this.verbPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox verbPictureBox;
        private System.Windows.Forms.Button ichdanButton;
        private System.Windows.Forms.Button yodanButton;
        private System.Windows.Forms.Button backButton;
    }
}