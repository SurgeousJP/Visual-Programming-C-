using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Lab04_Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToString("D", new CultureInfo("en-US")) + " " + DateTime.Now.ToString("T", new CultureInfo("vi-VN"))
                + " " + DateTime.Now.ToString("tt", CultureInfo.InvariantCulture); ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("D", new CultureInfo("en-US")) + " " + DateTime.Now.ToString("T", new CultureInfo("vi-VN"))
                + " " + DateTime.Now.ToString("tt", CultureInfo.InvariantCulture); ;
        }
    }
}
