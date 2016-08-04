using System.ComponentModel.DataAnnotations;

namespace SplashFun.Models
{
    public class Distance
    {
        [Key]
        public int DistanceID { get; set; }

        [Required]
        public int Measure { get; set; }
    }
}