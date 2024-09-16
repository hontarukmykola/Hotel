using System.ComponentModel.DataAnnotations;

namespace hotel.Entities
{
    public class HotelRoom
    {
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public int Flour { get; set; }
        [Required]
        public int AmoundOfPeople { get; set; }
        [Required]
        public int AmoundOfBed { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        [Range(0, 100)]
        public decimal? Discount { get; set; }
    }
}
