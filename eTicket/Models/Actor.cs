using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Profile Picture URL")]
        public string ProfilePicUrl { get; set; }
        [Display(Name="Actor Name")]
        public string Name { get; set; }
        [Display(Name="Bio")]
        public string bio { get; set; }
        public List<Actor_Movie> actor_movie { get; set; }
      
    }
}
