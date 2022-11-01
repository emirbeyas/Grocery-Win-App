using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medikal.Class;
using System.Data.SQLite;

namespace Medikal.View.Hastalar
{
    public partial class HastaRaporlariForm : Form
    {
        DbContext context = new DbContext();
        int ID;
        public HastaRaporlariForm()
        {
            InitializeComponent();
        }
        public HastaRaporlariForm(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void HastaRaporlariForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].DataPropertyName = "ID";
            dataGridView1.Columns[1].HeaderText = "RAPOR ADI";
            dataGridView1.Columns[1].DataPropertyName = "RAPORADI";
            dataGridView1.Columns[2].HeaderText = "TARİH";
            dataGridView1.Columns[2].DataPropertyName = "BASTARIH";
            dataGridView1.Columns[3].HeaderText = "TERKRAR SAYISI";
            dataGridView1.Columns[3].DataPropertyName = "TEKRAR";
            dataGridView1.Columns[4].HeaderText = "NOT";
            dataGridView1.Columns[4].DataPropertyName = "NOTALANI";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = context.sp_HastaRaporu_Listele(ID);
        }

        private void HRprEkl_Click(object sender, EventArgs e)
        {
            HastaRprEklDznlForm hastaRprEklDznlForm = new HastaRprEklDznlForm(ID);
            hastaRprEklDznlForm.ShowDialog();
            dataGridView1.DataSource = context.sp_HastaRaporu_Listele(ID);

        }

        private void RprDznle_Click(object sender, EventArgs e)
        {
            int secsatir = dataGridView1.SelectedCells[0].RowIndex;
            int ID2 = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

            HastaRprEklDznlForm hastaRprEklDznlForm = new HastaRprEklDznlForm("Duzenle", ID2);
            hastaRprEklDznlForm.ShowDialog();
            dataGridView1.DataSource = context.sp_HastaRaporu_Listele(ID);
        }

        private void RprSil_Click(object sender, EventArgs e)
        {
            try
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

                DialogResult dialogResult = MessageBox.Show("Raporu silmek istediğine emin misin?", "Emin misin", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    context.sp_HastaRaporu_Sil(ID);
                    dataGridView1.DataSource = context.sp_HastaRaporu_Listele(this.ID);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek satır seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
