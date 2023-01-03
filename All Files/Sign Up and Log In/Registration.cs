using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Sign_Up_and_Log_In
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tuanb\Downloads\C# Projects\Sign Up and Log In\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tuanb\Downloads\C# Projects\Sign Up and Log In\Database.mdf;Integrated Security=True");
            cn.Open();

            if (txtaddress.Text != string.Empty & txtbirthday.Text != string.Empty & txtemail.Text != string.Empty
                & txtname.Text != string.Empty & txtpassword.Text != string.Empty & txtphonenum.Text != string.Empty
                & txtsex.Text != string.Empty & txtusername.Text != string.Empty)
            {
                // Table is sql keyword so don't use it as a name for sql table
                SqlCommand cmd = new SqlCommand("select * from LoginTable where Username='" + txtusername.Text + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Tên đăng nhập này đã tồn tại, hãy thử lại !", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into LoginTable values(@Username, @Password, @Name, @Sex, @Birthday, @PhoneNum, @Email, @Address)", cn);
                    cmd.Parameters.AddWithValue("Username", txtusername.Text);
                    cmd.Parameters.AddWithValue("Password", txtpassword.Text);
                    cmd.Parameters.AddWithValue("Name", txtname.Text);
                    cmd.Parameters.AddWithValue("Sex", txtsex.Text);
                    cmd.Parameters.AddWithValue("Birthday", DateTime.Parse(txtbirthday.Text));
                    cmd.Parameters.AddWithValue("PhoneNum", txtphonenum.Text);
                    cmd.Parameters.AddWithValue("Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("Address", txtaddress.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tài khoản đã được tạo, xin mời đăng nhập", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
