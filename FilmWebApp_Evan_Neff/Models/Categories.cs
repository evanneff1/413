//This is the page used for creating the connection between the Categories database and the app

using System.ComponentModel.DataAnnotations;


namespace FilmWebApp_Evan_Neff.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(50)]  
        public string Category { get; set; }
    }
}
