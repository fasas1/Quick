using System.ComponentModel.DataAnnotations;

namespace QuickLogistics.Models.Dto
{
    public class ShipmentDto
    {
        public int ShipmentId { get; set; }
        [Required]
        public string TrackingNumber { get; set; }
        [Required]
        public DateTime ShippedDate { get; set; }
        [Required]
        public DateTime? DeliveredDate { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}
