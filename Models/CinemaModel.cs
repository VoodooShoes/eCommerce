using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class CinemaModel
    {
        [Key]
        public int CinemaId { get; set; }
        [Display(Name = "Logo")]
        public string Logo { get; set; } = null!;
        [Display(Name = "Studio Name")]
        public string Name { get; set; } = null!; 
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;

        //Relationships
        public List<MovieModel> Movies { get; set; } = null!;

    }
}
