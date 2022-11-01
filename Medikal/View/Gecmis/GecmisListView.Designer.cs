
namespace Medikal.View.Gecmis
{
    partial class GecmisListView
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.NotLbl = new System.Windows.Forms.ToolStripLabel();
            this.NotTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.StsDty = new FontAwesome.Sharp.IconToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geçmiş Satışlar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotLbl,
            this.NotTxt,
            this.toolStripSeparator2,
            this.StsDty});
            this.toolStrip2.Location = new System.Drawing.Point(9, 41);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(649, 38);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // NotLbl
            // 
            this.NotLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotLbl.Margin = new System.Windows.Forms.Padding(2);
            this.NotLbl.Name = "NotLbl";
            this.NotLbl.Size = new System.Drawing.Size(32, 34);
            this.NotLbl.Text = "Not :";
            // 
            // NotTxt
            // 
            this.NotTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NotTxt.Name = "NotTxt";
            this.NotTxt.Size = new System.Drawing.Size(86, 34);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // StsDty
            // 
            this.StsDty.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StsDty.AutoSize = false;
            this.StsDty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StsDty.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.StsDty.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.StsDty.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StsDty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StsDty.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.StsDty.Name = "StsDty";
            this.StsDty.Size = new System.Drawing.Size(34, 34);
            this.StsDty.Text = "ıconToolStripButton1";
            this.StsDty.ToolTipText = "Satış Detay";
            this.StsDty.Click += new System.EventHandler(this.StsDty_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(9, 79);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(649, 373);
            this.dataGridView1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // GecmisListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "GecmisListView";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.Size = new System.Drawing.Size(667, 461);
            this.Load += new System.EventHandler(this.GecmisListView_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel NotLbl;
        private System.Windows.Forms.ToolStripTextBox NotTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconToolStripButton StsDty;
    }
}
