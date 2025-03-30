using System;
using System.ComponentModel.DataAnnotations;
namespace efcore.Models
{
    public class Employe
    {
        [Key]
        public int eid{get; set;} 
        [Required]
        [StringLength(30)]
        public string name{get; set;} 
        [Required]
        [Range(0,30000)]
        public int salary{get; set;} 
    }
}