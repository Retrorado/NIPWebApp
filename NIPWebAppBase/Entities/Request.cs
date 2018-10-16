using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPWebAppBase.Entities
{
    public class Request
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SearchedData { get; set; }
        [Required]
        public string HttpHeaders { get; set; }
    }
}
