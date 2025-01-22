using System.ComponentModel.DataAnnotations;

namespace DanskeByer.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Population {  get; set; }
    }
}
