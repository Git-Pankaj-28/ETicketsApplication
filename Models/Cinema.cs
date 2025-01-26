using System.ComponentModel.DataAnnotations;

namespace ETicketsApplication.Models
{
    // 3.  this is the third model we created as these  id, Logo, Name, Decription , lastly we added ID because as we are using EF code first approch so that require ID
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description {  get; set; }


        // 9 Relationship Cinema can have multiple movies one to many relationship  
        public List<Movie> Movies { get; set; }
    }
}
