using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionRazoPages.Models
{
    public class User
    {
        /// <summary>
        /// Uri para consulta de cabeceras permitidas
        /// https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-2.2
        /// </summary>
        /// 
        public int ID { get; set; }
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Nick length can't be more than 10 and minimum than 3.")] //Cabecera de validación mínimo 3 máximo 10 caracteres
        public string Nick { get; set; }

        [RegularExpression(@"^[a-zA-Z]\w{3,14}$", ErrorMessage = "The password's first character must be a letter, it must contain at least 4 characters and no more than 15 characters and no characters other than letters, numbers and the underscore may be used")] //Cabecera para integrar validación con expresión regular
        [Required] //Cabecera para especificar que campo es requerido
        [StringLength(8)] //Cabecera para establecer el tamaño mínimo de un campo
        public string Password { get; set; }

        [Display(Name = "Fecha de creación")] //Cabecera para especificar la descripción de como se muestra en front end. Liga de consulta: https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/da1?view=aspnetcore-2.2
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

    }
}
