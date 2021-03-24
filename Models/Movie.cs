using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HiltonFilmCollection2.Models
{
    public class Movie
    {
        [Key]
        public int movieId { get; set; }
        [Required(ErrorMessage = "Please enter the category")]
        public string category { get; set; }
        [Required(ErrorMessage = "Please enter the title")]
        public string title { get; set; }
        [Required]
        public string year { get; set; }
        [Required]
        public string director { get; set; }
        [Required]
        public string rating { get; set; }
        public bool edited { get; set; }
        public string lentTo { get; set; }
        public string notes { get; set; }
        public virtual int MaxLength { get; set; }
    }
}
