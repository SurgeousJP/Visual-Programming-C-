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
        static int locX = 100;
        static int locY = 100;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void RedrawRectangle()
        {
            g.Clear(SystemColors.Control);
            g.DrawRectangle(Pens.Black, locX, locY, 200, 200);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(SystemColors.Control);
            g.DrawRectangle(Pens.Black, locX, locY, 200, 200);
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
            RedrawRectangle();
        }
    }
}
