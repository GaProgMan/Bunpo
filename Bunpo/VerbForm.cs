using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bunpo {
    public partial class VerbForm : Form {
        IchidanForm newIchidanForm = new IchidanForm();
        YodanMenuForm newYodanMenuForm = new YodanMenuForm();
        public VerbForm() {
            InitializeComponent();
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream verbMenuPic = myAssembly.GetManifestResourceStream("Bunpo.Doushi.jpg");
            Bitmap verbMenuBitmap = new Bitmap(verbMenuPic);
            verbPictureBox.Image = verbMenuBitmap;
        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void ichdanButton_Click(object sender, EventArgs e) {
            newIchidanForm.Show();
        }

        private void yodanButton_Click(object sender, EventArgs e){
            newYodanMenuForm.Show();
        }
    }
}