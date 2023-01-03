using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestABit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string filePath;
        static string outputFilePath;
        static List<string> lines = new List<string>();
        static Dictionary<int, TreeNode> parents = new Dictionary<int, TreeNode>();
        // Them node cha
        private void button5_Click(object sender, EventArgs e)
        {
            string nodeParent = textBox1.Text.Trim();
            if (nodeParent.Equals(""))
            {
                return;
            }
            TreeNode root = new TreeNode(nodeParent);
            treeView1.Nodes.Add(root);
        }
        // Them node con
        private void button6_Click(object sender, EventArgs e)
        {
            string nodeChild = textBox3.Text.Trim();
            if (nodeChild.Equals(""))
            {
                return;
            }
            TreeNode child = new TreeNode(nodeChild);
            try
            {
                treeView1.SelectedNode.Nodes.Add(child);
            }
            catch
            {

            }
            
        }
        //Sua node
        private void button7_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Text = textBox2.Text.Trim();
        }
        // Xoa node
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thực sự muốn xóa node này không ?", "Hỏi xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
        }
        // SaveFile
        private void button2_Click(object sender, EventArgs e)
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
        public void btnCreateTreeData()
        {
            // Tao bo dem de ghi nho data
            System.Text.StringBuilder buffer = new System.Text.StringBuilder();
            // Duyet qua cac node trong TreeView
            foreach (TreeNode rootNode in treeView1.Nodes)
                // Goi ham De quy
                BuildTreeString(rootNode, buffer);
            // Viet ket qua vo file, luu trong thu muc Debug
            System.IO.File.WriteAllText(@outputFilePath, buffer.ToString());
        }
        // ham luu chuoi vo file
        public void BuildTreeString(TreeNode rootNode, System.Text.StringBuilder buffer)
        {
            for (int i = 0; i < rootNode.Level; i++) {
                buffer.Append("\t");
            }
            buffer.Append(rootNode.Text);
            buffer.Append(Environment.NewLine);
            foreach (TreeNode childNode in rootNode.Nodes)
                BuildTreeString(childNode, buffer);
        }
        // ReadFile
        private void button1_Click(object sender, EventArgs e)
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

            treeView1.Nodes.Clear();
            parents = new Dictionary<int, TreeNode>();

            foreach (string line in lines)
            {
                // Dem xem bao nhieu tab -> bay nhieu level
                int level = line.Length - line.TrimStart('\t').Length;

                // Add the new node.
                if (level == 0)
                    parents[level] = treeView1.Nodes.Add(line.Trim());
                else
                    parents[level] = parents[level - 1].Nodes.Add(line.Trim());
                parents[level].EnsureVisible();
            }

            if (treeView1.Nodes.Count > 0) treeView1.Nodes[0].EnsureVisible();
        }

        // Reset
        private void button3_Click(object sender, EventArgs e)
        {
            lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            treeView1.Nodes.Clear();
            parents = new Dictionary<int, TreeNode>();

            foreach (string line in lines)
            {
                // Dem xem bao nhieu tab -> bay nhieu level
                int level = line.Length - line.TrimStart('\t').Length;

                // Add the new node.
                if (level == 0)
                    parents[level] = treeView1.Nodes.Add(line.Trim());
                else
                    parents[level] = parents[level - 1].Nodes.Add(line.Trim());
                parents[level].EnsureVisible();
            }

            if (treeView1.Nodes.Count > 0) treeView1.Nodes[0].EnsureVisible();
        }

        // Event Click vo node 
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox2.Text = treeView1.SelectedNode.Text;
        }

        // Cac thread de mo dialog 
        public static Thread t = new Thread((ThreadStart)(() => {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
        }));

        public static Thread s = new Thread((ThreadStart)(() => {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"TXT|*.txt" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFilePath = saveFileDialog.FileName;
                }
            }
        }));
    }
}
