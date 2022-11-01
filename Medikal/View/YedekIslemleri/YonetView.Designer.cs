
namespace Medikal.View.YedekIslemleri
{
    partial class YonetView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EklBtn = new FontAwesome.Sharp.IconToolStripButton();
            this.DznleBtn = new FontAwesome.Sharp.IconToolStripButton();
            this.kllnciSil = new FontAwesome.Sharp.IconToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(873, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yönetici Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(873, 558);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 205);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(865, 349);
            this.panel2.TabIndex = 2;
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
            this.dataGridView1.Size = new System.Drawing.Size(845, 248);
            this.dataGridView1.TabIndex = 4;
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
            this.toolStrip1.Size = new System.Drawing.Size(845, 44);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 2;
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
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(845, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı İşlemleri";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(865, 194);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ıconButton2);
            this.panel3.Controls.Add(this.ıconButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 39);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(25);
            this.panel3.Size = new System.Drawing.Size(845, 135);
            this.panel3.TabIndex = 5;
            // 
            // ıconButton2
            // 
            this.ıconButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.ıconButton2.IconColor = System.Drawing.Color.Black;
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.Location = new System.Drawing.Point(166, 25);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(141, 85);
            this.ıconButton2.TabIndex = 4;
            this.ıconButton2.Text = "YEDEKTEN DÖN";
            this.ıconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ıconButton2.UseVisualStyleBackColor = true;
            // 
            // ıconButton1
            // 
            this.ıconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ıconButton1.IconColor = System.Drawing.Color.Black;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.Location = new System.Drawing.Point(25, 25);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(141, 85);
            this.ıconButton1.TabIndex = 2;
            this.ıconButton1.Text = "YEDEKLE";
            this.ıconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yedekle İşlemleri";
            // 
            // YonetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "YonetView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(893, 615);
            this.Load += new System.EventHandler(this.YonetView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton EklBtn;
        private FontAwesome.Sharp.IconToolStripButton DznleBtn;
        private FontAwesome.Sharp.IconToolStripButton kllnciSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton ıconButton2;
    }
}
