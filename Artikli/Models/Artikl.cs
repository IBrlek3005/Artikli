using System.ComponentModel.DataAnnotations;

namespace Artikli.Models
{
    public class Artikal
    {
        public int ID { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
        public string Kategorija { get; set; }

        [Required]
        public decimal Cijena { get; set; }
    }
}