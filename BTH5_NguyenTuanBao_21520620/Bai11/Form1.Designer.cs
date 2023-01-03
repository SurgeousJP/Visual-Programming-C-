namespace Bai11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelEdit = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LinearGradientBrush = new System.Windows.Forms.RadioButton();
            this.TextureBrush = new System.Windows.Forms.RadioButton();
            this.HatchBrush = new System.Windows.Forms.RadioButton();
            this.SolidBrush = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Color = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_Width = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EllipseShape = new System.Windows.Forms.RadioButton();
            this.RectangleShape = new System.Windows.Forms.RadioButton();
            this.LineShape = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelEdit.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelEdit
            // 
            this.PanelEdit.Controls.Add(this.groupBox3);
            this.PanelEdit.Controls.Add(this.groupBox2);
            this.PanelEdit.Controls.Add(this.groupBox1);
            this.PanelEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelEdit.Location = new System.Drawing.Point(0, 0);
            this.PanelEdit.Name = "PanelEdit";
            this.PanelEdit.Size = new System.Drawing.Size(294, 450);
            this.PanelEdit.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LinearGradientBrush);
            this.groupBox3.Controls.Add(this.TextureBrush);
            this.groupBox3.Controls.Add(this.HatchBrush);
            this.groupBox3.Controls.Add(this.SolidBrush);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(3, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 191);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // LinearGradientBrush
            // 
            this.LinearGradientBrush.AutoSize = true;
            this.LinearGradientBrush.Location = new System.Drawing.Point(6, 136);
            this.LinearGradientBrush.Name = "LinearGradientBrush";
            this.LinearGradientBrush.Size = new System.Drawing.Size(197, 26);
            this.LinearGradientBrush.TabIndex = 0;
            this.LinearGradientBrush.TabStop = true;
            this.LinearGradientBrush.Text = "LinearGradientBrush";
            this.LinearGradientBrush.UseVisualStyleBackColor = true;
            // 
            // TextureBrush
            // 
            this.TextureBrush.AutoSize = true;
            this.TextureBrush.Location = new System.Drawing.Point(6, 104);
            this.TextureBrush.Name = "TextureBrush";
            this.TextureBrush.Size = new System.Drawing.Size(140, 26);
            this.TextureBrush.TabIndex = 0;
            this.TextureBrush.TabStop = true;
            this.TextureBrush.Text = "TextureBrush";
            this.TextureBrush.UseVisualStyleBackColor = true;
            // 
            // HatchBrush
            // 
            this.HatchBrush.AutoSize = true;
            this.HatchBrush.Location = new System.Drawing.Point(6, 72);
            this.HatchBrush.Name = "HatchBrush";
            this.HatchBrush.Size = new System.Drawing.Size(125, 26);
            this.HatchBrush.TabIndex = 0;
            this.HatchBrush.TabStop = true;
            this.HatchBrush.Text = "HatchBrush";
            this.HatchBrush.UseVisualStyleBackColor = true;
            // 
            // SolidBrush
            // 
            this.SolidBrush.AutoSize = true;
            this.SolidBrush.Location = new System.Drawing.Point(6, 40);
            this.SolidBrush.Name = "SolidBrush";
            this.SolidBrush.Size = new System.Drawing.Size(118, 26);
            this.SolidBrush.TabIndex = 0;
            this.SolidBrush.TabStop = true;
            this.SolidBrush.Text = "SolidBrush";
            this.SolidBrush.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Color);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lb_Width);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 119);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // btn_Color
            // 
            this.btn_Color.Location = new System.Drawing.Point(60, 73);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(116, 36);
            this.btn_Color.TabIndex = 2;
            this.btn_Color.Text = "Color...";
            this.btn_Color.UseVisualStyleBackColor = true;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 1;
            // 
            // lb_Width
            // 
            this.lb_Width.AutoSize = true;
            this.lb_Width.Location = new System.Drawing.Point(13, 30);
            this.lb_Width.Name = "lb_Width";
            this.lb_Width.Size = new System.Drawing.Size(56, 22);
            this.lb_Width.TabIndex = 0;
            this.lb_Width.Text = "Width";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EllipseShape);
            this.groupBox1.Controls.Add(this.RectangleShape);
            this.groupBox1.Controls.Add(this.LineShape);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // EllipseShape
            // 
            this.EllipseShape.AutoSize = true;
            this.EllipseShape.Location = new System.Drawing.Point(6, 88);
            this.EllipseShape.Name = "EllipseShape";
            this.EllipseShape.Size = new System.Drawing.Size(84, 26);
            this.EllipseShape.TabIndex = 0;
            this.EllipseShape.TabStop = true;
            this.EllipseShape.Text = "Ellipse";
            this.EllipseShape.UseVisualStyleBackColor = true;
            // 
            // RectangleShape
            // 
            this.RectangleShape.AutoSize = true;
            this.RectangleShape.Location = new System.Drawing.Point(6, 56);
            this.RectangleShape.Name = "RectangleShape";
            this.RectangleShape.Size = new System.Drawing.Size(112, 26);
            this.RectangleShape.TabIndex = 0;
            this.RectangleShape.TabStop = true;
            this.RectangleShape.Text = "Rectangle";
            this.RectangleShape.UseVisualStyleBackColor = true;
            // 
            // LineShape
            // 
            this.LineShape.AutoSize = true;
            this.LineShape.Location = new System.Drawing.Point(6, 24);
            this.LineShape.Name = "LineShape";
            this.LineShape.Size = new System.Drawing.Size(65, 26);
            this.LineShape.TabIndex = 0;
            this.LineShape.TabStop = true;
            this.LineShape.Text = "Line";
            this.LineShape.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(289, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelEdit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelEdit.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelEdit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton LinearGradientBrush;
        private System.Windows.Forms.RadioButton TextureBrush;
        private System.Windows.Forms.RadioButton HatchBrush;
        private System.Windows.Forms.RadioButton SolidBrush;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Color;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_Width;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton EllipseShape;
        private System.Windows.Forms.RadioButton RectangleShape;
        private System.Windows.Forms.RadioButton LineShape;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

