
namespace Medikal
{
    partial class CheckYourWlan
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(40, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "@2021 by Emirhan BEYAZ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 61);
            this.label1.TabIndex = 17;
            this.label1.Text = "İnternet Bağlantınızı Kontrol Edin.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.ıconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ıconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Wifi;
            this.ıconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 57;
            this.ıconPictureBox1.Location = new System.Drawing.Point(43, 52);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(370, 57);
            this.ıconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ıconPictureBox1.TabIndex = 18;
            this.ıconPictureBox1.TabStop = false;
            // 
            // CheckYourWlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(456, 151);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(472, 190);
            this.MinimumSize = new System.Drawing.Size(472, 190);
            this.Name = "CheckYourWlan";
            this.Padding = new System.Windows.Forms.Padding(40, 10, 40, 10);
            this.Text = "BAĞLANTI HATASI";
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
    }
}