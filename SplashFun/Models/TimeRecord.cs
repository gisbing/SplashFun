using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SplashFun.Models
{
    public class TimeRecord
    {
        [ScaffoldColumn(false)]
        public int TimeRecordID { get; set; }

        [Required]
        public string Record { get; set; }

        public DateTime? EventDate { get; set;  }

      
        [Required]
        public int DistanceID { get; set; }
        [ForeignKey("DistanceID")]
        public virtual Distance Distance {get;set;}
        [Required]
        public int StrokeID {get; set;}
        [ForeignKey("StrokeID")]
        public virtual Stroke Stroke { get; set; }

        [Required]
        public int SwimmerID {get; set; }
        [ForeignKey("SwimmerID")]
        public virtual Swimmer Swimmer { get; set; }

    }
}