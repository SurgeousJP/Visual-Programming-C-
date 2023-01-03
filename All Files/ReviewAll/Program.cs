using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.IO;
using System;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace Random
{
    internal class Program
    {
        private static ContextMenuStrip contextMenustrip = new ContextMenuStrip();
        private static MenuStrip menuStrip = new MenuStrip();
        private static ToolStripMenuItem fileTab = new ToolStripMenuItem();
        private static ToolStripMenuItem editTab = new ToolStripMenuItem();
        private static ToolStripMenuItem New = new ToolStripMenuItem();
        private static ToolStripMenuItem Load = new ToolStripMenuItem();
        private static ListBox listDSSV = new ListBox();
        private static Label labelDSSV = new Label();
        private static Label labelMSSV = new Label();
        private static Label labelhoTen = new Label();
        private static Label labelKhoa = new Label();
        private static Label labelCMND = new Label();
        private static Label labelngaySinh = new Label();
        private static Label labeldiaChi = new Label();
        private static Label labelEmail = new Label();
        private static Label labelAnh = new Label();
        private static Button buttonOK = new Button();
        private static Button buttonCancel = new Button();
        private static TextBox textBoxMSSV = new TextBox();
        private static TextBox textBoxhoTen = new TextBox();
        private static TextBox textBoxCMND = new TextBox();
        private static TextBox textBoxAddress = new TextBox();
        private static TextBox textBoxEmail = new TextBox();
        private static ComboBox comboBoxKhoa = new ComboBox();
        private static DateTimePicker dateTimePickerNgaysinh = new DateTimePicker();
        private static PictureBox profile = new PictureBox();
        public static Form quanLySvForm = new Form();
        public Image profileimg;
        public static void AddKhoaComboBox()
        {
            for (int i = 1995; i <= 2020; i++)
            {
                comboBoxKhoa.Items.Add(i);
            }
        }
        [STAThread]
        static void Main(string[] args)
        {
            contextMenustrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenustrip.Size = new System.Drawing.Size(61, 4);

            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileTab, editTab});
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip1";
            menuStrip.Size = new System.Drawing.Size(1106, 28);
            fileTab.Size = new System.Drawing.Size(46, 24);
            fileTab.Text = "File";
            fileTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            New,
            Load});

            editTab.Size = new System.Drawing.Size(49, 24);
            editTab.Text = "Edit";
            quanLySvForm.Controls.Add(menuStrip);

            listDSSV.FormattingEnabled = true;
            listDSSV.ItemHeight = 16;
            listDSSV.Location = new System.Drawing.Point(12, 70);
            listDSSV.Size = new System.Drawing.Size(254, 484);
            listDSSV.SelectedIndexChanged += new EventHandler(ClicksinhVien);
            quanLySvForm.Controls.Add(listDSSV);

            labelDSSV.AutoSize = true;
            labelDSSV.Location = new System.Drawing.Point(13, 48);
            labelDSSV.Size = new System.Drawing.Size(85, 16);
            labelDSSV.TabIndex = 3;
            labelDSSV.Text = "DS Sinh Viên";
            quanLySvForm.Controls.Add(labelDSSV);

            labelAnh.AutoSize = true;
            labelAnh.Location = new System.Drawing.Point(292, 48);
            labelAnh.Size = new System.Drawing.Size(30, 16);
            labelAnh.Text = "Ảnh";
            quanLySvForm.Controls.Add(labelAnh);

            profile.Location = new System.Drawing.Point(295, 70);
            profile.Size = new System.Drawing.Size(207, 182);
            profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            quanLySvForm.Controls.Add(profile);

            labelMSSV.AutoSize = true;
            labelMSSV.Location = new System.Drawing.Point(521, 48);
            labelMSSV.Size = new System.Drawing.Size(45, 16);
            labelMSSV.Text = "MSSV";
            quanLySvForm.Controls.Add(labelMSSV);

            labelhoTen.AutoSize = true;
            labelhoTen.Location = new System.Drawing.Point(740, 48);
            labelhoTen.Size = new System.Drawing.Size(52, 16);
            labelhoTen.Text = "Họ Tên";
            quanLySvForm.Controls.Add(labelhoTen);

            labelKhoa.AutoSize = true;
            labelKhoa.Location = new System.Drawing.Point(521, 122);
            labelKhoa.Size = new System.Drawing.Size(38, 16);
            labelKhoa.Text = "Khóa";
            quanLySvForm.Controls.Add(labelKhoa);

            labelCMND.AutoSize = true;
            labelCMND.Location = new System.Drawing.Point(740, 122);
            labelCMND.Size = new System.Drawing.Size(47, 16);
            labelCMND.Text = "CMND";
            quanLySvForm.Controls.Add(labelCMND);

            labelngaySinh.Location = new System.Drawing.Point(521, 194);
            labelngaySinh.Size = new System.Drawing.Size(67, 16);
            labelngaySinh.TabIndex = 3;
            labelngaySinh.Text = "Ngày sinh";
            quanLySvForm.Controls.Add(labelngaySinh);

            labeldiaChi.Location = new System.Drawing.Point(740, 194);
            labeldiaChi.Size = new System.Drawing.Size(47, 16);
            labeldiaChi.Text = "Địa chỉ";
            quanLySvForm.Controls.Add(labeldiaChi);

            labelEmail.AutoSize = true;
            labelEmail.Location = new System.Drawing.Point(521, 261);
            labelEmail.Size = new System.Drawing.Size(41, 16);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Email";
            quanLySvForm.Controls.Add(labelEmail);

            buttonOK.Location = new System.Drawing.Point(524, 338);
            buttonOK.Size = new System.Drawing.Size(75, 23);
            buttonOK.Text = "OK";
            quanLySvForm.Controls.Add(buttonOK);

            buttonCancel.Location = new System.Drawing.Point(743, 338);
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            quanLySvForm.Controls.Add(buttonCancel);

            textBoxMSSV.Location = new System.Drawing.Point(524, 70);
            textBoxMSSV.Size = new System.Drawing.Size(121, 22);
            quanLySvForm.Controls.Add(textBoxMSSV);

            textBoxhoTen.Location = new System.Drawing.Point(743, 70);
            textBoxhoTen.Size = new System.Drawing.Size(178, 22);
            quanLySvForm.Controls.Add(textBoxhoTen);

            textBoxCMND.Location = new System.Drawing.Point(743, 157);
            textBoxCMND.Size = new System.Drawing.Size(178, 22);
            quanLySvForm.Controls.Add(textBoxCMND);

            textBoxAddress.Location = new System.Drawing.Point(743, 230);
            textBoxAddress.Size = new System.Drawing.Size(178, 22);
            quanLySvForm.Controls.Add(textBoxAddress);

            textBoxEmail.Location = new System.Drawing.Point(524, 297);
            textBoxEmail.Size = new System.Drawing.Size(178, 22);
            quanLySvForm.Controls.Add(textBoxEmail);

            comboBoxKhoa.Location = new System.Drawing.Point(524, 157);
            comboBoxKhoa.Size = new System.Drawing.Size(178, 24);
            quanLySvForm.Controls.Add(comboBoxKhoa);
            AddKhoaComboBox();

            dateTimePickerNgaysinh.Location = new System.Drawing.Point(524, 230);
            dateTimePickerNgaysinh.Size = new System.Drawing.Size(200, 22);
            quanLySvForm.Controls.Add(dateTimePickerNgaysinh);
            quanLySvForm.Size = new System.Drawing.Size(1124, 652);

            New.Size = new System.Drawing.Size(224, 26);
            New.Text = "New";
            Load.Size = new System.Drawing.Size(224, 26);
            Load.Text = "Load";
            Load.Click += new EventHandler(Loadclick);
            Application.Run(quanLySvForm);
        }
        public class TTSV
        {
            protected string mssv;
            public string MSSV
            {
                get { return mssv; }
                set { mssv = value; }
            }
            protected string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            protected int khoa;
            public int Khoa
            {
                get { return khoa; }
                set
                {
                    khoa = value;
                }
            }
            protected string CMND;
            public string soCMND
            {
                get { return CMND; }
                set { CMND = value; }
            }
            protected DateTime ngSinh;
            public DateTime NgSinh
            {
                get { return ngSinh; }
                set
                {
                    ngSinh = value;
                }
            }
            protected string soDT;

            public string SoDT
            {
                get { return soDT; }
                set
                {
                    soDT = value;
                }
            }
            protected string email;
            public  string Email
            {
                get { return email; }
                set
                {
                    email = value;
                }
            }
            protected string pathAnh;
            public string PathAnh
            {
                get { return pathAnh; }
                set { pathAnh = value; }
            }

        }
        public static List<TTSV> dsSV = new List<TTSV>();
        public static string path;
        private static void Loadclick(Object obj, EventArgs ea)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"TXT|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
            foreach (string line in System.IO.File.ReadLines(@path))
            {
                string[] tachChuoi = line.Split('|');
                MessageBox.Show(tachChuoi.Length.ToString());
                TTSV temp = new TTSV();
                try
                {
                    temp.MSSV = tachChuoi[0].ToString();
                    temp.Name = tachChuoi[1].ToString();
                    temp.Khoa = int.Parse(tachChuoi[2].ToString());
                    temp.soCMND = tachChuoi[3].ToString();
                    temp.NgSinh = DateTime.ParseExact(tachChuoi[4].ToString(), "yyyy-MM-dd", null);
                    temp.SoDT = tachChuoi[5].ToString();
                    temp.Email = tachChuoi[6].ToString();
                    temp.PathAnh = tachChuoi[7].ToString();
                    dsSV.Add(temp);
                }
                catch(Exception exception)
                {
                    MessageBox.Show("Loi doc thong tin !!!");
                }
            }
            foreach (var sinhvien in dsSV)
            {
                listDSSV.Items.Add(sinhvien.MSSV + " - " + sinhvien.Name);
            }
        }

        private static void ClicksinhVien(Object obj, EventArgs ea)
        {

        }
    }
}
//namespace KTCL
//{
//    internal class Program
//    {
//        static PictureBox orgPicture = new PictureBox();
//        static PictureBox changePicture = new PictureBox();
//        static Label bri = new Label();
//        static Label sat = new Label();
//        static Button load = new Button();
//        static Button save = new Button();
//        static Button reset = new Button();
//        static TrackBar brightness = new TrackBar();
//        static TrackBar saturation = new TrackBar();
//        static Form form = new Form();
//        static string path;
//        static Bitmap myImage;

//        // Thread t = new Thread( (ThreadStart)(() => {}) )
//        public static Thread o = new Thread((ThreadStart)(() =>
//        {
//            OpenFileDialog openFileDialog1 = new OpenFileDialog();
//            if (openFileDialog1.ShowDialog() == DialogResult.OK)
//            {
//                path = openFileDialog1.FileName;
//                orgPicture.Image = new Bitmap(@path);
//                changePicture.Image = new Bitmap(@path);
//                myImage = new Bitmap(@path);
//            }
//        }));

//        public static Thread s = new Thread((ThreadStart)(() =>
//        {
//            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
//            {
//                if (saveFileDialog.ShowDialog() == DialogResult.OK)
//                {
//                    changePicture.Image.Save(saveFileDialog.FileName);
//                }
//            }
//        }));
//        public static void bt_Load(Object obj, EventArgs ea)
//        {
//            try
//            {
//                o.SetApartmentState(ApartmentState.STA);
//                o.Start();
//                o.Join();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Exception Unhandled");
//            }
//        }
//        public static void bt_Save(Object obj, EventArgs ea)
//        {
//            try
//            {
//                s.SetApartmentState(ApartmentState.STA);
//                s.Start();
//                s.Join();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Exception Unhandled");
//            }
//        }
//        public static void bt_Reset(Object obj, EventArgs ea)
//        {
//            changePicture.Image = new Bitmap(@path);
//            myImage = new Bitmap(@path);
//            brightness.Value = 0;
//            saturation.Value = 0;
//        }
//        public static void bri_Scroll(Object obj, EventArgs ea)
//        {
//            changePicture.Image = Brightness1(myImage, (float)brightness.Value );
//        }
//        public static void sat_Scroll(Object obj, EventArgs ea)
//        {
//            changePicture.Image = Saturation1(myImage, (float)saturation.Value / 255);
//        }
//        public static Image Saturation1(Bitmap img, float fSaturation)
//        {
//            Bitmap TempBitmap = img;

//            Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);

//            Graphics NewGraphics = Graphics.FromImage(NewBitmap);

//            fSaturation = (float)fSaturation + 255 / 255.0f;
//            float rWeight = 0.3086f;
//            float gWeight = 0.6094f;
//            float bWeight = 0.0820f;

//            float a = (1.0f - fSaturation) * rWeight + fSaturation;
//            float b = (1.0f - fSaturation) * rWeight;
//            float c = (1.0f - fSaturation) * rWeight;
//            float d = (1.0f - fSaturation) * gWeight;
//            float e = (1.0f - fSaturation) * gWeight + fSaturation;
//            float f = (1.0f - fSaturation) * gWeight;
//            float g = (1.0f - fSaturation) * bWeight;
//            float h = (1.0f - fSaturation) * bWeight;
//            float i = (1.0f - fSaturation) * bWeight + fSaturation;

//            float[][] FloatColorMatrix = {
//                new float[] {a,  b,  c,  0, 0},
//                new float[] {d,  e,  f,  0, 0},
//                new float[] {g,  h,  i,  0, 0},
//                new float[] {0,  0,  0,  1, 0},
//                new float[] {0, 0, 0, 0, 1}
//            };
//            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);

//            ImageAttributes Attributes = new ImageAttributes();

//            Attributes.SetColorMatrix(NewColorMatrix);

//            NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);

//            Attributes.Dispose();

//            NewGraphics.Dispose();

//            return NewBitmap;
//        }
//        public static Image Brightness1(Bitmap img, float fBrightness)
//        {
//            Bitmap TempBitmap = img;

//            Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);

//            Graphics NewGraphics = Graphics.FromImage(NewBitmap);

//            fBrightness = (float)fBrightness / 255.0f;
//            float[][] FloatColorMatrix = {
//                new float[] {1,  0,  0,  0, 0},
//                new float[] {0,  1,  0,  0, 0},
//                new float[] {0,  0,  1,  0, 0},
//                new float[] {0,  0,  0,  1, 0},
//                new float[] { fBrightness, fBrightness, fBrightness, 0, 1}
//            };
//            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);

//            ImageAttributes Attributes = new ImageAttributes();

//            Attributes.SetColorMatrix(NewColorMatrix);

//            NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);

//            Attributes.Dispose();

//            NewGraphics.Dispose();

//            return NewBitmap;
//        }
//        static Thread threadEven, threadOdd;
//        static int count = 0;
//        static object _lock = new object();
//        static void Main(string[] args)
//        {
//            orgPicture.Location = new Point(600, 50);
//            orgPicture.Size = new System.Drawing.Size(300, 300);
//            orgPicture.SizeMode = PictureBoxSizeMode.StretchImage;

//            changePicture.Location = new Point(50, 50);
//            changePicture.Size = new System.Drawing.Size(300, 300);
//            changePicture.SizeMode = PictureBoxSizeMode.StretchImage;

//            bri.Text = "Brightness";
//            bri.Location = new Point(50, 350);
//            bri.Width = 100;
//            bri.Height = 50;

//            sat.Text = "Saturation";
//            sat.Location = new Point(50, 450);
//            sat.Width = 100;
//            sat.Height = 50;

//            load.Width = 40;
//            load.Height = 30;
//            load.Location = new Point(820, 350);
//            load.Text = "Load";
//            load.Click += new EventHandler(bt_Load);

//            save.Width = 40;
//            save.Height = 30;
//            save.Location = new Point(820, 450);
//            save.Text = "Save";
//            save.Click += new EventHandler(bt_Save);

//            reset.Width = 50;
//            reset.Height = 30;
//            reset.Location = new Point(870, 350);
//            reset.Text = "Reset";
//            reset.Click += new EventHandler(bt_Reset);

//            brightness.Location = new Point(150, 350);
//            brightness.Width = 600;
//            brightness.Height = 50;
//            brightness.SetRange(-255, 255);
//            brightness.TickFrequency = 10;
//            brightness.Scroll += new EventHandler(bri_Scroll);

//            saturation.Location = new Point(150, 450);
//            saturation.Width = 600;
//            saturation.Height = 50;
//            saturation.SetRange(-255, 255);
//            saturation.TickFrequency = 10;
//            saturation.Scroll += new EventHandler(sat_Scroll);

//            form.Size = new System.Drawing.Size(1000, 1000);
//            //form.AutoSize = true;

//            form.Controls.Add(orgPicture);
//            form.Controls.Add(changePicture);

//            form.Controls.Add(sat);
//            form.Controls.Add(bri);

//            form.Controls.Add(load);
//            form.Controls.Add(save);
//            form.Controls.Add(reset);

//            form.Controls.Add(brightness);
//            form.Controls.Add(saturation);
//            Application.Run(form);
//        }
//    }
//}


