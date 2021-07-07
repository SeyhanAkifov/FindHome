using System.ComponentModel.DataAnnotations;

namespace FindHome.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string StreetName { get; set; }

        [Required]
        public int StreeyNumber { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }
    }
}
