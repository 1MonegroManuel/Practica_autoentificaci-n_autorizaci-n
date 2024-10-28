using Microsoft.AspNetCore.Mvc.Rendering;

namespace appMvcEF.Models.ViewModels
{
	public class ProductWarranty
	{
		public Product? Product { get; set; }
		public Warranty? Warranty { get; set; }
		public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();
	}
}
