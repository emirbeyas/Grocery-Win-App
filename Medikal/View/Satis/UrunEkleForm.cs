using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Medikal.Class;
using Medikal.View.Satis;

namespace Medikal.View.Satis
{
    public partial class UrunEkleForm : Form
    {
        DbContext context = new DbContext();
        public string BARKOD = "";
        public UrunEkleForm()
        {
            InitializeComponent();
        }

        private void UrunEkleForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderText = "BARKOD NO";
            dataGridView1.Columns[0].DataPropertyName = "BARKOD";
            dataGridView1.Columns[1].HeaderText = "URUN ADI";
            dataGridView1.Columns[1].DataPropertyName = "URUNADI";
            dataGridView1.Columns[2].HeaderText = "STOK";
            dataGridView1.Columns[2].DataPropertyName = "STOK";
            dataGridView1.Columns[3].HeaderText = "FİYAT";
            dataGridView1.Columns[3].DataPropertyName = "SATISFIYAT";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = context.sp_Urun_Listele(BrkdTxt.Text, AdTxt.Text);
        }

        private void UrnEklBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                BARKOD = dataGridView1.Rows[secsatir].Cells[0].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek satır seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrkdTxt_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.sp_Urun_Listele(BrkdTxt.Text, AdTxt.Text);
        }

        private void AdTxt_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.sp_Urun_Listele(BrkdTxt.Text, AdTxt.Text);
        }
    }
}
