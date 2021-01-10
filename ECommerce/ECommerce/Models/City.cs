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
        public int CityId { get; set; }

        [Required(ErrorMessage ="O campo Nome é requerido!")]
        public int Name { get; set; }

        [Required(ErrorMessage = "O campo Departamento é requerido!")]
        public int DepartamentsId { get; set; }
    }
}