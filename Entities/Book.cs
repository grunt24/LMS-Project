using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Roles.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        [DisplayName("Book Name")]
        public string BookName { get; set; }
        [Required]
        [DisplayName("Book Author")]
        public string BookAuthor { get; set; }
        [Required]
        [DisplayName("Book Publication")]

        public string BookPublication { get; set; }
        [Required]
        [DisplayName("Book Purchase Date")]

        public DateTime BookPurchaseDate { get; set; } = DateTime.Now;
        [Required]
        [DisplayName("Book Price")]

        public decimal BookPrice { get; set; }
        [Required]
        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [ValidateNever]
        [DisplayName("Genre Name")]
        public int GenreId { get; set; }
        [ValidateNever]

        public Genre Genre { get; set; }

    }
}
