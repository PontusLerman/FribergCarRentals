namespace FribergCarRentals.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookingStart { get; set; }
        public DateTime BookingEnd { get; set;}
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
    }
}
