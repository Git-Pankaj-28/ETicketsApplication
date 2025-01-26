using System.ComponentModel.DataAnnotations;

namespace ETicketsApplication.Models
{
    // 2.  this is the second model we created as these  id, profilrpicture, fullname attribute of Actor , lastly we added ID because as we are using EF code first approch so that require ID

    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //8 Relationships a producer can have multiple movies , one to many relationship 

        public List<Movie> Movies { get; set; }

    }
}
