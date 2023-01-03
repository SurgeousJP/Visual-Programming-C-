namespace Bai09
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
            this.cb_DrawShape = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_DrawShape
            // 
            this.cb_DrawShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DrawShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_DrawShape.FormattingEnabled = true;
            this.cb_DrawShape.Location = new System.Drawing.Point(64, 31);
            this.cb_DrawShape.Name = "cb_DrawShape";
            this.cb_DrawShape.Size = new System.Drawing.Size(184, 33);
            this.cb_DrawShape.TabIndex = 0;
            this.cb_DrawShape.SelectedIndexChanged += new System.EventHandler(this.ChangeShape);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_DrawShape);
            this.Name = "Form1";
            this.Text = "Combobox Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_DrawShape;
    }
}

