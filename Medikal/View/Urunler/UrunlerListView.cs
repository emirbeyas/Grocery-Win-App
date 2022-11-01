using Medikal.Class;
using System;
using System.Windows.Forms;
namespace Medikal.View.Urunler
{
    public partial class UrunlerListView : UserControl
    {
        DbContext context = new DbContext();

        public UrunlerListView(string yetki)
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            if (yetki != "ADMIN")
            {
                EklBtn.Enabled = false;
                DznleBtn.Enabled = false;
                UrnDty.Enabled = false;
            }
        }

        private void UrunlerListView_Load(object sender, EventArgs e)
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

        private void EklBtn_Click(object sender, EventArgs e)
        {
            UrunEklDznleForm urunEklDznleForm = new UrunEklDznleForm();
            urunEklDznleForm.ShowDialog();
            BrkdTxt.Text = "";
            AdTxt.Text = "";
            dataGridView1.DataSource = context.sp_Urun_Listele(BrkdTxt.Text, AdTxt.Text);

        }

        private void DznleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                string ID = dataGridView1.Rows[secsatir].Cells[0].Value.ToString();

                UrunEklDznleForm urunEklDznleForm = new UrunEklDznleForm(ID);
                urunEklDznleForm.ShowDialog();
                BrkdTxt.Text = "";
                AdTxt.Text = "";
                dataGridView1.DataSource = context.sp_Urun_Listele(BrkdTxt.Text, AdTxt.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek satır seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UrnDty_Click(object sender, EventArgs e)
        {
            try
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                string ID = dataGridView1.Rows[secsatir].Cells[0].Value.ToString();

                UrnDetayForm urnDetayForm = new UrnDetayForm(ID);
                urnDetayForm.ShowDialog();
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

        private void UrnCkr_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Seçilen ürünü silmek istediğine emin misin?", "Emin misin", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                    string ID = dataGridView1.Rows[secsatir].Cells[0].Value.ToString();

                    context.sp_Urun_Sil(ID, 0);

                    BrkdTxt.Text = "";
                    AdTxt.Text = "";
                    dataGridView1.DataSource = context.sp_Urun_Listele(BrkdTxt.Text, AdTxt.Text);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek satır seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
