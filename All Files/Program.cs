using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Timers;
using System.ComponentModel;
using System.Data;
using System.Collections.ObjectModel;

namespace _21520620_NguyenTuanBao_KTGK
{
    internal class Program
    {
        // Khai bao cac object su dung (public static)
        // Thread temp = new Thread((ThreadStart)( () => function used ))
        // Cac thao tac Thread: start => chay tieu trinh, join => hop tieu trinh (tieu trinh chay xong moi chay tiep)
        // setApartmentState -> chay tren thread khac ?
        public static Form form = new Form();
        public static string[] alphabet =
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L"
            ,"M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
            "W", "X", "Y", "Z"
        };
        // A-0 => Z-25
        public int indexOfAlphabet(string alphabetCharacter)
        {
            return Array.IndexOf(alphabet, alphabetCharacter);
        }
        public static MenuStrip menuStrip = new MenuStrip();
        public static ToolStripMenuItem New = new ToolStripMenuItem();
        public static ToolStripMenuItem Load = new ToolStripMenuItem();
        public static ToolStripMenuItem Save = new ToolStripMenuItem();
        public static ToolStripMenuItem File = new ToolStripMenuItem();
        public static ToolStripMenuItem SaveAs = new ToolStripMenuItem();

        public static TextBox tb_Display = new TextBox();
        // Start as 60
        public static TextBox[,] tb_ExcelArray = new TextBox[50, 26];
        public static Label[] lb_ColumnHeaders = new Label[26];
        public static Label[] lb_RowHeaders = new Label[50];
        public static string outputFilePath = Directory.GetCurrentDirectory();
        public static string inputFilePath;
        public static List<string> lines = new List<string>();
        public static List<TextBox> listWorkingCells = new List<TextBox>();
        public static void InitExcelColumnHeaders()
        {
            int currXLocation = 30;
            int currYLocation = 60;
            for (int j = 0; j < 26; j++)
            {
                lb_ColumnHeaders[j] = new Label();
                lb_ColumnHeaders[j].Size = new System.Drawing.Size(30, 20);
                lb_ColumnHeaders[j].Location = new Point(currXLocation, currYLocation);
                lb_ColumnHeaders[j].Text = alphabet[j];
                currXLocation += 30;
                form.Controls.Add(lb_ColumnHeaders[j]);
            }
        }

        public static void InitExcelRowHeaders()
        {
            int currXLocation = 0;
            int currYLocation = 80;
            for (int i = 0; i < 50; i++)
            {
                lb_RowHeaders[i] = new Label();
                lb_RowHeaders[i].Size = new System.Drawing.Size(30, 20);
                lb_RowHeaders[i].Location = new Point(currXLocation, currYLocation);
                lb_RowHeaders[i].Text = (i + 1).ToString();
                currYLocation += 20;
                form.Controls.Add(lb_RowHeaders[i]);
            }
        }

        public static void InitExcelArray()
        {
            int currXLocation = 30;
            int currYLocation = 80;
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    tb_ExcelArray[i, j] = new TextBox();
                    tb_ExcelArray[i, j].Size = new System.Drawing.Size(30, 20);
                    tb_ExcelArray[i, j].Location = new Point(currXLocation, currYLocation);
                    tb_ExcelArray[i, j].Click += new EventHandler(EventClickCell);

                    tb_ExcelArray[i, j].KeyDown += new KeyEventHandler(EnterEventKeyDown);

                    currXLocation += 30;
                    form.Controls.Add(tb_ExcelArray[i, j]);
                }
                currXLocation = 30;
                currYLocation += 20;
            }
        }

        private static void EnterEventKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listWorkingCells.Count <= 1) return;
                int testVal;
                bool isNumeric = false;
                bool isString = false;
                int resultNumeric = 0;
                string resultString = "";
                if (int.TryParse(listWorkingCells[0].Text, out testVal) == true)
                {
                    isNumeric = true;
                }
                else isString = true;
                try
                {
                    if (isNumeric == true)
                    {
                        foreach (var textBox in listWorkingCells)
                        {
                            resultNumeric += int.Parse(textBox.Text);
                        }
                        tb_Display.Text = resultNumeric.ToString() ;
                    }
                    else
                    {
                        foreach (var textBox in listWorkingCells)
                        {
                            resultString += textBox.Text;
                        }
                        tb_Display.Text = resultString.ToString() ;
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static int[] returnCellCoordinates(TextBox tb)
        {
            int[] res = new int[2];
            res[0] = -1;
            res[1] = -1;
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (tb_ExcelArray[i, j].Equals(tb))
                    {
                        res[0] = i;
                        res[1] = j;
                        break;
                    }
                }
            }
            return res;
        }
        private static void EventClickCell(Object obj, EventArgs ea)
        {
            tb_Display.Clear();
            TextBox tb = (TextBox)obj;
            try
            {
                listWorkingCells.Add((TextBox)obj);
                tb_Display.Text = "= ";
                bool firstTime = true;
                foreach(var textBox in listWorkingCells)
                {
                    if (firstTime == true)
                    {
                        tb_Display.Text += alphabet[returnCellCoordinates(textBox)[1]] + (returnCellCoordinates(textBox)[0] + 1).ToString();
                        firstTime = false;
                    }
                    else
                    {
                        tb_Display.Text += " + " + alphabet[returnCellCoordinates(textBox)[1]] + (returnCellCoordinates(textBox)[0] + 1).ToString();
                    }
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ResetExcelArray()
        {
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    form.Controls.Remove(tb_ExcelArray[i, j]);
                }
            }
        }

       

        public static void EventClickNew(Object obj, EventArgs ea)
        {
            ResetExcelArray();
            InitExcelArray();
            InitExcelColumnHeaders();
            InitExcelRowHeaders();
        }

        public static void EventClickLoad(Object obj, EventArgs ea)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFilePath = openFileDialog.FileName;
            }
            lines = new List<string>();
            lines = System.IO.File.ReadAllLines(inputFilePath).ToList();
            
            for (int i = 0; i < lines.Count; i++)
            {
                string[] line = lines[i].Split('|');
                string[] trimLine;
                try
                {
                    for (int j = 1; j < 26; j++)
                    {
                        tb_ExcelArray[i, j - 1].Text = line[j].ToString();
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void EventClickSave(Object obj, EventArgs ea)
        {
            WriteToFile();
        }

        private static void WriteToFile()
        {
            System.Text.StringBuilder buffer = new System.Text.StringBuilder();

            string line = "";
            for (int i = 0; i < 50; i++)
            {
                line = "|";
                for (int j = 0; j < 26; j++)
                {
                    line = line + tb_ExcelArray[i, j].Text + "|";
                }
                buffer.AppendLine(line);
            }

            System.IO.File.WriteAllText(outputFilePath, buffer.ToString());
        }

        public static void EventClickSaveAs(Object obj, EventArgs ea)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"TXT|*.txt" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFilePath = saveFileDialog.FileName;
                }
            }
            WriteToFile();
        }

        [STAThread]
        static void Main(string[] args)
        {
            

            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            File});
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Size = new System.Drawing.Size(800, 28);
            menuStrip.TabIndex = 0;


            File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            New, Load, Save, SaveAs});
            File.Size = new System.Drawing.Size(46, 24);
            File.Text = "File";

            Load.Size = new System.Drawing.Size(224, 26);
            Load.Text = "Load";
            Load.Click += new EventHandler(EventClickLoad);

            Save.Size = new System.Drawing.Size(224, 26);
            Save.Text = "Save";
            Save.Click += new EventHandler(EventClickSave);

            SaveAs.Size = new System.Drawing.Size(224, 26);
            SaveAs.Text = "Save As";
            SaveAs.Click += new EventHandler(EventClickSaveAs);

            New.Size = new System.Drawing.Size(224, 26);
            New.Text = "New";
            New.Click += new EventHandler(EventClickNew);

            tb_Display.Location = new System.Drawing.Point(0, 32);
            tb_Display.Size = new System.Drawing.Size(800, 22);
            tb_Display.ReadOnly = true;

            form.Controls.Add(tb_Display);
            form.Controls.Add(menuStrip);
            form.Height = 818;
            form.Width = 800;
            form.Text = "My Excel";

            InitExcelArray();
            InitExcelRowHeaders();
            InitExcelColumnHeaders();
            form.AutoSize = true;
            form.AutoScroll = true;
            Application.Run(form);
        }
    }
    }
