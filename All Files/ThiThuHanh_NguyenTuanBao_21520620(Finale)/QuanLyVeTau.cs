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


namespace ThiThuHanh_NguyenTuanBao_21520620
{
    public partial class QuanLyVeTau : Form
    {
        public QuanLyVeTau()
        {
            InitializeComponent();
        }

        public class NguoiMuaVe
        {
            protected string _hoTen;
            public string HoTen
            {
                get
                {
                    return _hoTen;
                }
                set
                {
                    _hoTen = value;
                }
            }

            protected string _CCCD;
            public string CCCD
            {
                get
                {
                    return _CCCD;
                }
                set
                {
                    _CCCD = value;
                }
            }

            protected DateTime _NgSinh;
            public DateTime NgSinh
            {
                get { return _NgSinh; }
                set { _NgSinh = value; }
            }

            protected bool _GioiTinh; // true - Nam / false - Nu 
            public bool GioiTinh
            {
                get { return _GioiTinh; }
                set { _GioiTinh = value; }
            }

            protected string _DiaChi;
            public string DiaChi
            {
                get { return _DiaChi; }
                set { _DiaChi = value; }
            }

            protected int _MaVe; // Mac dinh Ma ve la 6 chu so
            public int MaVe
            {
                get { return _MaVe; }
                set { _MaVe = value; }
            }

            protected string _GaDen;
            public string GaDen
            {
                get { return _GaDen; }
                set
                {
                    _GaDen = value;
                }   
            }
            protected string _GaDi;
            public string GaDi
            {
                get { return _GaDi; }
                set
                {
                    _GaDi = value;
                }
            }
            protected int _SoGhe;
            public int SoGhe
            {
                get { return _SoGhe; }
                set { _SoGhe = value; }
            }
            protected float _GiaVe;
            public float GiaVe
            {
                get { return _GiaVe; }
                set { _GiaVe = value; }
            }

            public NguoiMuaVe()
            {

            }
        }
        public static List<NguoiMuaVe> dsMuaVe = new List<NguoiMuaVe>();
        public static int indexCount = 0;
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public bool CheckValidValueInInput()
        {
            if (textBox1.Text == "") return false;
            if (textBox2.Text == "") return false;
            if (textBox5.Text == "") return false;
            if (dateTimePicker1.Value == DateTime.Now) return false;
            if (Nam.Checked == false && Nu.Checked == false) return false;
            if (comboBox2.SelectedItem == null) return false;
            if (comboBox3.SelectedItem == null) return false;
            if (comboBox4.SelectedItem == null) return false;
            return true;
        }
        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            Nam.Checked = false;
            Nu.Checked = false;
            comboBox2.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        public void ResetIndex()
        {
            for (int i = 0; i < dsMuaVe.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (CheckValidValueInInput() == false)
            {
                MessageBox.Show("Chưa điền đủ thông tin, vui lòng nhập đủ thông tin và thử lại !!");
            }

            NguoiMuaVe temp = new NguoiMuaVe();

            textBox3.Clear();
            Random rnd = new Random();
            temp.MaVe = rnd.Next(100000, 999999);
            textBox3.Text = temp.MaVe.ToString();

            var result = MessageBox.Show("Bạn có chắc muốn tạo vé với mã vé " + textBox3.Text, "Tạo vé", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            string hoTen = textBox1.Text;
            string charVietnamese = "aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ";
            
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
            temp.HoTen = hoTen;

            string CCCD = textBox2.Text;
            if (!Regex.IsMatch(CCCD, @"^[0-9 ]+$") && CCCD.Length != 12)
            {
                MessageBox.Show("Căn cước công dân chỉ được phép gồm toàn số !");
                return;
            }
            temp.CCCD = CCCD;

            temp.NgSinh = dateTimePicker1.Value;

            if (Nam.Checked == true)
            {
                temp.GioiTinh = true;
            }
            else
            {
                temp.GioiTinh = false;
            }
            temp.DiaChi = textBox5.Text;
            temp.GaDi = comboBox2.SelectedItem.ToString();
            temp.GaDen = comboBox3.SelectedItem.ToString();
            temp.SoGhe = int.Parse(comboBox4.SelectedItem.ToString());
            float giaVe = 0;
            if (temp.GaDi == "Hồ Chí Minh")
            {
                giaVe = 300000 * temp.SoGhe;
            }
            else if (temp.GaDi == "Biên Hòa")
            {
                giaVe = 250000 * temp.SoGhe;
            }
            price.Text = giaVe.ToString();
            temp.GiaVe = giaVe;
            dsMuaVe.Add(temp);
        }

        private void CapNhat_Click(object sender, EventArgs e)
        {
            int updateMaVe;
            if (listView1.SelectedItems.Count > 0) updateMaVe = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
            else if (textBox3.Text != "")
            {
                if (textBox3.Text.Length != 6 || !Regex.IsMatch(textBox3.Text, @"^[0-9 ]+$"))
                {
                    MessageBox.Show("Mã vé không hợp lệ !!!");
                    return;
                }
                else updateMaVe = int.Parse(textBox3.Text.ToString());
            }
            else
            {
                return;
            }

            if (CheckValidValueInInput() == false)
            {
                MessageBox.Show("Chưa điền đủ thông tin, vui lòng nhập đủ thông tin và thử lại !!");
            }

            bool isFound = false;
            for (int i = 0; i < dsMuaVe.Count; i++)
            {
                if (updateMaVe == dsMuaVe[i].MaVe)
                {
                    isFound = true;
                    var result = MessageBox.Show("Warning", "YES/NO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        listView1.Items.RemoveAt(i);
                        dsMuaVe[i].HoTen = textBox1.Text;
                        dsMuaVe[i].CCCD = textBox2.Text;
                        dsMuaVe[i].NgSinh = dateTimePicker1.Value;
                        dsMuaVe[i].GioiTinh = Nam.Checked == true ? true : false;
                        dsMuaVe[i].DiaChi = textBox5.Text;
                        dsMuaVe[i].GaDi = comboBox2.SelectedItem.ToString();
                        dsMuaVe[i].GaDen = comboBox3.SelectedItem.ToString();
                        dsMuaVe[i].SoGhe = int.Parse(comboBox4.SelectedItem.ToString());
                        dsMuaVe[i].GiaVe = dsMuaVe[i].GaDi == "Hồ Chí Minh" ? 300000 * dsMuaVe[i].SoGhe
                            : 250000 * dsMuaVe[i].SoGhe;
                        Clear();
                        ResetIndex();
                        DisplayInformation(dsMuaVe[i]);
                        string[] arr = { indexCount.ToString(), dsMuaVe[i].MaVe.ToString(),
                            dsMuaVe[i].GaDi, dsMuaVe[i].GaDen };
                        listView1.Items.Add(new ListViewItem(arr));
                        MessageBox.Show("Cập nhật vé thành công");
                        
                        return;
                    }
                    else return;
                }
            }
            if (!isFound) MessageBox.Show("Không tìm thấy mã vé cần cập nhật");
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            int deleteMaVe;
            if (listView1.SelectedItems.Count > 0) deleteMaVe = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
            else if (textBox3.Text != "")
            {
                if (textBox3.Text.Length != 6 || !Regex.IsMatch(textBox3.Text, @"^[0-9 ]+$"))
                {
                    MessageBox.Show("Mã vé không hợp lệ !!!");
                    return;
                }
                else deleteMaVe = int.Parse(textBox3.Text.ToString());
            }
            else
            {
                return;
            }

            bool isFound = false;
            for (int i = 0; i < dsMuaVe.Count; i++)
            {
                if (deleteMaVe == dsMuaVe[i].MaVe)
                {
                    isFound = true;
                    var result = MessageBox.Show("Warning", "YES/NO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        listView1.Items.RemoveAt(i);
                        dsMuaVe.RemoveAt(i);
                        MessageBox.Show("Xóa vé thành công");
                        Clear();
                        ResetIndex();
                        return;
                    }
                    else return;
                }
            }
            if (!isFound) MessageBox.Show("Không tìm thấy mã vé cần xóa");
        }
        public void DisplayInformation(NguoiMuaVe input)
        {
            textBox1.Text = input.HoTen;
            textBox2.Text = input.CCCD;
            dateTimePicker1.Value = input.NgSinh;
            if (input.GioiTinh == true)
            {
                Nam.Checked = true;

            }
            else
            {
                Nu.Checked = true;
            }
            textBox5.Text = input.DiaChi;
            comboBox2.SelectedItem = input.GaDi;
            comboBox3.SelectedItem = input.GaDen;
            comboBox4.SelectedItem = input.SoGhe.ToString();
            price.Text = input.GiaVe.ToString();
        }
        private void Xem_Click(object sender, EventArgs e)
        {
            string searchMaVe = textBox3.Text;
            if (searchMaVe.Length != 6 || !Regex.IsMatch(searchMaVe, @"^[0-9 ]+$"))
            {
                MessageBox.Show("Mã vé không hợp lệ !!!");
            }
            else
            {
                foreach (var tickets in dsMuaVe)
                {
                    if (tickets.MaVe == int.Parse(searchMaVe))
                    {
                        DisplayInformation(tickets);
                        string []arr = { indexCount.ToString() , tickets.MaVe.ToString(),tickets.GaDi, tickets.GaDen };
                        listView1.Items.Add(new ListViewItem(arr));
                        return;
                    }
                }
            }
        }

        private void QuanLyVeTau_FormClosing(object sender, FormClosingEventArgs e)
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

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string searchMaVe = listView1.SelectedItems[0].SubItems[1].Text;
                if (searchMaVe.Length != 6 || !Regex.IsMatch(searchMaVe, @"^[0-9 ]+$"))
                {
                    MessageBox.Show("Mã vé không hợp lệ !!!");
                }
                else
                {
                    foreach (var tickets in dsMuaVe)
                    {
                        if (tickets.MaVe == int.Parse(searchMaVe))
                        {
                            DisplayInformation(tickets);
                            return;
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }
    }
}
