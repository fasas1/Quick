using System.ComponentModel.DataAnnotations.Schema;

namespace QuickLogistics.Models.Dto
{
    public class VehicleDto
    {
       
        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }
    }
}
