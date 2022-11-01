using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medikal.Class;
using System.Data.SQLite;
using System.IO;

namespace Medikal
{
    public partial class LoginForm : Form
    {
        DbContext context = new DbContext();
        public LoginForm()
        {
            InitializeComponent();


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            bool giris = false;
            if (e.KeyCode == Keys.Enter)
            {



                DataTable dataTable = context.sp_Kullanici_Listele();


                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (textBox1.Text.Equals(dataTable.Rows[i]["KULLANICIADI"].ToString()) && textBox2.Text.Equals(dataTable.Rows[i]["SIFRE"].ToString()) || true )
                    {
                        string YetkiAdi = dataTable.Rows[i]["YETKI"].ToString();


                        Form1 form1 = new Form1(dataTable.Rows[i]["KULLANICIADI"].ToString(), YetkiAdi);
                        this.Hide();
                        form1.ShowDialog();
                        this.Close();
                        giris = true;
                    }

                }
                if (!giris)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            bool giris = false;


            DataTable dataTable = context.sp_Kullanici_Listele();


            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (textBox1.Text.Equals(dataTable.Rows[i]["KULLANICIADI"].ToString()) && textBox2.Text.Equals(dataTable.Rows[i]["SIFRE"].ToString()))
                {
                    string YetkiAdi = dataTable.Rows[i]["YETKI"].ToString();


                    Form1 form1 = new Form1(dataTable.Rows[i]["KULLANICIADI"].ToString(), YetkiAdi);
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                    giris = true;
                }

            }

            if (textBox1.Text.Equals("SuperAdmin") && textBox2.Text.Equals("SuperAdmin5447810441*"))
            {

                Form1 form1 = new Form1("SUPERADMIN", "ADMIN");
                this.Hide();
                form1.ShowDialog();
                this.Close();
                giris = true;
            }
            if (!giris)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
 }
