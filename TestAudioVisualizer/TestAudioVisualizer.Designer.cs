namespace TestAudioVisualizer
{
    partial class TestAudioVisualizer
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
            this.audioVisualization1 = new CSAudioVisualization.AudioVisualization();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // audioVisualization1
            // 
            this.audioVisualization1.AudioSource = null;
            this.audioVisualization1.BackColor = System.Drawing.Color.Transparent;
            this.audioVisualization1.BarCount = 50;
            this.audioVisualization1.BarSpacing = 2;
            this.audioVisualization1.ColorBase = System.Drawing.Color.DarkRed;
            this.audioVisualization1.ColorMax = System.Drawing.Color.Snow;
            this.audioVisualization1.DeviceIndex = 0;
            this.audioVisualization1.FileName = null;
            this.audioVisualization1.HighQuality = true;
            this.audioVisualization1.Interval = 40;
            this.audioVisualization1.IsXLogScale = true;
            this.audioVisualization1.Location = new System.Drawing.Point(237, 75);
            this.audioVisualization1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.audioVisualization1.MaximumFrequency = 10000;
            this.audioVisualization1.MessageArgs = null;
            this.audioVisualization1.Name = "audioVisualization1";
            this.audioVisualization1.pic3DGraph = null;
            this.audioVisualization1.Size = new System.Drawing.Size(322, 179);
            this.audioVisualization1.TabIndex = 0;
            this.audioVisualization1.UseAverage = true;
            this.audioVisualization1.UserKey = "Your registration key";
            this.audioVisualization1.UserName = "Your email";
            this.audioVisualization1.VisMode = CSAudioVisualization.GraphMode.ModeSpectrum;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(525, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(143, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Begin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(327, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Restart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TestAudioVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.audioVisualization1);
            this.Name = "TestAudioVisualizer";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CSAudioVisualization.AudioVisualization audioVisualization1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

