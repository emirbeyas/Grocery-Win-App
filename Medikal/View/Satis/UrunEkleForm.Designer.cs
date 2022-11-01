
namespace Medikal.View.Satis
{
    partial class UrunEkleForm
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
            this.SatisUrunEkleBaslik = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BrkdLbl = new System.Windows.Forms.ToolStripLabel();
            this.BrkdTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AdLbl = new System.Windows.Forms.ToolStripLabel();
            this.AdTxt = new System.Windows.Forms.ToolStripTextBox();
            this.UrnEklBtn = new FontAwesome.Sharp.IconToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SatisUrunEkleBaslik
            // 
            this.SatisUrunEkleBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.SatisUrunEkleBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SatisUrunEkleBaslik.Location = new System.Drawing.Point(10, 10);
            this.SatisUrunEkleBaslik.Name = "SatisUrunEkleBaslik";
            this.SatisUrunEkleBaslik.Size = new System.Drawing.Size(651, 37);
            this.SatisUrunEkleBaslik.TabIndex = 3;
            this.SatisUrunEkleBaslik.Text = "Ürünler";
            this.SatisUrunEkleBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.UrnEklBtn});
            this.toolStrip2.Location = new System.Drawing.Point(10, 47);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(651, 44);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 8;
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
            // UrnEklBtn
            // 
            this.UrnEklBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UrnEklBtn.AutoSize = false;
            this.UrnEklBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UrnEklBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.UrnEklBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.UrnEklBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UrnEklBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UrnEklBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.UrnEklBtn.Name = "UrnEklBtn";
            this.UrnEklBtn.Size = new System.Drawing.Size(34, 34);
            this.UrnEklBtn.Text = "ıconToolStripButton1";
            this.UrnEklBtn.ToolTipText = "Ürün Ekle";
            this.UrnEklBtn.Click += new System.EventHandler(this.UrnEklBtn_Click);
            // 
            // UrunEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.SatisUrunEkleBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunEkleForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "UrunEkleForm";
            this.Load += new System.EventHandler(this.UrunEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SatisUrunEkleBaslik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel BrkdLbl;
        private System.Windows.Forms.ToolStripTextBox BrkdTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel AdLbl;
        private System.Windows.Forms.ToolStripTextBox AdTxt;
        private FontAwesome.Sharp.IconToolStripButton UrnEklBtn;
    }
}