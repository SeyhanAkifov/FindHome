using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FindHome.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CityName { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
