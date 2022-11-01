using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Medikal.Class;

namespace Medikal
{
    public partial class ActicationForm : Form
    {
        public ActicationForm()
        {
            InitializeComponent();

            //string CSVFilePathName = @"C:\\urunler1.csv";
            //string[] Lines = File.ReadAllLines(CSVFilePathName);
            //string[] Fields;
            //Fields = Lines[0].Split(new char[] { ',' });
            //int Cols = Fields.GetLength(0);
            //DataTable dt = new DataTable();
            ////1st row must be column names; force lower case to ensure matching later on.
            //for (int i = 0; i < Cols; i++)
            //    dt.Columns.Add(Fields[i].ToLower(), typeof(string));
            //DataRow Row;
            //for (int i = 1; i < Lines.GetLength(0); i++)
            //{
            //    Fields = Lines[i].Split(new char[] { ',' });
            //    Row = dt.NewRow();
            //    for (int f = 0; f < Cols; f++)
            //        Row[f] = Fields[f];
            //    dt.Rows.Add(Row);
            //}


            //for (int i = 0; i < dt.Rows.Count; i++)
            //{

            //    //MessageBox.Show(dt.Rows[i][1].ToString()); //urunadı
            //    //MessageBox.Show(dt.Rows[i][2].ToString()); //alisfiyat
            //    //MessageBox.Show(dt.Rows[i][3].ToString()); //satisfiyat
            //    //MessageBox.Show(dt.Rows[i][4].ToString()); //stok
            //    //MessageBox.Show(dt.Rows[i][5].ToString()); //barkod

            //    //MessageBox.Show(dt.Rows[i][0].ToString()+" " + dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString() + " " + dt.Rows[i][3].ToString() + " " + dt.Rows[i][4].ToString());
            //    //if (dt.Rows[i][4].ToString().Length < 13)
            //    //{
            //    //    MessageBox.Show(dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString() + " " + dt.Rows[i][3].ToString() + " " + dt.Rows[i][4].ToString());
            //    //}

            //    context.sp_Urun_Ekle(dt.Rows[i][4].ToString(), dt.Rows[i][0].ToString(), Convert.ToDouble(dt.Rows[i][2]), Convert.ToDouble(dt.Rows[i][1]), Convert.ToInt32(dt.Rows[i][3]));
            //}

        }
        static FirebaseConnection firebaseConnection = new FirebaseConnection();
        DbContext context = new DbContext();
        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    firebaseConnection.client = new FireSharp.FirebaseClient(firebaseConnection.config);
                    firebaseConnection.response = firebaseConnection.client.Get("TBL_Activation/TEKMEDICAL");
                    TBL_Activation activationkey = firebaseConnection.response.ResultAs<TBL_Activation>();

                    if (maskedTextBox1.Text.Equals(activationkey.ActivationKey) && activationkey.KeyState)
                    {
                        context.sp_Activation_ekle(activationkey.ActivationKey);
                        activationkey.KeyState = false;
                        var setter = firebaseConnection.client.Set("TBL_Activation/TEKMEDICAL/",activationkey);

                        LoginForm login = new LoginForm();
                        this.Hide();
                        login.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Aktivasyon Anahtarınız Hatalı veya Daha Önce Kullanılmış.", "HATALI ANAHTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    CheckYourWlan checkYourWlan = new CheckYourWlan();
                    this.Hide();
                    checkYourWlan.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
