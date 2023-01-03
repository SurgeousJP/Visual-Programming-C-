using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        static string[] shapeArray = {"Circle", "Square", "Ellipse", "Pie",
                                    "Filled Circle", "Filled Square", "Filled Ellipse", "Filled Pie" };
        
        public void InitializeDrawShapeComboBox()
        {
            foreach (string shape in shapeArray)
            {
                cb_DrawShape.Items.Add(shape);
            }
        }
        static Graphics drawGraphics; 
        public Form1()
        {
            InitializeComponent();
            InitializeDrawShapeComboBox();
            drawGraphics = this.CreateGraphics();
        }
        public void DrawCircle()
        {
            drawGraphics.DrawEllipse(new Pen(Color.Red), 150, 150, 150, 150);
        }
        public void DrawFilledCircle()
        {
            DrawCircle();
            drawGraphics.FillEllipse(new SolidBrush(Color.Red), 150, 150, 150, 150);
        }
        public void DrawSquare()
        {
            drawGraphics.DrawRectangle(new Pen(Color.Red), 150, 150, 150, 150);
        }
        public void DrawFilledSquare()
        {
            DrawSquare();
            drawGraphics.FillRectangle(new SolidBrush(Color.Red), 150, 150, 150, 150);
        }
        public void DrawEllipse()
        {
            drawGraphics.DrawEllipse(new Pen(Color.Red), 150, 150, 200, 150);
        }
        public void DrawFilledEllipse()
        {
            DrawEllipse();
            drawGraphics.FillEllipse(new SolidBrush(Color.Red), 150, 150, 200, 150);
        }
        public void DrawPie()
        {
            drawGraphics.DrawPie(new Pen(Color.Red), 150, 150, 150, 150, 0, 240);
        }
        public void DrawFilledPie()
        {
            DrawPie();
            drawGraphics.FillPie(new SolidBrush(Color.Red), 150, 150, 150, 150, 0, 240);
        }
        private void ChangeShape(object sender, EventArgs e)
        {
            drawGraphics.Clear(SystemColors.Control);
            switch (cb_DrawShape.SelectedItem.ToString())
            {
                case "Circle":
                    DrawCircle();
                    break;
                case "Square":
                    DrawSquare();
                    break;
                case "Ellipse":
                    DrawEllipse();
                    break;
                case "Pie":
                    DrawPie();
                    break;
                case "Filled Circle":
                    DrawFilledCircle();
                    break;
                case "Filled Square":
                    DrawFilledSquare();
                    break;
                case "Filled Pie":
                    DrawFilledPie();
                    break;
                case "Filled Ellipse":
                    DrawFilledEllipse();
                    break;
            }
        }
    }
}
