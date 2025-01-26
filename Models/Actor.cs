using System.ComponentModel.DataAnnotations;

namespace ETicketsApplication.Models
{
    // 1.  this is the first model we created as these  id, profilrpicture, fullname attribute of Actor , lastly we added ID because as we are using EF code first approch so that require ID
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //11. realtionship  manytomany
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
