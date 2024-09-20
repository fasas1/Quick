using System.ComponentModel.DataAnnotations;

namespace QuickLogistics.Models.Dto
{
    public class CreateVehicleDto
    {
        [Required]
        public string LicensePlate { get; set; }
        [Required]
        public string Model { get; set; }
    }
}
