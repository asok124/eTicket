using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Pic URL")]
        public string ProfilePicUrl { get; set; }
        [Display(Name ="Full Name ")]
        public string Name { get; set; }
        [Display(Name= "Biography")]
        public string bio { get; set; }
        public List<Movie> movies { get; set; }

    }
}
