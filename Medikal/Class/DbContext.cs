using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Medikal.Class
{
    class DbContext
    {
        public SQLiteConnection con = null;

        public DbContext()
        {
            //con = new SQLiteConnection(System.IO.File.ReadAllText(@"C:\DatabasePath.txt"));

            con = new SQLiteConnection("Data Source=DATA\\MedicalDB.db;Version=3;Read Only=False;");

        }

        public void OpenConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Bağlantı Kapatılamadı", ex);
            }
        }

        private void CMD_Run(SQLiteCommand cmd)
        {
            try
            {
                OpenConnection();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                }
            }
            catch (Exception exp)
            {
                CloseConnection();
                MessageBox.Show(exp.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable SP_DataTable(SQLiteCommand cmd)
        {
            DataTable dataTable = new DataTable();
            try
            {
                OpenConnection();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    CloseConnection();
                }
            }
            catch (Exception exp)
            {
                CloseConnection();
                MessageBox.Show(exp.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return dataTable;
        }

        public DataTable sp_Hasta_Listele(string tc, string ad, string soyad)
        {
            string komut = "SELECT * FROM TBL_Hastalar";
            string where = "";

            if (ad != "")
            {
                where = " WHERE ADI LIKE '%" + ad + "%' ";
            }
            if (soyad != "")
            {
                if (where.Length > 0)
                {
                    where = where + " AND SOYADI LIKE '%" + soyad + "%' ";
                }
                else
                {
                    where = " WHERE SOYADI LIKE '%" + soyad + "%' ";
                }
            }
            if (tc != "")
            {
                if (where.Length > 0)
                {
                    where = where + " AND TC LIKE '%" + tc + "%' ";
                }
                else
                {
                    where = " WHERE TC LIKE '%" + tc + "%' ";
                }
            }
            komut = komut + where;

            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = komut;

            return SP_DataTable(cmd);
        }

        public void sp_Hasta_Ekle(string tc, string adi, string soyadi, string telefon, string adres )
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO TBL_Hastalar(TC, ADI, SOYADI, TELEFON, ADRES) VALUES (@TC, @ADI, @SOYADI, @TELEFON, @ADRES)";

            cmd.Parameters.AddWithValue("TC", tc);
            cmd.Parameters.AddWithValue("ADI", adi);
            cmd.Parameters.AddWithValue("SOYADI", soyadi);
            cmd.Parameters.AddWithValue("TELEFON", telefon);
            cmd.Parameters.AddWithValue("ADRES", adres);

            CMD_Run(cmd);
        }
        public SQLiteDataReader sp_Hasta_Get(int id)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM TBL_Hastalar WHERE ID = @ID";

            cmd.Parameters.AddWithValue("ID", id);

            SQLiteDataReader sqlDataReader = cmd.ExecuteReader();
            return sqlDataReader;
        }
        public void sp_Hasta_Guncelle(int id, string tc, string adi, string soyadi, string telefon, string adres)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "UPDATE TBL_Hastalar SET TC = @TC, ADI = @adi, SOYADI = @Soyadi, TELEFON = @Telefon, ADRES = @Adres WHERE ID = @ID ";

            cmd.Parameters.AddWithValue("ID", id);
            cmd.Parameters.AddWithValue("TC", tc);
            cmd.Parameters.AddWithValue("Adi", adi);
            cmd.Parameters.AddWithValue("Soyadi", soyadi);
            cmd.Parameters.AddWithValue("Telefon", telefon);
            cmd.Parameters.AddWithValue("Adres", adres);

            CMD_Run(cmd);
        }
        public DataTable sp_HastaRaporu_Listele(int ID)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM TBL_HastaRaporlari WHERE HASTA_ID = @ID";
            cmd.Parameters.AddWithValue("ID", ID);

            return SP_DataTable(cmd);
        }
        public SQLiteDataReader sp_HastaRaporu_Get(int id)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM TBL_HastaRaporlari WHERE ID = @ID";

            cmd.Parameters.AddWithValue("ID", id);

            SQLiteDataReader sqlDataReader = cmd.ExecuteReader();
            return sqlDataReader;
        }
        public void sp_HastaRaporu_Ekle(string RAPORADI, string BASTARIH, int TEKRAR, int HASTA_ID, string NOTALANI)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO TBL_HastaRaporlari(RAPORADI, BASTARIH, TEKRAR, HASTA_ID, NOTALANI, SATTARIH, ARTISTEKRAR) VALUES (@RAPORADI, @BASTARIH, @TEKRAR, @HASTA_ID, @NOTALANI, @SATTARIH ,@ARTISTEKRAR )";

            string ARTISTEKRAR = "+" + TEKRAR + " DAY";

            cmd.Parameters.AddWithValue("RAPORADI", RAPORADI);
            cmd.Parameters.AddWithValue("BASTARIH", BASTARIH);
            cmd.Parameters.AddWithValue("TEKRAR", TEKRAR);
            cmd.Parameters.AddWithValue("HASTA_ID", HASTA_ID);
            cmd.Parameters.AddWithValue("NOTALANI", NOTALANI);
            cmd.Parameters.AddWithValue("SATTARIH", BASTARIH);
            cmd.Parameters.AddWithValue("ARTISTEKRAR", ARTISTEKRAR);

            CMD_Run(cmd);
        }
        public void sp_HastaRaporu_Sil(int id)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "Delete from TBL_HastaRaporlari where ID = @ID";
            cmd.Parameters.AddWithValue("ID", id);

            CMD_Run(cmd);
        }
        public void sp_HastaRaporu_Guncelle(int ID, string RAPORADI, string BASTARIH, int TEKRAR, string NOTALANI)
        {
            string ARTISTEKRAR = "+" + TEKRAR + " DAY";

            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "UPDATE TBL_HastaRaporlari SET RAPORADI = @RAPORADI, BASTARIH = @BASTARIH, TEKRAR = @TEKRAR, NOTALANI = @NOTALANI, ARTISTEKRAR = @BASTARIH, ARTISTEKRAR = @ARTISTEKRAR  WHERE ID = @ID ";

            cmd.Parameters.AddWithValue("ID", ID);
            cmd.Parameters.AddWithValue("RAPORADI", RAPORADI);
            cmd.Parameters.AddWithValue("BASTARIH", BASTARIH);
            cmd.Parameters.AddWithValue("TEKRAR", TEKRAR);
            cmd.Parameters.AddWithValue("NOTALANI", NOTALANI);
            cmd.Parameters.AddWithValue("ARTISTEKRAR", ARTISTEKRAR);

            CMD_Run(cmd);
        }
        public DataTable sp_Sepet_Listele(string notAlani, string date)
        {
            string komut = "SELECT * FROM TBL_Sepet";
            string where = "";

            if (notAlani != "")
            {
                where = " WHERE NOTALANI LIKE '%" + notAlani + "%' ";
            }
            if (date != "")
            {
                if (where.Length > 0)
                {
                    where = where + " AND substr(TARIHSAAT, 1, 10) = '" + date.Split('T')[0] + "'";
                }
                else
                {
                    where = " WHERE substr(TARIHSAAT, 1, 10) = '" + date.Split('T')[0] + "'";
                }
            }
            komut = komut + where;

            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = komut;

            return SP_DataTable(cmd);
        }
        public DataTable sp_Sepet_Listele()
        {
            string komut = "SELECT * FROM TBL_Sepet WHERE TOPLAMFIYAT <= 0";
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = komut;

            return SP_DataTable(cmd);
        }
        public void sp_Sepet_Ekle(double TOPLAMFIYAT, string TARIHSAAT)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO TBL_Sepet(TOPLAMFIYAT, TARIHSAAT) VALUES (@TOPLAMFIYAT, @TARIHSAAT)";

            cmd.Parameters.AddWithValue("TOPLAMFIYAT", TOPLAMFIYAT);
            cmd.Parameters.AddWithValue("TARIHSAAT", TARIHSAAT);

            CMD_Run(cmd);
        }
        public void sp_Sepet_Guncelle(int ID, double TOPLAMFIYAT, string TARIHSAAT, string NOTALANI, string PERSONELADI, double INDIRIM)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "UPDATE TBL_Sepet SET TOPLAMFIYAT = @TOPLAMFIYAT, TARIHSAAT = @TARIHSAAT, NOTALANI = @NOTALANI, PERSONELADI = @PERSONELADI, INDIRIM = @INDIRIM WHERE ID = @ID ";

            cmd.Parameters.AddWithValue("ID", ID);
            cmd.Parameters.AddWithValue("TOPLAMFIYAT", TOPLAMFIYAT);
            cmd.Parameters.AddWithValue("TARIHSAAT", TARIHSAAT);
            cmd.Parameters.AddWithValue("NOTALANI", NOTALANI);
            cmd.Parameters.AddWithValue("PERSONELADI", PERSONELADI);
            cmd.Parameters.AddWithValue("INDIRIM", INDIRIM);

            CMD_Run(cmd);
        }
        public SQLiteDataReader sp_Sepet_Get(int id)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM TBL_Sepet WHERE ID = @ID";

            cmd.Parameters.AddWithValue("ID", id);

            SQLiteDataReader sqlDataReader = cmd.ExecuteReader();
            return sqlDataReader;
        }
        public DataTable sp_SepetSatir_Listele(int SEPETID)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM VW_SepetSatir WHERE SEPET_ID = @SEPETID";
            cmd.Parameters.AddWithValue("SEPETID", SEPETID);

            return SP_DataTable(cmd);
        }
        public void sp_SepetSatir_Ekle(int SEPET_ID, string URUN_ID, int ADET, double SATIRFIYAT)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO TBL_SepetSatir(SEPET_ID, URUN_ID, ADET, SATIRFIYAT) VALUES (@SEPET_ID, @URUN_ID, @ADET, @SATIRFIYAT)";

            cmd.Parameters.AddWithValue("SEPET_ID", SEPET_ID);
            cmd.Parameters.AddWithValue("URUN_ID", URUN_ID);
            cmd.Parameters.AddWithValue("ADET", ADET);
            cmd.Parameters.AddWithValue("SATIRFIYAT", SATIRFIYAT);

            CMD_Run(cmd);
        }
        public void sp_SepetSatir_Sil(int id)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "Delete from TBL_SepetSatir where ID = @ID";
            cmd.Parameters.AddWithValue("ID", id);

            CMD_Run(cmd);
        }
        public DataTable sp_SepetSatir_Get(int id)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM VW_SepetSatir WHERE ID = @ID";

            cmd.Parameters.AddWithValue("ID", id);

            return SP_DataTable(cmd);
        }
        public DataTable sp_Urun_Listele(string barkod, string urunAdi)
        {
            string komut = "SELECT * FROM TBL_Urunler";
            string where = "";

            if (barkod != "")
            {
                where = " WHERE BARKOD LIKE '%" + barkod + "%' ";
            }
            if (urunAdi != "")
            {
                if (where.Length > 0)
                {
                    where = where + " AND URUNADI LIKE '%" + urunAdi + "%' ";
                }
                else
                {
                    where = " WHERE URUNADI LIKE '%" + urunAdi + "%' ";
                }
            }
            if (where.Length > 0)
            {
                where = where + " AND DURUM = 1 ";
            }
            else
            {
                where = " WHERE DURUM = 1  ";
            }


            komut = komut + where;

            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = komut;

            return SP_DataTable(cmd);
        }
        public void sp_Urun_Ekle(string BARKOD, string URUNADI, double SATISFIYAT, double ALISFIYAT, int STOK)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO TBL_Urunler(BARKOD, URUNADI, SATISFIYAT, ALISFIYAT, STOK, DURUM) VALUES (@BARKOD, @URUNADI, @SATISFIYAT, @ALISFIYAT, @STOK, @DURUM)";

            cmd.Parameters.AddWithValue("BARKOD", BARKOD);
            cmd.Parameters.AddWithValue("URUNADI", URUNADI);
            cmd.Parameters.AddWithValue("SATISFIYAT", SATISFIYAT);
            cmd.Parameters.AddWithValue("ALISFIYAT", ALISFIYAT);
            cmd.Parameters.AddWithValue("STOK", STOK);
            cmd.Parameters.AddWithValue("DURUM", 1);

            CMD_Run(cmd);
        }
        public void sp_Urun_Guncelle( string BARKOD, string URUNADI, double SATISFIYAT, double ALISFIYAT, int STOK)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "UPDATE TBL_Urunler SET URUNADI = @URUNADI, SATISFIYAT = @SATISFIYAT, ALISFIYAT = @ALISFIYAT, STOK = @STOK WHERE BARKOD = @BARKOD ";

            cmd.Parameters.AddWithValue("BARKOD", BARKOD);
            cmd.Parameters.AddWithValue("URUNADI", URUNADI);
            cmd.Parameters.AddWithValue("SATISFIYAT", SATISFIYAT);
            cmd.Parameters.AddWithValue("ALISFIYAT", ALISFIYAT);
            cmd.Parameters.AddWithValue("STOK", STOK);
            cmd.Parameters.AddWithValue("DURUM", 1);

            CMD_Run(cmd);
        }
        public void sp_Urun_Sil(string BARKOD, int DURUM)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "UPDATE TBL_Urunler SET DURUM = @DURUM WHERE BARKOD = @BARKOD ";

            cmd.Parameters.AddWithValue("BARKOD", BARKOD);
            cmd.Parameters.AddWithValue("DURUM", DURUM);

            CMD_Run(cmd);
        }
        public SQLiteDataReader sp_Urun_Get(string id)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM TBL_Urunler WHERE BARKOD = @ID";

            cmd.Parameters.AddWithValue("ID", id);

            SQLiteDataReader sqlDataReader = cmd.ExecuteReader();
            return sqlDataReader;
        }
        public DataTable sp_Kullanici_Listele()
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM TBL_Kullanicilar";

            return SP_DataTable(cmd);
        }
        public void sp_Kullanici_Ekle(string KULLANICIADI, string SIFRE, string YETKI)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO TBL_Kullanicilar(KULLANICIADI, SIFRE, YETKI) VALUES (@KULLANICIADI, @SIFRE, @YETKI)";

            cmd.Parameters.AddWithValue("KULLANICIADI", KULLANICIADI);
            cmd.Parameters.AddWithValue("SIFRE", SIFRE);
            cmd.Parameters.AddWithValue("YETKI", YETKI);

            CMD_Run(cmd);
        }
        public void sp_Kullanici_Guncelle(int ID, string KULLANICIADI, string SIFRE, string YETKI)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "UPDATE TBL_Kullanicilar SET KULLANICIADI = @KULLANICIADI, SIFRE = @SIFRE, YETKI = @YETKI WHERE ID = @ID ";

            cmd.Parameters.AddWithValue("ID", ID);
            cmd.Parameters.AddWithValue("KULLANICIADI", KULLANICIADI);
            cmd.Parameters.AddWithValue("SIFRE", SIFRE);
            cmd.Parameters.AddWithValue("YETKI", YETKI);

            CMD_Run(cmd);
        }
        public SQLiteDataReader sp_Kullanici_Get(int id)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM TBL_Kullanicilar WHERE ID = @ID";

            cmd.Parameters.AddWithValue("ID", id);

            SQLiteDataReader sqlDataReader = cmd.ExecuteReader();
            return sqlDataReader;
        }
        public void sp_Kullanici_Sil(int ID)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "DELETE FROM TBL_Kullanicilar WHERE ID = @ID";

            cmd.Parameters.AddWithValue("ID", ID);

            CMD_Run(cmd);
        }
        public DataTable sp_Anasayfa_Listele()
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM VW_Anasayfa WHERE date(SATTARIH) between date('now') and date('now', 'start of day', '+5 day')";

            return SP_DataTable(cmd);
        }
        public void sp_Sattarih_Guncelle()
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "UPDATE TBL_HastaRaporlari set SATTARIH = date(SATTARIH, ARTISTEKRAR) where date(SATTARIH) < date('now')";

            CMD_Run(cmd);
        }
        public void sp_Activation_ekle(string key)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO TBL_Activation (ACTIVATIONKEY) VALUES (@KEY)";
            cmd.Parameters.AddWithValue("KEY", key);

            CMD_Run(cmd);
        }
        public DataTable sp_ActivationKey_Get()
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT ACTIVATIONKEY FROM TBL_Activation ORDER BY ID DESC LIMIT 1";

            return SP_DataTable(cmd);
        }
        //---------------------------------------------------------------------------------------------------------------
        public void sp_Stok_Azalt(string BARKOD, int ADET)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "UPDATE TBL_Urunler SET STOK = STOK - @ADET WHERE BARKOD = @BARKOD";

            cmd.Parameters.AddWithValue("BARKOD", BARKOD);
            cmd.Parameters.AddWithValue("ADET", ADET);

            CMD_Run(cmd);
        }
        public void sp_Stok_Arttir(string BARKOD, int ADET)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "UPDATE TBL_Urunler SET STOK = STOK + @ADET WHERE BARKOD = @BARKOD";

            cmd.Parameters.AddWithValue("BARKOD", BARKOD);
            cmd.Parameters.AddWithValue("ADET", ADET);

            CMD_Run(cmd);
        }
        public double sp_satirFiyat_Get(int id)
        {
            Double result = 0;
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "select SATIRFIYAT from TBL_SepetSatir where ID = " + id;
            OpenConnection();
            try
            {
                result = Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch (Exception exp)
            {
                CloseConnection();
                MessageBox.Show(exp.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
            return result;
        }
        public void sp_Sepetsatir_temizle(int ID)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "delete from TBL_SepetSatir where Sepet_ID = @ID";
            cmd.Parameters.AddWithValue("ID", ID);

            CMD_Run(cmd);
        }
        public void sp_Sepet_sil()
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "delete from TBL_Sepet where ToplamFiyat <= 0 ";

            CMD_Run(cmd);
        }
        public int sp_SonSepet_GetID()
        {
            int result = 0;

            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT ID FROM TBL_Sepet ORDER BY ID DESC LIMIT 1";
            OpenConnection();

            try
            {
                result = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception exp)
            {
                CloseConnection();
                MessageBox.Show(exp.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
            return result;
        }
        public double sp_UrunFiyat_GetBarkod(string barkod)
        {
            Double result = 0;
            
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT SATISFIYAT FROM TBL_Urunler WHERE BARKOD = " + barkod;

            OpenConnection();

            try
            {
                result = Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch (Exception exp)
            {
                CloseConnection();
                MessageBox.Show(exp.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
            return result;
        }
    }
}
