using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPWebAppBase.Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        public string NIP { get; set; } 
        public string KRS { get; set; }
        public string REGON { get; set; }
    }
}
