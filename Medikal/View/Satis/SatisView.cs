using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Medikal.Class;

namespace Medikal.View.Satis
{
    public partial class SatisView : UserControl
    {
        int SepetID = 0;
        double ToplamTutar = 0;
        double indirimTutar = 0;
        string personelAdi = null;

        DbContext context = new DbContext();
        public SatisView(string Personel)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            AdetTxtBx.Text = "1";
            IndrmTextBox.Text = "0,00";
            personelAdi = Personel;

        }

        private void SatisView_Load(object sender, EventArgs e)
        {
            context.sp_Sepet_Ekle(0, DateTime.Now.ToString("s"));
            BrkdTxtBx.Focus();
            SepetID = context.sp_SonSepet_GetID();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].DataPropertyName = "ID";
            dataGridView1.Columns[1].HeaderText = "BARKOD";
            dataGridView1.Columns[1].DataPropertyName = "BARKOD";
            dataGridView1.Columns[2].HeaderText = "URUN";
            dataGridView1.Columns[2].DataPropertyName = "URUNADI";
            dataGridView1.Columns[3].HeaderText = "ADET";
            dataGridView1.Columns[3].DataPropertyName = "ADET";
            dataGridView1.Columns[4].HeaderText = "FIYAT";
            dataGridView1.Columns[4].DataPropertyName = "SATIRFIYAT";



            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = context.sp_SepetSatir_Listele(SepetID);
            dataGridView1.Columns[0].Width = 35;

        }

        private void BrkdTxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string urunID = BrkdTxtBx.Text;
                Double urunFiyat = context.sp_UrunFiyat_GetBarkod(BrkdTxtBx.Text);
                double satirFiyat = urunFiyat * Convert.ToInt32(AdetTxtBx.Text);

                context.sp_SepetSatir_Ekle(SepetID, urunID, Convert.ToInt32(AdetTxtBx.Text), satirFiyat);

                dataGridView1.DataSource = context.sp_SepetSatir_Listele(SepetID);

                ToplamTutar = ToplamTutar + satirFiyat;
                TplmTtr.Text = ToplamTutar.ToString();
                BrkdTxtBx.Clear();
                netTutarGuncelle();
            }

        }


        private void ıconButton3_Click(object sender, EventArgs e)
        {
            context.sp_Sepet_Guncelle(SepetID, Convert.ToDouble(NetTtrLbl.Text), DateTime.Now.ToString("s"), textBox6.Text, personelAdi, Convert.ToDouble(IndrmLbl.Text));
            DataTable dataTable = context.sp_SepetSatir_Listele(SepetID);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                context.sp_Stok_Azalt(dataTable.Rows[i]["BARKOD"].ToString(), Convert.ToInt32(dataTable.Rows[i]["ADET"]));
            }

            context.sp_Sepet_Ekle(0, DateTime.Now.ToString("s"));
            SepetID = context.sp_SonSepet_GetID();
            dataGridView1.DataSource = context.sp_SepetSatir_Listele(SepetID);


            MessageBox.Show("Satış yapıldı.", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BrkdTxtBx.Clear();
            AdetTxtBx.Text = "1";
            IndrmTextBox.Text = "0,00";
            TplmTtr.Text = "0";
            NetTtrLbl.Text = "0";
            IndrmLbl.Text = "0";
            ToplamTutar = 0;
            indirimTutar = 0;
            textBox6.Clear();
            BrkdTxtBx.Focus();

        }

        private void IndrmTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                indirimTutar = Convert.ToDouble(IndrmTextBox.Text);
                IndrmLbl.Text = indirimTutar.ToString();
            }

        }

        private void IndrmLbl_TextChanged(object sender, EventArgs e)
        {
            netTutarGuncelle();
        }

        private void EklBtn_Click(object sender, EventArgs e)
        {
            string urunID = BrkdTxtBx.Text;
            Double urunFiyat = context.sp_UrunFiyat_GetBarkod(BrkdTxtBx.Text);
            double satirFiyat = urunFiyat * Convert.ToInt32(AdetTxtBx.Text);

            context.sp_SepetSatir_Ekle(SepetID, urunID, Convert.ToInt32(AdetTxtBx.Text), satirFiyat);

            dataGridView1.DataSource = context.sp_SepetSatir_Listele(SepetID);

            ToplamTutar = ToplamTutar + satirFiyat;
            TplmTtr.Text = ToplamTutar.ToString();
            BrkdTxtBx.Clear();
            netTutarGuncelle();

        }

        private void indrmUyglaButton_Click(object sender, EventArgs e)
        {
            indirimTutar = Convert.ToDouble(IndrmTextBox.Text);
            IndrmLbl.Text = indirimTutar.ToString();
        }

        private void UrnCkr_Click(object sender, EventArgs e)
        {
            try
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

                ToplamTutar = ToplamTutar - context.sp_satirFiyat_Get(ID);

                context.sp_SepetSatir_Sil(ID);
                dataGridView1.DataSource = context.sp_SepetSatir_Listele(SepetID);
                netTutarGuncelle();
                TplmTtr.Text = ToplamTutar.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek satır seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            context.sp_Sepet_Ekle(0, DateTime.Now.ToString("s"));
            SepetID = context.sp_SonSepet_GetID();
            dataGridView1.DataSource = context.sp_SepetSatir_Listele(SepetID);

            MessageBox.Show("Sepet Temizlendi.", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);


            BrkdTxtBx.Clear();
            AdetTxtBx.Text = "1";
            IndrmTextBox.Text = "0,00";
            TplmTtr.Text = "0";
            NetTtrLbl.Text = "0";
            IndrmLbl.Text = "0";
            ToplamTutar = 0;
            indirimTutar = 0;
            textBox6.Clear();
            BrkdTxtBx.Focus();
        }

        void netTutarGuncelle()
        {
            NetTtrLbl.Text = (ToplamTutar - indirimTutar).ToString();
        }

        private void BrkdTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (Char.IsDigit(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void AdetTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (Char.IsDigit(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void IndrmTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (Char.IsDigit(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                int counter = 0;
                char[] check = IndrmTextBox.Text.ToCharArray();
                for (int i = 0; i < check.Length; i++)
                {
                    if (check[i].Equals(','))
                    {
                        counter++;
                    }
                }
                if (counter < 1)
                {
                    if (e.KeyChar.Equals(',')) return;
                }
                e.Handled = true;
            }

        }

        private void UrnEklBtn_Click(object sender, EventArgs e)
        {
            UrunEkleForm urunEkleForm = new UrunEkleForm();
            urunEkleForm.ShowDialog();
            BrkdTxtBx.Text = urunEkleForm.BARKOD;
        }
    }
}
