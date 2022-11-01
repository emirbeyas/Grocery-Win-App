using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Medikal.Class;
namespace Medikal.View.YedekIslemleri
{
    public partial class KullaniciEkleDznleForm : Form
    {
        DbContext context = new DbContext();
        int ID;

        public KullaniciEkleDznleForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("ADMIN");
            comboBox1.Items.Add("KULLANICI");
            comboBox1.SelectedIndex = 0;

        }
        public KullaniciEkleDznleForm(int id)
        {
            InitializeComponent();

            ID = id;
            context.OpenConnection();
            KullaniciFormBaslik.Text = "Kullanıcı Düzenle";
            SQLiteDataReader sqlDataReader = context.sp_Kullanici_Get(id);

            while (sqlDataReader.Read())
            {
                textBox2.Text = sqlDataReader[1].ToString();
                comboBox1.SelectedValue = sqlDataReader[0].ToString();
            }

            comboBox1.Items.Add("ADMIN");
            comboBox1.Items.Add("KULLANICI");

            comboBox1.SelectedIndex = 0;
        }

        

        private void TmmBtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            bool ekle = true;

            try
            {
                context.OpenConnection();
                SQLiteCommand cmd = context.con.CreateCommand();
                cmd.CommandText = "select * from TBL_Kullanicilar";
                cmd.CommandType = CommandType.Text;
                SQLiteDataReader sqlDataReader = cmd.ExecuteReader();
                dataTable.Load(sqlDataReader);
                context.CloseConnection();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (textBox3.Text.Equals(textBox1.Text) && (textBox1.Text.Length > 4))
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (textBox2.Text.Equals(dataTable.Rows[i]["KULLANICIADI"].ToString()) && KullaniciFormBaslik.Text.Equals("Kullanıcı Ekle"))
                    {
                        MessageBox.Show("Kullanıcı adı zaten kayıtlı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ekle = false;
                    }
                }

                if (ekle)
                {
                    if (KullaniciFormBaslik.Text.Equals("Kullanıcı Düzenle"))
                    {
                        context.sp_Kullanici_Guncelle(ID, textBox2.Text, textBox3.Text, comboBox1.Text);
                    }
                    else
                    {
                        context.sp_Kullanici_Ekle(textBox2.Text, textBox3.Text, comboBox1.Text);
                        
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Şifreler aynı değil veya 4 karakterden az.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IptBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
