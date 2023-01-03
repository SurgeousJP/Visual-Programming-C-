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
using System.Data.SqlClient;
namespace Bai09
{
    public partial class AD : Form
    {
        public static string[] monHoc_KHMT =
            {"Nguyên lý và phương pháp lập trình",
             "Lập trình Python cho Máy học",
             "Trí tuệ nhân tạo"};

        public static string[] monHoc_KTPM =
            {"Máy học và các công cụ",
             "Quản lý dự án phát triển phần mềm",
             "Nhập môn phát triển game"};

        public static string[] monHoc_KHDL =
            {"Deep Learning trong Khoa học dữ liệu",
             "Tính toán song song và phân tán",
             "Đồ án Khoa học dữ liệu và ứng dụng"};

        public class ThongTinSinhVien
        {
            // mssv, hoten, chuyen nganh, gioi tinh // so mon
            protected string _Mssv;
            public string MSSV
            {
                get { return _Mssv; }
                set { _Mssv = value; }
            }

            protected string _HoTen;
            public string HoTen
            {
                get { return _HoTen; }
                set { _HoTen = value; }
            }

            protected string _ChuyenNganh;
            public string ChuyenNganh
            {
                get { return _ChuyenNganh; }
                set { _ChuyenNganh = value; }
            }

            protected string _GioiTinh; // Nam -> 1 / Nu -> 0
            public string GioiTinh
            {
                get { return _GioiTinh;}
                set { _GioiTinh = value; }
            }

            protected int _SoMon; 
            public int SoMon
            {
                get { return _SoMon;}
                set { _SoMon = value; }
            }
            // Default constructor
            public ThongTinSinhVien()
            {

            }
            // Parameter Constructor
            public ThongTinSinhVien(string mssv, string hoTen, string chuyenNganh, string gioiTinh, int soMon) 
            {
                this.MSSV = mssv;
                this.HoTen = hoTen;
                this.ChuyenNganh = chuyenNganh;
                this.GioiTinh = GioiTinh;
                this.SoMon = soMon;
            }
            
        }
        public AD()
        {
            InitializeComponent();
            Init();
        }
        // Event doi nganh -> doi list mon hoc
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            string[] items = new string[3];
            if (comboBox1.SelectedItem == "Khoa học máy tính")
            {
                Array.Copy(monHoc_KHMT, items, monHoc_KHMT.Length);
            }
            else if (comboBox1.SelectedItem == "Khoa học dữ liệu")
            {
                Array.Copy(monHoc_KHDL, items, monHoc_KHMT.Length);
            }
            else if (comboBox1.SelectedItem == "Kỹ thuật phần mềm")
            {
                Array.Copy(monHoc_KTPM, items, monHoc_KHMT.Length);
            }
            foreach (var item in items)
            {
                string[] arr = { item };
                listView1.Items.Add(new ListViewItem(arr));
            }
        }
        // Checkbox gioi tinh Nam
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
                if (checkBox1.Checked == true)
                {
                    checkBox1.Checked = false;
                } // Nam thi khong nu
            }
        }
        // Checkbox gioi tinh Nu
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
                if (checkBox2.Checked == true)
                {
                    checkBox2.Checked = false;
                }
            }// Nu thi khong nam
        }
        // Button >
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (var item in listView1.SelectedItems)
                {
                    listView1.Items.Remove((ListViewItem)item);
                    listView2.Items.Add((ListViewItem)item);
                }
            }
        }
        // Button <
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                foreach (var item in listView2.SelectedItems)
                {
                    listView2.Items.Remove((ListViewItem)item);
                    listView1.Items.Add((ListViewItem)item);
                }
            }
        }
        
        public static List<ThongTinSinhVien> dsThongTinSinhVien = new List<ThongTinSinhVien>();
        void Init()
        {
            dsThongTinSinhVien = new List<ThongTinSinhVien>();
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tuanb\Downloads\C# Projects\Bai09\Database.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from ThongTinSinhVien", cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ThongTinSinhVien temp = new ThongTinSinhVien();
                temp.MSSV = dr["MSSV"].ToString();
                temp.HoTen = dr["HoTen"].ToString();
                temp.ChuyenNganh = dr["ChuyenNganh"].ToString();
                temp.GioiTinh = dr["GioiTinh"].ToString();
                temp.SoMon = int.Parse(dr["SoMon"].ToString());
                dsThongTinSinhVien.Add(temp);
            }
            dr.Close();

            for (int i = 0; i < dsThongTinSinhVien.Count; i++)
            {
                string[] arr = { dsThongTinSinhVien[i].MSSV,
                    dsThongTinSinhVien[i].HoTen,
                    dsThongTinSinhVien[i].ChuyenNganh,
                    dsThongTinSinhVien[i].GioiTinh,
                    dsThongTinSinhVien[i].SoMon.ToString() };
                dataGridView1.Rows.Add(arr);
            }
        }
        public void SaveToDatabase(ref ThongTinSinhVien input)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tuanb\Downloads\C# Projects\Bai09\Database.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from ThongTinSinhVien where MSSV='" + input.MSSV + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                cmd = new SqlCommand("Update ThongTinSinhVien Set HoTen = @HoTen Where MSSV = @Mssv", cn);
                cmd.Parameters.AddWithValue("HoTen", input.HoTen);
                cmd.Parameters.AddWithValue("Mssv", input.MSSV);

                cmd = new SqlCommand("Update ThongTinSinhVien Set ChuyenNganh = @ChuyenNganh Where MSSV = @Mssv", cn);
                cmd.Parameters.AddWithValue("ChuyenNganh", input.ChuyenNganh);
                cmd.Parameters.AddWithValue("Mssv", input.MSSV);

                cmd = new SqlCommand("Update ThongTinSinhVien Set GioiTinh = @GioiTinh Where MSSV = @Mssv", cn);
                cmd.Parameters.AddWithValue("GioiTinh", input.GioiTinh);
                cmd.Parameters.AddWithValue("Mssv", input.MSSV);

                cmd = new SqlCommand("Update ThongTinSinhVien Set SoMon = @soMon Where MSSV = @Mssv", cn);
                cmd.Parameters.AddWithValue("soMon", input.SoMon);
                cmd.Parameters.AddWithValue("Mssv", input.MSSV);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin lên database thành công", "Cập nhật", MessageBoxButtons.OK);
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into ThongTinSinhVien" +
                    " values(@Mssv, @HoTen, @ChuyenNganh, @GioiTinh, @SoMon)", cn);
                cmd.Parameters.AddWithValue("Mssv", input.MSSV);
                cmd.Parameters.AddWithValue("HoTen", input.HoTen);
                cmd.Parameters.AddWithValue("ChuyenNganh", input.ChuyenNganh);
                cmd.Parameters.AddWithValue("GioiTinh", input.GioiTinh);
                cmd.Parameters.AddWithValue("SoMon", input.SoMon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập thông tin thành công", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Button luu thong tin
        private void button3_Click(object sender, EventArgs e)
        {
            ThongTinSinhVien temp = new ThongTinSinhVien();

            string temp_MSSV = textBox1.Text;
            if (!Regex.IsMatch(temp_MSSV, @"^[0-9 ]+$"))
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ, vui lòng nhập lại !!!");
                return;
            }
            string temp_HoTen = textBox2.Text;
            string temp_ChuyenNganh = comboBox1.SelectedItem.ToString();
            string temp_GioiTinh = null;
            if (checkBox1.Checked) temp_GioiTinh = "Nam";
            else if (checkBox2.Checked) temp_GioiTinh = "Nữ";
            int temp_SoMonHoc = listView2.Items.Count;
            
            if (!String.IsNullOrEmpty(temp_MSSV) && !String.IsNullOrEmpty(temp_HoTen)
                && !String.IsNullOrEmpty(temp_ChuyenNganh) && !String.IsNullOrEmpty(temp_GioiTinh)
                && temp_SoMonHoc > 0)
            {
                temp.MSSV = temp_MSSV;
                temp.HoTen = temp_HoTen;
                temp.ChuyenNganh = temp_ChuyenNganh;
                temp.GioiTinh = temp_GioiTinh;
                temp.SoMon = temp_SoMonHoc;
                dsThongTinSinhVien.Add(temp);
                string[] arr = { temp_MSSV, temp_HoTen, temp_ChuyenNganh, temp_GioiTinh, temp_SoMonHoc.ToString() };
                
                // Finding if there's already that information in database, if yes then update data 
                bool isFound = false;
                if (dataGridView1.Rows.Count > 1) 
                {
                    // MessageBox.Show(dataGridView1.Rows.Count.ToString());
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        // MessageBox.Show(i.ToString());
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == temp_MSSV)
                        {
                            dataGridView1.Rows[i].Cells[1].Value = temp_HoTen;
                            dataGridView1.Rows[i].Cells[2].Value = temp_ChuyenNganh;
                            dataGridView1.Rows[i].Cells[3].Value = temp_GioiTinh;
                            dataGridView1.Rows[i].Cells[4].Value = temp_SoMonHoc;
                            MessageBox.Show("Cập nhật thông tin thành công");
                            isFound = true;
                            break;
                        }
                    }
                }
                
                if (!isFound)
                {
                    dataGridView1.Rows.Add(arr);
                    MessageBox.Show("Nhập thông tin thành công");
                }
                SaveToDatabase(ref temp);

            }
            else
            {
                MessageBox.Show("Chưa đủ thông tin hoặc chưa đk môn nào, vui lòng nhập lại");
            }
        }
        
        // Button xoa chon
        private void button4_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
        }
        // Button reset
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.ResetText();
            comboBox1.SelectedIndex = -1;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            listView1.Items.Clear();
            listView2.Items.Clear();
            // dataGridView1.Rows.Clear();
        }
        // Closing Form event
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn muốn tắt form ? (Yes/No)", "Cảnh báo", MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;
        }

        private void AD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinhVienDataSet.ThongTinSinhVien' table. You can move, or remove it, as needed.
            this.thongTinSinhVienTableAdapter.Fill(this.sinhVienDataSet.ThongTinSinhVien);

        }
        // Event click row trong datagridview
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    if (row.Cells[2].Value.ToString() == "Khoa học máy tính")
                    {
                        comboBox1.SelectedItem = comboBox1.Items[2].ToString();
                    }
                    else if (row.Cells[2].Value.ToString() == "Khoa học dữ liệu")
                    {
                        comboBox1.SelectedItem = comboBox1.Items[1].ToString();
                    }
                    else if (row.Cells[2].Value.ToString() == "Kỹ thuật phần mềm")
                    {
                        comboBox1.SelectedItem = comboBox1.Items[0].ToString();
                    }
                    if (row.Cells[3].Value.ToString() == "Nam")
                    {
                        checkBox1.Checked = true;
                        checkBox2.Checked = false;
                    }
                    else
                    {
                        checkBox1.Checked = false;
                        checkBox2.Checked = true;
                    }
                }
            }
            catch
            {
                // Do nothing 
            }
            
        }
    }
}
