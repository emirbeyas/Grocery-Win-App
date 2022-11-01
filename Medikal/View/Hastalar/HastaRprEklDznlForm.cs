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
    public partial class HastaRprEklDznlForm : Form
    {
        DbContext context = new DbContext();
        int HastaID;
        public HastaRprEklDznlForm()
        {
            InitializeComponent();
        }
        public HastaRprEklDznlForm(int id)
        {
            InitializeComponent();
            HastaID = id;
        }
        public HastaRprEklDznlForm(string secenek, int id)
        {
            HastaID = id;
            InitializeComponent();
            HstaRprEklBaslik.Text = "Hasta Raporu Düzenle";
            context.OpenConnection();

            SQLiteDataReader sqlDataReader = context.sp_HastaRaporu_Get(id);

            while (sqlDataReader.Read())
            {
                textBox2.Text = sqlDataReader[1].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(sqlDataReader[2].ToString());
                textBox1.Text = sqlDataReader[3].ToString();
                textBox6.Text = sqlDataReader[5].ToString();
            }
        }

        private void TmmBtn_Click(object sender, EventArgs e)
        {
            if (HstaRprEklBaslik.Text == "Hasta Raporu Düzenle")
            {
                context.sp_HastaRaporu_Guncelle(HastaID, textBox2.Text, Convert.ToDateTime(dateTimePicker1.Text).ToString("s").Split('T')[0], Convert.ToInt32(textBox1.Text), textBox6.Text);
            }
            else
            {
                context.sp_HastaRaporu_Ekle(textBox2.Text, Convert.ToDateTime(dateTimePicker1.Text).ToString("s").Split('T')[0], Convert.ToInt32(textBox1.Text), HastaID, textBox6.Text);
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
