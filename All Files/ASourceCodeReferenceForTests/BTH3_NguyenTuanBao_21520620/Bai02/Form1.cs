using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        static Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(SystemColors.Control);

            Random rnd = new Random();
            int rnd_LocX = rnd.Next(800);
            int rnd_LocY = rnd.Next(800);
            string drawString = "Paint Event";

            Font drawFont = new Font("Times New Roman", 18);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            g.DrawString(drawString, drawFont, drawBrush, rnd_LocX, rnd_LocY);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit ?", "Closing Form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
