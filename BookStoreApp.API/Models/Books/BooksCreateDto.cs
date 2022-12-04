using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Books
{
    public class BooksCreateDto
    {
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }
        public string Isbn { get; set; } = null!;
        public string Summary { get; set; }
        public string Image { get; set; }

        [Required]
        public decimal Price { get; set; }
        
        [Required]
        public int AuthorId { get; set; }
    }
}
