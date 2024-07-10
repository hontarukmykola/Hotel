namespace hotel.Entities
{
    public class HotelRoom
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Rating { get; set; }
        public int Flour { get; set; }
        public int AmoundOfPeople { get; set; }
        public int AmoundOfBed { get; set; }    
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
