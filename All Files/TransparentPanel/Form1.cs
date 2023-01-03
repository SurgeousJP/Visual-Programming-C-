using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransparentPanel
{
    public partial class Form1 : Form
    {

        public class TransparentPanel : Panel
        {
            protected override CreateParams CreateParams
            {
                get
                {
                    var cp = base.CreateParams;
                    cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT

                    return cp;
                }
            }

            protected override void OnPaint(PaintEventArgs e) =>
                e.Graphics.FillRectangle(new SolidBrush(this.BackColor), this.ClientRectangle);
        }
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.White);
        }
    }
}
