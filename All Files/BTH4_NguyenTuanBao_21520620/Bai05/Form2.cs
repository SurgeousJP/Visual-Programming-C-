using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Lab04_Bai05;
namespace Lab04_Bai05
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Thêm mới
        private void button1_Click(object sender, EventArgs e)
        {
            string mssv = textBox1.Text;
            if (!Regex.IsMatch(mssv, @"^[0-9 ]+$"))
            {
                MessageBox.Show("Mã số sinh viên chỉ được phép gồm toàn số !");
                return;
            }
            string hoTen = textBox2.Text;
            string charVietnamese = "aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ";
            string spaceChar = " ";
            for (int i = 0; i < hoTen.Length; i++)
            {
                if (charVietnamese.Contains(hoTen[i].ToString()) == false
                    && hoTen[i] != '-'
                    && hoTen[i] != '.'
                    && hoTen[i] != '\''
                    && hoTen[i] != ' ')
                {
                    MessageBox.Show(hoTen[i] + "Tên không hợp lệ !");
                    return;
                }
            }

            //string khoa = comboBox1.SelectedItem.ToString();
            string khoa = comboBox1.SelectedItem.ToString();

            float diemTB;
            if (!float.TryParse(textBox3.Text, out diemTB))
            {
                MessageBox.Show("Điểm trung bình sinh viên không hợp lệ, vui lòng nhập lại !");
                return;
            }
            PassData.MSSV = mssv;
            PassData.HoTen = hoTen;
            PassData.DiemTB = diemTB;
            PassData.Khoa = khoa;
            PassData.IsSuccess = true;

            this.Close();
        }
        // Thoát
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
