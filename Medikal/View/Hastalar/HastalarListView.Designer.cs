
namespace Medikal.View.Hastalar
{
    partial class HastalarListView
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
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EklBtn = new FontAwesome.Sharp.IconToolStripButton();
            this.DznleBtn = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RprList = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.TcLbl = new System.Windows.Forms.ToolStripLabel();
            this.TcTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AdLbl = new System.Windows.Forms.ToolStripLabel();
            this.AdTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SoyadLbl = new System.Windows.Forms.ToolStripLabel();
            this.SoyadTxt = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastalar Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.toolStripSeparator1,
            this.RprList});
            this.toolStrip1.Location = new System.Drawing.Point(10, 47);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(719, 44);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
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
            this.EklBtn.ToolTipText = "Hasta Ekle";
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
            this.DznleBtn.ToolTipText = "Hasta Düzenle";
            this.DznleBtn.Click += new System.EventHandler(this.DznleBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // RprList
            // 
            this.RprList.AutoSize = false;
            this.RprList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RprList.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.RprList.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.RprList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RprList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RprList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.RprList.Name = "RprList";
            this.RprList.Size = new System.Drawing.Size(34, 34);
            this.RprList.Text = "ıconToolStripButton1";
            this.RprList.ToolTipText = "Hasta Raporları";
            this.RprList.Click += new System.EventHandler(this.RprList_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TcLbl,
            this.TcTxt,
            this.toolStripSeparator2,
            this.AdLbl,
            this.AdTxt,
            this.toolStripSeparator3,
            this.SoyadLbl,
            this.SoyadTxt});
            this.toolStrip2.Location = new System.Drawing.Point(10, 91);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(719, 44);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // TcLbl
            // 
            this.TcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TcLbl.Margin = new System.Windows.Forms.Padding(2);
            this.TcLbl.Name = "TcLbl";
            this.TcLbl.Size = new System.Drawing.Size(28, 40);
            this.TcLbl.Text = "TC :";
            // 
            // TcTxt
            // 
            this.TcTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TcTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TcTxt.Margin = new System.Windows.Forms.Padding(2);
            this.TcTxt.MaxLength = 11;
            this.TcTxt.Name = "TcTxt";
            this.TcTxt.Size = new System.Drawing.Size(100, 40);
            this.TcTxt.TextChanged += new System.EventHandler(this.TcTxt_TextChanged);
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
            // SoyadLbl
            // 
            this.SoyadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoyadLbl.Margin = new System.Windows.Forms.Padding(2);
            this.SoyadLbl.Name = "SoyadLbl";
            this.SoyadLbl.Size = new System.Drawing.Size(47, 40);
            this.SoyadLbl.Text = "Soyad :";
            // 
            // SoyadTxt
            // 
            this.SoyadTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoyadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoyadTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SoyadTxt.Name = "SoyadTxt";
            this.SoyadTxt.Size = new System.Drawing.Size(100, 40);
            this.SoyadTxt.TextChanged += new System.EventHandler(this.SoyadTxt_TextChanged);
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
            this.dataGridView1.Size = new System.Drawing.Size(719, 390);
            this.dataGridView1.TabIndex = 3;
            // 
            // HastalarListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "HastalarListView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(739, 535);
            this.Load += new System.EventHandler(this.HastalarListView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton EklBtn;
        private FontAwesome.Sharp.IconToolStripButton DznleBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconToolStripButton RprList;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel TcLbl;
        private System.Windows.Forms.ToolStripTextBox TcTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel AdLbl;
        private System.Windows.Forms.ToolStripTextBox AdTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel SoyadLbl;
        private System.Windows.Forms.ToolStripTextBox SoyadTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
