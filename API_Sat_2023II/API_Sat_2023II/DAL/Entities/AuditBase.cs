using System.ComponentModel.DataAnnotations;

namespace API_Sat_2023II.DAL.Entities
{
    public class AuditBase
    {
        [Key]                           //DataAnnotation me sirve para definir que esta propiedad ID es mi PK
        [Required]                      //Para campos obligatorios, o sea que deben tener un valor (no permite nulls)
        public virtual Guid Id { get; set; }            //Será la PK de todas las tablas de mi DB
        public virtual DateTime? CreatedDate { get; set; }  //Campos nuleables, notación elvis (?) permite guardar nulos
        public virtual DateTime? ModifiedDate { get; set; } //Campos nuleables, notación elvis (?) permite guardar nulos
    }
}
