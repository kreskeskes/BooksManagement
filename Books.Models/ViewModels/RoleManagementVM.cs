using Books.Models.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Books.Models.ViewModels
{
	public class RoleManagementVM
	{
		public ApplicationUser ApplicationUser { get; set; }
		public IEnumerable<SelectListItem> CompanyList { get; set; }
		public IEnumerable<SelectListItem> RoleList { get; set; }

	}
}
