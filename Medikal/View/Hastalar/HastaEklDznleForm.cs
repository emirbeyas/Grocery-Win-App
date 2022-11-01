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
    public partial class HastaEklDznleForm : Form
    {
        DbContext context = new DbContext();
        int HastaID;
        public HastaEklDznleForm()
        {
            InitializeComponent();
        }
        public HastaEklDznleForm(int id)
        {
            HastaID = id;
            InitializeComponent();
            context.OpenConnection();
            HstaFormBaslik.Text = "Hasta Düzenle";
            SQLiteDataReader sqlDataReader = context.sp_Hasta_Get(id);

            while (sqlDataReader.Read())
            {
                textBox1.Text = sqlDataReader[1].ToString();
                textBox2.Text = sqlDataReader[2].ToString();
                textBox3.Text = sqlDataReader[3].ToString();
                maskedTextBox1.Text = sqlDataReader[4].ToString();
                textBox5.Text = sqlDataReader[5].ToString();

            }
            context.CloseConnection();
        }

        private void TmmBtn_Click(object sender, EventArgs e)
        {
            if (HstaFormBaslik.Text == "Hasta Düzenle")
            {
                context.sp_Hasta_Guncelle(HastaID, textBox1.Text, textBox2.Text, textBox3.Text, maskedTextBox1.Text, textBox5.Text);
            }
            else
            {
                context.sp_Hasta_Ekle(textBox1.Text, textBox2.Text, textBox3.Text, maskedTextBox1.Text, textBox5.Text);
            }
            this.Close();
        }

        private void IptBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
