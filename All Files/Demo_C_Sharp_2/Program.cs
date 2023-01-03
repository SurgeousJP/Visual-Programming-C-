using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
namespace ReviewAll
{
    internal class Program
    {

        static PictureBox pb1 = new PictureBox();
        static PictureBox pb2 = new PictureBox();
        static Form test = new Form();
        public static void Main(string[] args)
        {
            // Switch to Net 6.0 and remove ImplicitUsing in csproj file
            test.Size = new System.Drawing.Size(1024, 1024);


            pb2 = new PictureBox();
            pb1.Size = new System.Drawing.Size(400, 400);
            pb1.Location = new Point(50, 50);
            pb2.Size = new System.Drawing.Size(400, 400);
            pb2.Location = new Point(650, 50);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            test.Controls.Add(pb1);
            test.Controls.Add(pb2);
            // Start from (50, 600)
            Label brightness = new Label();
            Label saturation = new Label();

            brightness.Text = "Brightness";
            brightness.Location = new Point(50, 600);
            brightness.Size = new System.Drawing.Size(100, 50);
            TrackBar brightnessTrackBar = new TrackBar();
            brightnessTrackBar.Location = new Point(175, 600);
            brightnessTrackBar.Width = 800;
            brightnessTrackBar.Height = 100;

            saturation.Text = "Saturation";
            saturation.Location = new Point(50, 700);
            saturation.Size = new System.Drawing.Size(100, 50);
            TrackBar saturationTrackBar = new TrackBar();
            saturationTrackBar.Location = new Point(175, 700);
            saturationTrackBar.Width = 800;
            saturationTrackBar.Height = 100;

            test.Controls.Add(brightness);
            test.Controls.Add(saturation);
            test.Controls.Add(brightnessTrackBar);
            test.Controls.Add(saturationTrackBar);

            Button fLoad, Save, Reset;
            fLoad = new Button();
            fLoad.Location = new Point(1000, 600);
            fLoad.Text = "Load";
            fLoad.Width = 50;
            fLoad.Height = 50;
            fLoad.Click += new EventHandler(Load_EventHandler);
            Save = new Button();
            Save.Text = "Save";
            Save.Width = 50;
            Save.Height = 50;
            Save.Location = new Point(1000, 700);
            Reset = new Button();
            Reset.Text = "Reset";
            Reset.Width = 75;
            Reset.Height = 75;
            Reset.Location = new Point(1100, 650);

            test.Controls.Add(fLoad);


            test.Controls.Add(Save);
            test.Controls.Add(Reset);
            test.AutoSize = true;
            Application.Run(test);
        }
        public static void Load_EventHandler(Object obj, EventArgs ea)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;" +
            "*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
            "Windows Bitmap (*.bmp)|*.bmp";
            openFileDialog.Multiselect = false;
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    test.Text = Path.GetFileName(openFileDialog.FileName);
                    pb1.Image = image;
                    pb2.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unhandled Exception !!!");
                    return;
                }

            }

        }
    }
}