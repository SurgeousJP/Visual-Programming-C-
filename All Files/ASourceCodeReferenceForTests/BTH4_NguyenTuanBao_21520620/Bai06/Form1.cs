using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace Lab04_Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string orgFilePath, descFilePath;
        static bool CopyFolder = false;
        // Ham lay duong dan goc
        // Copy file hoac folder
        // Neu truy dan de quy -> +0.5
        private void button1_Click(object sender, EventArgs e)
        {
            var choosingOption = MessageBox.Show("Hãy chọn copy file (Yes) / folder (No) / Không copy (Cancel)", "Copy", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (choosingOption.Equals(DialogResult.Yes))
            {
                CopyFolder = false;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                try
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK) orgFilePath = openFileDialog.FileName;
                    textBox1.Text = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Chọn file không thành công, vui lòng thử lại !!!");
                }
            }
            else if (choosingOption.Equals(DialogResult.No))
            {
                CopyFolder = true;
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                try
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        orgFilePath = folderBrowserDialog.SelectedPath;
                        textBox1.Text = folderBrowserDialog.SelectedPath;
                    }
                }
                catch
                {
                    MessageBox.Show("Chọn thư mục không thành công, vui lòng thử lại !!!");
                }
            }
        }
        // Ham lay duong dan dich
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            try
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    descFilePath = folderBrowserDialog.SelectedPath;
                    textBox2.Text = descFilePath;
                }
            }
            catch
            {
                MessageBox.Show("Chọn thư mục không thành công, vui lòng thử lại !!!");
            }
        }
        public void CopyFolderFunction(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                Thread waiting = new Thread((ThreadStart)(() => {
                    groupBox3.Text = "Đang copy file: " + dest + '\\' + name;
                }));
                waiting.Start();
                waiting.Join();
                // MessageBox.Show(groupBox3.Text);
                File.Copy(file, dest, true);
                progressBar1.PerformStep();
                Thread.Sleep(1000);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                groupBox3.Text = "Đang copy file: " + dest + '\\' + name;
                Thread waiting = new Thread((ThreadStart)(() => {
                    groupBox3.Text = "Đang copy file: " + dest + '\\' + name;
                }));
                waiting.Start();
                waiting.Join();
                // MessageBox.Show(groupBox3.Text);
                CopyFolderFunction(folder, dest);
                progressBar1.PerformStep();
                Thread.Sleep(1000);
            }
        }
        // Button sao chep
        private void button3_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(descFilePath))
            {
                MessageBox.Show("Đường dẫn thư mục không hợp lệ, lỗi !!!");
            }
            if (CopyFolder == true)
            {
                string[] files = Directory.GetFiles(orgFilePath);
                string[] folders = Directory.GetDirectories(orgFilePath);

                progressBar1.Minimum = 0;
                progressBar1.Maximum = files.Length + folders.Length;
                progressBar1.Value = 0;
                progressBar1.Step = 1;

                CopyFolderFunction(orgFilePath, descFilePath);
                Thread.Sleep(1000);
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    // System.Threading.Thread.Sleep(3000);
                    groupBox3.Text = "Quá trình copy hoàn tất !";
                    // progressBar1.Value = progressBar1.Minimum;
                }
            }
            else
            {
                string fileName = Path.GetFileName(orgFilePath);
                progressBar1.Minimum = 0;
                progressBar1.Value = 1;
                progressBar1.Step = 1;
                progressBar1.Maximum = 1;
                groupBox3.Text = "Đang copy file: " + descFilePath + '\\' + fileName;
                File.Copy(orgFilePath, descFilePath + '\\' + fileName, true);
                Thread.Sleep(1000);

                if (progressBar1.Value == progressBar1.Maximum)
                {
                    groupBox3.Text = "Quá trình copy hoàn tất !";
                    // progressBar1.Value = 0;
                }
            }
        }
    }
}
