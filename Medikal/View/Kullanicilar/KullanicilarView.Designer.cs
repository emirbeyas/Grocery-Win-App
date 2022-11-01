
namespace Medikal.View.Kullanicilar
{
    partial class KullanicilarView
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EklBtn = new FontAwesome.Sharp.IconToolStripButton();
            this.DznleBtn = new FontAwesome.Sharp.IconToolStripButton();
            this.kllnciSil = new FontAwesome.Sharp.IconToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(782, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı İşlemleri";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EklBtn,
            this.DznleBtn,
            this.kllnciSil});
            this.toolStrip1.Location = new System.Drawing.Point(10, 47);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 44);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // EklBtn
            // 
            this.EklBtn.AutoSize = false;
            this.EklBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EklBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.EklBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.EklBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EklBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EklBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.EklBtn.Name = "EklBtn";
            this.EklBtn.Size = new System.Drawing.Size(34, 34);
            this.EklBtn.Text = "ıconToolStripButton1";
            this.EklBtn.ToolTipText = "Kullanıcı Ekle";
            this.EklBtn.Click += new System.EventHandler(this.EklBtn_Click);
            // 
            // DznleBtn
            // 
            this.DznleBtn.AutoSize = false;
            this.DznleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DznleBtn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.DznleBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.DznleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DznleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DznleBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.DznleBtn.Name = "DznleBtn";
            this.DznleBtn.Size = new System.Drawing.Size(34, 34);
            this.DznleBtn.Text = "ıconToolStripButton1";
            this.DznleBtn.ToolTipText = "Kullanıcı Düzenle";
            this.DznleBtn.Click += new System.EventHandler(this.DznleBtn_Click);
            // 
            // kllnciSil
            // 
            this.kllnciSil.AutoSize = false;
            this.kllnciSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kllnciSil.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.kllnciSil.IconColor = System.Drawing.Color.Red;
            this.kllnciSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kllnciSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kllnciSil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.kllnciSil.Name = "kllnciSil";
            this.kllnciSil.Size = new System.Drawing.Size(34, 34);
            this.kllnciSil.Text = "ıconToolStripButton1";
            this.kllnciSil.ToolTipText = "Kullanıcı Sil";
            this.kllnciSil.Click += new System.EventHandler(this.kllnciSil_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(782, 394);
            this.dataGridView1.TabIndex = 5;
            // 
            // KullanicilarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Name = "KullanicilarView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(802, 495);
            this.Load += new System.EventHandler(this.KullanicilarView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton EklBtn;
        private FontAwesome.Sharp.IconToolStripButton DznleBtn;
        private FontAwesome.Sharp.IconToolStripButton kllnciSil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
