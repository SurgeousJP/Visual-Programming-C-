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
        public static Button btn_ThemNganhHang = new Button();
        public static Button btn_ThemMH = new Button();
        public static Button btn_LoadFile = new Button();
        public static Button btn_SaveFile = new Button();

        public static TreeView treeMH = new TreeView();

        public static Label lb_MS = new Label();
        public static Label lb_Ten = new Label();
        public static Label lb_GiaBan = new Label();
        public static TextBox tb_MS = new TextBox();
        public static TextBox tb_Ten = new TextBox();
        public static TextBox tb_GiaBan = new TextBox();

        public static string filePath;
        public static string outputFilePath;
        public static List<string> lines;

        public static TreeNode parentNode = null;
        public static TreeNode addNode = null;
        public static Button btn_OK = new Button();
        public static Label customlb_MS = new Label();
        public static Label customlb_Ten = new Label();
        public static Label customlb_Parent = new Label();
        public static Label customlb_GiaBan = new Label();
        public static TextBox customtb_MS = new TextBox();
        public static TextBox customtb_Ten = new TextBox();
        public static TextBox customtb_GiaBan = new TextBox();
        public static TextBox customtb_Parent = new TextBox();
        public static void OK_EventMatHang(Object sender, EventArgs ea)
        {
            
            string keyMatHang = customtb_MS.Text;
            string keyParent = customtb_Parent.Text;
            string name = customtb_Ten.Text;
            float price = float.Parse(customtb_GiaBan.Text);
            parentNode = new TreeNode();
            addNode = new TreeNode();
            if (false == nodeCache.TryGetValue(keyParent, out parentNode))
            {
                MessageBox.Show("Khong tim thay nganh hang , Error !!!");
            }
            else
            {
                addNode = new TreeNode();
                addNode.Text = name;
                string[] info = { keyMatHang, keyParent, price.ToString() };
                Data.Add(name, info);
            }
        }
        public static void OK_EventNganhHang(Object sender, EventArgs ea)
        {
            string keyMatHang = customtb_MS.Text;
            string keyParent = customtb_Parent.Text;
            string name = customtb_Ten.Text;
            parentNode = new TreeNode();
            addNode = new TreeNode();
            addNode.Text = name;
            string[] info = { keyMatHang, keyParent, "" };
            Data.Add(name, info);
            if (false == nodeCache.TryGetValue(keyParent, out parentNode))
            {
                // do nothing 
            }
            else
            {
                // do nothing
            }
        }

        public static Thread t = new Thread((ThreadStart)(() =>
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
        }));

        public static Thread s = new Thread((ThreadStart)(() =>
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"TXT|*.txt" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFilePath = saveFileDialog.FileName;
                }
            }
        }));
        public static Dictionary<string, TreeNode> nodeCache = new Dictionary<string, TreeNode>();
        public static ObservableCollection<TreeNode> mRootNodes = new ObservableCollection<TreeNode>();
        public static Dictionary<string, string[]> Data = new Dictionary<string, string[]>();

        public static Thread add = new Thread((ThreadStart)(() =>
        {
            Form customDialog = new Form();
            customDialog.Size = new Size(800, 800);

            btn_OK = new Button();
            customlb_MS = new Label();
            customlb_Ten = new Label();
            customlb_Parent = new Label();
            customlb_GiaBan = new Label();
            customtb_MS = new TextBox();
            customtb_Ten = new TextBox();
            customtb_GiaBan = new TextBox();
            customtb_Parent = new TextBox();

            btn_OK.Location = new Point(397, 300);
            btn_OK.Text = "OK";
            btn_OK.Width = 100;
            btn_OK.Height = 100;
            btn_OK.Click += new EventHandler(OK_EventMatHang);

            customlb_MS.Text = "Ma so";
            customlb_MS.Location = new Point(397, 81);
            customlb_MS.Width = 44;
            customlb_MS.Height = 16;

            customlb_Ten.Text = "Ten";
            customlb_Ten.Location = new Point(397, 135);
            customlb_Ten.Width = 44;
            customlb_Ten.Height = 16;

            customlb_GiaBan.Text = "Gia ban";
            customlb_GiaBan.Location = new Point(380, 184);
            customlb_GiaBan.Width = 60;
            customlb_GiaBan.Height = 25;

            customtb_MS.Location = new Point(483, 81);
            customtb_MS.Width = 246;
            customtb_MS.Height = 22;

            customtb_Ten.Location = new Point(483, 135);
            customtb_Ten.Width = 246;
            customtb_Ten.Height = 22;

            customtb_GiaBan.Location = new Point(483, 184);
            customtb_GiaBan.Width = 246;
            customtb_GiaBan.Height = 22;

            customlb_Parent.Text = "Cha";
            customlb_Parent.Location = new Point(397, 250);
            customlb_Parent.Width = 44;
            customlb_Parent.Height = 16;

            customtb_Parent.Location = new Point(483, 250);
            customtb_Parent.Width = 246;
            customtb_Parent.Height = 22;

            customDialog.Controls.Add(customlb_Parent);
            customDialog.Controls.Add(customtb_Parent);
            customDialog.Controls.Add(customlb_MS);
            customDialog.Controls.Add(customtb_GiaBan);
            customDialog.Controls.Add(customtb_Ten);
            customDialog.Controls.Add(customtb_MS);
            customDialog.Controls.Add(customlb_Ten);
            customDialog.Controls.Add(customlb_GiaBan);
            customDialog.Controls.Add(btn_OK);
            customDialog.ShowDialog();
            customDialog.Close();
        }));
        public static Thread addNganh = new Thread((ThreadStart)(() =>
        {
            Form customDialog = new Form();
            customDialog.Size = new Size(800, 800);

            btn_OK = new Button();
            customlb_MS = new Label();
            customlb_Ten = new Label();
            customlb_Parent = new Label();
            customlb_GiaBan = new Label();
            customtb_MS = new TextBox();
            customtb_Ten = new TextBox();
            customtb_GiaBan = new TextBox();
            customtb_Parent = new TextBox();

            btn_OK.Location = new Point(397, 300);
            btn_OK.Text = "OK";
            btn_OK.Width = 100;
            btn_OK.Height = 100;
            btn_OK.Click += new EventHandler(OK_EventNganhHang);

            customlb_MS.Text = "Ma so";
            customlb_MS.Location = new Point(397, 81);
            customlb_MS.Width = 44;
            customlb_MS.Height = 16;

            customlb_Ten.Text = "Ten";
            customlb_Ten.Location = new Point(397, 135);
            customlb_Ten.Width = 44;
            customlb_Ten.Height = 16;

            customtb_MS.Location = new Point(483, 81);
            customtb_MS.Width = 246;
            customtb_MS.Height = 22;

            customtb_Ten.Location = new Point(483, 135);
            customtb_Ten.Width = 246;
            customtb_Ten.Height = 22;

            customlb_Parent.Text = "Cha";
            customlb_Parent.Location = new Point(397, 250);
            customlb_Parent.Width = 44;
            customlb_Parent.Height = 16;

            customtb_Parent.Location = new Point(483, 250);
            customtb_Parent.Width = 246;
            customtb_Parent.Height = 22;

            customDialog.Controls.Add(customlb_Parent);
            customDialog.Controls.Add(customtb_Parent);
            customDialog.Controls.Add(customlb_MS);
            customDialog.Controls.Add(customtb_Ten);
            customDialog.Controls.Add(customtb_MS);
            customDialog.Controls.Add(customlb_Ten);
            customDialog.Controls.Add(btn_OK);
            customDialog.ShowDialog();
            customDialog.Close();
        }));
        public static void btn_ReadFile(Object obj, EventArgs ea)
        {
            try
            {
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();
            }
            catch
            {

            }
            // Using filePath & treeView1
            lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            treeMH.Nodes.Clear();

            foreach (var line in lines)
            {
                TreeNode parentNode = null;
                string key = null;
                string[] line_split = line.Split('|');
                string[] pair = { line_split[0], line_split[1] };
                string[] arr = new string[3];
                arr[0] = line_split[0];
                arr[1] = line_split[2];
                if (line_split.Length > 3)
                {
                    arr[2] = line_split[3];
                }
                else arr[2] = "";

                // in each line there are one or more node names, separated by | char
                string childNodeName = pair[0];
                TreeNode childNode;
                // names are not unique, we need a composite key (full node path)
                key = childNodeName;

                // each node has unique key
                // if key doesn't exists in cache, we need to create new child node
                if (false == nodeCache.TryGetValue(key, out childNode))
                {
                    childNode = new TreeNode { Name = childNodeName };
                    nodeCache.Add(key, childNode);

                    if (true == nodeCache.TryGetValue(pair[1], out parentNode))
                    {
                        // each node (exept root) has a parent
                        // we need to add a child node to parent ChildRen collection
                        parentNode.Nodes.Add(childNode);
                        childNode.Text = line_split[2];
                    }

                    else
                    {
                        // root nodes are stored in a separate collection
                        mRootNodes.Add(childNode);
                        childNode.Text = line_split[2];
                        
                        treeMH.Nodes.Add(childNode);
                    }
                    Data.Add(line_split[2], arr);
                }

                
            } 
        }
        
        public static void btn_AfterSelect(Object obj, TreeViewEventArgs ea)
        {
            tb_MS.Text = Data[treeMH.SelectedNode.Text][0];
            tb_Ten.Text = Data[treeMH.SelectedNode.Text][1];
            tb_GiaBan.Text = Data[treeMH.SelectedNode.Text][2];
        }
        public static void AddMatHang(Object obj, EventArgs ea)
        {
            try
            {
                add.SetApartmentState(ApartmentState.STA);
                add.Start();
                add.Join();
            }
            catch
            {

            }
            if (addNode != null && parentNode != null)
            {
                parentNode.Nodes.Add(addNode);
            }
            addNode = null;
            parentNode = null;
        }

        public static void AddNganhHang(Object obj, EventArgs ea)
        {
            try
            {
                addNganh.SetApartmentState(ApartmentState.STA);
                addNganh.Start();
                addNganh.Join();
            }
            catch
            {

            }
            if (addNode != null)
            {
                if (parentNode == null)
                {
                    treeMH.Nodes.Add(addNode);
                }
                else
                {
                    parentNode.Nodes.Add(addNode);
                }
            }
            addNode = null;
            parentNode = null;
        }

        // SaveFile
        public static void button2_Click(object sender, EventArgs e)
        {
            try
            {
                s.SetApartmentState(ApartmentState.STA);
                s.Start();
                s.Join();
            }
            catch
            {

            }
            btnCreateTreeData();
        }
        // Ham thuc thi luu treeview
        public static void btnCreateTreeData()
        {
            // Tao bo dem de ghi nho data
            System.Text.StringBuilder buffer = new System.Text.StringBuilder();
            // Duyet qua cac node trong TreeView
            foreach (TreeNode rootNode in treeMH.Nodes)
                // Goi ham De quy
                BuildTreeString(rootNode, buffer);
            // Viet ket qua vo file, luu trong thu muc Debug
            System.IO.File.WriteAllText(@outputFilePath, buffer.ToString());
        }
        // ham luu chuoi vo file
        public static void BuildTreeString(TreeNode rootNode, System.Text.StringBuilder buffer)
        {
            TreeNode parentNode;
            buffer.Append(rootNode.Text);
            if (nodeCache.TryGetValue(rootNode.Text, out parentNode) == true)
            {
                buffer.Append("|" + parentNode.Text);
            }
            buffer.Append("|" + Data[rootNode.Text][1].ToString() + "|" + Data[rootNode.Text][2].ToString());
            buffer.Append(Environment.NewLine);
            foreach (TreeNode childNode in rootNode.Nodes)
                BuildTreeString(childNode, buffer);
        }


        [STAThread]
        static void Main(string[] args)
        {

            btn_ThemNganhHang.Location = new Point(12, 12);
            btn_ThemNganhHang.Width = 130;
            btn_ThemNganhHang.Height = 35;
            btn_ThemNganhHang.Text = "Them Nganh Hang";
            btn_ThemNganhHang.Click += new EventHandler(AddNganhHang);

            btn_ThemMH.Location = new Point(203, 12);
            btn_ThemMH.Width = 130;
            btn_ThemMH.Height = 35;
            btn_ThemMH.Text = "Them mat hang";
            btn_ThemMH.Click += new EventHandler(AddMatHang);

            treeMH.Location = new Point(12, 53);
            treeMH.Width = 321;
            treeMH.Height = 351;
            treeMH.AfterSelect += new TreeViewEventHandler(btn_AfterSelect);

            btn_LoadFile.Location = new Point(12, 410);
            btn_LoadFile.Width = 130;
            btn_LoadFile.Height = 35;
            btn_LoadFile.Text = "Load";
            btn_LoadFile.Click += new EventHandler(btn_ReadFile);

            btn_SaveFile.Location = new Point(203, 410);
            btn_SaveFile.Width = 130;
            btn_SaveFile.Height = 35;
            btn_SaveFile.Text = "Save";
            btn_SaveFile.Click += new EventHandler(button2_Click);

            lb_MS.Text = "Ma so";
            lb_MS.Location = new Point(397, 81);
            lb_MS.Width = 44;
            lb_MS.Height = 16;

            lb_Ten.Text = "Ten";
            lb_Ten.Location = new Point(397, 135);
            lb_Ten.Width = 44;
            lb_Ten.Height = 16;

            lb_GiaBan.Text = "Gia ban";
            lb_GiaBan.Location = new Point(380, 184);
            lb_GiaBan.Width = 60;
            lb_GiaBan.Height = 25;

            tb_MS.Location = new Point(483, 81);
            tb_MS.Width = 246;
            tb_MS.Height = 22;

            tb_Ten.Location = new Point(483, 135);
            tb_Ten.Width = 246;
            tb_Ten.Height = 22;

            tb_GiaBan.Location = new Point(483, 184);
            tb_GiaBan.Width = 246;
            tb_GiaBan.Height = 22;

            form.Controls.Add(btn_ThemNganhHang);
            form.Controls.Add(btn_ThemMH);
            form.Controls.Add(btn_LoadFile);
            form.Controls.Add(btn_SaveFile);
            form.Controls.Add(treeMH);
            form.Controls.Add(tb_MS);
            form.Controls.Add(tb_GiaBan);
            form.Controls.Add(tb_Ten);
            form.Controls.Add(lb_MS);
            form.Controls.Add(lb_Ten);
            form.Controls.Add(lb_GiaBan);
            form.Height = 818;
            form.Width = 800;
            Application.Run(form);
        }
    }
    }
