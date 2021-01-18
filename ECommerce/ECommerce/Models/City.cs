using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class City
    {
        [Key]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }

        [Required(ErrorMessage ="O campo Nome é requerido!")]
        [Display(Name = "Cidade")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Departamento é requerido!")]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }

        //relacionamento entre tabelas
        public virtual Departaments Departament { get; set; }
    }
}