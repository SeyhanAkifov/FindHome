using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CountryName { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
