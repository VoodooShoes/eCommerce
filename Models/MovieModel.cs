using eCommerce.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    public class MovieModel
    {
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = null!;
        public double Price { get; set; }
        public string ImageURL { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCatagory MovieCatagory { get; set; }

        //Relationships
       public List<Actor_MovieModel> Actors_Movies { get; set; } = null!;

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public CinemaModel Cinemas { get; set; } = null!;

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public ProducerModel Producers { get; set; } = null!;
    }
}
