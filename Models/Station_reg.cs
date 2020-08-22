using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fuela.Models
{
    public class Station_reg
    {

        [Key]
        public int Station_ref { get; set; }
        [Required]
        //[StringLength(8,ErrorMessage ="Value must be 8 characters")]
        [Range(8,8 ,ErrorMessage ="Must be 8 characters!")]
        [Display(Name = "Enter ID:")]
        public int National_ID { get; set; }
        [Required]
        [Display(Name = "Enter Station name:")]

        public int Station_name { get; set; }
        [Required]
        [Display(Name = "Enter Location:")]

        public int Location { get; set; }
    }
}
