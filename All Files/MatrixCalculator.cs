using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
namespace Demo_C_Sharp_2
{
    internal class Program
    {
        static Label EnterDim = new Label();
        static Form form = new Form();
        static ComboBox MatDim = new ComboBox();
        static ComboBox CalcChoice = new ComboBox();
        static Button Calc = new Button();
        static int selectedDim = new int();
        static void Main(string[] args)
        {
            EnterDim.Text = "So chieu ma tran";
            EnterDim.Location = new Point(20, 10);

            form.Width = 800;
            form.Height = 500;
            MatDim.Location = new Point(100, 10);
            MatDim.Size = new System.Drawing.Size(100, 20);
            MatDim.Items.Add("2");
            MatDim.Items.Add("3");
            MatDim.Items.Add("4");
            MatDim.Items.Add("5");

            MatDim.SelectedIndexChanged += new System.EventHandler(ComboBox_SelectedIndexChanged);

            form.Controls.Add(EnterDim);
            form.Controls.Add(MatDim);

            Calc.Click += new System.EventHandler(Calc_ClickOn);

            Application.Run(form);
        }
        static TextBox[,] mat_arr_A, mat_arr_B, mat_arr_C;
        static int[,] matA, matB, matC;
        public static void ConvertToMat(TextBox[,] mat_arr, int MatDim, ref int[,] mat)
        {
            mat = new int[MatDim, MatDim];

            for (int i = 0; i < MatDim; i++)
            {
                for (int j = 0; j < MatDim; j++)
                {
                    mat[i, j] = new int();
                    mat[i, j] = int.Parse(mat_arr[i, j].Text.ToString());
                }
            }
        }
        public static void MatAddition(int[,] mat1, int[,] mat2, int MatDim)
        {
            int[,] mat = new int[MatDim, MatDim];
            for (int i = 0; i < MatDim; i++)
            {
                for (int j = 0; j < MatDim; j++)
                {
                    mat[i, j] = new int();
                    mat[i, j] = mat1[i, j] + mat2[i, j];
                    
                }
            }
            int x = 540;
            int y = 60;
            for (int i = 0; i < MatDim; i++)
            {
                for (int j = 0; j < MatDim; j++)
                {
                    mat_arr_C[i, j] = new TextBox() { Text = mat[i, j].ToString() };
                    mat_arr_C[i, j].Location = new Point(x, y);
                    mat_arr_C[i, j].Size = new System.Drawing.Size(30, 30);
                    form.Controls.Add(mat_arr_C[i, j]);
                    x += 30;
                }
                y += 30;
                x = 540;
            }
            
        }

        public static void MatMultiplication(int[,] mat1, int[,] mat2, int MatDim)
        {

            int[,] mat = new int[MatDim, MatDim];

            TextBox[,] res = new TextBox[MatDim, MatDim];
            for (int i = 0; i < MatDim; i++)
            {
                for (int j = 0; j < MatDim; j++)
                {
                    mat[i, j] = 0;
                }
            }

            for (int i = 0; i < MatDim; i++)
            {
                for (int j = 0; j < MatDim; j++)
                {
                    for (int k = 0; k < MatDim; k++)
                    {
                        mat[i, j] += mat1[i, k] * mat2[k, j];
                    }
                }
            }

            int x = 540;
            int y = 60;
            for (int i = 0; i < MatDim; i++)
            {
                for (int j = 0; j < MatDim; j++)
                {
                    mat_arr_C[i, j] = new TextBox() { Text = mat[i, j].ToString() };
                    mat_arr_C[i, j].Location = new Point(x, y);
                    mat_arr_C[i, j].Size = new System.Drawing.Size(30, 30);
                    form.Controls.Add(mat_arr_C[i, j]);
                    x += 30;
                }
                y += 30;
                x = 540;
            }


        }

        public static void Drawing_Mat(int xLoc, int yLoc, int MatDim, TextBox[,] mat_arr)
        {
            int x = xLoc;
            int y = yLoc;
            for (int i = 0; i < MatDim; i++)
            {
                for (int j = 0; j < MatDim; j++)
                {
                    mat_arr[i, j] = new TextBox();
                    mat_arr[i, j].Location = new Point(x, y);
                    mat_arr[i, j].Size = new System.Drawing.Size(30, 30);
                    form.Controls.Add(mat_arr[i, j]);
                    x += 30;
                }
                y += 30;
                x = xLoc;
            }
        }
        private static void TextBoxChanged(object sender, System.EventArgs e)
        {

        }
        private static void ComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox combobox = (ComboBox) sender;
            selectedDim = int.Parse((string)combobox.SelectedItem);

            mat_arr_A = new TextBox[selectedDim, selectedDim];
            mat_arr_B = new TextBox[selectedDim, selectedDim];
            mat_arr_C = new TextBox[selectedDim, selectedDim];

            CalcChoice.Size = new System.Drawing.Size(40, 20);
            CalcChoice.Items.Add("+");
            CalcChoice.Items.Add("x");
            CalcChoice.Location = new Point((300 + (60 + (selectedDim - 1) * 30))/2 ,60 + 30 * selectedDim / 2);
            form.Controls.Add(CalcChoice);

            Calc.Size = new System.Drawing.Size(40, 20);
            Calc.Text = "=";
            Calc.Location = new Point((540 + (300 + (selectedDim - 1) * 30)) / 2, 60 + 30 * selectedDim / 2);
            form.Controls.Add(Calc);

            Drawing_Mat(60, 60, selectedDim, mat_arr_A);
            Drawing_Mat(300, 60, selectedDim, mat_arr_B);

        }
        private static void Calc_ClickOn(object sender, System.EventArgs e)
        {
            matA = new int[selectedDim, selectedDim];
            matB = new int[selectedDim, selectedDim];
            ConvertToMat(mat_arr_A, selectedDim, ref matA);
            ConvertToMat(mat_arr_B, selectedDim, ref matB);
            if (CalcChoice.SelectedItem == "+")
            {
                MatAddition(matA, matB, selectedDim);
            }
            else if (CalcChoice.SelectedItem == "x")
            {
                MatMultiplication(matA, matB, selectedDim);
            }
        }
    }

}
