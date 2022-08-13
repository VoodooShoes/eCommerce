using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    public class ProducerModel
    {
        [Key]
        public int ProducerId { get; set; }

        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationships
        public List<MovieModel> Movies { get; set; }

    }
}
