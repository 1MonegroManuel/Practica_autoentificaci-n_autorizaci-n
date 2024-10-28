using System.ComponentModel.DataAnnotations;

namespace appMvcEF.Models.ViewModels
{
    public class ProductsDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime ProductDate { get; set; }
        public int ProductCount { get; set; }
    }
}
