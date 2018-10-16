using NIPWebAppBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPWebAppBase.Data
{
    public class DummyData
    {
        #region Public methods
        public static List<Company> GetCompanies()
        {
            List<Company> companies = new List<Company>()
            {
                new Company() { Name = "Wspaniała firma",  Street = "Warszawska", BuildingNumber = "1", PostalCode = "60-100", City = "Poznań", NIP = "7777777777"} ,
                new Company() { Name = "Wspaniała firma",  Street = "Warszawska", BuildingNumber = "1", PostalCode = "60-100", City = "Poznań", NIP = " 3199020798"} ,
                new Company() { Name = "Super firma",  Street = "Kupiecka", BuildingNumber = "10A", PostalCode = "60-500", City = "Poznań", NIP = "5379815164", KRS = "9876543210", REGON = "123456789"} ,
                new Company() { Name = "Bardzo dobra firma",  Street = "Marcelińska", BuildingNumber = "4/12", PostalCode = "60-555", City = "Poznań", NIP = "4357059370"} ,
                new Company() { Name = "Dobra firma",  City = "Szczecin", REGON = "595401465"} ,
                new Company() { Name = "Dobra firma 2",  City = "Szczecin", REGON = "03496593003422"} ,
                new Company() { Name = "Firma",  City = "Warszawa", KRS = "0000311911"}
            };

            return companies;
        }
        
        #endregion
    }
}
