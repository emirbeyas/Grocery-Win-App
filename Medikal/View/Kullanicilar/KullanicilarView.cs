using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medikal.Class;

namespace Medikal.View.Kullanicilar
{
    public partial class KullanicilarView : UserControl
    {
        DbContext context = new DbContext();
        public KullanicilarView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void EklBtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm kullaniciEkleDznleForm = new KullaniciEkleForm();
            kullaniciEkleDznleForm.ShowDialog();
            dataGridView1.DataSource = context.sp_Kullanici_Listele();
        }

        private void DznleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

                KullaniciEkleForm kullaniciEkleDznleForm = new KullaniciEkleForm(ID);
                kullaniciEkleDznleForm.ShowDialog();
                dataGridView1.DataSource = context.sp_Kullanici_Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Düzenlenecek kullanıcıyı seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kllnciSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Seçilen kullanıcıyı silmek istediğine emin misin?", "Emin misin", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                    int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);
                    context.sp_Kullanici_Sil(ID);
                    dataGridView1.DataSource = context.sp_Kullanici_Listele();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek satır seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KullanicilarView_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].DataPropertyName = "ID";
            dataGridView1.Columns[1].HeaderText = "KULLANICI ADI";
            dataGridView1.Columns[1].DataPropertyName = "KULLANICIADI";
            dataGridView1.Columns[2].HeaderText = "YETKI";
            dataGridView1.Columns[2].DataPropertyName = "YETKI";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = context.sp_Kullanici_Listele();

            dataGridView1.Columns[0].Width = 25;
        }
    }
}
