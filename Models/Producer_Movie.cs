namespace eTickets.Models
{
    public class Producer_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
    }
}
