namespace Bunpo
{
    partial class MainMenu
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
            this.mainMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.verbButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuPictureBox
            // 
            this.mainMenuPictureBox.Location = new System.Drawing.Point(55, 10);
            this.mainMenuPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.mainMenuPictureBox.Name = "mainMenuPictureBox";
            this.mainMenuPictureBox.Size = new System.Drawing.Size(100, 50);
            this.mainMenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainMenuPictureBox.TabIndex = 1;
            this.mainMenuPictureBox.TabStop = false;
            // 
            // verbButton
            // 
            this.verbButton.AutoSize = true;
            this.verbButton.Location = new System.Drawing.Point(12, 172);
            this.verbButton.Name = "verbButton";
            this.verbButton.Size = new System.Drawing.Size(75, 30);
            this.verbButton.TabIndex = 1;
            this.verbButton.Text = "&Verbs";
            this.verbButton.UseVisualStyleBackColor = true;
            this.verbButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.AutoSize = true;
            this.aboutButton.Location = new System.Drawing.Point(110, 198);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 30);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.Text = "&About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(110, 234);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 30);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 276);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.verbButton);
            this.Controls.Add(this.mainMenuPictureBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainMenuPictureBox;
        private System.Windows.Forms.Button verbButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButton;
    }
}

