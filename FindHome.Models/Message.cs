using System;
using System.ComponentModel.DataAnnotations;

namespace FindHome.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Required]
        public string Description { get; set; }
    }
}
