using System.ComponentModel.DataAnnotations;

namespace ETicketsApplication.Models
{
    // 2.  this is the second model we created as these  id, profilrpicture, fullname attribute of Actor , lastly we added ID because as we are using EF code first approch so that require ID

    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")] // 28 to show in UI instead on view using display prop to show it
        public string ProfilePictureURL { get; set; }

        [Display(Name = "FullName")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //8 Relationships a producer can have multiple movies , one to many relationship 

        public List<Movie> Movies { get; set; }

    }
}
