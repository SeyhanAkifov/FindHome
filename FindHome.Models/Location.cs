using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome.Models
{
    public class Location
    {
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int ZipCodeId { get; set; }
        public ZipCode ZipCode { get; set; }
    }
}
