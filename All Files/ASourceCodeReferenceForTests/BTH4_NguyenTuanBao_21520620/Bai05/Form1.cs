using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab04_Bai05;
using System.Data.SqlClient;
namespace Lab04_Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public class SinhVien
        {
            protected int _Id;
            public int Id
            {
                get { return _Id; }
                set { _Id = value; }
            }
            protected string _MSSV;
            public string MSSV
            {
                get
                {
                    return _MSSV;
                }
                set
                {
                    _MSSV = value;
                }
            }

            protected string _HoTen;
            public string HoTen
            {
                get { return _HoTen; }
                set { _HoTen = value; }
            }

            protected string _Khoa;
            public string Khoa
            {
                get { return _Khoa; }
                set { _Khoa = value; }
            }

            protected float _DiemTB;
            public float DiemTB
            {
                get { return _DiemTB; }
                set { _DiemTB = value; }
            }

            public SinhVien()
            {

            }
            public SinhVien(int id, string mssv, string hoTen, string khoa, float diemTB)
            {
                this.Id = id;
                this.MSSV = mssv;
                this.HoTen = hoTen;
                this.Khoa = khoa;
                this.DiemTB = diemTB;
            }
        }

        public static List<SinhVien> dsSinhVien = new List<SinhVien>();
        public static int id = 1;
        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassData.IsSuccess = false;
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (PassData.IsSuccess == true)
            {
                SinhVien temp = new SinhVien(id++, PassData.MSSV, PassData.HoTen, PassData.Khoa, PassData.DiemTB);
                foreach (var sinhVien in dsSinhVien)
                {
                    if (sinhVien.MSSV == temp.MSSV)
                    {
                        MessageBox.Show("Đã có sinh viên sử dụng mssv này !!");
                        return;
                        break;
                    }
                }
                dsSinhVien.Add(temp);
                string[] arr = { id.ToString(), temp.MSSV, temp.HoTen, temp.Khoa, temp.DiemTB.ToString() };
                id++;
                dataGridView1.Rows.Add(arr);
                SaveToDatabase(ref temp);
            }
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PassData.IsSuccess = false;
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (PassData.IsSuccess == true)
            {
                SinhVien temp = new SinhVien(id++, PassData.MSSV, PassData.HoTen, PassData.Khoa, PassData.DiemTB);
                foreach (var sinhVien in dsSinhVien)
                {
                    if (sinhVien.MSSV == temp.MSSV)
                    {
                        MessageBox.Show("Đã có sinh viên sử dụng mssv này !!");
                        return;
                        break;
                    }
                }
                dsSinhVien.Add(temp);
                string[] arr = { id.ToString(), temp.MSSV, temp.HoTen, temp.Khoa, temp.DiemTB.ToString() };
                id++;
                dataGridView1.Rows.Add(arr);
                SaveToDatabase(ref temp);
            }
        }
        
        void Init()
        {
            dsSinhVien = new List<SinhVien>();
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tuanb\Downloads\C# Projects\BTH4_NguyenTuanBao_21520620\Bai05\SinhVien.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from SinhVien", cn);
            SqlDataReader dr = cmd.ExecuteReader();

            id = 1;

            while (dr.Read())
            {
                SinhVien temp = new SinhVien();
                temp.Id = id++;
                temp.MSSV = dr["MSSV"].ToString();
                temp.HoTen = dr["HoTen"].ToString();
                temp.Khoa = dr["Khoa"].ToString();
                temp.DiemTB = float.Parse(dr["DiemTB"].ToString());
                dsSinhVien.Add(temp);
            }
            dr.Close();

            for (int i = 0; i < dsSinhVien.Count; i++)
            {
                string[] arr = { dsSinhVien[i].Id.ToString(),
                    dsSinhVien[i].MSSV,
                    dsSinhVien[i].HoTen,
                    dsSinhVien[i].Khoa,
                    dsSinhVien[i].DiemTB.ToString() };
                dataGridView1.Rows.Add(arr);
            }
            cn.Close();
        }
        public void SaveToDatabase(ref SinhVien input)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tuanb\Downloads\C# Projects\BTH4_NguyenTuanBao_21520620\Bai05\SinhVien.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd =  new SqlCommand("insert into SinhVien" +
                    " values(@MSSV, @HoTen, @Khoa, @DiemTB)", cn);
            cmd.Parameters.AddWithValue("Mssv", input.MSSV);
            cmd.Parameters.AddWithValue("HoTen", input.HoTen);
            cmd.Parameters.AddWithValue("Khoa", input.Khoa);
            cmd.Parameters.AddWithValue("DiemTB", input.DiemTB);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Nhập thông tin thành công", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cn.Close();
        }
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string searchString = toolStripTextBox1.Text;
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tuanb\Downloads\C# Projects\BTH4_NguyenTuanBao_21520620\Bai05\SinhVien.mdf;Integrated Security=True");
            cn.Open();

            string query = "SELECT * FROM SinhVien WHERE HoTen like '%" + searchString + "%'";
            SqlCommand command = new SqlCommand(query, cn);
            SqlDataReader dr = command.ExecuteReader();
            id = 1;
            while (dr.Read())
            {
                SinhVien temp = new SinhVien();
                temp.Id = id++;
                temp.MSSV = dr["MSSV"].ToString();
                temp.HoTen = dr["HoTen"].ToString();
                temp.Khoa = dr["Khoa"].ToString();
                temp.DiemTB = float.Parse(dr["DiemTB"].ToString());
                string[] arr = { temp.Id.ToString(),
                    temp.MSSV,
                    temp.HoTen,
                    temp.Khoa,
                    temp.DiemTB.ToString() };
                dataGridView1.Rows.Add(arr);
            }
            dr.Close();
            cn.Close();
        }
    }
}
