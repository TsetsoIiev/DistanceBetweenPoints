using System.ComponentModel.DataAnnotations;

namespace DistanceBetweenPoints.Services.Models
{
    public class DistanceInputModel
    {
        [Required]
        public double Lat1 { get; set; }

        [Required]
        public double Long1 { get; set; }

        [Required]
        public double Lat2 { get; set; }

        [Required]
        public double Long2 { get; set; }
    }
}
