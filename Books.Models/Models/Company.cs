using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Books.Models.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [DisplayName("Street Address")]
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        [DisplayName("Postal Code")]
        public string? PostalCode { get; set; }
        [DisplayName("Phone number")]
        public int PhoneNumber { get; set; }


    }
}
