using System;
using System.Collections.Generic;
using System.Text;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Medikal.Class
{
    class FirebaseConnection
    {
        public IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "25amgCZXspYfkiIPwPhAuRrkvkxfcg4rAsCRCthx",
            BasePath = "https://medikal-2452a-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        public IFirebaseClient client;
        public FirebaseResponse response;
    }
}
