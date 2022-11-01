
namespace Medikal.View.Satis
{
    partial class SatisView
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
            this.BrkdTxtBx = new System.Windows.Forms.ToolStripTextBox();
            this.EklBtn = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TcLbl = new System.Windows.Forms.ToolStripLabel();
            this.AdetTxtBx = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UrnCkr = new FontAwesome.Sharp.IconToolStripButton();
            this.indrmUyglaButton = new FontAwesome.Sharp.IconToolStripButton();
            this.IndrmTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.UrnEklBtn = new FontAwesome.Sharp.IconToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.NetTtrLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IndrmLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TplmTtr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satış";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrkdTxtBx,
            this.EklBtn,
            this.toolStripSeparator1,
            this.TcLbl,
            this.AdetTxtBx,
            this.toolStripSeparator2,
            this.UrnCkr,
            this.indrmUyglaButton,
            this.IndrmTextBox,
            this.toolStripLabel1,
            this.UrnEklBtn});
            this.toolStrip1.Location = new System.Drawing.Point(10, 47);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 62);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BrkdTxtBx
            // 
            this.BrkdTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrkdTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrkdTxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.BrkdTxtBx.MaxLength = 13;
            this.BrkdTxtBx.Name = "BrkdTxtBx";
            this.BrkdTxtBx.Size = new System.Drawing.Size(180, 58);
            this.BrkdTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrkdTxtBx_KeyDown);
            this.BrkdTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BrkdTxtBx_KeyPress);
            // 
            // EklBtn
            // 
            this.EklBtn.AutoSize = false;
            this.EklBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EklBtn.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.EklBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.EklBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EklBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EklBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EklBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.EklBtn.Name = "EklBtn";
            this.EklBtn.Size = new System.Drawing.Size(54, 44);
            this.EklBtn.Text = "ıconToolStripButton1";
            this.EklBtn.ToolTipText = "Ürün Ekle";
            this.EklBtn.Click += new System.EventHandler(this.EklBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // TcLbl
            // 
            this.TcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TcLbl.Margin = new System.Windows.Forms.Padding(2);
            this.TcLbl.Name = "TcLbl";
            this.TcLbl.Size = new System.Drawing.Size(37, 58);
            this.TcLbl.Text = "Adet :";
            // 
            // AdetTxtBx
            // 
            this.AdetTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdetTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdetTxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.AdetTxtBx.MaxLength = 2;
            this.AdetTxtBx.Name = "AdetTxtBx";
            this.AdetTxtBx.Size = new System.Drawing.Size(50, 58);
            this.AdetTxtBx.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdetTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdetTxtBx_KeyPress);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
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
            this.UrnCkr.ToolTipText = "Ürün Çıkar";
            this.UrnCkr.Click += new System.EventHandler(this.UrnCkr_Click);
            // 
            // indrmUyglaButton
            // 
            this.indrmUyglaButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.indrmUyglaButton.AutoSize = false;
            this.indrmUyglaButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.indrmUyglaButton.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.indrmUyglaButton.IconColor = System.Drawing.Color.Green;
            this.indrmUyglaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.indrmUyglaButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.indrmUyglaButton.Margin = new System.Windows.Forms.Padding(2);
            this.indrmUyglaButton.Name = "indrmUyglaButton";
            this.indrmUyglaButton.Size = new System.Drawing.Size(34, 34);
            this.indrmUyglaButton.Text = "ıconToolStripButton1";
            this.indrmUyglaButton.ToolTipText = "İndirim Uygula";
            this.indrmUyglaButton.Click += new System.EventHandler(this.indrmUyglaButton_Click);
            // 
            // IndrmTextBox
            // 
            this.IndrmTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.IndrmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IndrmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IndrmTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IndrmTextBox.Name = "IndrmTextBox";
            this.IndrmTextBox.Size = new System.Drawing.Size(100, 58);
            this.IndrmTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IndrmTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IndrmTextBox_KeyDown);
            this.IndrmTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IndrmTextBox_KeyPress);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 58);
            this.toolStripLabel1.Text = "İndirim :";
            // 
            // UrnEklBtn
            // 
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.13776F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.86224F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 412);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(635, 406);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ıconButton3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ıconButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(644, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 406);
            this.panel1.TabIndex = 5;
            // 
            // ıconButton3
            // 
            this.ıconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton3.FlatAppearance.BorderSize = 0;
            this.ıconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ıconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ıconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ıconButton3.Location = new System.Drawing.Point(0, 295);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(195, 50);
            this.ıconButton3.TabIndex = 22;
            this.ıconButton3.Text = "SATIŞ";
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ıconButton3.UseVisualStyleBackColor = true;
            this.ıconButton3.Click += new System.EventHandler(this.ıconButton3_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 25);
            this.label7.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.8718F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.1282F));
            this.tableLayoutPanel2.Controls.Add(this.NetTtrLbl, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.IndrmLbl, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TplmTtr, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 191);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(195, 79);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // NetTtrLbl
            // 
            this.NetTtrLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NetTtrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NetTtrLbl.Location = new System.Drawing.Point(110, 51);
            this.NetTtrLbl.Name = "NetTtrLbl";
            this.NetTtrLbl.Size = new System.Drawing.Size(81, 27);
            this.NetTtrLbl.TabIndex = 9;
            this.NetTtrLbl.Text = "0";
            this.NetTtrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(4, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Net Tutar :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IndrmLbl
            // 
            this.IndrmLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndrmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IndrmLbl.Location = new System.Drawing.Point(110, 26);
            this.IndrmLbl.Name = "IndrmLbl";
            this.IndrmLbl.Size = new System.Drawing.Size(81, 24);
            this.IndrmLbl.TabIndex = 7;
            this.IndrmLbl.Text = "0";
            this.IndrmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IndrmLbl.TextChanged += new System.EventHandler(this.IndrmLbl_TextChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "İndirim Tutar :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TplmTtr
            // 
            this.TplmTtr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TplmTtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TplmTtr.Location = new System.Drawing.Point(110, 1);
            this.TplmTtr.Name = "TplmTtr";
            this.TplmTtr.Size = new System.Drawing.Size(81, 24);
            this.TplmTtr.TabIndex = 5;
            this.TplmTtr.Text = "0";
            this.TplmTtr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Tutar :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 25);
            this.label5.TabIndex = 25;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(0, 78);
            this.textBox6.MaxLength = 2000;
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "Not Alanı";
            this.textBox6.Size = new System.Drawing.Size(195, 88);
            this.textBox6.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 28);
            this.label3.TabIndex = 24;
            // 
            // ıconButton2
            // 
            this.ıconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton2.FlatAppearance.BorderSize = 0;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ıconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.ıconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ıconButton2.Location = new System.Drawing.Point(0, 0);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(195, 50);
            this.ıconButton2.TabIndex = 20;
            this.ıconButton2.Text = "TEMIZLE";
            this.ıconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ıconButton2.UseVisualStyleBackColor = true;
            this.ıconButton2.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // SatisView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "SatisView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(862, 531);
            this.Load += new System.EventHandler(this.SatisView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton EklBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox AdetTxtBx;
        private System.Windows.Forms.ToolStripLabel TcLbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private FontAwesome.Sharp.IconToolStripButton UrnCkr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private System.Windows.Forms.ToolStripTextBox IndrmTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label NetTtrLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label IndrmLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TplmTtr;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconToolStripButton indrmUyglaButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconToolStripButton UrnEklBtn;
        public System.Windows.Forms.ToolStripTextBox BrkdTxtBx;
    }
}
