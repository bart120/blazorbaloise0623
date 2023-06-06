using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLibrary.Models
{
    public class Car
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Modèle obligatoire")]
        public string? Model { get; set; }
        [Required]
        public int? BrandID { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public DateTime DateOfCirculation { get; set; }
    }
}
