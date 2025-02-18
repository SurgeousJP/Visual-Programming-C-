﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace Bai07
{
    public partial class Form1 : Form
    {

        class SevenSegmentDisplay
        {
            Graphics grfx;

            // Indicates what segments are illuminated for all 10 digits

            static byte[,] bySegment = {{1, 1, 1, 0, 1, 1, 1},       // 0
                                 {0, 0, 1, 0, 0, 1, 0},       // 1
                                 {1, 0, 1, 1, 1, 0, 1},       // 2
                                 {1, 0, 1, 1, 0, 1, 1},       // 3
                                 {0, 1, 1, 1, 0, 1, 0},       // 4
                                 {1, 1, 0, 1, 0, 1, 1},       // 5
                                 {1, 1, 0, 1, 1, 1, 1},       // 6
                                 {1, 0, 1, 0, 0, 1, 0},       // 7
                                 {1, 1, 1, 1, 1, 1, 1},       // 8
                                 {1, 1, 1, 1, 0, 1, 1}};      // 9

            // Points that define each of the seven segments

            readonly Point[][] apt = new Point[7][];

            public SevenSegmentDisplay(Graphics grfx)
            {
                this.grfx = grfx;

                // Initialize jagged Point array.

                apt[0] = new Point[] {new Point( 3,  2), new Point(39,  2),
                                new Point(31, 10), new Point(11, 10)};

                apt[1] = new Point[] {new Point( 2,  3), new Point(10, 11),
                                new Point(10, 31), new Point( 2, 35)};

                apt[2] = new Point[] {new Point(40,  3), new Point(40, 35),
                                new Point(32, 31), new Point(32, 11)};

                apt[3] = new Point[] {new Point( 3, 36), new Point(11, 32),
                                new Point(31, 32), new Point(39, 36),
                                new Point(31, 40), new Point(11, 40)};

                apt[4] = new Point[] {new Point( 2, 37), new Point(10, 41),
                                new Point(10, 61), new Point( 2, 69)};

                apt[5] = new Point[] {new Point(40, 37), new Point(40, 69),
                                new Point(32, 61), new Point(32, 41)};

                apt[6] = new Point[] {new Point(11, 62), new Point(31, 62),
                                new Point(39, 70), new Point( 3, 70)};
            }
            public SizeF MeasureString(string str, Font font)
            {
                SizeF sizef = new SizeF(0, grfx.DpiX * font.SizeInPoints / 72);

                for (int i = 0; i < str.Length; i++)
                {
                    if (Char.IsDigit(str[i]))
                        sizef.Width += 42 * grfx.DpiX * font.SizeInPoints
                                                                / 72 / 72;
                    else if (str[i] == ':')
                        sizef.Width += 12 * grfx.DpiX * font.SizeInPoints
                                                                / 72 / 72;
                }
                return sizef;
            }
            public void DrawString(string str, Font font,
                                   Brush brush, float x, float y)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (Char.IsDigit(str[i]))
                        x = Number(str[i] - '0', font, brush, x, y);

                    else if (str[i] == ':')
                        x = Colon(font, brush, x, y);
                }
            }
            float Number(int num, Font font,
                         Brush brush, float x, float y)
            {
                for (int i = 0; i < apt.Length; i++)
                    if (bySegment[num, i] == 1)
                        Fill(apt[i], font, brush, x, y);

                return x + 42 * grfx.DpiX * font.SizeInPoints / 72 / 72;
            }
            float Colon(Font font, Brush brush, float x, float y)
            {
                Point[][] apt = new Point[2][];

                apt[0] = new Point[] {new Point( 2, 21), new Point( 6, 17),
                                new Point(10, 21), new Point( 6, 25)};

                apt[1] = new Point[] {new Point( 2, 51), new Point( 6, 47),
                                new Point(10, 51), new Point( 6, 55)};

                for (int i = 0; i < apt.Length; i++)
                    Fill(apt[i], font, brush, x, y);

                return x + 12 * grfx.DpiX * font.SizeInPoints / 72 / 72;
            }
            void Fill(Point[] apt, Font font, Brush brush, float x, float y)
            {
                PointF[] aptf = new PointF[apt.Length];

                for (int i = 0; i < apt.Length; i++)
                {
                    aptf[i].X = x + apt[i].X * grfx.DpiX *
                                               font.SizeInPoints / 72 / 72;
                    aptf[i].Y = y + apt[i].Y * grfx.DpiY *
                                               font.SizeInPoints / 72 / 72;
                }
                grfx.FillPolygon(brush, aptf);
            }
        }
        public string setTimestamp(DateTime dateTime)
        {
            currentHour = dateTime.Hour.ToString();
            if (int.Parse(currentHour) < 10) currentHour = "0" + currentHour;

            currentMinute = dateTime.Minute.ToString();
            if (int.Parse(currentMinute) < 10) currentMinute = "0" + currentMinute;

            currentSecond = dateTime.Second.ToString();
            if (int.Parse(currentSecond) < 10) currentSecond = "0" + currentSecond;

            return currentHour + ":" + currentMinute + ":" + currentSecond;
        }
        public void DisplayClock()
        {
            DateTime currTime = DateTime.Now;
            string strTime = setTimestamp(currTime);

            SevenSegmentDisplay ssd = new SevenSegmentDisplay(drawClock);
            
            SizeF sizef = ssd.MeasureString(strTime, Font);
            float fScale = Math.Min(ClientSize.Width / sizef.Width,
                ClientSize.Height / sizef.Height);
            Font font = new Font(Font.FontFamily,
                fScale * Font.SizeInPoints);

            sizef = ssd.MeasureString(strTime, font);

            ssd.DrawString(strTime, font, Brushes.Red,
                (ClientSize.Width - sizef.Width) / 2,
                (ClientSize.Height - sizef.Height) / 2);
        }
        static Graphics drawClock;
        static string currentHour, currentMinute, currentSecond;

        private void timer1_Tick(object sender, EventArgs e)
        {
            drawClock.Clear(SystemColors.Control);
            DisplayClock();
        }
        public Form1()
        {
            InitializeComponent();
            drawClock = panelArea.CreateGraphics();
            EnableDoubleBuffered(panelArea);
            DisplayClock();
        }
        private void EnableDoubleBuffered<T>(T control)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, control, new object[] { true });
        }
    }
}
