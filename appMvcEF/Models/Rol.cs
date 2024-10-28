using System.ComponentModel.DataAnnotations;

namespace appMvcEF.Models
{
    public class Rol
    {
        [Key]
        public int RolId { get; set; }

        [Required(ErrorMessage = "El nombre del rol es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre del rol no puede exceder de 50 caracteres")]
        [Display(Name = "Nombre del Rol")]
        public string RolName { get; set; }

        // Relación uno a muchos con User
        public ICollection<User>? Users { get; set; }
    }
}
