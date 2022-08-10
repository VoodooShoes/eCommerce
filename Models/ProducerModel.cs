using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    public class ProducerModel
    {
        [Key]
        public int ProducerId { get; set; }

        public string ProfilePictureURL { get; set; } = null!;

        public string FullName { get; set; } = null!;

        public string Bio { get; set; } = null!;

        //Relationships
        public List<MovieModel> Movies { get; set; } = null!;

    }
}
