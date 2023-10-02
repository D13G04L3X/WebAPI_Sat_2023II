using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace API_Sat_2023II.DAL.Entities
{
    public class Country : AuditBase
    {
        [Display(Name = "País")]                                                                            //Para yo pintar el nombre  bien bonito en el FrontEnd 
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]                     //Longitud de caracteres máxima que esta propiedad me permite tener, ejemplo varchar(50)
        [Required(ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string Name { get; set; }            //varchar(50)
    }
}
