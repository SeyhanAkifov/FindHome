using System.ComponentModel.DataAnnotations;

namespace FindHome.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CityName { get; set; }
    }
}
