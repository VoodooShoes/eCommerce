namespace eCommerce.Models
{
    public class Actor_MovieModel
    {
        public int MovieId { get; set; }
        public MovieModel Movies { get; set; }
        public int ActorId { get; set; }
        public ActorModel Actors { get; set; }
    }
}
