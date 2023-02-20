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
namespace TryDeleteFiles
{
    public partial class Form1 : Form
    {
        static string path = @"C:\Users\tuanb\Downloads\TestPicture";
        public Form1()
        {
            InitializeComponent();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            string[] allFiles = Directory.GetFiles(path);
            foreach (string file in allFiles)
            {
                if (file.EndsWith(".jpg"))
                {
                    try
                    {
                        System.IO.File.Delete(file);
                        MessageBox.Show("Successfully Deleted " + file);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}

