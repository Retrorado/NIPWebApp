using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPWebAppBase.DTO
{
    public class CompanyDto
    {
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Ulica")]
        public string Street { get; set; }
        [DisplayName("Numer budynku")]
        public string BuildingNumber { get; set; }
        [DisplayName("Kod pocztowy")]
        public string PostalCode { get; set; }
        [DisplayName("Miasto")]
        public string City { get; set; }
        public string Nip { get; set; }
        public string Krs { get; set; }
        public string Regon { get; set; }
    }
}
