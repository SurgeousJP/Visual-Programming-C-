using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        static Graphics drawAnalogClock;
        static int centerXCoordinate = 220, centerYCoordinate = 220;
        static SolidBrush DEFAULT_CLOCK_POINT_BRUSH = new SolidBrush(Color.White);
        static Pen DEFAULT_CLOCK_POINT_PEN = new Pen(Color.White);
        static int SECOND_CLOCK_HAND = 180, MINUTE_CLOCK_HAND = 180, HOUR_CLOCK_HAND = 130;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            drawAnalogClock = this.CreateGraphics();
        }

        // Draw those circles
        public void Draw12ClockHourPoints()
        {
            for (int hourInAClock = 1; hourInAClock <= 12; hourInAClock++)
            {
                int[] coordinates = GetHourCoordinates(hourInAClock, 0, 200);
                DrawClockPoint(coordinates[0], coordinates[1], 15);
            }
        }

        public void DrawMinutePoints()
        {
            for (int minuteInAHour = 0; minuteInAHour <= 60; minuteInAHour++)
            {
                if (minuteInAHour % 5 == 0) continue;
                int[] coordinates = GetMinuteSecondCoordinates(minuteInAHour, 200);
                DrawClockPoint(coordinates[0], coordinates[1], 5);
            }
            
        }
        public void DrawClockPoint(int xCoordinate, int yCoordinate, int radius)
        {
            Rectangle drawCircle = new Rectangle(xCoordinate, yCoordinate, radius, radius);
            drawAnalogClock.DrawEllipse(DEFAULT_CLOCK_POINT_PEN, drawCircle);
            drawAnalogClock.FillEllipse(DEFAULT_CLOCK_POINT_BRUSH, drawCircle);
        }
        public int[] GetHourCoordinates(int hourVal, int minuteVal, int lineLength)
        {
            int[] hourCoordinates = new int[2];
            int clockAngle = (int)(hourVal * 30 + minuteVal * 0.5);
            if (clockAngle >= 0 && clockAngle <= 180)
            {
                hourCoordinates[0] = centerXCoordinate + (int)(lineLength * Math.Sin(Math.PI * clockAngle / 180));
                hourCoordinates[1] = centerYCoordinate - (int)(lineLength * Math.Cos(Math.PI * clockAngle / 180));
            }
            else
            {
                hourCoordinates[0] = centerXCoordinate - (int)(lineLength * -Math.Sin(Math.PI * clockAngle / 180));
                hourCoordinates[1] = centerYCoordinate - (int)(lineLength * Math.Cos(Math.PI * clockAngle / 180));
            }
            return hourCoordinates;
        }

        public int[] GetMinuteSecondCoordinates(int minuteSecondVal, int lineLength)
        {
            int[] minuteSecondCoordinates = new int[2];
            minuteSecondVal *= 6; // note: each minute and seconds make a 6 degree  
            if (minuteSecondVal >= 0 && minuteSecondVal <= 100)
            {
                minuteSecondCoordinates[0] = centerXCoordinate + (int)(lineLength * Math.Sin(Math.PI * minuteSecondVal / 180));
                minuteSecondCoordinates[1] = centerYCoordinate - (int)(lineLength * Math.Cos(Math.PI * minuteSecondVal / 180));
            }
            else
            {
                minuteSecondCoordinates[0] = centerXCoordinate - (int)(lineLength * -Math.Sin(Math.PI * minuteSecondVal / 180));
                minuteSecondCoordinates[1] = centerYCoordinate - (int)(lineLength * Math.Cos(Math.PI * minuteSecondVal / 180));
            }
            return minuteSecondCoordinates;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void DrawClockLineHand(Point start, Point destination)
        {
            drawAnalogClock.DrawLine(DEFAULT_CLOCK_POINT_PEN,
                start, destination);
        }
        public int caculatingDistance(Point p1, Point p2)
        {
            return (int)(Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2)));
        }
        public void DrawFullHandClock(ref int[] leftSideCoordinates, ref int[] rightSideCoordinates, ref int[] handCoordinates)
        {
            DrawClockLineHand(new Point(centerXCoordinate, centerYCoordinate),
                new Point(leftSideCoordinates[0], leftSideCoordinates[1]));

            DrawClockLineHand(new Point(centerXCoordinate, centerYCoordinate),
                new Point(rightSideCoordinates[0], rightSideCoordinates[1]));

            DrawClockLineHand(new Point(leftSideCoordinates[0], leftSideCoordinates[1]),
                new Point(handCoordinates[0], handCoordinates[1]));

            DrawClockLineHand(new Point(rightSideCoordinates[0], rightSideCoordinates[1]),
                new Point(handCoordinates[0], handCoordinates[1]));
        }
        private void DrawingClock()
        {
            Draw12ClockHourPoints();
            DrawMinutePoints();
            int currentSecond = DateTime.Now.Second;
            int currentMinute = DateTime.Now.Minute;
            int currentHour = DateTime.Now.Hour % 12;
            int[] handCoordinates = new int[2];
            int[] middleCoordinates = new int[2];
            int[] leftSideCoordinates = new int[2];
            int[] rightSideCoordinates = new int[2];
            int distance;

            //draw seconds hand  
            handCoordinates = GetMinuteSecondCoordinates(currentSecond, SECOND_CLOCK_HAND);
            drawAnalogClock.DrawLine(new Pen(Color.Red, 2f), 
                    new Point(centerXCoordinate, centerYCoordinate), 
                    new Point(handCoordinates[0], handCoordinates[1]));
            //draw minutes hand  
            handCoordinates = GetMinuteSecondCoordinates(currentMinute, MINUTE_CLOCK_HAND);
            middleCoordinates = GetMinuteSecondCoordinates(currentMinute, 50);

            // Get distance to pass into rotate function below
            distance = caculatingDistance(new Point(middleCoordinates[0], middleCoordinates[1]),
                new Point(centerXCoordinate, centerYCoordinate));

            // Rotate left & right side to draw clock hand two side line
            leftSideCoordinates = GetMinuteSecondCoordinates(currentMinute + 2, distance);
            rightSideCoordinates = GetMinuteSecondCoordinates(currentMinute - 2, distance);

            // Draw minute clock hand (include 4 lines)
            DrawFullHandClock(ref leftSideCoordinates, ref rightSideCoordinates, ref handCoordinates);

            //draw hours hand  
            handCoordinates = GetHourCoordinates(currentHour, currentMinute, HOUR_CLOCK_HAND);
            middleCoordinates = GetHourCoordinates(currentHour, currentMinute, 50);

            distance = caculatingDistance(new Point(middleCoordinates[0], middleCoordinates[1]),
                new Point(centerXCoordinate, centerYCoordinate));

            leftSideCoordinates = GetHourCoordinates(currentHour + 1, currentMinute + 1 , distance);
            rightSideCoordinates = GetHourCoordinates(currentHour - 1, currentMinute - 1,  distance);
            // Draw hour Clock hand
            DrawFullHandClock(ref leftSideCoordinates, ref rightSideCoordinates, ref handCoordinates);
        }
        private void OneSecondElapsed_Event(object sender, EventArgs e)
        {
            drawAnalogClock.Clear(Color.Black);
            DrawingClock();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawingClock();
        }
    }
}

