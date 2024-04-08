using System.ComponentModel.DataAnnotations;

namespace CRUDNETMVC.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre{ get; set; }
        
        [Required(ErrorMessage = "El precio es obligatorio.")]
        public double Precio{ get; set; }

        [Required(ErrorMessage = "La presentación es obligatorio.")]
        public string Presentacion { get; set; }



    }
}
