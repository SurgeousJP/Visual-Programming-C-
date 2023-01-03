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
using System.IO;
using System.Windows.Forms.VisualStyles;
namespace Lab04_Bai04
{
    public partial class Form1 : Form
    {
        public static string filePath = null;
        void InitFontComboBox()
        {
            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    toolStripComboBox1.Items.Add(fa.Name);
                }
            }
            toolStripComboBox1.SelectedItem = "Tahoma";
            
        }
        void InitFontSizeComboBox()
        {
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var size in sizes)
            {
                toolStripComboBox2.Items.Add(size.ToString());
            }
            toolStripComboBox2.SelectedItem = "14";
        }
        public Form1()
        {
            InitializeComponent();
            InitFontComboBox();
            InitFontSizeComboBox();
            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void tạoVănBảnMớiCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            filePath = null;
            toolStripComboBox1.SelectedItem = "Tahoma";
            toolStripComboBox2.SelectedItem = "14";
            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd  = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "TXT|*.txt|RTF|*.rtf";
            ofd.CheckPathExists = true;
            ofd.CheckFileExists = true;
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;
                    string extension = Path.GetExtension(filePath);
                    if (extension == ".txt") richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                    else richTextBox1.LoadFile(filePath, RichTextBoxStreamType.RichText);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lưuNộiDungVănBảnCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "rtf|*.rtf";

            if (string.IsNullOrEmpty(filePath))
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else
            {
                richTextBox1.SaveFile(filePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Đã lưu thành công file !");
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // Not finished yet !
        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // do nothing =))
            }
        }
        // New File
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            filePath = null;
            toolStripComboBox1.SelectedItem = "Tahoma";
            toolStripComboBox2.SelectedItem = "14";
            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }
        // Save File
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "rtf|*.rtf";
            sfd.CheckPathExists = true;
            sfd.CheckFileExists = true;

            if (string.IsNullOrEmpty(filePath))
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else
            {
                richTextBox1.SaveFile(filePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Đã lưu thành công file !");
            }
        }
        // Font
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == null) return;   
            if (toolStripComboBox2.SelectedItem != null)
            {
                richTextBox1.SelectionFont = new Font(
                    toolStripComboBox1.SelectedItem.ToString(),
                    int.Parse(toolStripComboBox2.SelectedItem.ToString()), fontStyle);
            }
            else
            {
                // Does not change yet so use default settings
                richTextBox1.SelectionFont = new Font(
                    toolStripComboBox1.SelectedItem.ToString(),
                    14, fontStyle);
            }

        }
        // FontSize
        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == null) return;
            richTextBox1.SelectionFont = new Font(
                toolStripComboBox1.SelectedItem.ToString(),
                int.Parse(toolStripComboBox2.SelectedItem.ToString()), fontStyle);
        }

        public static bool isBold, isItalic, isUnderline;
        public static FontStyle fontStyle = FontStyle.Regular;
        public static string selectedText;
        void SetFontStyle()
        {
            fontStyle = FontStyle.Regular;
            if (isBold) fontStyle = fontStyle | FontStyle.Bold;
            if (isItalic) fontStyle = fontStyle | FontStyle.Italic;
            if (isUnderline) fontStyle = fontStyle | FontStyle.Underline;
        }
        // Bold
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == null) return;
                  
            if (isBold == true) isBold = false;
            else isBold = true;
            SetFontStyle();
            richTextBox1.SelectionFont = new Font(
                toolStripComboBox1.SelectedItem.ToString(),
                int.Parse(toolStripComboBox2.SelectedItem.ToString()), fontStyle);

        }
        // Italic
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == null) return;

            if (isItalic == true) isItalic = false;
            else isItalic = true;
            SetFontStyle();
            richTextBox1.SelectionFont = new Font(
                toolStripComboBox1.SelectedItem.ToString(),
                int.Parse(toolStripComboBox2.SelectedItem.ToString()), fontStyle);
        }
        // Underline
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == null) return;

            if (isUnderline == true) isUnderline = false;
            else isUnderline = true;
            SetFontStyle();
            richTextBox1.SelectionFont = new Font(
                toolStripComboBox1.SelectedItem.ToString(),
                int.Parse(toolStripComboBox2.SelectedItem.ToString()), fontStyle);
        }
    }
}
