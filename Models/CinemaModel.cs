using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class CinemaModel
    {
        [Key]
        public int CinemaId { get; set; }
        public string Logo { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        //Relationships
        public List<MovieModel> Movies { get; set; } = null!;

    }
}
