﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diacritics;
using Diacritics.Extensions;
using System.Text;
namespace TestRemoveVietnameseAccentsOnForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string output = Diacritics.Extensions.StringExtensions.RemoveDiacritics(input);
            textBox2.Text = output;
        }
    }
}
