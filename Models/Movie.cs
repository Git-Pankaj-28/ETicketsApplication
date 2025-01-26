using ETicketsApplication.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicketsApplication.Models
{

    // 4 this Movie model which contain following props , along with that there some relational property llikes  CinemaNAme, MoviesActor , movie Producer and lastly added Id for Ef codefirst approch.
    public class Movie
    {
        public int Id { get; set; } 

        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL {  get; set; }

        public DateTime StartDate {  get; set; }

        public DateTime EndDate { get; set; }

        // 5  Added Enum in data folder.
        public MovieCategory MovieCategory { get; set; }

        // 12 . Relationship many to many 
        public List<Actor_Movie> Actors_Movies { get; set; }

        //13. Cinema  we can also dclared to foreignkey also 
        public int CinemaId {  get; set; }
        [ForeignKey("CinemaId")]

        public Cinema Cinema { get; set; }

        //14 Same with producer 

        public int ProducerId {  get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set;}
    }
}
