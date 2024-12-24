using eTicket.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicket.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }    

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory movieCategory { get; set; }
        public List<Actor_Movie> actor_Movies { get; set; }
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema cinema { get; set; }
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer producer { get; set; }



    }
}
