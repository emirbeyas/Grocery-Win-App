using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Medikal.Class;

namespace Medikal.View.YedekIslemleri
{
    public partial class YonetView : UserControl
    {
        DbContext context = new DbContext();
        public YonetView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void EklBtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleDznleForm kullaniciEkleDznleForm = new KullaniciEkleDznleForm();
            kullaniciEkleDznleForm.ShowDialog();
            dataGridView1.DataSource = context.sp_Kullanici_Listele();
        }

        private void YonetView_Load(object sender, EventArgs e)
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

        private void DznleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;
                int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

                KullaniciEkleDznleForm kullaniciEkleDznleForm = new KullaniciEkleDznleForm(ID);
                kullaniciEkleDznleForm.ShowDialog();
                dataGridView1.DataSource = context.sp_Kullanici_Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Düzenlenecek kullanıcıyı seçin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            //SaveFileDialog dialog = new SaveFileDialog();
            //dialog.Filter = "Backup Files|*.bak";
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{

            //    SqlCommand cmd = new SqlCommand("BACKUP DATABASE " + context.con.Database + " TO DISK = @filepath", context.con);
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Parameters.AddWithValue("@filepath", dialog.FileName);
            //    context.OpenConnection();
            //    cmd.ExecuteNonQuery();
            //    context.CloseConnection();

            //    MessageBox.Show("Veritabanı yedeğiniz oluşturuldu.", "Database Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //}
            




        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Backup Files|*.bak";
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{

            //    string query = "ALTER DATABASE [" + context.con.Database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;" +
            //        "USE MASTER RESTORE DATABASE [" + context.con.Database + "] FROM DISK= @filepath  WITH REPLACE;" +
            //        "ALTER DATABASE[" + context.con.Database + "] SET MULTI_USER";


            //    SqlCommand cmd = new SqlCommand(query, context.con);
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Parameters.AddWithValue("@filepath", dialog.FileName);
            //    context.OpenConnection();
            //    cmd.ExecuteNonQuery();
            //    context.CloseConnection();

            //    MessageBox.Show("Veritabanı yedeğinizden geri dönüldü", "Database Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //}
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

        private static void RestoreDB(string filePath, string srcFilename, string
  destFileName, bool IsCopy = false)
        {
            var srcfile = Path.Combine(filePath, srcFilename);
            var destfile = Path.Combine(filePath, destFileName);

            if (File.Exists(destfile)) File.Delete(destfile);

            if (IsCopy)
                BackupDB(filePath, srcFilename, destFileName);
            else
                File.Move(srcfile, destfile);
        }

        private static void BackupDB(string filePath, string srcFilename, string
        destFileName)
        {
            var srcfile = Path.Combine(filePath, srcFilename);
            var destfile = Path.Combine(filePath, destFileName);

            if (File.Exists(destfile)) File.Delete(destfile);

            File.Copy(srcfile, destfile);
        }

    }
}
