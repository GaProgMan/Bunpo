using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Bunpo {
    public partial class YodanUForm : Form {
        public string[] yodanExamples;
        public int lines = 0;

        public YodanUForm() {
            InitializeComponent();

            System.IO.Stream fileStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Bunpo.yodanUExamples.txt");
            using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
            {
               string details = reader.ReadToEnd();
               yodanExamples = details.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
               lines = yodanExamples.Length;
            }

            LoadImages();
        }
        private void LoadImages() {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream yodanPic;
            Bitmap yodanBitmap;
            switch (lines) {
                case 0:
                    yodanPic = myAssembly.GetManifestResourceStream("Bunpo.YodanU.00-au.jpg");
                    yodanBitmap = new Bitmap(yodanPic);
                    yodanUPictureBoxOne.Image = yodanBitmap;
                    yodanULabelOne.Text = yodanExamples[0];

                    yodanPic = myAssembly.GetManifestResourceStream("Bunpo.YodanU.01-iu.jpg");
                    yodanBitmap = new Bitmap(yodanPic);
                    yodanUPictureBoxTwo.Image = yodanBitmap;
                    yodanULabelTwo.Text = yodanExamples[1];
                    lines++;
                    break;

                case 1:
                    yodanPic = myAssembly.GetManifestResourceStream("Bunpo.YodanU.02-kau.jpg");
                    yodanBitmap = new Bitmap(yodanPic);
                    yodanUPictureBoxOne.Image = yodanBitmap;
                    yodanULabelOne.Text = yodanExamples[2];

                    yodanPic = myAssembly.GetManifestResourceStream("Bunpo.YodanU.03-utau.jpg");
                    yodanBitmap = new Bitmap(yodanPic);
                    yodanUPictureBoxTwo.Image = yodanBitmap;
                    yodanULabelTwo.Text = yodanExamples[3];

                    lines = 0;
                    break;
            };
        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void nextButton_Click(object sender, EventArgs e) {
            LoadImages();
        }
    }
}