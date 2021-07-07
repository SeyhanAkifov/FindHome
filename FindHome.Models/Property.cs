using System.ComponentModel.DataAnnotations;

namespace FindHome.Models
{
    public class Property
    {
       [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, double.PositiveInfinity)]
        public decimal Price { get; set; }

        [Required]
        public decimal Area { get; set; }

        [Required]
        public int Rooms { get; set; }

        public int AddressId { get; set; }

        public Address Address { get; set; }
    }
}
