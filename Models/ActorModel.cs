using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class ActorModel
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationships
        public List<Actor_MovieModel> Actors_Movies { get; set; }
    }
}
