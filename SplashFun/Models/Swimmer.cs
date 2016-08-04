using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SplashFun.Models
{
    public class Swimmer
    {
        [ScaffoldColumn(false)]
        public int SwimmerID { get; set; }

        [Required, StringLength(20), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, StringLength(20), Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(2), Display(Name = "Middle Initial")]
        public string MiddleIni { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Gender"), StringLength(1)]
        public string Gender { get; set; }

        [Display(Name = "Avatar")]
        public string Avatar { get; set; }

        
        public int? TeamID { get; set; }
        [ForeignKey("TeamID")]
        public virtual Team Team { get; set; }
    }
}