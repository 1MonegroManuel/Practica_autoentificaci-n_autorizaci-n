using System.ComponentModel.DataAnnotations;

namespace appMvcEF.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage ="Name is required")]
		[StringLength(50,ErrorMessage ="{0} must be: minimum {2} and maximum {1}",MinimumLength =3)]
		[Display(Name ="NAME")]
		public string? Name { get; set; }

		[Required(ErrorMessage ="Expiration date is required")]
		[Display(Name ="EXPIRATION DATE")]
		[DataType(DataType.DateTime)]
		public DateTime ExpDate { get; set; }

		[Required(ErrorMessage ="Price is required")]
		[Display(Name="PRICE")]
		public double Price { get; set; }
		public int CategoryId { get; set; }

		public Category? category { get; set; }

		public Warranty? WarrantyProd {  get; set; }
	}
}
