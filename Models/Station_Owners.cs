using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fuela.Models
{
    public class Station_Owners
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "National ID:",Prompt ="National id")]
       
        public int National_id { get; set; }
        [Required]
        [Display(Name = "Full names:")]
        [MaxLength(100)]
        public string Full_Names { get; set; }
        [Required]
        [Display(Name = "Username:")]
        public string Username { get; set; }
        [DataType (DataType.Password)]
        [Required]
        //[MaxLength(8)]

        [Display(Name = "Password:")]
        public string Password { get; set; }
        [Display(Name = "Location:")]
        public string Location { get; set; }
        [Display(Name = "Phone:")]
        [DataType(DataType.PhoneNumber,ErrorMessage ="Invalid phone number!") ]
        public int Phone { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Installation date:")]
        public string InstallationDate { get; set; }
        [Required]
        [Display(Name = "Role:")]
        public int Role { get; set; }
    }
}
