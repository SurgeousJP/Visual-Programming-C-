using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Lab04_Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text ="Hôm nay là ngày " + DateTime.Now.ToString("d", new CultureInfo("vi-VN")) 
                + " - Bây giờ là"
                + " " + DateTime.Now.ToString("T", new CultureInfo("vi-VN"))
                + " " + DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
        }
        public static string filePath;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "AVI|*.avi|MPEG|*.mpeg|WAV|*.wav|MIDI|*.midi|MP4|*.mp4|MP3|*.mp3";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
                axWindowsMediaPlayer1.URL = filePath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nException Unhandled");

            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Hôm nay là ngày " + DateTime.Now.ToString("d", new CultureInfo("vi-VN"))
                + " - Bây giờ là"
                + " " + DateTime.Now.ToString("T", new CultureInfo("vi-VN"))
                + " " + DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn tắt media player ? (Y/N)", "Tắt Media Player"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;
        }
    }
}
