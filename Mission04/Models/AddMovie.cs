using System;
using System.ComponentModel.DataAnnotations;

namespace Mission04.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1900,2022)]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
