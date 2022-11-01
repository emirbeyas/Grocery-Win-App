using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using Medikal.Class;

namespace Medikal.View.Anasayfa
{
    public partial class AnasayfaView : UserControl
    {
        DbContext context = new DbContext();
        public AnasayfaView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void AnasayfaView_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderText = "RAPOR ADI";
            dataGridView1.Columns[0].DataPropertyName = "RAPORADI";
            dataGridView1.Columns[1].HeaderText = "HASTA ADI";
            dataGridView1.Columns[1].DataPropertyName = "ADI";
            dataGridView1.Columns[2].HeaderText = "NOT";
            dataGridView1.Columns[2].DataPropertyName = "NOTALANI";
            dataGridView1.Columns[3].HeaderText = "TARİH";
            dataGridView1.Columns[3].DataPropertyName = "BASTARIH";
            dataGridView1.Columns[4].HeaderText = "TEKRAR";
            dataGridView1.Columns[4].DataPropertyName = "TEKRAR";
            dataGridView1.Columns[5].HeaderText = "TELEFON";
            dataGridView1.Columns[5].DataPropertyName = "TELEFON";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            context.sp_Sattarih_Guncelle();
            dataGridView1.DataSource = context.sp_Anasayfa_Listele();



        }
    }
}
