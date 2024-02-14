//This is the contoller page for the database. It creates the Movies class which handles all of the values in the the database, setting which are required and which can be null. As well as setting the Notes string limit

using System.ComponentModel.DataAnnotations;

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
        public string Category { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }


        public bool ? IsLent { get; set; }

        public bool ? IsEdited { get; set; }



     
    }
}
