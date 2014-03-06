using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bunpo {
    public partial class YodanMenuForm : Form {
        public string description;
        public int screen = 1;

        //form declarations
        YodanUForm newYodanUForm = new YodanUForm();
        public YodanMenuForm() {
            InitializeComponent();
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream yodanPic = myAssembly.GetManifestResourceStream("Bunpo.Yodan.jpg");
            Bitmap yodanBitmap = new Bitmap(yodanPic);
            yodanPictureBox.Image = yodanBitmap;

            StreamReader sr = File.OpenText("Yodan.txt");
            description = sr.ReadToEnd();
            sr.Close();

            yodanDescriptionLabel.Text = description;

            showButtons();
        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void uButton_Click(object sender, EventArgs e) {
            newYodanUForm.Show();
        }

        private void tsuButton_Click(object sender, EventArgs e) {

        }

        private void ruButton_Click(object sender, EventArgs e) {

        }

        private void kuButton_Click(object sender, EventArgs e) {

        }

        private void guButton_Click(object sender, EventArgs e) {

        }

        private void suButton_Click(object sender, EventArgs e) {

        }

        private void nuButton_Click(object sender, EventArgs e) {

        }

        private void muButton_Click(object sender, EventArgs e) {

        }

        private void buButton_Click(object sender, EventArgs e) {

        }

        private void showButtons() {
            switch (screen) {
                case 1:
                    //visible buttons
                    uButton.Visible     = true;
                    tsuButton.Visible   = true;
                    ruButton.Visible    = true;

                    //invisible buttons
                    kuButton.Visible    = false;
                    guButton.Visible    = false;
                    suButton.Visible    = false;
                    nuButton.Visible    = false;
                    muButton.Visible    = false;
                    buButton.Visible    = false;

                    screen++;
                    break;

                case 2:
                    //visible buttons
                    kuButton.Visible    = true;
                    guButton.Visible    = true;
                    suButton.Visible    = true;

                    //invisible buttons
                    uButton.Visible     = false;
                    tsuButton.Visible   = false;
                    ruButton.Visible    = false;
                    nuButton.Visible    = false;
                    muButton.Visible    = false;
                    buButton.Visible    = false;
                    screen++;
                    break;

                case 3:
                    //visible buttons
                    nuButton.Visible    = true;
                    muButton.Visible    = true;
                    buButton.Visible    = true;

                    //invisible buttons
                    kuButton.Visible    = false;
                    guButton.Visible    = false;
                    suButton.Visible    = false;
                    uButton.Visible     = false;
                    tsuButton.Visible   = false;
                    ruButton.Visible    = false;

                    screen = 1;
                    break;
            };
        }

        private void nextButton_Click(object sender, EventArgs e) {
            showButtons();
        }
    }
}