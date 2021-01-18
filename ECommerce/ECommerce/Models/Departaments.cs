using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Departaments
    {
        [Key]//Chave Primária
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido!")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set;}
    }
}