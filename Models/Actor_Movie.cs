namespace ETicketsApplication.Models
{
    // 10 . Add Actor_movies as joined to class to get many to many realationships now go to actor model 
    public class Actor_Movie
    {
        public int MovieId {  get; set; }
        public Movie Movie { get; set; }
        public int ActorId {  get; set; }
        public Actor Actor { get; set; }

    }
}
