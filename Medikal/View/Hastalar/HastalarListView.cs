using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medikal.Class;

namespace Medikal.View.Hastalar
{
    public partial class HastalarListView : UserControl
    {
        DbContext context = new DbContext();
        public HastalarListView(string yetki)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            if (yetki != "ADMIN")
            {
                EklBtn.Enabled = false;
                DznleBtn.Enabled = false;
                RprList.Enabled = false;
            }
        }

        private void EklBtn_Click(object sender, EventArgs e)
        {
            HastaEklDznleForm hastaEklDznleForm = new HastaEklDznleForm();
            hastaEklDznleForm.ShowDialog();
            TcTxt.Text = "";
            AdTxt.Text = "";
            SoyadTxt.Text = "";
            dataGridView1.DataSource = context.sp_Hasta_Listele(TcTxt.Text, AdTxt.Text, SoyadTxt.Text);
        }

        private void HastalarListView_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].DataPropertyName = "ID";
            dataGridView1.Columns[1].HeaderText = "TC";
            dataGridView1.Columns[1].DataPropertyName = "TC";
            dataGridView1.Columns[2].HeaderText = "ADI";
            dataGridView1.Columns[2].DataPropertyName = "ADI";
            dataGridView1.Columns[3].HeaderText = "SOYADI";
            dataGridView1.Columns[3].DataPropertyName = "SOYADI";
            dataGridView1.Columns[4].HeaderText = "TELEFON";
            dataGridView1.Columns[4].DataPropertyName = "TELEFON";
            dataGridView1.Columns[5].HeaderText = "ADRES";
            dataGridView1.Columns[5].DataPropertyName = "ADRES";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = context.sp_Hasta_Listele(TcTxt.Text, AdTxt.Text, SoyadTxt.Text);

            dataGridView1.Columns[0].Width = 35;
        }

        private void DznleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

                HastaEklDznleForm hastaEklDznleForm = new HastaEklDznleForm(ID);
                hastaEklDznleForm.ShowDialog();
                TcTxt.Text = "";
                AdTxt.Text = "";
                SoyadTxt.Text = "";
                dataGridView1.DataSource = context.sp_Hasta_Listele(TcTxt.Text, AdTxt.Text, SoyadTxt.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek satır seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RprList_Click(object sender, EventArgs e)
        {
            try
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

                HastaRaporlariForm hastaRaporlariForm = new HastaRaporlariForm(ID);
                hastaRaporlariForm.ShowDialog();
                TcTxt.Text = "";
                AdTxt.Text = "";
                SoyadTxt.Text = "";
                dataGridView1.DataSource = context.sp_Hasta_Listele(TcTxt.Text, AdTxt.Text, SoyadTxt.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek satır seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TcTxt_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.sp_Hasta_Listele(TcTxt.Text, AdTxt.Text, SoyadTxt.Text);
        }

        private void AdTxt_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.sp_Hasta_Listele(TcTxt.Text, AdTxt.Text, SoyadTxt.Text);

        }

        private void SoyadTxt_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.sp_Hasta_Listele(TcTxt.Text, AdTxt.Text, SoyadTxt.Text);

        }
    }
}
