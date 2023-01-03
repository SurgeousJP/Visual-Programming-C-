using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Event Click chuột
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Bạn đã click chuột trái ở tọa độ (" + e.X.ToString() + "," + e.Y.ToString() + ")"); ;
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Bạn đã click chuột phải ở tọa độ (" + e.X.ToString() + "," + e.Y.ToString() + ")");
            }
            else if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Bạn đã click con lăn chuột (middle) ở tọa độ (" + e.X.ToString() + "," + e.Y.ToString() + ")");
            }
        }
        // Event keydown (nhấn phím)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // +"\nKeyModifier: " + e.KeyData.ToString()
            MessageBox.Show("Mã ASCII: " + e.KeyValue.ToString() + "\nKeyCode: " + e.KeyCode.ToString());
        }
    }
}
