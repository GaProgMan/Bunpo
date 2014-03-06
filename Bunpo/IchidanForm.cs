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
    public partial class IchidanForm : Form {
        public string description;
        public string[] ichidanExamples;
        public int lines = 0;
        public int exampleNumber;

        public IchidanForm() {
            InitializeComponent();
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream ichidanPic = myAssembly.GetManifestResourceStream("Bunpo.Ichidan.jpg");
            Bitmap ichidanBitmap = new Bitmap(ichidanPic);
            ichidanPictureBox.Image = ichidanBitmap;

            System.IO.Stream fileStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Bunpo.Ichidan.txt");
            using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
            {
               description = reader.ReadToEnd();
            }

            ichidanDescriptionLabel.Text = description;

            fileStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Bunpo.IchidanExamples.txt");
            using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
            {
               string details = reader.ReadToEnd();
               ichidanExamples = details.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
               lines = ichidanExamples.Length;
            }

            loadImage();
        }

        private void loadImage() {
           System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
           Stream ichidanPic;
           Bitmap ichidanBitmap;
           switch (lines)
           {
              case 0:
                 ichidanPic = myAssembly.GetManifestResourceStream("Bunpo.IchidanExamples.00-ageru.jpg");
                 ichidanBitmap = new Bitmap(ichidanPic);
                 examplePictureBox.Image = ichidanBitmap;
                 exampleLabel.Text = ichidanExamples[0];
                 lines++;
                 break;
              case 1:
                 ichidanPic = myAssembly.GetManifestResourceStream("Bunpo.IchidanExamples.01-deru.jpg");
                 ichidanBitmap = new Bitmap(ichidanPic);
                 examplePictureBox.Image = ichidanBitmap;
                 exampleLabel.Text = ichidanExamples[1];
                 lines++;
                 break;
              case 2:
                 ichidanPic = myAssembly.GetManifestResourceStream("Bunpo.IchidanExamples.02-haeru.jpg");
                 ichidanBitmap = new Bitmap(ichidanPic);
                 examplePictureBox.Image = ichidanBitmap;
                 exampleLabel.Text = ichidanExamples[2];
                 lines++;
                 break;
              case 3:
                 ichidanPic = myAssembly.GetManifestResourceStream("Bunpo.IchidanExamples.03-iru.jpg");
                 ichidanBitmap = new Bitmap(ichidanPic);
                 examplePictureBox.Image = ichidanBitmap;
                 exampleLabel.Text = ichidanExamples[3];
                 lines++;
                 break;
              case 4:
                 ichidanPic = myAssembly.GetManifestResourceStream("Bunpo.IchidanExamples.04-kiru.jpg");
                 ichidanBitmap = new Bitmap(ichidanPic);
                 examplePictureBox.Image = ichidanBitmap;
                 exampleLabel.Text = ichidanExamples[4];
                 lines++;
                 break;
              case 5:
                 ichidanPic = myAssembly.GetManifestResourceStream("Bunpo.IchidanExamples.05-miru.jpg");
                 ichidanBitmap = new Bitmap(ichidanPic);
                 examplePictureBox.Image = ichidanBitmap;
                 exampleLabel.Text = ichidanExamples[5];
                 lines++;
                 break;
              case 6:
                 ichidanPic = myAssembly.GetManifestResourceStream("Bunpo.IchidanExamples.06-ochiru.jpg");
                 ichidanBitmap = new Bitmap(ichidanPic);
                 examplePictureBox.Image = ichidanBitmap;
                 exampleLabel.Text = ichidanExamples[6];
                 lines++;
                 break;
              case 7:
                 ichidanPic = myAssembly.GetManifestResourceStream("Bunpo.IchidanExamples.07-taberu.jpg");
                 ichidanBitmap = new Bitmap(ichidanPic);
                 examplePictureBox.Image = ichidanBitmap;
                 exampleLabel.Text = ichidanExamples[7];
                 lines = 0;
                 break;
           };
        }

        private void backButton_Click(object sender, EventArgs e) {
            lines = 0;
            this.Hide();
        }

        private void nextButton_Click(object sender, EventArgs e) {
            loadImage();
        }
    }
}