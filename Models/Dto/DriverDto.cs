using System.ComponentModel.DataAnnotations;

namespace QuickLogistics.Models.Dto
{
    public class DriverDto
    {
        public int DriverId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LicenseNumber { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
