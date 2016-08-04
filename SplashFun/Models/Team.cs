using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace SplashFun.Models
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        [Required, Display(Name="TeamName"), StringLength(20)]
        public string Name { get; set; }
        [Display(Name = "TeamName"), StringLength(200)]
        public string Description { get; set; }
        [Display(Name="Logo")]
        public string Logo { get; set; }
    }
}