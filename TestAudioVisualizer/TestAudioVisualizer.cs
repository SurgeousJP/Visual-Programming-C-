using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TestAudioVisualizer
{
    public partial class TestAudioVisualizer : Form
    {
        public TestAudioVisualizer()
        {
            InitializeComponent();
            SetAudioVisualizer();
        }

        private void SetAudioVisualizer()
        {
            //Set the mode
            audioVisualization1.Mode = CSAudioVisualization.Mode.WasapiLoopbackCapture;

            //Set the device index
            //audioVisualization1.DeviceIndex = cboAudioSource.SelectedIndex;

            //Set the quality
            audioVisualization1.HighQuality = true;

            //Set the interval
            audioVisualization1.Interval = 40;

            //Set the background color
            audioVisualization1.BackColor = Color.Transparent;

            //Set the base color
            audioVisualization1.ColorBase = Color.White;

            //Set the max color
            audioVisualization1.ColorMax = Color.Black;

            // Set it to same effect as stretch image
            audioVisualization1.AutoScaleMode = AutoScaleMode.Dpi;
        }

        // Begin
        private void button2_Click(object sender, EventArgs e)
        {
            audioVisualization1.Start();
        }
        // Stop
        private void button1_Click(object sender, EventArgs e)
        {
            audioVisualization1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            audioVisualization1.Update();
        }
    }
}
