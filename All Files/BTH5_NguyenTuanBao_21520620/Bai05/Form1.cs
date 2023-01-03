using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            DrawDemo();
        }
        private void DrawDemo()
        {
            Font fa = new Font("Times New Roman", 14);
            g.DrawString("ĐH CNTT", fa, Brushes.Salmon, 10, 10);
            Font fb = new Font("Arial", 36, FontStyle.Bold);
            g.DrawString("ĐH CNTT", fb, Brushes.Navy, 10, 30);
            Font fc = new Font(fb, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("ĐH CNTT", fc, Brushes.Orchid, 10, 80);
            Font fd = new Font("Impact", 1, GraphicsUnit.Inch);
            g.DrawString("ĐH CNTT", fd, Brushes.HotPink, 10, 120);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDemo();
        }
    }
}
