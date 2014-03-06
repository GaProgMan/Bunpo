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
    public partial class MainMenu : Form {
        public string aboutString = "";
        VerbForm newVerbForm = new VerbForm();
        public MainMenu() {
            InitializeComponent();
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream mainMenuPic = myAssembly.GetManifestResourceStream("Bunpo.Bunpo.jpg");
            Bitmap mainMenuBitmap = new Bitmap(mainMenuPic);
            mainMenuPictureBox.Image = mainMenuBitmap;
        }

        private void button1_Click(object sender, EventArgs e) {
            newVerbForm.Show();
            //MessageBox.Show("You clicked the verb button! Yay!!", "Warning", MessageBoxButtons.OK);
        }

        private void aboutButton_Click(object sender, EventArgs e) {
           System.IO.Stream fileStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Bunpo.AboutMessage.txt");
           using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
           {
              aboutString = reader.ReadToEnd();
           }
            MessageBox.Show(aboutString, "About", MessageBoxButtons.OK);
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}