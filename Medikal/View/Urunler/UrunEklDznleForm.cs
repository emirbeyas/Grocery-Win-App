using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medikal.Class;
using System.Data.SQLite;

namespace Medikal.View.Urunler
{
    public partial class UrunEklDznleForm : Form
    {
        string ID;
        DbContext context = new DbContext();
        public UrunEklDznleForm()
        {
            InitializeComponent();
            

        }
        public UrunEklDznleForm(string id)
        {
            InitializeComponent();
            UrnEklBaslik.Text = "Ürün Düzenle";
            textBox2.Enabled = false;
            ID = id;



            context.OpenConnection();
            SQLiteDataReader sqlDataReader = context.sp_Urun_Get(id);

            while (sqlDataReader.Read())
            {
                textBox2.Text = sqlDataReader[0].ToString();
                textBox3.Text = sqlDataReader[1].ToString();
                textBox4.Text = sqlDataReader[2].ToString();
                textBox1.Text = sqlDataReader[3].ToString();
                textBox5.Text = sqlDataReader[4].ToString();
            }
            context.CloseConnection();
        }

        private void TmmBtn_Click(object sender, EventArgs e)
        {
            bool HATA = true;

            context.OpenConnection();
            SQLiteCommand cmd = context.con.CreateCommand();
            cmd.CommandText = "select BARKOD from TBL_Urunler";
            cmd.CommandType = CommandType.Text;
            SQLiteDataReader sqlDataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (textBox2.Text.Equals(dataTable.Rows[i]["BARKOD"].ToString()))
                {
                    HATA = false;
                }
            }
            context.CloseConnection();

            if (UrnEklBaslik.Text.Equals("Ürün Düzenle"))
            {
                context.sp_Urun_Guncelle(textBox2.Text, textBox3.Text, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox1.Text), Convert.ToInt32(textBox5.Text));
            }
            else
            {
                if (HATA)
                {
                    context.sp_Urun_Ekle(textBox2.Text, textBox3.Text, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox1.Text), Convert.ToInt32(textBox5.Text));
                }
                else
                {
                    MessageBox.Show("Barkod Numarası Zaten Kayıtlı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        private void IptBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (Char.IsDigit(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (Char.IsDigit(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                int counter = 0;
                char[] check = textBox1.Text.ToCharArray();
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (Char.IsDigit(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                int counter = 0;
                char[] check = textBox4.Text.ToCharArray();
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (Char.IsDigit(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }
    }
}
