using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using Medikal.Class;

namespace Medikal
{
    static class Program
    {
        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string keyFromFirebase = "";

            try
            {
                FirebaseConnection firebaseConnection = new FirebaseConnection();

                firebaseConnection.client = new FireSharp.FirebaseClient(firebaseConnection.config);
                firebaseConnection.response = firebaseConnection.client.Get("TBL_Activation/TEKMEDICAL");
                TBL_Activation activationkey = firebaseConnection.response.ResultAs<TBL_Activation>();

                keyFromFirebase = activationkey.ActivationKey;

            }
            catch (Exception)
            {
                Application.Run(new CheckYourWlan());
            }

            DbContext context = new DbContext();
            DataTable dataTable = context.sp_ActivationKey_Get();

            if (dataTable.Rows.Count < 1)
                Application.Run(new ActicationForm());
            else
            {
                if (keyFromFirebase.Equals(dataTable.Rows[0]["ACTIVATIONKEY"].ToString()))
                {
                    Application.Run(new LoginForm());
                }
                else
                    Application.Run(new ActicationForm());
            }

        }
    }
}
