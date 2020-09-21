using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BMI.Models
{
    [Table("persons")]
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="First name is missing!")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is missing!")]
        [Display(Name = "Last name")]
        public String LastName{ get; set; }
        [Required(ErrorMessage = "Gender is missing!")]
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Height is missing!")]
        [Display(Name = "Height")]
        public double Height { get; set; }
        [Required(ErrorMessage = "Weight is missing!")]
        [Display(Name = "Weight")]
        public double Weight { get; set; }
    }
}
