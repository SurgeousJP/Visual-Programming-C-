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
        public Form1()
        {
            InitializeComponent();
        }
        static bool parseSuccessful1, parseSuccessful2;
        static float firstElement, secondElement;
        // Event Cong hai so
        private void button1_Click(object sender, EventArgs e)
        {
            parseSuccessful1 = float.TryParse(textBox1.Text, out firstElement);
            parseSuccessful2 = float.TryParse(textBox2.Text, out secondElement);

            if (parseSuccessful1 & parseSuccessful2)
            {
                textBox3.Text = (firstElement + secondElement).ToString();
            }
            else
            {
                textBox3.Text = "So khong hop le !!!";
            }

        }
        // Event tru hai so
        private void button2_Click(object sender, EventArgs e)
        {
            parseSuccessful1 = float.TryParse(textBox1.Text, out firstElement);
            parseSuccessful2 = float.TryParse(textBox2.Text, out secondElement);

            if (parseSuccessful1 & parseSuccessful2)
            {
                textBox3.Text = (firstElement - secondElement).ToString();
            }
            else
            {
                textBox3.Text = "So khong hop le !!!";
            }
        }
        // Event nhan hai so
        private void button3_Click(object sender, EventArgs e)
        {
            parseSuccessful1 = float.TryParse(textBox1.Text, out firstElement);
            parseSuccessful2 = float.TryParse(textBox2.Text, out secondElement);

            if (parseSuccessful1 & parseSuccessful2)
            {
                textBox3.Text = (firstElement * secondElement).ToString();
            }
            else
            {
                textBox3.Text = "So khong hop le !!!";
            }
        }
        // Event chia hai so
        private void button4_Click(object sender, EventArgs e)
        {
            parseSuccessful1 = float.TryParse(textBox1.Text, out firstElement);
            parseSuccessful2 = float.TryParse(textBox2.Text, out secondElement);

            if (parseSuccessful1 & parseSuccessful2)
            {
                textBox3.Text = (firstElement / secondElement).ToString();
            }
            else
            {
                textBox3.Text = "So khong hop le !!!";
            }
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
