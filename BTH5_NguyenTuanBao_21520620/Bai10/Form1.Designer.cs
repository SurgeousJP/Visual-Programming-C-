namespace Bai10
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_EndCap = new System.Windows.Forms.ComboBox();
            this.cb_StartCap = new System.Windows.Forms.ComboBox();
            this.cb_DashCap = new System.Windows.Forms.ComboBox();
            this.cb_LineJoin = new System.Windows.Forms.ComboBox();
            this.cb_Width = new System.Windows.Forms.ComboBox();
            this.cb_DashStyle = new System.Windows.Forms.ComboBox();
            this.lb_EndCap = new System.Windows.Forms.Label();
            this.lb_StartCap = new System.Windows.Forms.Label();
            this.lb_DashCap = new System.Windows.Forms.Label();
            this.lb_LineJoin = new System.Windows.Forms.Label();
            this.lb_Width = new System.Windows.Forms.Label();
            this.lb_DashStyle = new System.Windows.Forms.Label();
            this.drawingSpace = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.cb_EndCap);
            this.panel1.Controls.Add(this.cb_StartCap);
            this.panel1.Controls.Add(this.cb_DashCap);
            this.panel1.Controls.Add(this.cb_LineJoin);
            this.panel1.Controls.Add(this.cb_Width);
            this.panel1.Controls.Add(this.cb_DashStyle);
            this.panel1.Controls.Add(this.lb_EndCap);
            this.panel1.Controls.Add(this.lb_StartCap);
            this.panel1.Controls.Add(this.lb_DashCap);
            this.panel1.Controls.Add(this.lb_LineJoin);
            this.panel1.Controls.Add(this.lb_Width);
            this.panel1.Controls.Add(this.lb_DashStyle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 450);
            this.panel1.TabIndex = 0;
            // 
            // cb_EndCap
            // 
            this.cb_EndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EndCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_EndCap.FormattingEnabled = true;
            this.cb_EndCap.Location = new System.Drawing.Point(137, 318);
            this.cb_EndCap.Name = "cb_EndCap";
            this.cb_EndCap.Size = new System.Drawing.Size(161, 30);
            this.cb_EndCap.TabIndex = 1;
            this.cb_EndCap.SelectedIndexChanged += new System.EventHandler(this.EndCapChangedEvent);
            // 
            // cb_StartCap
            // 
            this.cb_StartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_StartCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_StartCap.FormattingEnabled = true;
            this.cb_StartCap.Location = new System.Drawing.Point(137, 252);
            this.cb_StartCap.Name = "cb_StartCap";
            this.cb_StartCap.Size = new System.Drawing.Size(161, 30);
            this.cb_StartCap.TabIndex = 1;
            this.cb_StartCap.SelectedIndexChanged += new System.EventHandler(this.StartCapChangedEvent);
            // 
            // cb_DashCap
            // 
            this.cb_DashCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DashCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_DashCap.FormattingEnabled = true;
            this.cb_DashCap.Location = new System.Drawing.Point(137, 191);
            this.cb_DashCap.Name = "cb_DashCap";
            this.cb_DashCap.Size = new System.Drawing.Size(161, 30);
            this.cb_DashCap.TabIndex = 1;
            this.cb_DashCap.SelectedIndexChanged += new System.EventHandler(this.DashCapChangeEvent);
            // 
            // cb_LineJoin
            // 
            this.cb_LineJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LineJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_LineJoin.FormattingEnabled = true;
            this.cb_LineJoin.Location = new System.Drawing.Point(137, 134);
            this.cb_LineJoin.Name = "cb_LineJoin";
            this.cb_LineJoin.Size = new System.Drawing.Size(161, 30);
            this.cb_LineJoin.TabIndex = 1;
            this.cb_LineJoin.SelectedIndexChanged += new System.EventHandler(this.LineJoinChangedEvent);
            // 
            // cb_Width
            // 
            this.cb_Width.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_Width.FormattingEnabled = true;
            this.cb_Width.Location = new System.Drawing.Point(137, 77);
            this.cb_Width.Name = "cb_Width";
            this.cb_Width.Size = new System.Drawing.Size(161, 30);
            this.cb_Width.TabIndex = 1;
            this.cb_Width.SelectedIndexChanged += new System.EventHandler(this.WidthChangedEvent);
            // 
            // cb_DashStyle
            // 
            this.cb_DashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DashStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_DashStyle.FormattingEnabled = true;
            this.cb_DashStyle.Location = new System.Drawing.Point(137, 19);
            this.cb_DashStyle.Name = "cb_DashStyle";
            this.cb_DashStyle.Size = new System.Drawing.Size(161, 30);
            this.cb_DashStyle.TabIndex = 1;
            this.cb_DashStyle.SelectedIndexChanged += new System.EventHandler(this.DashStyleChangedEvent);
            // 
            // lb_EndCap
            // 
            this.lb_EndCap.AutoSize = true;
            this.lb_EndCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_EndCap.Location = new System.Drawing.Point(13, 321);
            this.lb_EndCap.Name = "lb_EndCap";
            this.lb_EndCap.Size = new System.Drawing.Size(85, 22);
            this.lb_EndCap.TabIndex = 0;
            this.lb_EndCap.Text = "End Cap:";
            // 
            // lb_StartCap
            // 
            this.lb_StartCap.AutoSize = true;
            this.lb_StartCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_StartCap.Location = new System.Drawing.Point(13, 255);
            this.lb_StartCap.Name = "lb_StartCap";
            this.lb_StartCap.Size = new System.Drawing.Size(91, 22);
            this.lb_StartCap.TabIndex = 0;
            this.lb_StartCap.Text = "Start Cap:";
            // 
            // lb_DashCap
            // 
            this.lb_DashCap.AutoSize = true;
            this.lb_DashCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_DashCap.Location = new System.Drawing.Point(13, 194);
            this.lb_DashCap.Name = "lb_DashCap";
            this.lb_DashCap.Size = new System.Drawing.Size(95, 22);
            this.lb_DashCap.TabIndex = 0;
            this.lb_DashCap.Text = "Dash Cap:";
            // 
            // lb_LineJoin
            // 
            this.lb_LineJoin.AutoSize = true;
            this.lb_LineJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_LineJoin.Location = new System.Drawing.Point(13, 137);
            this.lb_LineJoin.Name = "lb_LineJoin";
            this.lb_LineJoin.Size = new System.Drawing.Size(87, 22);
            this.lb_LineJoin.TabIndex = 0;
            this.lb_LineJoin.Text = "Line Join:";
            // 
            // lb_Width
            // 
            this.lb_Width.AutoSize = true;
            this.lb_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Width.Location = new System.Drawing.Point(13, 80);
            this.lb_Width.Name = "lb_Width";
            this.lb_Width.Size = new System.Drawing.Size(61, 22);
            this.lb_Width.TabIndex = 0;
            this.lb_Width.Text = "Width:";
            // 
            // lb_DashStyle
            // 
            this.lb_DashStyle.AutoSize = true;
            this.lb_DashStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_DashStyle.Location = new System.Drawing.Point(13, 22);
            this.lb_DashStyle.Name = "lb_DashStyle";
            this.lb_DashStyle.Size = new System.Drawing.Size(102, 22);
            this.lb_DashStyle.TabIndex = 0;
            this.lb_DashStyle.Text = "Dash Style:";
            // 
            // drawingSpace
            // 
            this.drawingSpace.Location = new System.Drawing.Point(327, 0);
            this.drawingSpace.Name = "drawingSpace";
            this.drawingSpace.Size = new System.Drawing.Size(476, 450);
            this.drawingSpace.TabIndex = 1;
            this.drawingSpace.TabStop = false;
            this.drawingSpace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingSpace_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawingSpace);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingSpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_EndCap;
        private System.Windows.Forms.ComboBox cb_StartCap;
        private System.Windows.Forms.ComboBox cb_DashCap;
        private System.Windows.Forms.ComboBox cb_LineJoin;
        private System.Windows.Forms.ComboBox cb_Width;
        private System.Windows.Forms.ComboBox cb_DashStyle;
        private System.Windows.Forms.Label lb_EndCap;
        private System.Windows.Forms.Label lb_StartCap;
        private System.Windows.Forms.Label lb_DashCap;
        private System.Windows.Forms.Label lb_LineJoin;
        private System.Windows.Forms.Label lb_Width;
        private System.Windows.Forms.Label lb_DashStyle;
        private System.Windows.Forms.PictureBox drawingSpace;
    }
}

