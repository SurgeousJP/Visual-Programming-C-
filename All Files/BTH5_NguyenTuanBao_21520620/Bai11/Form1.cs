using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Bai11
{
    public partial class Form1 : Form
    {
        
        public static Point nonReachablePoint = new Point(-1, -1);
        public static Point startPoint, endPoint;

        public static bool isInDrawingMode = false;

        public static Color txtColor = Color.Black;
        public static Bitmap textureStyle = (Bitmap) Image.FromFile(@"ImgSource\\randbitmap-wamp.png");

        public static GraphicsPath drawingPath;

        static SolidBrush fillSolidColor = new SolidBrush(Color.Green);
        static HatchBrush fillHatchColor = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
        static TextureBrush fillTextureColor = new TextureBrush(textureStyle);
        static LinearGradientBrush fillLinearGradientColor;

        public static Bitmap drawingCanvas;

        static Graphics drawDemo;
        static Rectangle AreaDrawnRectangle;

        static string drawShape;
        public Form1()
        {
            InitializeComponent();
            drawingPath = new GraphicsPath();
            drawingPath.StartFigure();
        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtColor = colorDialog.Color;
            }
        }
        public void DrawLine(Graphics input)
        {
            if (txtColor == null) return;
            if (String.IsNullOrEmpty(textBox1.Text.ToString()) == true) return;
            input.DrawLine(new Pen(txtColor, int.Parse(textBox1.Text)), startPoint, endPoint);
        }

        public void DrawRectangle(Graphics input, Rectangle areaDrawnRectangle)
        {
            input.DrawRectangle(new Pen(Color.White), areaDrawnRectangle);

            if (SolidBrush.Checked == true)
            {
                input.FillRectangle(fillSolidColor, areaDrawnRectangle);
            }
            else if (HatchBrush.Checked == true)
            {
                input.FillRectangle(fillHatchColor, areaDrawnRectangle);
            }
            else if (TextureBrush.Checked == true)
            {
                input.FillRectangle(fillTextureColor, areaDrawnRectangle);
            }
            else if (LinearGradientBrush.Checked == true)
            {
                input.FillRectangle(fillLinearGradientColor, areaDrawnRectangle);
            }
        }

        public void DrawEllipse(Graphics input, Rectangle areaDrawnRectangle)
        {
            input.DrawEllipse(new Pen(Color.White), areaDrawnRectangle);
            if (SolidBrush.Checked == true)
            {
                input.FillEllipse(fillSolidColor, areaDrawnRectangle);
            }
            else if (HatchBrush.Checked == true)
            {
                input.FillEllipse(fillHatchColor, areaDrawnRectangle);
            }
            else if (TextureBrush.Checked == true)
            {
                input.FillEllipse(fillTextureColor, areaDrawnRectangle);
            }
            else if (LinearGradientBrush.Checked == true)
            {
                input.FillEllipse(fillLinearGradientColor, areaDrawnRectangle);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (startPoint.X == endPoint.X && startPoint.Y == endPoint.Y) return;
            drawDemo = e.Graphics;
            Graphics g;
            drawDemo.Clear(Color.White);

            Pen pen = new Pen(Color.White);

            AreaDrawnRectangle = new Rectangle(Math.Min(startPoint.X, endPoint.X),
                Math.Min(startPoint.Y, endPoint.Y),
                Math.Abs(startPoint.X - endPoint.X),
                Math.Abs(startPoint.Y - endPoint.Y));

            fillLinearGradientColor = new LinearGradientBrush(
                    new PointF(0, startPoint.Y), new PointF(1, endPoint.Y), Color.Green, Color.Red);

            if (drawingCanvas == null)
            {
                //drawingCanvas = (Bitmap)pictureBox1.Image;
                drawingCanvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                Rectangle whiteArea = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);

                g = Graphics.FromImage(drawingCanvas);
                g.DrawRectangle(new Pen(Color.White), whiteArea);
                g.FillRectangle(new SolidBrush(Color.White), whiteArea);
            }
            else
            {
                g = Graphics.FromImage(drawingCanvas);
            }

            drawDemo.DrawImage(drawingCanvas, 0, 0, pictureBox1.Width, pictureBox1.Height);

            if (LineShape.Checked == true)
            {
                DrawLine(drawDemo);
            }
            else if (RectangleShape.Checked == true)
            {
                DrawRectangle(drawDemo, AreaDrawnRectangle);
            }
            else if (EllipseShape.Checked == true)
            {
                DrawEllipse(drawDemo, AreaDrawnRectangle);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isInDrawingMode)
            {
                endPoint = e.Location;
                pictureBox1.Invalidate();
                pictureBox1.Update();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isInDrawingMode == false)
            {
                isInDrawingMode = true;
                startPoint = e.Location;
            }
            else if (e.Button == MouseButtons.Left && isInDrawingMode == true)
            {
                Graphics g = Graphics.FromImage(drawingCanvas);
                if (LineShape.Checked == true)
                {
                    DrawLine(g);
                }
                else if (RectangleShape.Checked == true)
                {
                    DrawRectangle(g, AreaDrawnRectangle);
                }
                else if (EllipseShape.Checked == true)
                {
                    DrawEllipse(g, AreaDrawnRectangle);
                }
                isInDrawingMode = false;
                startPoint = new Point(nonReachablePoint.X, nonReachablePoint.Y);
                endPoint = new Point(nonReachablePoint.X, nonReachablePoint.Y);
            }
        }
    }
}
