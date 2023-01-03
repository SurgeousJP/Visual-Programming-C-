namespace ThiThuHanh_NguyenTuanBao_21520620
{
    partial class QuanLyVeTau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HoTen = new System.Windows.Forms.Label();
            this.CCCD = new System.Windows.Forms.Label();
            this.NgSinh = new System.Windows.Forms.Label();
            this.GioiTinh = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Nam = new System.Windows.Forms.RadioButton();
            this.Nu = new System.Windows.Forms.RadioButton();
            this.MaVe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.Xoa = new System.Windows.Forms.Button();
            this.CapNhat = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.Xem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lv_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_maVe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_GaDi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_GaDen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Nu);
            this.groupBox1.Controls.Add(this.Nam);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.DiaChi);
            this.groupBox1.Controls.Add(this.GioiTinh);
            this.groupBox1.Controls.Add(this.NgSinh);
            this.groupBox1.Controls.Add(this.CCCD);
            this.groupBox1.Controls.Add(this.HoTen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người mua";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MaVe);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.price);
            this.groupBox2.Controls.Add(this.lb_Price);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(496, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 223);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin vé tàu";
            // 
            // HoTen
            // 
            this.HoTen.AutoSize = true;
            this.HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HoTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HoTen.Location = new System.Drawing.Point(19, 41);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(69, 22);
            this.HoTen.TabIndex = 1;
            this.HoTen.Text = "Họ tên";
            // 
            // CCCD
            // 
            this.CCCD.AutoSize = true;
            this.CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CCCD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CCCD.Location = new System.Drawing.Point(19, 75);
            this.CCCD.Name = "CCCD";
            this.CCCD.Size = new System.Drawing.Size(66, 22);
            this.CCCD.TabIndex = 1;
            this.CCCD.Text = "CCCD";
            this.CCCD.Click += new System.EventHandler(this.label2_Click);
            // 
            // NgSinh
            // 
            this.NgSinh.AutoSize = true;
            this.NgSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NgSinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NgSinh.Location = new System.Drawing.Point(16, 108);
            this.NgSinh.Name = "NgSinh";
            this.NgSinh.Size = new System.Drawing.Size(99, 22);
            this.NgSinh.TabIndex = 1;
            this.NgSinh.Text = "Ngày sinh";
            this.NgSinh.Click += new System.EventHandler(this.label2_Click);
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSize = true;
            this.GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GioiTinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GioiTinh.Location = new System.Drawing.Point(16, 145);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(85, 22);
            this.GioiTinh.TabIndex = 1;
            this.GioiTinh.Text = "Giới tính";
            this.GioiTinh.Click += new System.EventHandler(this.label2_Click);
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DiaChi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DiaChi.Location = new System.Drawing.Point(16, 176);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(72, 22);
            this.DiaChi.TabIndex = 1;
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 28);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 28);
            this.textBox2.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 173);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(300, 28);
            this.textBox5.TabIndex = 2;
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nam.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Nam.Location = new System.Drawing.Point(131, 141);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(71, 26);
            this.Nam.TabIndex = 4;
            this.Nam.TabStop = true;
            this.Nam.Text = "Nam";
            this.Nam.UseVisualStyleBackColor = true;
            // 
            // Nu
            // 
            this.Nu.AutoSize = true;
            this.Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Nu.Location = new System.Drawing.Point(270, 141);
            this.Nu.Name = "Nu";
            this.Nu.Size = new System.Drawing.Size(56, 26);
            this.Nu.TabIndex = 4;
            this.Nu.TabStop = true;
            this.Nu.Text = "Nữ";
            this.Nu.UseVisualStyleBackColor = true;
            // 
            // MaVe
            // 
            this.MaVe.AutoSize = true;
            this.MaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaVe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaVe.Location = new System.Drawing.Point(22, 36);
            this.MaVe.Name = "MaVe";
            this.MaVe.Size = new System.Drawing.Size(63, 22);
            this.MaVe.TabIndex = 1;
            this.MaVe.Text = "Mã vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ga đi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(22, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ga đến";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(23, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số ghế ngồi";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Price.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Price.Location = new System.Drawing.Point(23, 179);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(41, 22);
            this.lb_Price.TabIndex = 1;
            this.lb_Price.Text = "Giá";
            this.lb_Price.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 28);
            this.textBox3.TabIndex = 2;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.price.ForeColor = System.Drawing.SystemColors.ControlText;
            this.price.Location = new System.Drawing.Point(142, 179);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 22);
            this.price.TabIndex = 1;
            this.price.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Hồ Chí Minh",
            "Biên Hòa"});
            this.comboBox2.Location = new System.Drawing.Point(146, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(300, 30);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Hà Nội",
            "Đà Nẵng"});
            this.comboBox3.Location = new System.Drawing.Point(146, 105);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(300, 30);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox4.Location = new System.Drawing.Point(146, 141);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(300, 30);
            this.comboBox4.TabIndex = 3;
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Xoa.Location = new System.Drawing.Point(173, 257);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(122, 60);
            this.Xoa.TabIndex = 1;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // CapNhat
            // 
            this.CapNhat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CapNhat.Location = new System.Drawing.Point(337, 257);
            this.CapNhat.Name = "CapNhat";
            this.CapNhat.Size = new System.Drawing.Size(122, 60);
            this.CapNhat.TabIndex = 1;
            this.CapNhat.Text = "Cập nhật";
            this.CapNhat.UseVisualStyleBackColor = false;
            this.CapNhat.Click += new System.EventHandler(this.CapNhat_Click);
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Them.Location = new System.Drawing.Point(496, 257);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(122, 60);
            this.Them.TabIndex = 1;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Xem
            // 
            this.Xem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Xem.Location = new System.Drawing.Point(654, 257);
            this.Xem.Name = "Xem";
            this.Xem.Size = new System.Drawing.Size(122, 60);
            this.Xem.TabIndex = 1;
            this.Xem.Text = "Xem";
            this.Xem.UseVisualStyleBackColor = false;
            this.Xem.Click += new System.EventHandler(this.Xem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_STT,
            this.lv_maVe,
            this.lv_GaDi,
            this.lv_GaDen});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 323);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(958, 288);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // lv_STT
            // 
            this.lv_STT.Text = "STT";
            this.lv_STT.Width = 243;
            // 
            // lv_maVe
            // 
            this.lv_maVe.Text = "Mã vé";
            this.lv_maVe.Width = 192;
            // 
            // lv_GaDi
            // 
            this.lv_GaDi.Text = "Ga đi";
            this.lv_GaDi.Width = 248;
            // 
            // lv_GaDen
            // 
            this.lv_GaDen.Text = "Ga đến";
            this.lv_GaDen.Width = 584;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 28);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // QuanLyVeTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 616);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Xem);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.CapNhat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyVeTau";
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyVeTau_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CCCD;
        private System.Windows.Forms.Label HoTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Label GioiTinh;
        private System.Windows.Forms.Label NgSinh;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton Nu;
        private System.Windows.Forms.RadioButton Nam;
        private System.Windows.Forms.Label MaVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button CapNhat;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Xem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lv_STT;
        private System.Windows.Forms.ColumnHeader lv_maVe;
        private System.Windows.Forms.ColumnHeader lv_GaDi;
        private System.Windows.Forms.ColumnHeader lv_GaDen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

