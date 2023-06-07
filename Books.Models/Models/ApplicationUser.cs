using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Models.Models
{
	public class ApplicationUser : IdentityUser
	{
		[Required]
		public string Name { get; set; }
		public string? StreetAddress { get; set; }
		public string? City { get; set; }
		public string? PostalCode { get; set; }

		public int? CompanyId { get; set; }

		[ValidateNever]
		[DisplayName("Company ID")]
		[ForeignKey("CompanyId")]
		public Company? Company { get; set; }
		[NotMapped]
		public string Role { get; set; }
	}
}
