namespace eTickets.Models
{
    // define table many to many between Actor and Movie
    public class Actor_Movie
    {
        // Relationships N to 1:
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        // Relationships N to 1:
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}