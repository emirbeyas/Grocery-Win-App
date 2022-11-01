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
    public partial class UrnDetayForm : Form
    {
        string ID;
        DbContext context = new DbContext();
        public UrnDetayForm()
        {
            InitializeComponent();
        }
        public UrnDetayForm(string id)
        {
            InitializeComponent();
            ID = id;
            context.OpenConnection();
            SQLiteDataReader sqlDataReader = context.sp_Urun_Get(id);

            while (sqlDataReader.Read())
            {
                Brkdno.Text = sqlDataReader[0].ToString();
                UrnAdi.Text = sqlDataReader[1].ToString();
                StkSayisi.Text = sqlDataReader[4].ToString() + " Ürün Kaldı";
                label1.Text = sqlDataReader[3].ToString() + " ₺";
            }
            context.CloseConnection();

        }
    }
}
