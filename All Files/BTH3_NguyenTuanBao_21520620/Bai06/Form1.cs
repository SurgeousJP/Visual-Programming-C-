using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai06
{
    public partial class Form1 : Form
    {
        // Cac bien luu tru 
        static bool performOp = false;
        static float memValue = 0;
        static string calcOperator = "";
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }
        // Cac event click chuot vo cac so 0->9, su dung chung 1 ham do y tuong giong nhau
        private void NumberButton(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || performOp) textBox1.Clear();
            performOp = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NumberButton(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberButton(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberButton(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberButton(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberButton(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NumberButton(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NumberButton(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            NumberButton(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            NumberButton(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            NumberButton(sender, e);
        }
        // Backspace --> xoa so cuoi
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            catch
            {
                // do nothing
            }
        }
        // CE -> xoa mot gia tri 
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        // C  --> xoa toan bo gia tri
        private void button19_Click(object sender, EventArgs e)
        {
            memValue = 0;
            textBox1.Text = "0";
            label1.Text = " ";
        }
        // +/- 
        private void button2_Click(object sender, EventArgs e)
        {
            float value = float.Parse(textBox1.Text);
            textBox1.Text = (-value).ToString();
        }
        //, 
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(','))
            {
                return;
            }
            else
            {
                textBox1.Text += ',';
            }
        }
        // Ham su dung chung cho cac phep cong tru nhan chia
        private void button_Operators(object sender, EventArgs e, string Operator)
        {
            if (memValue == 0)
            {
                calcOperator = Operator;
                memValue = float.Parse(textBox1.Text);
            }
            else
            {
                button20.PerformClick();
                calcOperator = Operator;
            }
            label1.Text = textBox1.Text + " " + Operator;
            performOp = true;
        }
        // + 
        private void button4_Click(object sender, EventArgs e)
        {
            button_Operators(sender, e, "+");
        }
        // -  
        private void button8_Click(object sender, EventArgs e)
        {
            button_Operators(sender, e, "-");
        }
        // * 
        private void button12_Click(object sender, EventArgs e)
        {
            button_Operators(sender, e, "*");
        }
        // /
        private void button16_Click(object sender, EventArgs e)
        {
            button_Operators(sender, e, "/");
        }
        // =
        private void button20_Click(object sender, EventArgs e)
        {
            
            switch (calcOperator)
            {
                case "+":
                    memValue = memValue + float.Parse(textBox1.Text);
                    textBox1.Text = memValue.ToString();
                    label1.Text = " ";
                    calcOperator = " ";
                    break;
                case "-":
                    memValue = memValue - float.Parse(textBox1.Text);
                    textBox1.Text = memValue.ToString();
                    label1.Text = " ";
                    calcOperator = " ";
                    break;
                case "*":
                    memValue = memValue * float.Parse(textBox1.Text);
                    textBox1.Text = memValue.ToString();
                    label1.Text = " ";
                    calcOperator = " ";
                    break;
                case "/":
                    memValue = memValue / float.Parse(textBox1.Text);
                    textBox1.Text = memValue.ToString();
                    label1.Text = " ";
                    calcOperator = " ";
                    break;
            }
            try
            {
                if (textBox1.Text[textBox1.Text.Length - 1] == ',')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            catch
            {
                // do nothing since there's nothing to delete
            }
            
            
        }
        // Event form closing
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
