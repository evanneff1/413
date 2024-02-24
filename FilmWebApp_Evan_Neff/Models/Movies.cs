//This is the contoller page for the database. It creates the Movies class which handles all of the values in the the database, setting which are required and which can be null. As well as setting the Notes string limit

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmWebApp_Evan_Neff.Models
{
    public class Movies
    {
        [Key]
        public int MovieID {get; set; }

        [Required]
        public string Title { get; set; }
        
        [StringLength(25)]
        public string ? Notes { get; set; }

        [Required]
        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }

        [Required]
        [Range(1888, 2100, ErrorMessage = "Please enter a valid year")]
        public int Year { get; set; } = 0;
        
        public string ? Director { get; set; }

        public string ? Rating { get; set; }

        public string ? LentTo { get; set; }

        [Required]
        public bool Edited { get; set; }

        [Required]
        public int CopiedToPlex { get; set; }



     
    }
}
