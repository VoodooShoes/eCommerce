using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    public class ProducerModel
    {
        [Key]
        public int ProducerId { get; set; }

        [Display(Name = "Picture")]
        public string ProfilePictureURL { get; set; } = null!;

        [Display(Name = "Name")]
        public string FullName { get; set; } = null!;

        [Display(Name = "Bio")]
        public string Bio { get; set; } = null!;

        //Relationships
        public List<MovieModel> Movies { get; set; } = null!;

    }
}
