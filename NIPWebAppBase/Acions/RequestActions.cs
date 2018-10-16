using NIPWebAppBase.Data;
using NIPWebAppBase.DTO;
using NIPWebAppBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPWebAppBase.Acions
{
    public class RequestActions
    {
        #region Private parameters

        private static NIPContext db = new NIPContext();

        #endregion

        #region Public methods 

        public static void Add(string valueToFind, string httpHeaders)
        {
            Request request = new Request()
            {
                HttpHeaders = valueToFind,
                SearchedData = httpHeaders
            };

            db.Requests.Add(request);
            db.SaveChanges();
        }

        #endregion
    }
}
