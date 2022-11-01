using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medikal.Class;
using Medikal.View.Anasayfa;
using Medikal.View.Gecmis;
using Medikal.View.Hastalar;
using Medikal.View.infoBox;
using Medikal.View.Satis;
using Medikal.View.Urunler;
using Medikal.View.YedekIslemleri;
using Medikal.View.Kullanicilar;



namespace Medikal
{
    public partial class Form1 : Form
    {
        LoginUser loginUser = new LoginUser();
        string loginYetki = null;
        string loginKullaniciAdi = null;

        DbContext context = new DbContext();
        public Form1(string loginKullaniciAdi, string loginYetki)
        {
            InitializeComponent();
            loginUser.kullaniciAdi = loginKullaniciAdi;
            loginUser.yetki = loginYetki;
            this.loginYetki = loginYetki;
            this.loginKullaniciAdi = loginKullaniciAdi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonDisable();
            lblAnaSayfaActive.Visible = true;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(new AnasayfaView());
            if (loginUser.yetki != "ADMIN")
            {
                ıconButton5.Visible = false;
                lblYedekActive.Visible = false;
            }



        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            buttonDisable();
            lblAnaSayfaActive.Visible = true;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(new AnasayfaView());
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            buttonDisable();
            lblHastalarActive.Visible = true;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(new HastalarListView(loginYetki));
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            buttonDisable();
            lblUrunlerActive.Visible = true;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(new UrunlerListView(loginYetki));
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            buttonDisable();
            lblGecmisActive.Visible = true;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(new GecmisListView());
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            buttonDisable();
            lblYedekActive.Visible = true;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(new KullanicilarView());
        }

        

        private void ıconButton6_Click(object sender, EventArgs e)
        {
            buttonDisable();
            lblSatisActive.Visible = true;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(new SatisView(loginKullaniciAdi));
        }

        public void buttonDisable()
        {
            lblAnaSayfaActive.Visible = false;
            lblGecmisActive.Visible = false;
            lblHastalarActive.Visible = false;
            lblSatisActive.Visible = false;
            lblUrunlerActive.Visible = false;
            lblYedekActive.Visible = false;
        }

        private void ıconButton6_LocationChanged(object sender, EventArgs e)
        {

            if (lblSatisActive.Visible)
            {
                buttonDisable();
                lblSatisActive.Location = new Point(3, ıconButton6.Location.Y);
                lblSatisActive.Visible = true;
            }
            
        }
    }
}
