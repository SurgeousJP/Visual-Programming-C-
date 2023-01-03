using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
namespace Bai06
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            InitializeFontList();
        }
        public void InitializeFontList()
        {
            listBox1.ItemHeight = 30;
            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    listBox1.Items.Add(fa.Name);
                }
                listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
                new Font(listBox1.Items[e.Index].ToString(), 20), Brushes.Black, e.Bounds);
        }
    }
}
