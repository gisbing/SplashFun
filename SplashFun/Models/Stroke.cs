using System.ComponentModel.DataAnnotations;

namespace SplashFun.Models
{
    public class Stroke
    {
        [Key]
        public int StrokeID { get; set; }

        [Required, StringLength(10)]
        public string StrokeName { get; set; }

    }
}