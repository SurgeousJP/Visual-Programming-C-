using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public class TaiKhoanNganHang
        {
            public TaiKhoanNganHang()
            {

            }
            public TaiKhoanNganHang(int soTT, string soTK, string tenKH, string diaChi, float soTien)
            {
                this.SoTT = soTT;
                this.SoTK = soTK;
                this.TenKH = tenKH;
                this.DiaChi = diaChi;
                this.SoTien = soTien;
            }

            protected int _soTT;
            public int SoTT
            {
                get { return _soTT; }
                set { _soTT = value; }
            }
            protected string _soTK;
            public string SoTK
            {
                get
                { return _soTK; }
                set
                { _soTK = value; }
            }
            protected string _tenKH;
            public string TenKH
            {
                get { return _tenKH; }
                set { _tenKH = value; }
            }
            protected string _diaChi;
            public string DiaChi
            {
                get { return _diaChi; }
                set { _diaChi = value; }
            }

            protected float _soTien;
            public float SoTien
            {
                get { return _soTien; }
                set { _soTien = value; }
            }
        }
        public static List<TaiKhoanNganHang> DSTaiKhoan = new List<TaiKhoanNganHang>();
        public static int idx = 1;
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        public void ResetIndex()
        {
            for (int i = 0; i < DSTaiKhoan.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }
        // Them / cap nhat
        private void button1_Click(object sender, EventArgs e)
        {
            string temp_SoTK, temp_TenKH, temp_DiaChi;
            float temp_SoTien;
            bool parseSuccessful;
            
            temp_SoTK = textBox1.Text;
            temp_TenKH = textBox2.Text;
            temp_DiaChi = textBox3.Text;
            parseSuccessful = float.TryParse(textBox4.Text, out temp_SoTien);

            if (!parseSuccessful && temp_SoTien < 0)
            {
                MessageBox.Show("Số tiền không hợp lệ");
                return;
            }

            if (!String.IsNullOrEmpty(temp_SoTK) && !String.IsNullOrEmpty(temp_TenKH)
                && !String.IsNullOrEmpty(temp_DiaChi) && temp_SoTien >= 0)
            {
                for (int i = 0; i < DSTaiKhoan.Count; i++)
                {
                    if (temp_SoTK == DSTaiKhoan[i].SoTK)
                    {
                        DSTaiKhoan[i].SoTien += float.Parse(textBox4.Text);
                        listView1.Items[i].SubItems[4].Text = DSTaiKhoan[i].SoTien.ToString();
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        Clear();
                        return;
                    }
                }
                DSTaiKhoan.Add(new TaiKhoanNganHang(DSTaiKhoan.Count, temp_SoTK, temp_TenKH, temp_DiaChi, temp_SoTien));
                string[] arr = { (DSTaiKhoan.Count).ToString(), temp_SoTK, temp_TenKH, temp_DiaChi, temp_SoTien.ToString() };
                listView1.Items.Add(new ListViewItem(arr));
                MessageBox.Show("Thêm mới dữ liệu thành công!");
                Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }
        // Xoa
        private void button2_Click(object sender, EventArgs e)
        {
            string temp_SoTK = textBox1.Text;
            bool isFound = false;
            for (int i = 0; i < DSTaiKhoan.Count; i++)
            {
                if (temp_SoTK == DSTaiKhoan[i].SoTK)
                {
                    isFound = true;
                    var result = MessageBox.Show("Warning", "YES/NO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        listView1.Items.RemoveAt(i);
                        DSTaiKhoan.RemoveAt(i);
                        MessageBox.Show("Xóa tài khoản thành công");
                        Clear();
                        ResetIndex();
                        return;
                    }
                    else return;
                }
            }
            if (!isFound) MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
        }
        // Reset
        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
            listView1.Items.Clear();
            DSTaiKhoan = new List<TaiKhoanNganHang>();
        }
        // Thoat
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Lay thong tin khi click vo 
        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
        }
        // Confirm Exit
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Canh bao", "Ban muon tat form (Yes/No)", MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;
        }
    }
}
