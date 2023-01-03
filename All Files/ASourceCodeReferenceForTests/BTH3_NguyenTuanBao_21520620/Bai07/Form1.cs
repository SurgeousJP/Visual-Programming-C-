using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai7
{
    public partial class Form1 : Form
    {
        public enum SeatColor { White, Blue, Yellow}
        // class Ticket
        internal Ticket[,] ticket;
        static double TotalPrice = 0;
        public class Ticket : Button
        {
            private void btn_SeatClick(object sender, EventArgs e)
            {
                Ticket temp = (Ticket)sender;
                if (temp.IsSold)
                {
                    MessageBox.Show("Cho nay da duoc ban !!!");
                    return;
                }
                if (temp.IsPicked)
                {
                    temp.seatColor = SeatColor.White;
                    IsPicked = false;
                }
                else
                {
                    temp.seatColor = SeatColor.Blue;
                    IsPicked = true;
                }
            }
            public Ticket()
            {
                this.Click += new EventHandler(btn_SeatClick);
            }
            private double _price;
            public double Price
            {
                get { return _price; }
                set { _price = value; }
            }
            private bool _isPicked;
            public bool IsPicked
            {
                get { return _isPicked; }
                set { _isPicked = value; }
            }
            private bool _isSold;
            public bool IsSold
            {
                get { return _isSold; }
                set { _isSold = value; }
            }
            private SeatColor _seatColor;
            public SeatColor seatColor
            {
                get { return _seatColor; }
                set {
                    _seatColor = value;
                    if (seatColor == SeatColor.White)
                    {
                        this.BackColor = Color.White;
                    }
                    if (seatColor == SeatColor.Yellow)
                    {
                        this.BackColor = Color.Yellow;
                    }
                    if (seatColor == SeatColor.Blue)
                    {
                        this.BackColor = Color.Blue;
                    }
                }
            }
            
        }
        
        public Form1()
        {
            InitializeComponent();
            Init();
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Ve panel mua ve
        void Init()
        {
            panel1.Location = new Point(53, 53);
            panel1.AutoSize = true;
            panel1.Width = 789;
            panel1.Height = 289;
            ticket = new Ticket[3, 5];
            int xLoc = 79;
            int yLoc = 22;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    ticket[i, j] = new Ticket();
                    ticket[i, j].Text = (1 + j + 5 * i).ToString();
                    ticket[i, j].Width = 60;
                    ticket[i, j].Height = 60;
                    ticket[i, j].Location = new Point(xLoc, yLoc);
                    ticket[i, j].IsPicked = false;
                    ticket[i, j].seatColor = SeatColor.White;
                    ticket[i, j].IsSold = false;
                    switch (i)
                    {
                        case 0:
                            ticket[i, j].Price = 5000;
                            break;
                        case 1:
                            ticket[i, j].Price = 6500;
                            break;
                        case 2:
                            ticket[i, j].Price = 8000;
                            break;
                    }
                    panel1.Controls.Add(ticket[i, j]);
                    xLoc += 66;
                }
                xLoc = 79;
                yLoc += 66;
            }
            TotalPrice = 0;
        }
        // Event click Button Chon
        private void button16_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (ticket[i, j].seatColor == SeatColor.Blue)
                    {
                        ticket[i, j].seatColor = SeatColor.Yellow;
                        ticket[i, j].IsSold = true;
                        TotalPrice += ticket[i, j].Price;
                    }
                }
            }
            textBox2.Text = TotalPrice.ToString();
        }
        // Event click button huy bo 
        private void button17_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (ticket[i, j].seatColor == SeatColor.Blue)
                    {
                        ticket[i, j].seatColor = SeatColor.White;
                        ticket[i, j].IsSold = false;
                    }
                }
            }
            textBox2.Text = "0";
        }
        // Event click ket thuc
        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Event click reset
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    ticket[i, j].IsPicked = false;
                    ticket[i, j].seatColor = SeatColor.White;
                    ticket[i, j].IsSold = false;
                }
            }
            textBox2.Text = "0";
            TotalPrice = 0;
        }
        // Event Closing Form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
