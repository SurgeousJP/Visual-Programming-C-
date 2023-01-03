using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        static Graphics g;
        static int locX = 200;
        static int locY = 200;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        static void RedrawString()
        {
            g.Clear(SystemColors.Control);
            string drawString = "Move ME";
            Font drawFont = new Font("Times New Roman", 18);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.DrawString(drawString, drawFont, drawBrush, locX, locY);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                locY -= 20;
            }
            else if (e.KeyCode == Keys.Down)
            {
                locY += 20;
            }
            else if (e.KeyCode == Keys.Left)
            {
                locX -= 20;
            }
            else if (e.KeyCode == Keys.Right)
            {
                locX += 20;
            }
            RedrawString();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string drawString = "Move ME";
            Font drawFont = new Font("Times New Roman", 18);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.DrawString(drawString, drawFont, drawBrush, 200, 200);
        }
    }
}
