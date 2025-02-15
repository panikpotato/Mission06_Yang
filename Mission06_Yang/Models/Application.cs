﻿using System.ComponentModel.DataAnnotations;

namespace Mission06_Yang.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edit { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
    }
}
