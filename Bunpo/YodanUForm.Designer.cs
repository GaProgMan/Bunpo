namespace Bunpo
{
    partial class YodanUForm
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
            this.yodanUPictureBoxOne = new System.Windows.Forms.PictureBox();
            this.yodanULabelOne = new System.Windows.Forms.Label();
            this.yodanULabelTwo = new System.Windows.Forms.Label();
            this.yodanUPictureBoxTwo = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yodanUPictureBoxOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yodanUPictureBoxTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // yodanUPictureBoxOne
            // 
            this.yodanUPictureBoxOne.Location = new System.Drawing.Point(12, 12);
            this.yodanUPictureBoxOne.Name = "yodanUPictureBoxOne";
            this.yodanUPictureBoxOne.Size = new System.Drawing.Size(136, 73);
            this.yodanUPictureBoxOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.yodanUPictureBoxOne.TabIndex = 7;
            this.yodanUPictureBoxOne.TabStop = false;
            // 
            // yodanULabelOne
            // 
            this.yodanULabelOne.AutoSize = true;
            this.yodanULabelOne.Location = new System.Drawing.Point(154, 41);
            this.yodanULabelOne.Name = "yodanULabelOne";
            this.yodanULabelOne.Size = new System.Drawing.Size(44, 18);
            this.yodanULabelOne.TabIndex = 8;
            this.yodanULabelOne.Text = "label1";
            // 
            // yodanULabelTwo
            // 
            this.yodanULabelTwo.AutoSize = true;
            this.yodanULabelTwo.Location = new System.Drawing.Point(154, 120);
            this.yodanULabelTwo.Name = "yodanULabelTwo";
            this.yodanULabelTwo.Size = new System.Drawing.Size(44, 18);
            this.yodanULabelTwo.TabIndex = 10;
            this.yodanULabelTwo.Text = "label1";
            // 
            // yodanUPictureBoxTwo
            // 
            this.yodanUPictureBoxTwo.Location = new System.Drawing.Point(12, 91);
            this.yodanUPictureBoxTwo.Name = "yodanUPictureBoxTwo";
            this.yodanUPictureBoxTwo.Size = new System.Drawing.Size(136, 73);
            this.yodanUPictureBoxTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.yodanUPictureBoxTwo.TabIndex = 9;
            this.yodanUPictureBoxTwo.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = true;
            this.nextButton.Location = new System.Drawing.Point(207, 234);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 30);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "->";
            this.nextButton.UseMnemonic = false;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Location = new System.Drawing.Point(110, 234);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 30);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "&Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // YodanUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 276);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.yodanULabelTwo);
            this.Controls.Add(this.yodanUPictureBoxTwo);
            this.Controls.Add(this.yodanULabelOne);
            this.Controls.Add(this.yodanUPictureBoxOne);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YodanUForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yodan - U Verbs";
            ((System.ComponentModel.ISupportInitialize)(this.yodanUPictureBoxOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yodanUPictureBoxTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox yodanUPictureBoxOne;
        private System.Windows.Forms.Label yodanULabelOne;
        private System.Windows.Forms.Label yodanULabelTwo;
        private System.Windows.Forms.PictureBox yodanUPictureBoxTwo;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
    }
}