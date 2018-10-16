using NIPWebAppBase.Acions;
using NIPWebAppBase.Data;
using NIPWebAppBase.DTO;
using NIPWebAppBase.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPWebAppBase.Providers
{
    public class CompaniesProvider
    {
        #region Private parameters

        private static NIPContext db = new NIPContext();

        #endregion

        #region Public methods

        public static async Task<CompanyDto> GetCompany(string valueToFind, NameValueCollection httpHeaders)
        {
            if (String.IsNullOrEmpty(valueToFind))
                return null;

            var companyDto = Task.Run(() => FindCompanyByValue(valueToFind));        

            // Add fact of searching for valueToFind to table Requests
            RequestActions.Add(valueToFind, httpHeaders.ToString());

            return await companyDto;
        }

        #endregion

        #region Private methods

        private static CompanyDto FindCompanyByValue(string valueToFind)
        {           
            valueToFind = TextOperations.RectifyValueToFind(valueToFind);
            var company = db.Companies.FirstOrDefault(c => c.NIP == valueToFind || c.KRS == valueToFind || c.REGON == valueToFind);

            if (company != null)
            {
                var companyDto = new CompanyDto()
                {
                    Name = company.Name,
                    Street = company.Street,
                    BuildingNumber = company.BuildingNumber,
                    PostalCode = company.PostalCode,
                    City = company.City,
                    Krs = company.KRS,
                    Nip = company.NIP,
                    Regon = company.REGON
                };

                return companyDto;
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}
