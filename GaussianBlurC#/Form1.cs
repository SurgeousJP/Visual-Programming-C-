using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBlur
{
    public partial class Form1 : Form
    {
        public static Image img = Image.FromFile(@"C:\Users\tuanb\Downloads\Pictures\DOkiRkcWkAAojb-.jfif");
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = img;
            pictureBox2.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var image = img;
            var blur = new GaussianBlur(img as Bitmap);

            var result = blur.Process(25);
            pictureBox2.Image = result;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var image = img;
            var blur = new GaussianBlur(img as Bitmap);

            var result = blur.Process(trackBar1.Value);
            pictureBox2.Image = result;
        }
    }
}
