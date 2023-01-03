// 472431@#3712
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiThuHanh_NguyenTuanBao_21520620
{


    public partial class DangNhap : Form
    {
        static string formPassword = "";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            if (userName == "admin" && formPassword == "admin")
            {
                
                QuanLyVeTau quanLyVeTau = new QuanLyVeTau();
                quanLyVeTau.ShowDialog();

            }
            else
            {
                MessageBox.Show("Username hoặc password sai, vui lòng nhập lại!", "Wrong Info");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string password = textBox2.Text.ToString();
            if (password[password.Length - 1] != '*')
            formPassword = formPassword + password[password.Length - 1];
            textBox2.Text = String.Concat(Enumerable.Repeat("*", textBox2.Text.Length));
            textBox2.SelectionStart = textBox2.Text.Length;
            
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
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
// 4621372137@