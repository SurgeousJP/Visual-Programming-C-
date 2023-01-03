using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        static Graphics g;
        static int Radius;
        static int xLoc, yLoc;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Subtract)
            {
                Radius -= 10;
            }
            else if (e.KeyCode == Keys.Add)
            {
                Radius += 10;
            }
            RedrawCircle();
        }
        private void RedrawCircle()
        {
            g.Clear(SystemColors.Control);
            g.DrawEllipse(Pens.Black, xLoc, yLoc, Radius, Radius);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            g.Clear(SystemColors.Control);
            Random rnd = new Random();
            Radius = rnd.Next(0, 250);
            xLoc = e.X;
            yLoc = e.Y;
            g.DrawEllipse(Pens.Black, e.X, e.Y, Radius, Radius);
        }
    }
}
