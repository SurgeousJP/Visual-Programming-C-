using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace SqlLiteDemoTest
{
    public partial class Form1 : Form
    {
        static SQLiteConnection conn = new SQLiteConnection("Data Source=test.db");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                conn.Open();
                //InsertData(conn, "S100", "Ngo Gia Khai", 22);
                //InsertData(conn, "S101", "Le Tuan Anh", 32);
                //InsertData(conn, "S104", "Nguyen Hai Long", 26);
                //ShowData(conn);

            string sqlCreateTable = "CREATE TABLE IF NOT EXISTS Staffs(" +
                "StaffId VARCHAR(20) PRIMARY KEY," +
                "FullName VARCHAR(50)," +
                "Age INT DEFAULT 0" +
                ")";

            var sqlCommand = new SQLiteCommand(sqlCreateTable, conn);
            int result = sqlCommand.ExecuteNonQuery();
            MessageBox.Show(result.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sql = "INSERT INTO Staffs(StaffId, FullName, Age) " +
                "VALUES(@staffId, @fullName, @age)";

            var cmd = new SQLiteCommand(sql, conn);

            cmd.Parameters.AddWithValue("@staffId", "100");
            cmd.Parameters.AddWithValue("@fullName", "Ngo Gia Khai");
            cmd.Parameters.AddWithValue("@age", "32");

            int result = cmd.ExecuteNonQuery();
            MessageBox.Show(result.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();

            textBox1.Text = "";
            string result = "";
            var id = "StaffId";
            var fullName = "FullName";
            var age = "Age";

            Console.WriteLine($"{id,-20:s}{fullName,-35:s}{age,-10:d}");
            var sql = "SELECT * FROM Staffs";
            var cmd = new SQLiteCommand(sql, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                    result += "";
                }
                else result += reader.GetValue(0).ToString();

                if (reader.IsDBNull(1))
                {
                    result += "";
                }
                else result += reader.GetValue(1).ToString();

                if (reader.IsDBNull(2))
                {
                    result += "";
                }
                else result += reader.GetValue(2).ToString();


            }
            textBox1.Text = result;
        }
    }
}
