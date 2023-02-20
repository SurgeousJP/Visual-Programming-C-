using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace TestMultipleFormsToDeleteFiles
{
    public partial class FormStart : Form
    {
        public static List<string> files = new List<string>();

        public void InitializeDummyImageList()
        {
            files = new List<string>();
            string path = @"C:\Users\tuanb\Downloads\TestPicture";
            string[] allFiles = Directory.GetFiles(path);
            for (int i = 0; i < 12; i++)
            {
                files.Add(allFiles[i]);
            }
        }
        public FormStart()
        {
            InitializeDummyImageList();
            InitializeComponent();
            SetImageToPictureBoxes();
        }

        public void SetImageToPictureBoxes()
        {
            pictureBox1.Image = Image.FromFile(files[0]);
            pictureBox2.Image = Image.FromFile(files[1]);
            pictureBox3.Image = Image.FromFile(files[2]);
            pictureBox4.Image = Image.FromFile(files[3]);
            pictureBox5.Image = Image.FromFile(files[4]);
            pictureBox6.Image = Image.FromFile(files[5]);   
            pictureBox7.Image = Image.FromFile(files[6]);
            pictureBox8.Image = Image.FromFile(files[7]);
            pictureBox9.Image = Image.FromFile(files[8]);
            pictureBox10.Image = Image.FromFile(files[9]);
            pictureBox11.Image = Image.FromFile(files[10]);
            pictureBox12.Image = Image.FromFile(files[11]);
        }

        private void FormStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;

            foreach (var file in files)
            {
                File.Delete(file);
            }
        }

        private void FormStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.Dispose();
            pictureBox2.Dispose();
            pictureBox3.Dispose();
            pictureBox4.Dispose();
            pictureBox5.Dispose();
             pictureBox6.Dispose();
            pictureBox7.Dispose();
            pictureBox8.Dispose();
            pictureBox9.Dispose();
            pictureBox10.Dispose();
            pictureBox11.Dispose();
            pictureBox12.Dispose();


            foreach (var file in files)
            {
                File.Delete(file);
            }
        }
    }
}
