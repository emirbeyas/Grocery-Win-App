
namespace Medikal.View.Hastalar
{
    partial class HastaRaporlariForm
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
            this.HstaRaporlariBaslik = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.HRprEkl = new FontAwesome.Sharp.IconToolStripButton();
            this.RprDznle = new FontAwesome.Sharp.IconToolStripButton();
            this.RprSil = new FontAwesome.Sharp.IconToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HstaRaporlariBaslik
            // 
            this.HstaRaporlariBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.HstaRaporlariBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HstaRaporlariBaslik.Location = new System.Drawing.Point(10, 10);
            this.HstaRaporlariBaslik.Name = "HstaRaporlariBaslik";
            this.HstaRaporlariBaslik.Size = new System.Drawing.Size(651, 37);
            this.HstaRaporlariBaslik.TabIndex = 2;
            this.HstaRaporlariBaslik.Text = "Hasta Raporları";
            this.HstaRaporlariBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 91);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(651, 360);
            this.dataGridView1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HRprEkl,
            this.RprDznle,
            this.RprSil});
            this.toolStrip1.Location = new System.Drawing.Point(10, 47);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 44);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // HRprEkl
            // 
            this.HRprEkl.AutoSize = false;
            this.HRprEkl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HRprEkl.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.HRprEkl.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.HRprEkl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HRprEkl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HRprEkl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.HRprEkl.Name = "HRprEkl";
            this.HRprEkl.Size = new System.Drawing.Size(34, 34);
            this.HRprEkl.Text = "ıconToolStripButton1";
            this.HRprEkl.ToolTipText = "Hasta Raporu Ekle";
            this.HRprEkl.Click += new System.EventHandler(this.HRprEkl_Click);
            // 
            // RprDznle
            // 
            this.RprDznle.AutoSize = false;
            this.RprDznle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RprDznle.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.RprDznle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.RprDznle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RprDznle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RprDznle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.RprDznle.Name = "RprDznle";
            this.RprDznle.Size = new System.Drawing.Size(34, 34);
            this.RprDznle.Text = "ıconToolStripButton1";
            this.RprDznle.ToolTipText = "Hasta Raporu Düzenle";
            this.RprDznle.Click += new System.EventHandler(this.RprDznle_Click);
            // 
            // RprSil
            // 
            this.RprSil.AutoSize = false;
            this.RprSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RprSil.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.RprSil.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.RprSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RprSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RprSil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.RprSil.Name = "RprSil";
            this.RprSil.Size = new System.Drawing.Size(34, 34);
            this.RprSil.Text = "ıconToolStripButton1";
            this.RprSil.ToolTipText = "Hasta Raporu Sil";
            this.RprSil.Click += new System.EventHandler(this.RprSil_Click);
            // 
            // HastaRaporlariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.HstaRaporlariBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HastaRaporlariForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "HASTA RAPORLARI";
            this.Load += new System.EventHandler(this.HastaRaporlariForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HstaRaporlariBaslik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton HRprEkl;
        private FontAwesome.Sharp.IconToolStripButton RprDznle;
        private FontAwesome.Sharp.IconToolStripButton RprSil;
    }
}