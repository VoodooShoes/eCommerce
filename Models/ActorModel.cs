using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class ActorModel
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name = "Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }
        //Relationships
        public List<Actor_MovieModel> Actors_Movies { get; set; }
    }
}
