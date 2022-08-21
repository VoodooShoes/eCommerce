using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class ActorModel
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name = "Picture")]
		[Required(ErrorMessage = "Missing profile picture.")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Missing Full Name.")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Fill name must be between 3 and 50 characters.")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Missing Bio.")]
        public string Bio { get; set; }
        //Relationships
        public List<Actor_MovieModel> Actors_Movies { get; set; }
    }
}
