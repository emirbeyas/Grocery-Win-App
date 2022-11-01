
namespace Medikal
{
    partial class ActicationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "AKTİVASYON ANAHTARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(43, 69);
            this.maskedTextBox1.Mask = "AAAAA-AAAAA-AAAAA-AAAAA";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(370, 30);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
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
            this.label4.TabIndex = 15;
            this.label4.Text = "@2021 by Emirhan BEYAZ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(456, 151);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(472, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(472, 190);
            this.Name = "ActicationForm";
            this.Padding = new System.Windows.Forms.Padding(40, 10, 40, 10);
            this.Text = "AKTİVASYON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
    }
}