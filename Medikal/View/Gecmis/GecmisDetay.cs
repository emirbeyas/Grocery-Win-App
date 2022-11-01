using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Medikal.Class;

namespace Medikal.View.Gecmis
{
    public partial class GecmisDetay : Form
    {
        DbContext context = new DbContext();
        int ID;
        double SepetFiyat = 0;
        double indirim = 0;
        DateTime dateTime;
        public GecmisDetay()
        {
            InitializeComponent();
        }
        public GecmisDetay(int id)
        {
            InitializeComponent();
            ID = id;
            context.OpenConnection();
            SQLiteDataReader sQLiteDataReader = context.sp_Sepet_Get(id);
            while (sQLiteDataReader.Read())
            {
                label2.Text = sQLiteDataReader[2].ToString();
                label3.Text = sQLiteDataReader[3].ToString();
                label5.Text = "Yapılan İndirim :" + sQLiteDataReader[5].ToString();
                label4.Text = "TOPLAM :" + sQLiteDataReader[1].ToString();
                label6.Text = "Personel :" + sQLiteDataReader[4].ToString();
                dateTime = Convert.ToDateTime(sQLiteDataReader[2].ToString());
                SepetFiyat = Convert.ToDouble(sQLiteDataReader[1].ToString());
                indirim = Convert.ToDouble(sQLiteDataReader[5].ToString());
            }
            context.CloseConnection();

        }

        private void GecmisDetay_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].DataPropertyName = "ID";
            dataGridView1.Columns[1].HeaderText = "URUN";
            dataGridView1.Columns[1].DataPropertyName = "URUNADI";
            dataGridView1.Columns[2].HeaderText = "ADET";
            dataGridView1.Columns[2].DataPropertyName = "ADET";
            dataGridView1.Columns[3].HeaderText = "FIYAT";
            dataGridView1.Columns[3].DataPropertyName = "SATIRFIYAT";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = context.sp_SepetSatir_Listele(ID);
            dataGridView1.Columns[0].Width = 20;

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

                DialogResult dialogResult = MessageBox.Show("Seçilen satırı iade etmek istediğine emin misin?", "Emin misin", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataTable dataTable = context.sp_SepetSatir_Get(ID);
                    double silinenFiyat = context.sp_satirFiyat_Get(ID);
                    SepetFiyat = SepetFiyat - silinenFiyat;
                    context.sp_SepetSatir_Sil(ID);
                    context.sp_Sepet_Guncelle(this.ID, SepetFiyat, dateTime.ToString("s"), label3.Text, label6.Text.Split(':')[1], indirim);
                    dataGridView1.DataSource = context.sp_SepetSatir_Listele(this.ID);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        context.sp_Stok_Arttir(dataTable.Rows[i]["BARKOD"].ToString(), Convert.ToInt32(dataTable.Rows[i]["ADET"]));
                    }
                }
                context.OpenConnection();
                SQLiteDataReader sqlDataReader = context.sp_Sepet_Get(this.ID);
                while (sqlDataReader.Read())
                {
                    label2.Text = sqlDataReader[2].ToString();
                    label3.Text = sqlDataReader[3].ToString();
                    label5.Text = "Yapılan İndirim :" + sqlDataReader[5].ToString();
                    label4.Text = "TOPLAM :" + sqlDataReader[1].ToString();
                    label6.Text = "Personel :" + sqlDataReader[4].ToString();
                    dateTime = Convert.ToDateTime(sqlDataReader[2].ToString());
                    SepetFiyat = Convert.ToDouble(sqlDataReader[1].ToString());
                    indirim = Convert.ToDouble(sqlDataReader[5].ToString());
                }
                context.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek satır seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
