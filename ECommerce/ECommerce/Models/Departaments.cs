using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Departaments
    {
        [Key]//Chave Primária
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage ="O campo Nome é requerido!")]
        public string Name { get; set; }
    }
}