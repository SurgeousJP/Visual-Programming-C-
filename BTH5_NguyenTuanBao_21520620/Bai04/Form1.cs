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
namespace Bai04
{
    public partial class Form1 : Form
    {
        public static Color textColor;
        public static bool isBold, isItalic, isUnderline;
        public static bool isLeftAlign, isRightAlign, isCenterAlign;
        public static FontStyle fontStyle;
        public static HorizontalAlignment textAlignment;
        public void Init()
        {
            richTextBox1.SelectionFont = new Font("Tahoma", 14, FontStyle.Regular);
            comboBox1.SelectedItem = "Tahoma";
            comboBox2.SelectedItem = "14";
            button1.BackColor = Color.Black;
            radioButton1.Checked = true;
        }
        public Form1()
        {
            InitializeComponent();
            InitializeFontList();
            InitializeFontSize();
            Init();
        }
        public void InitializeFontList()
        {
            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    comboBox1.Items.Add(fa.Name);
                }
            }
        }
        public void InitializeFontSize()
        {
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var size in sizes)
            {
                comboBox2.Items.Add(size.ToString());
            }
        }
        public void GetFontStyle()
        {
            fontStyle = FontStyle.Regular;
            if (isBold == true) fontStyle = fontStyle | FontStyle.Bold;
            if (isItalic == true) fontStyle = fontStyle | FontStyle.Italic;
            if (isUnderline == true) fontStyle = fontStyle | FontStyle.Underline;
        }

        public void GetAlignment()
        {
            if (isLeftAlign) textAlignment = HorizontalAlignment.Left;
            else if (isRightAlign) textAlignment = HorizontalAlignment.Right;
            else if (isCenterAlign) textAlignment = HorizontalAlignment.Center;
        }
        public void Change()
        {
            GetFontStyle();
            GetAlignment();
            if (comboBox1.SelectedItem == null)
            {
                comboBox1.SelectedItem = "Tahoma";
            }
            if (comboBox2.SelectedItem == null)
            {
                comboBox2.SelectedItem = "14";
            }
            try
            {
                richTextBox1.SelectionFont = new Font(comboBox1.SelectedItem.ToString(),
                float.Parse(comboBox2.SelectedItem.ToString()), fontStyle, GraphicsUnit.Pixel);
                richTextBox1.SelectionColor = textColor;
                richTextBox1.SelectionAlignment = textAlignment;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ColorDialog
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textColor = colorDialog.Color;
                button1.BackColor = colorDialog.Color;
            }
            Change();
        }
        // Bold
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (isBold == true)
            {
                isBold = false;
            }
            else isBold = true;
            Change();
        }
        // Italic
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (isItalic == true) isItalic = false;
            else isItalic = true;
            Change();
        }
        // Font
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change();
        }
        // FontSize
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change();
        }

        // Underline
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (isUnderline == true) isUnderline = false;
            else isUnderline = true;
            Change();
        }
        // Left
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isLeftAlign = true;
            isCenterAlign = false;
            isRightAlign = false;
            Change();
        }
        // Center
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isLeftAlign = false;
            isCenterAlign = true;
            isRightAlign = false;
            Change();
        }
        // Right
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            isLeftAlign = false;
            isCenterAlign = false;
            isRightAlign = true;
            Change();
        }
    }
}
