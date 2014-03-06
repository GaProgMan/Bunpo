using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bunpo {
    public partial class MainMenu : Form {
        public string aboutString = "\tWelcome to seppydude's Japanese Grammar program!\nThis program was made to help me study Japanese grammar over the 2007 summer\nvacation from university. At the minute, it only has verbs, but a later version will\nhave all sorts of goodies and shiny objects (hopefully).\n\nIf you have anyproblems or suggestions, please feel free to email me:\n\t\t\t\t\tseppydude@gmail.com";
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
            MessageBox.Show(aboutString, "About", MessageBoxButtons.OK);
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}