
namespace Medikal.View.infoBox
{
    partial class InfBxView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfBxIco = new FontAwesome.Sharp.IconPictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InfBxValueLbl = new System.Windows.Forms.Label();
            this.InfBxBslkLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfBxIco)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InfBxIco);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 96);
            this.panel1.TabIndex = 0;
            // 
            // InfBxIco
            // 
            this.InfBxIco.BackColor = System.Drawing.SystemColors.Control;
            this.InfBxIco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfBxIco.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.InfBxIco.IconColor = System.Drawing.SystemColors.ControlText;
            this.InfBxIco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InfBxIco.IconSize = 96;
            this.InfBxIco.Location = new System.Drawing.Point(2, 8);
            this.InfBxIco.Name = "InfBxIco";
            this.InfBxIco.Size = new System.Drawing.Size(96, 98);
            this.InfBxIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfBxIco.TabIndex = 0;
            this.InfBxIco.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.InfBxValueLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.InfBxBslkLbl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(96, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(263, 96);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // InfBxValueLbl
            // 
            this.InfBxValueLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfBxValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfBxValueLbl.Location = new System.Drawing.Point(3, 48);
            this.InfBxValueLbl.Name = "InfBxValueLbl";
            this.InfBxValueLbl.Size = new System.Drawing.Size(257, 48);
            this.InfBxValueLbl.TabIndex = 2;
            this.InfBxValueLbl.Text = "131";
            this.InfBxValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfBxBslkLbl
            // 
            this.InfBxBslkLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfBxBslkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfBxBslkLbl.Location = new System.Drawing.Point(3, 0);
            this.InfBxBslkLbl.Name = "InfBxBslkLbl";
            this.InfBxBslkLbl.Size = new System.Drawing.Size(257, 48);
            this.InfBxBslkLbl.TabIndex = 1;
            this.InfBxBslkLbl.Text = "Personel Sayısı";
            this.InfBxBslkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfBxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "InfBxView";
            this.Size = new System.Drawing.Size(359, 96);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfBxIco)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconPictureBox InfBxIco;
        public System.Windows.Forms.Label InfBxValueLbl;
        public System.Windows.Forms.Label InfBxBslkLbl;
    }
}
