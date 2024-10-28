using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appMvcEF.Models
{
	public class Warranty
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ProductId { get; set; }
		public int Term {  get; set; }
		public string? Type { get; set; }
		public Product? ProductWarr {  get; set; }
	}
}
