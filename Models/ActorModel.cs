using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class ActorModel
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePictureURL { get; set; } = null!;

        public string FullName { get; set; } = null!;

        public string Bio { get; set; } = null!;

        //Relationships
        public List<Actor_MovieModel> Actors_Movies { get; set; } = null!;
    }
}
