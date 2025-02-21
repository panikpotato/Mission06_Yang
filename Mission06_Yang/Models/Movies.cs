using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Yang.Models
{
    public class Movies
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        
        public Category? Category { get; set; }
        [Required]
        public string Title { get; set; }
        
        [Range(1888,10000, ErrorMessage = "You must enter a year later than 1888 (the year the first movie came out.)")]
        public int Year { get; set; }
        
        public string? Director { get; set; }
       
        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public string CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
