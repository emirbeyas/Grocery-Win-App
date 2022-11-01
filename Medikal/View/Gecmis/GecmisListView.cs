using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medikal.Class;
using System.Data.SQLite;

namespace Medikal.View.Gecmis
{
    public partial class GecmisListView : UserControl
    {
        DbContext context = new DbContext();
        public GecmisListView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void GecmisListView_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].DataPropertyName = "ID";
            dataGridView1.Columns[1].HeaderText = "NOT";
            dataGridView1.Columns[1].DataPropertyName = "NOTALANI";
            dataGridView1.Columns[2].HeaderText = "TARİH SAAT";
            dataGridView1.Columns[2].DataPropertyName = "TARIHSAAT";
            dataGridView1.Columns[3].HeaderText = "TOPLAM";
            dataGridView1.Columns[3].DataPropertyName = "TOPLAMFIYAT";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            DataTable dataTable = context.sp_Sepet_Listele();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                context.sp_Sepetsatir_temizle(Convert.ToInt32(dataTable.Rows[i]["ID"]));
            }
            context.sp_Sepet_sil();

            dataGridView1.DataSource = context.sp_Sepet_Listele(NotTxt.Text, DateTime.Now.ToString("s"));

        }

        private void StsDty_Click(object sender, EventArgs e)
        {
            DataTable dataTable = context.sp_Sepet_Listele();

            try
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

                GecmisDetay gecmisDetay = new GecmisDetay(ID);
                gecmisDetay.ShowDialog();
                NotTxt.Text = "";

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    context.sp_Sepetsatir_temizle(Convert.ToInt32(dataTable.Rows[i]["ID"]));
                }
                context.sp_Sepet_sil();

                dataGridView1.DataSource = context.sp_Sepet_Listele(NotTxt.Text, dateTimePicker1.Value.ToString("s"));
            }
            catch (Exception)
            {
                MessageBox.Show("Bir satır seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.sp_Sepet_Listele(NotTxt.Text, dateTimePicker1.Value.ToString("s"));

        }
    }
}
