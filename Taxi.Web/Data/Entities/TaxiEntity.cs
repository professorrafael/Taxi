using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taxi.Web.Data.Entities
{
    public class TaxiEntity
    {
        public int Id { get; set; }

        [StringLength(6, MinimumLength = 6, ErrorMessage = "O campo {0} deve ter {1} caracteres!!!!")]
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage = "O campo {0} deve iniciar com três caracteres e terminar com três números!!!!")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!!!!")]
        public string Plaque { get; set; }
    }
}