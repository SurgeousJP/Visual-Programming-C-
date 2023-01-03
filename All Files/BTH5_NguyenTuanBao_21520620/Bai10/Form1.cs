using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public void InitializeDashStyleCombobox()
        {
            foreach (var dashStyle in Enum.GetValues(typeof(System.Drawing.Drawing2D.DashStyle)))
            {
                if (dashStyle.Equals( DashStyle.Custom) )continue;
                cb_DashStyle.Items.Add(dashStyle);
            }
        }
        public void InitializeWidthCombobox()
        {
            int[] widths = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 42 };
            foreach (var width in widths)
            {
                cb_Width.Items.Add(width);
            }
        }

        public void InitializeLineJoinCombobox()
        {
            foreach (var lineJoin in Enum.GetValues(typeof(System.Drawing.Drawing2D.LineJoin)))
            {
                cb_LineJoin.Items.Add(lineJoin);
            }
        }

        public void InitializeDashCapCombobox()
        {
            foreach (var dashCap in Enum.GetValues(typeof(System.Drawing.Drawing2D.DashCap)))
            {
                cb_DashCap.Items.Add(dashCap);
            }
        }

        public void InitializeStartEndCapComboboxes()
        {
            foreach (var lineCap in Enum.GetValues(typeof(System.Drawing.Drawing2D.LineCap)))
            {
                cb_StartCap.Items.Add(lineCap);
                cb_EndCap.Items.Add(lineCap);
            }
        }

        public void DrawPen()
        {
            // penDemo.Clear(Color.White);
            currentPen = new Pen(Color.Red);
            if (cb_DashCap.SelectedItem != null)
            {
                currentPen.DashCap = (System.Drawing.Drawing2D.DashCap)cb_DashCap.SelectedItem;
            }
            if (cb_DashStyle.SelectedItem != null)
            {
                currentPen.DashStyle = (System.Drawing.Drawing2D.DashStyle)cb_DashStyle.SelectedItem;
            }
            if (cb_StartCap.SelectedItem != null)
            {
                currentPen.StartCap = (System.Drawing.Drawing2D.LineCap)cb_StartCap.SelectedItem;
            }
            if (cb_EndCap.SelectedItem != null)
            {
                currentPen.EndCap = (System.Drawing.Drawing2D.LineCap)cb_EndCap.SelectedItem;
            }
            if (cb_LineJoin.SelectedItem != null)
            {
                currentPen.LineJoin = (System.Drawing.Drawing2D.LineJoin)cb_LineJoin.SelectedItem;
            }
            if (cb_Width.SelectedItem != null)
            {
                currentPen.Width = (int)cb_Width.SelectedItem;
            }
            
        }
        static Graphics penDemo;
        static GraphicsPath pathDemo;
        static Point start, end;
        static Pen currentPen;
        public Form1()
        {
            InitializeComponent();
            InitializeDashStyleCombobox();
            InitializeWidthCombobox();
            InitializeLineJoinCombobox();
            InitializeDashCapCombobox();
            InitializeStartEndCapComboboxes();
            penDemo = drawingSpace.CreateGraphics();
            pathDemo = new GraphicsPath();
           
        }

        private void DashStyleChangedEvent(object sender, EventArgs e)
        {
            DrawPen();
        }

        private void WidthChangedEvent(object sender, EventArgs e)
        {
            DrawPen();
        }

        private void LineJoinChangedEvent(object sender, EventArgs e)
        {
            DrawPen();
        }

        private void DashCapChangeEvent(object sender, EventArgs e)
        {
            DrawPen();
        }

        private void StartCapChangedEvent(object sender, EventArgs e)
        {
            DrawPen();
        }

        private void EndCapChangedEvent(object sender, EventArgs e)
        {
            DrawPen();
        }
        
        private void drawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (start == null || start.Equals(new Point(0, 0)))
                {
                    start = new Point(e.X, e.Y);
                    return;
                }
                else if (end == null || end.Equals(new Point(0, 0)))
                {
                    end = new Point(e.X, e.Y);
                    penDemo.Clear(Color.White);
                    pathDemo.AddLine(start, end);
                    penDemo.DrawPath(currentPen, pathDemo);
                    start = new Point(end.X, end.Y);
                    end = new Point(0, 0);
                    return;
                }
               
            }
            else if (e.Button == MouseButtons.Right)
            {
                start = new Point(0, 0);
                end = new Point(0, 0);
                pathDemo = new GraphicsPath();
            }
        }
    }
}
