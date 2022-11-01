
namespace Medikal.View.Urunler
{
    partial class UrunlerListView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BrkdLbl = new System.Windows.Forms.ToolStripLabel();
            this.BrkdTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AdLbl = new System.Windows.Forms.ToolStripLabel();
            this.AdTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EklBtn = new FontAwesome.Sharp.IconToolStripButton();
            this.DznleBtn = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UrnDty = new FontAwesome.Sharp.IconToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.UrnCkr = new FontAwesome.Sharp.IconToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 135);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(657, 397);
            this.dataGridView1.TabIndex = 7;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrkdLbl,
            this.BrkdTxt,
            this.toolStripSeparator2,
            this.AdLbl,
            this.AdTxt,
            this.toolStripSeparator3});
            this.toolStrip2.Location = new System.Drawing.Point(10, 91);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(657, 44);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BrkdLbl
            // 
            this.BrkdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrkdLbl.Margin = new System.Windows.Forms.Padding(2);
            this.BrkdLbl.Name = "BrkdLbl";
            this.BrkdLbl.Size = new System.Drawing.Size(52, 40);
            this.BrkdLbl.Text = "Barkod :";
            // 
            // BrkdTxt
            // 
            this.BrkdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrkdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrkdTxt.Margin = new System.Windows.Forms.Padding(2);
            this.BrkdTxt.MaxLength = 13;
            this.BrkdTxt.Name = "BrkdTxt";
            this.BrkdTxt.Size = new System.Drawing.Size(100, 40);
            this.BrkdTxt.TextChanged += new System.EventHandler(this.BrkdTxt_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // AdLbl
            // 
            this.AdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdLbl.Margin = new System.Windows.Forms.Padding(2);
            this.AdLbl.Name = "AdLbl";
            this.AdLbl.Size = new System.Drawing.Size(27, 40);
            this.AdLbl.Text = "Ad :";
            // 
            // AdTxt
            // 
            this.AdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdTxt.Margin = new System.Windows.Forms.Padding(2);
            this.AdTxt.Name = "AdTxt";
            this.AdTxt.Size = new System.Drawing.Size(100, 40);
            this.AdTxt.TextChanged += new System.EventHandler(this.AdTxt_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
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
            this.UrnCkr,
            this.toolStripSeparator1,
            this.UrnDty});
            this.toolStrip1.Location = new System.Drawing.Point(10, 47);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 44);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 5;
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
            this.EklBtn.ToolTipText = "Ürün Ekle";
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
            this.DznleBtn.ToolTipText = "Ürün Düzenle";
            this.DznleBtn.Click += new System.EventHandler(this.DznleBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // UrnDty
            // 
            this.UrnDty.AutoSize = false;
            this.UrnDty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UrnDty.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.UrnDty.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.UrnDty.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UrnDty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UrnDty.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.UrnDty.Name = "UrnDty";
            this.UrnDty.Size = new System.Drawing.Size(34, 34);
            this.UrnDty.Text = "ıconToolStripButton1";
            this.UrnDty.ToolTipText = "Ürün Detay";
            this.UrnDty.Click += new System.EventHandler(this.UrnDty_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürünler Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UrnCkr
            // 
            this.UrnCkr.AutoSize = false;
            this.UrnCkr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UrnCkr.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.UrnCkr.IconColor = System.Drawing.Color.Red;
            this.UrnCkr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UrnCkr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UrnCkr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.UrnCkr.Name = "UrnCkr";
            this.UrnCkr.Size = new System.Drawing.Size(34, 34);
            this.UrnCkr.Text = "ıconToolStripButton1";
            this.UrnCkr.ToolTipText = "Ürün Sil";
            this.UrnCkr.Click += new System.EventHandler(this.UrnCkr_Click);
            // 
            // UrunlerListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "UrunlerListView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(677, 542);
            this.Load += new System.EventHandler(this.UrunlerListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel BrkdLbl;
        private System.Windows.Forms.ToolStripTextBox BrkdTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel AdLbl;
        private System.Windows.Forms.ToolStripTextBox AdTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton EklBtn;
        private FontAwesome.Sharp.IconToolStripButton DznleBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconToolStripButton UrnDty;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconToolStripButton UrnCkr;
    }
}
