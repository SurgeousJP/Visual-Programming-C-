using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.IO;
using System;
using System.Drawing.Imaging;
using System.Collections.Generic;
namespace KTCL
{
    internal class Program
    {

        const int DEFAULT_WIDTH = 100;
        const int DEFAULT_HEIGHT = 80;
        static Form bt_calculator = new Form();
        
        static Button[] bt_nums = new Button[10];

        static Button bt_opposite = new Button();
        static Button bt_decimal_pt = new Button();

        static Button bt_equal = new Button();
        static Button bt_add = new Button();
        static Button bt_subtract = new Button();
        static Button bt_mul = new Button();
        static Button bt_div = new Button();

        static Button bt_erase = new Button();
        static Button bt_delete_recent = new Button();
        static Button bt_delete_all = new Button();
        static Button bt_percentage = new Button();
        static Button bt_reverse = new Button();
        static Button bt_square = new Button();
        static Button bt_square_root = new Button();
        
        static Button bt_memClear = new Button();
        static Button bt_memRecall = new Button();
        static Button bt_memPlus = new Button();
        static Button bt_memSub = new Button();
        static Button bt_memSave = new Button();

        static TextBox tb_enterInput = new TextBox();
        public static void Zero(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text += "0";
        }
        public static void One(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text += "1";
        }
        public static void Two(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text += "2";
        }
        public static void Three(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text += "3";
        }
        public static void Four(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text += "4";
        }
        public static void Five(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text += "5";
        }
        public static void Six(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text += "6";
        }
        public static void Seven(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text += "7";
        }
        public static void Eight(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text += "8";
        }
        public static void Nine(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text += "9";
        }
        static Queue<float> q = new Queue<float>();
        static string Operation;
        public static void Opposite(Object? obj, EventArgs ea)
        {
            if (!tb_enterInput.Text.Contains('-')) tb_enterInput.Text = "-" + tb_enterInput.Text;
            else tb_enterInput.Text = tb_enterInput.Text.Remove(tb_enterInput.Text.IndexOf('-'),1);
        }
        public static void Decimal(Object? obj, EventArgs ea)
        {
            if (!tb_enterInput.Text.Contains(','))
            {
                tb_enterInput.Text += ",";
            }
        }
        public static void Reverse(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text = (1.0 / float.Parse(tb_enterInput.Text)).ToString();
        }

        public static void Square(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text = (float.Parse(tb_enterInput.Text) * float.Parse(tb_enterInput.Text)).ToString();
        }
        public static void Square_Root(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text = (Math.Sqrt(float.Parse(tb_enterInput.Text))).ToString();
        }
        public static void Delete_All(Object? obj, EventArgs ea)
        {
            tb_enterInput.Text = "";
            q = new Queue<float>();
        }
        //public static void TextChange(Object? obj, EventArgs ea)
        //{
        //    try
        //    {
        //        if (tb_enterInput.Text != "")
                
        //        MessageBox.Show(tb_enterInput.Text);
        //    }
        //    catch(Exception ex){
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        public static void Addition(Object? obj, EventArgs ea)
        {
            Operation = "+";
            q.Enqueue(float.Parse(tb_enterInput.Text));
            tb_enterInput.Text = "";
            if (q.Count < 2)
            {
                tb_enterInput.Text = "";
                return;
            }
            else
            {
                float f1 = q.Dequeue();
                float f2 = q.Dequeue();
                tb_enterInput.Text = (f1 + f2).ToString();
            }
            
        }

        public static void Subtraction(Object? obj, EventArgs ea)
        {
            Operation = "-";
            q.Enqueue(float.Parse(tb_enterInput.Text));
            tb_enterInput.Text = "";
            if (q.Count < 2)
            {
                tb_enterInput.Text = "";
                return;
            }
            else
            {
                float f1 = q.Dequeue();
                float f2 = q.Dequeue();
                tb_enterInput.Text = (f1 - f2).ToString();
            }

        }
        public static void Multiplication(Object? obj, EventArgs ea)
        {
            Operation = "*";
            q.Enqueue(float.Parse(tb_enterInput.Text));
            tb_enterInput.Text = "";
            if (q.Count < 2)
            {
                tb_enterInput.Text = "";
                return;
            }
            else
            {
                float f1 = q.Dequeue();
                float f2 = q.Dequeue();
                tb_enterInput.Text = (f1 * f2).ToString();
            }

        }
        public static void Division(Object? obj, EventArgs ea)
        {
            Operation = "/";
            q.Enqueue(float.Parse(tb_enterInput.Text));
            tb_enterInput.Text = "";
            if (q.Count < 2)
            {
                tb_enterInput.Text = "";
                return;
            }
            else
            {
                float f1 = q.Dequeue();
                float f2 = q.Dequeue();
                tb_enterInput.Text = (f1 / f2).ToString();
            }

        }
        public static void Equal(Object? obj, EventArgs ea)
        {
            if (q.Count == 0)
            {
                tb_enterInput.Text = "0";
            }
            else if (q.Count == 1)
            {
                tb_enterInput.Text = q.Dequeue().ToString();
            }
            else
            {
                float f1 = q.Dequeue();
                float f2 = q.Dequeue();
                
                switch (Operation)
                {
                    case "+":
                        tb_enterInput.Text = (f1 + f2).ToString();
                        break;
                    case "-":
                        tb_enterInput.Text = (f1 - f2).ToString();
                        break;
                    case "*":
                        tb_enterInput.Text = (f1 * f2).ToString();
                        break;
                    case "/":
                        tb_enterInput.Text = (f1 / f2).ToString();
                        break;
                }
                q = new Queue<float>();
            }
        }
        static void Main(string[] args)
        {
            bt_calculator.Size = new System.Drawing.Size(400, 710);
            bt_calculator.AutoSize = true;
            int xLoc = 0;
            int yLoc = 710 - DEFAULT_HEIGHT;
            for (int i = 0; i <= 9; i++)
            {
                bt_nums[i] = new Button();
                bt_nums[i].Text = i.ToString();
                bt_nums[i].Width = DEFAULT_WIDTH;
                bt_nums[i].Height = DEFAULT_HEIGHT;
            }
            bt_nums[0].Location = new Point(100, 630);
            bt_nums[0].Click += new EventHandler(Zero);

            bt_nums[1].Location = new Point(0, 630 - 80);
            bt_nums[1].Click += new EventHandler(One);

            bt_nums[2].Location = new Point(100, 630 - 80);
            bt_nums[2].Click += new EventHandler(Two);

            bt_nums[3].Location = new Point(200, 630 - 80);
            bt_nums[3].Click += new EventHandler(Three);

            bt_nums[4].Location = new Point(0, 630 - 160);
            bt_nums[4].Click += new EventHandler(Four);

            bt_nums[5].Location = new Point(100, 630 - 160);
            bt_nums[5].Click += new EventHandler(Five);

            bt_nums[6].Location = new Point(200, 630 - 160);
            bt_nums[6].Click += new EventHandler(Six);

            bt_nums[7].Location = new Point(0, 630 - 240);
            bt_nums[7].Click += new EventHandler(Seven);

            bt_nums[8].Location = new Point(100, 630 - 240);
            bt_nums[8].Click += new EventHandler(Eight);

            bt_nums[9].Location = new Point(200, 630 - 240);
            bt_nums[9].Click += new EventHandler(Nine);

            for (int i = 0; i < 10; i++)
            {
                bt_calculator.Controls.Add(bt_nums[i]);
            }
            

            bt_opposite.Text = "+/-";
            bt_opposite.Width = DEFAULT_WIDTH;
            bt_opposite.Height = DEFAULT_HEIGHT;
            bt_opposite.Location = new Point(0, 630);
            bt_opposite.Click += new EventHandler(Opposite);

            bt_decimal_pt.Text = ".";
            bt_decimal_pt.Width = DEFAULT_WIDTH;
            bt_decimal_pt.Height = DEFAULT_HEIGHT;
            bt_decimal_pt.Location = new Point(200, 630);
            bt_decimal_pt.Click += new EventHandler(Decimal);

            bt_equal.Text = "=";
            bt_equal.Width = DEFAULT_WIDTH;
            bt_equal.Height = DEFAULT_HEIGHT;
            bt_equal.Location = new Point(300, 630);
            bt_equal.Click += new EventHandler(Equal);
            bt_add.Text = "+";
            bt_add.Width = DEFAULT_WIDTH;
            bt_add.Height = DEFAULT_HEIGHT;
            bt_add.Location = new Point(300, 630 - 80);
            bt_add.Click += new EventHandler(Addition);

            bt_subtract.Text = "-";
            bt_subtract.Width = DEFAULT_WIDTH;
            bt_subtract.Height = DEFAULT_HEIGHT;
            bt_subtract.Location = new Point(300, 630 - 80 * 2);
            bt_subtract.Click += new EventHandler(Subtraction);

            bt_mul.Text = "*";
            bt_mul.Width = DEFAULT_WIDTH;
            bt_mul.Height = DEFAULT_HEIGHT;
            bt_mul.Location = new Point(300, 630 - 80 * 3);
            bt_mul.Click += new EventHandler(Multiplication);

            bt_div.Text = "/";
            bt_div.Width = DEFAULT_WIDTH;
            bt_div.Height = DEFAULT_HEIGHT;
            bt_div.Location = new Point(300, 630 - 80 * 4);
            bt_div.Click += new EventHandler(Division);

            bt_calculator.Controls.Add(bt_opposite);
            bt_calculator.Controls.Add(bt_decimal_pt);
            bt_calculator.Controls.Add(bt_equal);
            bt_calculator.Controls.Add(bt_add);
            bt_calculator.Controls.Add(bt_subtract);
            bt_calculator.Controls.Add(bt_div);
            bt_calculator.Controls.Add(bt_mul);

            bt_reverse.Text = "1/x";
            bt_reverse.Width = DEFAULT_WIDTH;
            bt_reverse.Height = DEFAULT_HEIGHT;
            bt_reverse.Location = new Point(0, 310);
            bt_reverse.Click += new EventHandler(Reverse);

            bt_square.Text = "x^2";
            bt_square.Width = DEFAULT_WIDTH;
            bt_square.Height = DEFAULT_HEIGHT;
            bt_square.Location = new Point(100, 310);
            bt_square.Click += new EventHandler(Square);

            bt_square_root.Text = "sqrt(x)";
            bt_square_root.Width = DEFAULT_WIDTH;
            bt_square_root.Height = DEFAULT_HEIGHT;
            bt_square_root.Location = new Point(200, 310);
            bt_square_root.Click += new EventHandler(Square_Root);

            bt_calculator.Controls.Add(bt_reverse);
            bt_calculator.Controls.Add(bt_square);
            bt_calculator.Controls.Add(bt_square_root);

            bt_percentage.Text = "%";
            bt_percentage.Width = DEFAULT_WIDTH;
            bt_percentage.Height = DEFAULT_HEIGHT;
            bt_percentage.Location = new Point(0, 230);

            bt_delete_recent.Text = "CE";
            bt_delete_recent.Width = DEFAULT_WIDTH;
            bt_delete_recent.Height = DEFAULT_HEIGHT;
            bt_delete_recent.Location = new Point(100, 230);

            bt_delete_all.Text = "C";
            bt_delete_all.Width = DEFAULT_WIDTH;
            bt_delete_all.Height = DEFAULT_HEIGHT;
            bt_delete_all.Location = new Point(200, 230);
            bt_delete_all.Click += new EventHandler(Delete_All);

            bt_erase.Text = "<x>";
            bt_erase.Width = DEFAULT_WIDTH;
            bt_erase.Height = DEFAULT_HEIGHT;
            bt_erase.Location = new Point(300, 230);

            bt_calculator.Controls.Add(bt_erase);
            bt_calculator.Controls.Add(bt_percentage);
            bt_calculator.Controls.Add(bt_delete_recent);
            bt_calculator.Controls.Add(bt_delete_all);
            bt_calculator.Controls.Add(bt_erase);

            bt_memClear.Text = "MC";
            bt_memRecall.Text = "MR";
            bt_memPlus.Text = "M+";
            bt_memSub.Text = "M-";
            bt_memSave.Text = "MS";

            bt_memClear.Width = DEFAULT_WIDTH - 20;
            bt_memClear.Height = DEFAULT_HEIGHT;
            bt_memClear.Location = new Point(0, 150);

            bt_memRecall.Width = DEFAULT_WIDTH - 20;
            bt_memRecall.Height = DEFAULT_HEIGHT;
            bt_memRecall.Location = new Point(80, 150);

            bt_memPlus.Width = DEFAULT_WIDTH - 20;
            bt_memPlus.Height = DEFAULT_HEIGHT;
            bt_memPlus.Location = new Point(160, 150);

            bt_memSub.Width = DEFAULT_WIDTH - 20;
            bt_memSub.Height = DEFAULT_HEIGHT;
            bt_memSub.Location = new Point(240, 150);

            bt_memSave.Width = DEFAULT_WIDTH - 20;
            bt_memSave.Height = DEFAULT_HEIGHT;
            bt_memSave.Location = new Point(320, 150);

            tb_enterInput.Location = new Point(0, 0);
            tb_enterInput.Width = 400;
            tb_enterInput.Height = 150;
            tb_enterInput.Text = "";
            tb_enterInput.ReadOnly = true;
            // tb_enterInput.TextChanged += new EventHandler(TextChange);
            
            bt_calculator.Controls.Add(bt_memClear);
            bt_calculator.Controls.Add(bt_memRecall);
            bt_calculator.Controls.Add(bt_memPlus);
            bt_calculator.Controls.Add(bt_memSub);
            bt_calculator.Controls.Add(bt_memSave);
            bt_calculator.Controls.Add(tb_enterInput);

            Application.Run(bt_calculator);
        }
        

    }
}